using System;

using UIKit;
using Foundation;
using Mobstac;

namespace IEventGenie
{
	public partial class NotificationView : UIViewController
	{
		public GetAllEventAttendeeDetailByConfirmationCodeModel attendeeDetailData { get; set;}

		public NotificationView () : base ("NotificationView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.NavigationController.NavigationBarHidden = false;
			this.NavigationController.NavigationBar.TintColor = UIColor.Blue;
			this.NavigationController.NavigationBar.BarTintColor = UIColor.White;
			base.ViewDidLoad ();



			groupedTableSource.Source = new NotificationTableSource (attendeeDetailData);


		}


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
			
	}
}