using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin;

namespace AdventureTime.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();
			FormsMaps.Init ();

			window = new UIWindow (UIScreen.MainScreen.Bounds);

			window.RootViewController = AdventureTime.App.GetMainPage ().CreateViewController ();
			window.MakeKeyAndVisible ();

			return true;
		}
	}
}

