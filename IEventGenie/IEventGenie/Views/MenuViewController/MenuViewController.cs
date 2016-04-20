using System;

using UIKit;
using Foundation;

namespace IEventGenie
{
	public partial class MenuViewController : UIViewController
	{
		public GetAllEventAttendeeDetailByConfirmationCodeModel attendeeDetailData { get; set;}


		public MenuViewController () : base ("MenuViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			SetUpView ();
			Binding ();
			InitStoreListView ();
			// Perform any additional setup after loading the view, typically from a nib.
		}



		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		void SetUpView()
		{
			userImage.Layer.CornerRadius = 30f;
			logoutButton.Layer.CornerRadius = 10f;
			logoutButton.Layer.BorderWidth = 1.0f;
			this.View.Frame = new CoreGraphics.CGRect (-375f, 0, 0, 800);
			logoutButton.Layer.BorderColor = UIColor.White.CGColor;
			logoutButton.TouchUpInside+= LogoutButton_TouchUpInside;

				
		}

		void LogoutButton_TouchUpInside (object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine ("LogOut");
		}

		void Binding()
		{
			if(attendeeDetailData.attendeeDetails != null)
			name.Text = attendeeDetailData.attendeeDetails.FirstName + " " + attendeeDetailData.attendeeDetails.LastName;
		}

		public void InitStoreListView ()
		{
			tableView.Source = new MenuTableSource (attendeeDetailData);
		}

	}
}


