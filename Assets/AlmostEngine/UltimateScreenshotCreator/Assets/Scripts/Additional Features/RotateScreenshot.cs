using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace AlmostEngine.Screenshot
{
	[ExecuteInEditMode]
	public class RotateScreenshot : MonoBehaviour
	{
		

		void OnEnable ()
		{
			ScreenshotTaker.onResolutionUpdateEndDelegate -= EndCallback;
			ScreenshotTaker.onResolutionUpdateEndDelegate += EndCallback;
		}

		void OnDisable ()
		{
			ScreenshotTaker.onResolutionUpdateEndDelegate -= EndCallback;
		}


		void EndCallback (ScreenshotResolution res)
		{
			RotateTexture (res);
		}

		void RotateTexture (ScreenshotResolution res)
		{
			Texture2D rotated = new Texture2D (res.m_Texture.height, res.m_Texture.width, res.m_Texture.format, false);
				
			// Copy the content
			Color col;
			for (int x = 0; x < res.m_Texture.width; ++x) {
				for (int y = 0; y < res.m_Texture.height; ++y) {									
					col = res.m_Texture.GetPixel (res.m_Texture.width - 1 - x, y);
					rotated.SetPixel (y, x, col);
				}
			}
			rotated.Apply ();

			Debug.Log ("Screenshot rotated");

			// Replace the texture
			DestroyImmediate (res.m_Texture);
			res.m_Texture = rotated;
		}
	}
}
