using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Views.Animations;
using Triangulation;


namespace iBeaconImg
{

	[Activity (Label = "BeaconScan", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);


			SetContentView (Resource.Layout.Main);

			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
			
				int A = 1;
				int B = 1;
				int C = 1;
				ImageView dot = FindViewById<ImageView> (Resource.Id.dotID);
				dot.SetImageResource (Resource.Drawable.positionCursor);
				var dotpos = GetPositionInGrid((int) A, (int) B, (int) C);
				dot.SetX(checked((int)dotpos.X));
				dot.SetY(checked((int)dotpos.Y));
			};

			Button button2 = FindViewById<Button> (Resource.Id.BaconButton);
			button2.Click += delegate {
				ImageView dotb1 = FindViewById<ImageView> (Resource.Id.b1);
				ImageView dotb2 = FindViewById<ImageView> (Resource.Id.b2);
				ImageView dotb3 = FindViewById<ImageView> (Resource.Id.b3);

				dotb1.SetX(100);
				dotb1.SetY(37);

				dotb2.SetX(76);
				dotb2.SetY(328);

				dotb3.SetX(306);
				dotb3.SetY(97);
			};
		}

		public Position GetPositionInGrid(int sA, int sB, int sC)
		{

			var b1 = new iBeacon(100, 37, null, sA);
			var b2 = new iBeacon(76, 328, null, sB);
			var b3 = new iBeacon(306, 97, null, sC);

			return Trilateration.Trilaterate(b1, b2, b3);            
		}
	
	}
}