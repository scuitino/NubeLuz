#if UNITY_EDITOR

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

using AlmostEngine.Screenshot;

namespace AlmostEngine.Preview
{
	public class ResolutionWindowBase : EditorWindow
	{
		protected SerializedObject m_SerializedConfig;

		protected Texture2D m_BackgroundTexture;
		protected GUIStyle m_NameStyle;
		protected Vector2 m_ScrollviewPos;

		protected int m_WindowWidth;



		protected PreviewConfigAsset m_ConfigAsset;


		void Awake ()
		{
			Clear ();
		}

		void Clear ()
		{
			m_LastEditorUpdate = DateTime.Now;

			m_ConfigAsset = ResolutionSettingsWindow.GetConfig ();

			DestroyManager ();
		}



		protected virtual void OnEnable ()
		{
			#if UNITY_2017_2_OR_NEWER
			EditorApplication.playModeStateChanged += StateChange;
			#else 
			EditorApplication.playmodeStateChanged += StateChange;
			#endif

//						PreviewManager.onCaptureEndDelegate -= Repaint; // TODO: MAYBE IN 5.4 
		}

		protected virtual void OnDisable ()
		{
			#if UNITY_2017_2_OR_NEWER
						EditorApplication.playModeStateChanged -= StateChange;
			#else 
			EditorApplication.playmodeStateChanged -= StateChange;
			#endif

		}


		#if UNITY_2017_2_OR_NEWER
		void StateChange (PlayModeStateChange state)

		#else
		void StateChange ()
		#endif
		{
			if (EditorApplication.isPlayingOrWillChangePlaymode && EditorApplication.isPlaying) {
				InitTempManager ();
			} else {
				DestroyManager ();
			}
		}

		#region Events

		protected virtual void HandleEditorEvents ()
		{
		}

		void Update ()
		{
			AutoRefresh ();
		}

		DateTime m_LastEditorUpdate = new DateTime ();

		void AutoRefresh ()
		{
			if (Application.isPlaying && m_ConfigAsset.m_RefreshMode == PreviewConfigAsset.AutoRefreshMode.ONLY_IN_EDIT_MODE)
				return;
						
			if (!Application.isPlaying && m_ConfigAsset.m_RefreshMode == PreviewConfigAsset.AutoRefreshMode.ONLY_IN_PLAY_MODE)
				return;

			if (m_ConfigAsset.m_AutoRefresh && (DateTime.Now - m_LastEditorUpdate).TotalSeconds > m_ConfigAsset.m_RefreshDelay) {
				UpdateAll ();
			}
		}

		#endregion

		#region UI



		void OnGUI ()
		{
			if (EditorApplication.isCompiling) {
				Clear ();
			}

			m_WindowWidth = (int)position.width;

			HandleEditorEvents ();

			InitStyle ();

			// Init manager serializer
			m_SerializedConfig = new SerializedObject (m_ConfigAsset);
			m_SerializedConfig.Update ();

			// Draw GUI
			EditorGUI.BeginChangeCheck ();
			DrawToolBarGUI ();
			if (EditorGUI.EndChangeCheck ()) {
				ResolutionWindowBase.RepaintWindows ();
			}

			DrawPreviewGUI ();

			// APply properties
			m_SerializedConfig.ApplyModifiedProperties ();

		}

		void InitStyle ()
		{
			if (m_BackgroundTexture == null) {
				m_BackgroundTexture = new Texture2D (1, 1);
				m_BackgroundTexture.SetPixel (0, 0, Color.white);
				m_BackgroundTexture.Apply ();
			}

			if (m_NameStyle == null) {
				m_NameStyle = new GUIStyle ();
				m_NameStyle.wordWrap = true;
				m_NameStyle.alignment = TextAnchor.MiddleCenter;
			}
		}

		static float PixelsPerPoint() {
			#if UNITY_5_4_OR_NEWER
			return EditorGUIUtility.pixelsPerPoint;
			#else
			return 1f;
			#endif
		}

		protected Vector2 GetRenderSize (ScreenshotResolution resolution, float zoom, PreviewConfigAsset.GalleryDisplayMode mode)
		{
			int displayWidth, displayHeight;
			int width = resolution.ComputeTargetWidth ();
			int height = resolution.ComputeTargetHeight ();

			if (width <= 0 || height <= 0) {
				EditorGUILayout.LabelField ("Invalid dimensions for resolution " + resolution.ToString ());
				return Vector2.zero;
			}

			// Compute the box dimensions depending on the display mode
			if (mode == PreviewConfigAsset.GalleryDisplayMode.RATIOS) {
				displayWidth = (int)((m_WindowWidth - m_ConfigAsset.m_MarginHorizontal) * zoom);
				displayHeight = (int)(displayWidth * height / width);
			} else if (mode == PreviewConfigAsset.GalleryDisplayMode.PIXELS) {
				displayWidth = (int)(width * zoom  / PixelsPerPoint());
				displayHeight = (int)(height * zoom / PixelsPerPoint());
			} else {
				if (resolution.m_PPI <= 0) {
					EditorGUILayout.LabelField ("Missing PPI info for resolution " + resolution.ToString ());
					return Vector2.zero;
				}
				displayWidth = (int)(width * zoom / resolution.m_PPI * m_ConfigAsset.m_ScreenPPI / PixelsPerPoint());
				displayHeight = (int)(height * zoom / resolution.m_PPI * m_ConfigAsset.m_ScreenPPI / PixelsPerPoint());
			}
			return new Vector2 (displayWidth, displayHeight);
		}


		protected Vector2 scroll;
		protected int height;
		protected int width;

		protected virtual void DrawPreviewGUI ()
		{
		}

		protected virtual void DrawToolBarGUI ()
		{
		}

		#endregion

		#region Actions

		static bool m_Updating = false;

		public void UpdateAll ()
		{
			if (m_Updating)
				return;
						
			m_Updating = true;
			InitTempManager ();
			m_Manager.StartCoroutine (UpdateCoroutine (GetResolutionsToUpdate ()));
		}

		protected virtual void UpdatePreview ()
		{
			if (m_Updating)
				return;
						
			m_Updating = true;
			InitTempManager ();
			m_Manager.StartCoroutine (UpdateCoroutine (m_ConfigAsset.m_Config.GetActiveResolutions ()));
		}

		public void Export ()
		{
			m_ConfigAsset.m_Config.ExportToFiles (GetResolutionsToUpdate ());
		}

		protected static ScreenshotManager m_Manager;
		protected static ScreenshotTaker m_ScreenshotTaker;

		protected void InitTempManager ()
		{
			if (m_Manager != null)
				return;
						
			GameObject obj = new GameObject ();
			obj.name = "Temporary screenshot manager - remove if still exists in scene in edit mode.";

			// First we create the screenshot taker
			m_ScreenshotTaker = obj.AddComponent<ScreenshotTaker> ();
			m_ScreenshotTaker.m_GameViewResizingWaitingMode = m_ConfigAsset.m_Config.m_GameViewResizingWaitingMode;
			m_ScreenshotTaker.m_GameViewResizingWaitingFrames = m_ConfigAsset.m_Config.m_ResizingWaitingFrames;
			m_ScreenshotTaker.m_GameViewResizingWaitingTime = m_ConfigAsset.m_Config.m_ResizingWaitingTime;

			// Then the manager
			m_Manager = obj.AddComponent<ScreenshotManager> ();
			m_Manager.m_Config = m_ConfigAsset.m_Config;
			m_Manager.Awake ();
		}

		protected void DestroyManager ()
		{
			if (m_Manager == null)
				return;
						
			if (Application.isPlaying)
				return;

			GameObject.DestroyImmediate (m_Manager.gameObject);
			m_Manager = null;
		}





		protected IEnumerator UpdateCoroutine (List<ScreenshotResolution> res)
		{
			yield return   m_Manager.StartCoroutine (m_Manager.CaptureCoroutine (res, false));	// TODO: if playing do not restore!
			m_LastEditorUpdate = DateTime.Now;
			Repaint ();
			DestroyManager ();
			m_Updating = false;
		}

		protected virtual List<ScreenshotResolution> GetResolutionsToUpdate ()
		{
			List<ScreenshotResolution> resolutions = new List<ScreenshotResolution> ();
						
			// Look if the preview or gallery window is open
			if (ResolutionGalleryWindow.IsOpen ()) {
				// If the gallery is open, we update all resolutions
				resolutions.AddRange (m_ConfigAsset.m_Config.GetActiveResolutions ());
						
			} else if (ResolutionPreviewWindow.IsOpen ()) {
				// If only the preview is open, we only update the selected resolution
				if (m_ConfigAsset.m_Selected < m_ConfigAsset.m_Config.GetActiveResolutions ().Count) {
					resolutions.Add (m_ConfigAsset.m_Config.GetActiveResolutions () [m_ConfigAsset.m_Selected]);
				}
			}
						
			return resolutions;
		}

		public static void RepaintWindows()
		{
			if (ResolutionGalleryWindow.IsOpen ()) {
				ResolutionGalleryWindow.m_Window.Repaint ();
			}
			if (ResolutionPreviewWindow.IsOpen ()) {
				ResolutionPreviewWindow.m_Window.Repaint ();
			}
			if (ResolutionSettingsWindow.IsOpen ()) {
				ResolutionSettingsWindow.m_Window.Repaint ();
			}
		}


		#endregion

	}
}

#endif