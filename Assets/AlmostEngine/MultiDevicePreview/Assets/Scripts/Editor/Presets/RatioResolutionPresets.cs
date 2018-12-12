#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

using AlmostEngine.Screenshot;

namespace AlmostEngine.Preview
{
		[InitializeOnLoad]
		public class RatioResolutionPresets
		{

				static RatioResolutionPresets ()
				{
						Init ();
						ScreenshotResolutionPresets.Add (m_Presets);
				}



				public static List<ScreenshotResolution> m_Presets = new List<ScreenshotResolution> ();

				public static void Init ()
				{


						// popular 3/2 resolutions
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 360, 240, "WQVGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 480, 320, "HVGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 960, 640, "DVGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 1152, 768, "WXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 1440, 960, "WSXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 1920, 1280, "custom")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 2160, 1440, "custom"));  
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 2736, 1824, "custom")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 3000, 2000, "custom")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/3:2", 4500, 3000, "custom")); 

						// popular 4/3 resolutions
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 320, 240, "QVGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 640, 480, "VGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 768, 576, "PAL")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 800, 600, "SVGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 1024, 768, "XGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 1152, 864, "XGA+")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 1400, 1050, "SXGA+")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 1600, 1200, "UXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 2048, 1536, "QXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/4:3", 3200, 2400, "QUXGA")); 

						// popular 5/3 resolutions
						m_Presets.Add (new ScreenshotResolution ("Ratios/5:3", 400, 240, "WQGA"));
						m_Presets.Add (new ScreenshotResolution ("Ratios/5:3", 800, 480, "WVGA"));
						m_Presets.Add (new ScreenshotResolution ("Ratios/5:3", 1280, 768, "WXGA")); 

						// popular 5/4 resolutions
						m_Presets.Add (new ScreenshotResolution ("Ratios/5:4", 1280, 1024, "SXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/5:4", 2560, 2048, "QSXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/5:4", 5120, 4096, "HSXGA")); 

						// popular 16/9 resolutions
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 854, 480, "FWVGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 1024, 576, "WSVGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 1280, 720, "HD(720p)")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 1600, 900, "HD+"));  
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 1920, 1080, "FHD(1080p)")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 2048, 1152, "QWXGA"));  
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 2560, 1440, "WQHD")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 3200, 1800, "QHD+")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 3840, 2160, "4K UHD")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 5120, 2880, "5K UHD")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:9", 7680, 4320, "8K UHD")); 

						// popular 16/10 resolutions
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:10", 768, 480, "WVGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:10", 1280, 800, "WXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:10", 1440, 900, "WXGA+")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:10", 1680, 1050, "WSXGA+")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:10", 1920, 1200, "WUXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:10", 2560, 1600, "WQXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/16:10", 2880, 1800, "WQXGA")); 

						// popular custom ratios
						m_Presets.Add (new ScreenshotResolution ("Ratios/Other", 1360, 768, "WXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/Other", 1366, 768, "FWXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/Other", 3200, 2048, "WQSXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/Other", 3840, 2400, "WQUXGA")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/Other", 1136, 640, "custom")); 
						m_Presets.Add (new ScreenshotResolution ("Ratios/Other", 1334, 750, "custom"));





				}
		}
}


#endif