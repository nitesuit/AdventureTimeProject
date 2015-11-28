using System;

using Xamarin.Forms;
using UIKit;
using Foundation;
using MapKit;
using Xamarin.Forms.Maps;

namespace AdventureTime


{
	public class App  : Application
	{
		public static Page GetMainPage ()
		{   
			return new ContentPage { 
				Content = new Map (MapSpan.FromCenterAndRadius (new Position (37, -122), Distance.FromMiles (10)))
			};
		}
	}
	//iOS
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();
			Xamarin.FormsMaps.Init ();

			window = new UIWindow (UIScreen.MainScreen.Bounds);

			window.RootViewController = App.GetMainPage ().CreateViewController ();
			window.MakeKeyAndVisible ();

			return true;
		}
	}
	//Android 

	namespace HelloMap.Android
	{
		[Activity (Label = "HelloMap.Android.Android", MainLauncher = true)]
		public class MainActivity : AndroidActivity
		{
			protected override void OnCreate (Bundle bundle)
			{
				base.OnCreate (bundle);

				Xamarin.Forms.Forms.Init (this, bundle);
				FormsMaps.Init(this, bundle);

				SetPage (App.GetMainPage ());
			}
		}
	}

}

