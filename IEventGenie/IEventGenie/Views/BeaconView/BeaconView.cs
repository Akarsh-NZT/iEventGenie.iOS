using System;

using UIKit;
using Foundation;

namespace IEventGenie
{
	public partial class BeaconView : UIViewController
	{
		public NavController NavController { get; private set; }
		public NotificationView notificationView { get; set;}
		string s ;
		public BeaconView () : base ("BeaconView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

//			name.TextColor = UIColor.Black;
			NavController = new NavController ();
			crossButton.TouchUpInside+= CrossButton_TouchUpInside;
			this.NavController.NavigationBarHidden = false;
//			NSNotificationCenter.DefaultCenter.AddObserver(new NSString("A"),OnEventDetailRowTapped);

			// Perform any additional setup after loading the view, typically from a nib.
		}
		void OnEventDetailRowTapped(NSNotification notify)
		{
			NSDictionary dic = notify.UserInfo;

			s = dic ["key1"].ToString ();
		
			name.Text =  this.s;
		}

		void CrossButton_TouchUpInside (object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine ("BACKBUTTON ENETERED");
			this.DismissViewController(true, null);
			this.NavController.DismissViewController(true, null);
		
//			this.NavController.PopViewController (true);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


