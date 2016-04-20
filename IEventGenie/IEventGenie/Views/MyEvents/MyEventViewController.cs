using System;

using UIKit;
using Foundation;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IEventGenie
{
	public partial class MyEventViewController : UIViewController
	{
		public GetAllEventAttendeeDetailByConfirmationCodeModel attendeeDetailData { get; set;}
		public DashboardController dashboardController{ get; set;}
		private IPreCheckinService preCheckinService  ;

		public MyEventViewController () : base ("MyEventViewController", null)
		{
			preCheckinService = new PreCheckinService ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			SegmentControllerSetUp ();
			image2.Hidden = true;
			AddObserver ();
//			hiddenView.Hidden = true;
			InitStoreListView ();

			activateButton.TouchUpInside += ActivateButton_TouchUpInside;

			// Perform any additional setup after loading the view, typically from a nib.
		}
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			RemoveObserver ();
		}
		public override void ViewWillAppear (bool animated)
		{
			SetUpView ();

			base.ViewWillAppear (animated);
			this.NavigationController.NavigationBarHidden = false;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			this.NavigationController.NavigationBarHidden = true;
		}
		void AddObserver()
		{
			NSNotificationCenter.DefaultCenter.AddObserver(new NSString("ShowMyEventDetailNotification"),OnEventDetailRowTapped);
			NSNotificationCenter.DefaultCenter.AddObserver(new NSString("Pre-CheckinClick"),OnPreCheckinTapped);
		}

		void RemoveObserver()
		{
			NSNotificationCenter.DefaultCenter.RemoveObserver(new NSString("ShowMyEventDetailNotification"));
			NSNotificationCenter.DefaultCenter.RemoveObserver(new NSString("Pre-CheckinClick"));
		}

		void OnEventDetailRowTapped(NSNotification notify)
		{
			NSDictionary dic = notify.UserInfo;
			GetAllEventAttendeeDetailByConfirmationCodeModel data = JsonConvert.DeserializeObject<GetAllEventAttendeeDetailByConfirmationCodeModel > (dic["key1"].ToString());
			dashboardController = new DashboardController ();
			dashboardController.attendeeDetailData = data;
			this.NavigationController.PushViewController(dashboardController, true);
		}

		void OnPreCheckinTapped(NSNotification notify)
		{
			System.Diagnostics.Debug.WriteLine ("PRE_CHEKIN_h");

			DoPreCheckin ();


		}

		private async void  DoPreCheckin ()
		{
			ResponseModel<PreCheckinModel> Response = await preCheckinService.GetPreCheckinStatus ("552", "725484");
			if (Response.Success == ResponseStatus.OK) {
				System.Diagnostics.Debug.WriteLine ("SUCCESS");
			}
		}

		void ActivateButton_TouchUpInside (object sender, EventArgs e)
		{
//			this.NavigationController.PushViewController (new DashboardController(), true);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
		partial void Push (NSObject sender)
		{
			LoadDashBoard();
		}

		void LoadDashBoard()
		{
			this.NavigationController.NavigationBarHidden = true;
			this.NavigationController.PushViewController(new DashboardController(), true);
		}

		private void SetUpView()
		{
			
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			this.NavigationController.NavigationBar.BarTintColor = Themes.NavBarColor ();
			this.Title = StringConstants.MY_EVENTS_TITLE_NAVBAR;
			this.NavigationController.NavigationBar.TitleTextAttributes = new UIStringAttributes()
			{
				ForegroundColor = UIColor.White,

			};
			UIImage image = UIImage.FromFile (ImageConstants.BACK_BUTTON);

			image = image.ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal);

			this.NavigationItem.SetLeftBarButtonItem (
				new UIBarButtonItem (image
					, UIBarButtonItemStyle.Plain
					, (sender, args) => {
						{	
							this.NavigationController.PopViewController(true);	
						}
					})
				, true);
		}

		private void SegmentControllerSetUp()
		{

			segment.ValueChanged += (s, e) => {
				SegmentValueChanged((int)segment.SelectedSegment);
			};
				
		}

		void SegmentValueChanged(int index)
		{
			switch( index) {
			case 0:
				image1.Hidden = false;
				image2.Hidden = true;
				hiddenView.Hidden = true;
				break;
			case 1:
				image1.Hidden = true;
				image2.Hidden = false;
				hiddenView.Hidden = false;
				break;

			}
		}

		public void InitStoreListView ()
		{
			tableView.Source = new MyEventTableSource (attendeeDetailData);
		}

	}
}


