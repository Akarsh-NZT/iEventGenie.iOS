using System;

using Foundation;
using UIKit;

namespace IEventGenie
{
	public partial class NotificationCell : UITableViewCell
	{
		public AttendeeCustomFieldSettingsModel dataModel{ get; set;}

		public static readonly NSString Key = new NSString ("NotificationCell");
		public static readonly UINib Nib = UINib.FromName ("NotificationCell", NSBundle.MainBundle);


		static NotificationCell ()
		{
		}

		public NotificationCell (IntPtr handle) : base (handle)
		{
		}

		public void Binding()
		{

			image.Image = UIImage.FromFile("NoImage.jpg");
			notificationLabel.Text = "Sunglasses";
			date.Text = "12/04/2016";



		}

		public static NotificationCell Create ()
		{
			return (NotificationCell)Nib.Instantiate (null, null) [0];
		}
	}
}
