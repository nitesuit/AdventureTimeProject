using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AdventureTime
{
	public class App : Application
	{
		public App ()
		{

		
		}

		public static Page GetMainPage ()
		{   
			var map = new Map (MapSpan.FromCenterAndRadius (new Position (100, -4), Distance.FromMiles (10)));

			var pin1 = new Pin () {
				Position = new Position (37, -122),
				Label = "Some Pin!"
			};

			var pin2 = new Pin () {
				Position = new Position (39, -120),
				Label = "pin 2000"
			};
					
			map.Pins.Add (pin1);
			map.Pins.Add (pin2);

			var cp = new ContentPage { 
				Content = map, 
			};

			return cp;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

