#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

using AlmostEngine.Screenshot;

namespace AlmostEngine.Preview
{
		[InitializeOnLoad]
		public class DeviceResolutionPresets
		{

				static DeviceResolutionPresets ()
				{
						Init ();
						ScreenshotResolutionPresets.Add (m_Presets);
				}



				public static List<ScreenshotResolution> m_Presets = new List<ScreenshotResolution> ();

				public static void Init ()
				{

						// Amazon
						m_Presets.Add (new ScreenshotResolution ("Devices/Amazon", 1024, 600, "Amazon Kindle Fire", 170)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Amazon", 1280, 800, "Amazon Kindle Fire HD", 216)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Amazon", 1280, 800, "Amazon Kindle Fire HD 8", 189)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Amazon", 1920, 1200, "Amazon Kindle Fire HDX 7", 323)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Amazon", 2560, 1600, "Amazon Kindle Fire HDX 8.9", 339));
						m_Presets.Add (new ScreenshotResolution ("Devices/Amazon", 1024, 600, "Amazon Kindle Fire 2", 170)); 

						// Apple
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 480, 320, "Apple iPhone 2", 163)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 480, 320, "Apple iPhone 3", 163)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 960, 640, "Apple iPhone 4", 326)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1136, 640, "Apple iPhone 5", 326)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1334, 750, "Apple iPhone 6", 326)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1334, 750, "Apple iPhone 6S", 326)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1334, 750, "Apple iPhone 6S Plus", 326)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1920, 1080, "Apple iPhone 6 Plus", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1334, 750, "Apple iPhone 7", 326)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1920, 1080, "Apple iPhone 7 Plus", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1136, 640, "Apple iPhone SE", 326));
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1334, 750, "Apple iPhone 8", 326)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1920, 1080, "Apple iPhone 8 Plus", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2436, 1125, "Apple iPhone X", 459)); 



						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1024, 768, "Apple iPad", 132)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1024, 768, "Apple iPad 2", 132)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2048, 1536, "Apple iPad 3", 264)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2048, 1536, "Apple iPad 4", 264));
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 1024, 768, "Apple iPad Mini", 162)); 			
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2048, 1536, "Apple iPad Mini 2", 324)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2048, 1536, "Apple iPad Mini 3", 324));  
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2048, 1536, "Apple iPad Mini 4", 324));  
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2048, 1536, "Apple iPad Air", 264)); 			
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2732, 2048, "Apple iPad Pro", 265)); 		
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2048, 1536, "Apple iPad Pro 9.7-Inch", 264)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2224, 1668, "Apple iPad Pro 10.5-Inch", 265)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Apple", 2732, 2048, "Apple iPad Pro 12.9-Inch", 265)); 

						// Asus
						m_Presets.Add (new ScreenshotResolution ("Devices/Asus", 1280, 800, "Asus Fonepad", 216)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Asus", 1280, 720, "Asus  Zenfone Max", 267)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Asus", 1920, 1080, "Asus  Zenfone 2", 403)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Asus", 1920, 1080, "Asus  Zenfone 3", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Asus", 2560, 1440, "Asus  Zenfone AR", 515)); 

						// Google
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 1280, 768, "Google Nexus 4", 318)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 1920, 1080, "Google Nexus 5", 445)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 1920, 1080, "Google Nexus 5X", 423)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 2560, 1440, "Google Nexus 6", 493));  
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 2560, 1440, "Google Nexus 6P", 518));  
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 1280, 800, "Google Nexus 7 (2012)", 216)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 1920, 1200, "Google Nexus 7", 323)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 2048, 1536, "Google Nexus 9", 288));
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 2560, 1600, "Google Nexus 10", 299));
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 1920, 1080, "Google Pixel", 441));
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 2560, 1440, "Google Pixel XL", 534));
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 1920, 1080, "Google Pixel 2", 441));
						m_Presets.Add (new ScreenshotResolution ("Devices/Google", 2880, 1440, "Google Pixel 2 XL", 537));

						// HTC
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 2560, 1440, "HTC 10", 565));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1920, 1080, "HTC One", 468));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1920, 1080, "HTC One M8", 441));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1920, 1080, "HTC One M9", 441));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 2560, 1440, "HTC One M9 Plus", 565));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1920, 1080, "HTC One A9", 440));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1920, 1080, "HTC One X10", 401));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1280, 720, "HTC Desire 650", 294));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1280, 720, "HTC Desire 10 Lifestyle", 267));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1920, 1080, "HTC Desire 10 Pro", 401));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 2560, 1440, "HTC U Ultra", 513));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 1920, 1080, "HTC U Play", 428));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 2560, 1440, "HTC Bolt", 534));
						m_Presets.Add (new ScreenshotResolution ("Devices/HTC", 2560, 1440, "HTC U11", 534));

						// Huawei
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei Nova", 441)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei Nova Plus", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei P8", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1280, 720, "Huawei P8 Lite", 294)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei P9", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei P9 Lite", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei P9 Plus", 401));  
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei P10", 432)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei P10 Lite", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 2560, 1440, "Huawei P10 Plus", 534)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei Mate 9", 373)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 1920, 1080, "Huawei Mate 9 Lite", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 2560, 1440, "Huawei Mate 9 Pro", 534)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 2560, 1440, "Huawei Mate 10", 499)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 2160, 1080, "Huawei Mate 10 Lite", 409)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Huawei", 2160, 1080, "Huawei Mate 10 Pro", 402)); 


						// HONOR
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 1920, 1080, "Honor 5X", 400));
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 1920, 1080, "Honor 5C", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 1920, 1080, "Honor 6", 445)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 1920, 1080, "Honor 6 Plus", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 1920, 1080, "Honor 6X", 402)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 1920, 1080, "Honor 7", 424));  
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 1920, 1080, "Honor 7i", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 1920, 1080, "Honor 8", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Honor", 2560, 1440, "Honor Note 8", 445)); 

						// LG
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 1920, 1080, "LG G2", 423)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 2560, 1440, "LG G3", 538)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 2560, 1440, "LG G4", 538)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 2560, 1440, "LG G5", 554)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 2880, 1440, "LG G6", 561)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 2560, 1440, "LG Q8", 565)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 2560, 1440, "LG V10", 515)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 2560, 1440, "LG V20", 513)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 2880, 1440, "LG V30", 537)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 1280, 720, "LG Aristo", 294)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 1280, 720, "LG Harmony", 277)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/LG", 854, 480, "LG Fortune", 196)); 

						// Microsoft
						m_Presets.Add (new ScreenshotResolution ("Devices/Microsoft", 1280, 720, "Microsoft Lumia 640", 294));
						m_Presets.Add (new ScreenshotResolution ("Devices/Microsoft", 1280, 720, "Microsoft Lumia 640 XL", 259));  
						m_Presets.Add (new ScreenshotResolution ("Devices/Microsoft", 1280, 720, "Microsoft Lumia 650", 297));
						m_Presets.Add (new ScreenshotResolution ("Devices/Microsoft", 1280, 720, "Microsoft Lumia 650 XL", 259));  
						m_Presets.Add (new ScreenshotResolution ("Devices/Microsoft", 2560, 1440, "Microsoft Lumia 950", 515)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Microsoft", 2560, 1440, "Microsoft Lumia 950 XL", 565)); 

						m_Presets.Add (new ScreenshotResolution ("Devices/Microsoft", 1920, 1280, "Microsoft Surface 3", 214)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Microsoft", 2736, 1824, "Microsoft Surface Pro 4", 267)); 

						// Motorola
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 854, 480, "Motorola Droid", 265));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 2560, 1440, "Motorola Droid Turbo", 565));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 2560, 1440, "Motorola Droid Turbo 2", 540));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 1920, 1080, "Motorola Moto M", 401));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 1280, 720, "Motorola Moto X", 316));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 1280, 720, "Motorola Moto X STYLE", 316));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 1920, 1080, "Motorola Moto X4", 424));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 1920, 1080, "Motorola Moto Z Play Droid", 401));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 2560, 1440, "Motorola Moto Z FORCE", 534));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 1920, 1080, "Motorola G5", 441));
						m_Presets.Add (new ScreenshotResolution ("Devices/Motorola", 1920, 1080, "Motorola G5 Plus", 424));


						// OnePlus
						m_Presets.Add (new ScreenshotResolution ("Devices/OnePlus", 1920, 1080, "OnePlus One", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/OnePlus", 1920, 1080, "OnePlus 2", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/OnePlus", 1920, 1080, "OnePlus 3", 401)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/OnePlus", 1920, 1080, "OnePlus X", 441)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/OnePlus", 1920, 1080, "OnePlus 3T", 401)); 

						// Samsung
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1280, 720, "Samsung Galaxy S III", 306));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1920, 1080, "Samsung Galaxy S4", 441));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1920, 1080, "Samsung Galaxy S5", 432));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2560, 1440, "Samsung Galaxy S6", 577));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2560, 1440, "Samsung Galaxy S7", 576));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2560, 1440, "Samsung Galaxy S7 Edge", 534));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2960, 1440, "Samsung Galaxy S8", 570));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2960, 1440, "Samsung Galaxy S8+", 529));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1280, 720, "Samsung Galaxy Amp Prime 2", 294));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1280, 720, "Samsung Galaxy J7 V", 267));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 960, 540, "Samsung Galaxy A3", 245));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1280, 720, "Samsung Galaxy A3 (2017)", 312));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1280, 720, "Samsung Galaxy A5", 294));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1920, 1080, "Samsung Galaxy A5 (2017)", 424));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1920, 1080, "Samsung Galaxy A6", 401));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1920, 1080, "Samsung Galaxy A7", 401));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1920, 1080, "Samsung Galaxy A7 (2017)", 386));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2220, 1080, "Samsung Galaxy A8", 441));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2220, 1080, "Samsung Galaxy A8+", 411));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 1920, 1080, "Samsung Galaxy Note 3", 386));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2560, 1440, "Samsung Galaxy Note 4", 515));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2560, 1440, "Samsung Galaxy Note 5", 518));
						m_Presets.Add (new ScreenshotResolution ("Devices/Samsung", 2960, 1440, "Samsung Galaxy Note 8", 522));

						// Sony
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia Z2", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia Z5", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia X", 441)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1280, 720, "Sony Xperia X Compact", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia XZ", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia XZs", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia XZ1", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1280, 720, "Sony Xperia XZ1 Compact", 319)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1280, 720, "Sony Xperia XA1", 294)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia XA1 Ultra", 441)); 						
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1280, 720, "Sony Xperia XA2", 424)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia XA2 Ultra", 367)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1280, 720, "Sony Xperia E5", 294)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1920, 1080, "Sony Xperia M5", 441)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1280, 720, "Sony Xperia L1", 267)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Sony", 1280, 720, "Sony Xperia L2", 267)); 

						// Wileyfox
						m_Presets.Add (new ScreenshotResolution ("Devices/Wileyfox", 1280, 720, "Wileyfox Spark", 294)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Wileyfox", 1280, 720, "Wileyfox Spark X", 267)); 
						m_Presets.Add (new ScreenshotResolution ("Devices/Wileyfox", 1280, 720, "Wileyfox Swift", 294)); 
						// The DPI returned by Screen.dpi is wrong for the Wileyfox Swift. 
						// We set its "wrong" value here to render the constant physical scale canvas as they will be rendered on the phone.
						m_Presets [m_Presets.Count - 1].m_ForcedUnityPPI = 320; 





				}
		}
}


#endif