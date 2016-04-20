using System;

using Foundation;
using UIKit;

namespace IEventGenie
{
	public partial class MyEventCell : UITableViewCell
	{
		public GetAllEventAttendeeDetailByConfirmationCodeModel dataModel{ get; set;}

		public static readonly NSString Key = new NSString ("MyEventCell");
		public static readonly UINib Nib = UINib.FromName ("MyEventCell", NSBundle.MainBundle);


		static MyEventCell ()
		{
		}

		public MyEventCell (IntPtr handle) : base (handle)
		{
		}

		public void Binding()
		{
			precheckinButton.Layer.CornerRadius = 10f;
			precheckinButton.Layer.BorderWidth = 1.0f;
			precheckinButton.Layer.BorderColor = UIColor.FromRGB (79, 169, 40).CGColor;
			precheckinButton.ClipsToBounds = true;
			precheckinButton.TouchUpInside += PrecheckinButton_TouchUpInside;
			eventImage.Image = UIImage.FromBundle( "headlights.jpg");
			eventImage.Layer.CornerRadius = 30f;
			eventName.Text = dataModel.Ev_Desc;
			address.Text = dataModel.Ev_Addr_1_Txt + ", " + dataModel.Ev_City_Txt;
			date.Text = dataModel.Ev_Early_Chk_In_End_Dttm;
		}

		void PrecheckinButton_TouchUpInside (object sender, EventArgs e)
		{
			this.InvokeOnMainThread(() => {
				var av = new UIAlertView("Pre-Checkin", "", null, "OK", "Cancel");
				av.Show();

			});

			NSNotificationCenter.DefaultCenter.PostNotificationName("Pre-CheckinClick",null);


		}

		public static MyEventCell Create ()
		{
			return (MyEventCell)Nib.Instantiate (null, null) [0];
		}
	}
}



