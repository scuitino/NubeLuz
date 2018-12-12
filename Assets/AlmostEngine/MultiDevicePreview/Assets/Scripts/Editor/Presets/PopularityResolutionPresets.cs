#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

using AlmostEngine.Screenshot;

namespace AlmostEngine.Preview
{
		[InitializeOnLoad]
		public class PopularityResolutionPresets
		{

				static PopularityResolutionPresets ()
				{
						Init ();
						ScreenshotResolutionPresets.Add (m_Presets);
				}



				public static List<ScreenshotResolution> m_Presets = new List<ScreenshotResolution> ();

				public static void Init ()
				{

						// Stats steam
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1920, 1080, "FHD(1080p)", -1, 76.07f));
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1366, 768, "HD", -1, 8.45f)); 					
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 2560, 1440, "WQHD", -1, 3.48f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1600, 900, "HD+", -1, 2.12f));   
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1440, 900, "WXGA+", -1, 1.98f)); 				
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1680, 1050, "WSXGA+", -1, 1.45f)); 						
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1280, 1024, "SXGA", -1, 1.28f));								
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1360, 768, "WXGA", -1, 1.04f)); 	
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 2560, 1080, "custom", -1, 0.70f)); 					
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1024, 768, "XGA", -1, 0.53f)); 							
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1280, 800, "WXGA", -1, 0.51f)); 	
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 3840, 2160, "4K UHD", -1, 0.45f)); 								
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1920, 1200, "WUXGA", -1, 0.44f)); 	
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1536, 864, "custom", -1, 0.29f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Steam hardware 2017-12", 1280, 720, "WXGA(720p)", -1, 0.24f));




						// Stats unity standalone
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 1920, 1080, "FHD(1080p)", -1, 41.5f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 1366, 768, "HD", -1, 10.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 1366, 696, "custom", -1, 4.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 1440, 900, "WXGA+", -1, 3.7f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 1600, 900, "HD+", -1, 3.2f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 1024, 728, "XGA", -1, 3.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 1280, 800, "WXGA", -1, 2.3f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 800, 600, "SVGA", -1, 1.5f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone 2017-03", 1280, 1024, "SXGA", -1, 1.5f)); 

						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1920, 1080, "FHD(1080p)", -1, 64.1f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1366, 768, "HD", -1, 10.8f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1440, 900, "WXGA+", -1, 5.4f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1600, 900, "HD+", -1, 4.3f));
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1024, 728, "XGA", -1, 3.7f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1280, 1024, "SXGA", -1, 2.1f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1680, 1050, "WSXGA+", -1, 2.1f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1360, 768, "WXGA", -1, 1.3f));  
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 2560, 1440, "WQHD", -1, 1.1f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (windows) 2017-03", 1280, 800, "WXGA", -1, 1.0f)); 

						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (osx) 2017-03", 1440, 900, "WXGA+", -1, 36.9f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (osx) 2017-03", 1280, 800, "WXGA", -1, 30.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (osx) 2017-03", 1920, 1080, "FHD(1080p)", -1, 11.7f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (osx) 2017-03", 1366, 768, "HD", -1, 6.2f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (osx) 2017-03", 2560, 1440, "WQHD", -1, 6.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (osx) 2017-03", 1680, 1050, "WSXGA+", -1, 4.9f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity standalone (osx) 2017-03", 1920, 1200, "WUXGA", -1, 1.8f)); 



						// Stats unity mobile
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 1280, 720, "WXGA(720p)", -1, 26.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 1920, 1080, "FHD(1080p)", -1, 20.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 854, 480, "FWVGA", -1, 8.2f));
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 800, 480, "WVGA", -1, 8.1f));  
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 960, 540, "custom", -1, 7.7f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 1024, 600, "custom", -1, 6.2f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 1280, 800, "WXGA", -1, 4.4f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 1136, 640, "custom", -1, 2.2f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 2048, 1536, "QXGA", -1, 2.1f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile 2017-03", 2560, 1440, "WQHD", -1, 1.8f)); 

						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 1280, 720, "WXGA(720p)", -1, 30.1f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 1920, 1080, "FHD(1080p)", -1, 22.1f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 854, 480, "FWVGA", -1, 9.5f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 800, 480, "WVGA", -1, 9.3f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 960, 540, "custom", -1, 9.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 1024, 600, "custom", -1, 7.2f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 1280, 800, "WXGA", -1, 5.1f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 2560, 1440, "WQHD", -1, 2.2f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 480, 320, "HVGA", -1, 1.0f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (Android) 2017-03", 1920, 1200, "WUXGA", -1, 0.8f)); 

						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (iOS) 2017-03", 1136, 640, "custom", -1, 17.8f + 10.8f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (iOS) 2017-03", 2048, 1536, "QXGA", -1, 15.9f + 6.2f));  
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (iOS) 2017-03", 1334, 750, "custom", -1, 12.8f + 6.5f));
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (iOS) 2017-03", 1024, 768, "XGA", -1, 8.3f + 3.8f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (iOS) 2017-03", 1920, 1080, "FHD(1080p)", -1, 7.4f + 2.8f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (iOS) 2017-03", 960, 640, "DVGA", -1, 2.8f + 2.5f)); 

						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (wp8) 2017-03", 800, 480, "WVGA", -1, 53.9f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (wp8) 2017-03", 1280, 720, "WXGA(720p)", -1, 23.5f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (wp8) 2017-03", 854, 480, "FWVGA", -1, 12.6f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (wp8) 2017-03", 960, 540, "custom", -1, 4.2f)); 
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (wp8) 2017-03", 1280, 768, "WXGA", -1, 3.8f));  
						m_Presets.Add (new ScreenshotResolution ("Popularity/Unity mobile (wp8) 2017-03", 1920, 1080, "FHD(1080p)", -1, 1.6f)); 



				}
		}
}


#endif