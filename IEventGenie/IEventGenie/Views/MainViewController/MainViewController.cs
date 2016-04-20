using System;

using UIKit;
using Foundation;
using Newtonsoft.Json;

namespace IEventGenie
{
	public partial class MainViewController : UIViewController
	{
		public GetAllEventAttendeeDetailByConfirmationCodeModel attendeeDetailData { get; set;}
		private ICheckInWithConfirmationService checkInWithConfirmationCodeService  ;
		public MainViewController () : base ("MainViewController", null)
		{
			checkInWithConfirmationCodeService = new CheckInWithConfirmationService ();
		}

		public SidebarNavigation.SidebarController SidebarController { get; set; }

		public override void ViewDidLoad ()
		{
			



			DataBinding ();
			SetUpView ();
			eventImage.Layer.CornerRadius = 35f;
			precheckinButton.Layer.CornerRadius = 10f;
			precheckinButton.Layer.BorderWidth = 1.0f;
			precheckinButton.Layer.BorderColor = UIColor.FromRGB(79,169,40).CGColor;
			precheckinButton.ClipsToBounds = true;

			precheckinButton.TouchUpInside += PrecheckinButton_TouchUpInside;


		}

		 void PrecheckinButton_TouchUpInside (object sender, EventArgs e)
		{
			DoCheckin ();
		}

		private async void  DoCheckin ()
		{
			ResponseModel<CheckInWithConfirmationCodeModel> Response = await checkInWithConfirmationCodeService.GetCheckInWithConfirmationCodeStatus ("987654321","552", "725484");
			if (Response.Success == ResponseStatus.OK) {
				System.Diagnostics.Debug.WriteLine ("SUCCESS");
				string a = string.Empty;
				if (Response.Content.success == "False") {
					a = Response.Content.message;
				} else {
					a= "Successfully CheckIn";
				}

				this.InvokeOnMainThread(() => {
					var av = new UIAlertView(a, "", null, "OK", "Cancel");
					av.Show();

				});
			}
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.NavigationBarHidden = false;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.NavigationBarHidden = true;
		}

		void SetUpView()
		{
//			this.NavigationController.NavigationBarHidden = false;
//			this.NavigationController.NavigationBar.TintColor = UIColor.Blue;
//			this.NavigationController.NavigationBar.BarTintColor = UIColor.White;
//			this.Title = StringConstants.MY_EVENTS_TITLE_NAVBAR;
//			this.NavigationController.NavigationBar.TitleTextAttributes = new UIStringAttributes()
//			{
//				ForegroundColor = UIColor.White,
//
//			};
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

			base.ViewDidLoad ();
			NavigationItem.SetRightBarButtonItem(
				new UIBarButtonItem(UIImage.FromBundle("threelines.png")
					, UIBarButtonItemStyle.Plain
					, (sender,args) => {
						SidebarController.ToggleMenu();
					}), true);
		}
			
		void DataBinding ()
		{
			if (attendeeDetailData != null) {
				eventName.Text = attendeeDetailData.Ev_Desc;
				address.Text = attendeeDetailData.Ev_Addr_1_Txt + ", " + attendeeDetailData.Ev_City_Txt;
				date.Text = attendeeDetailData.Ev_Early_Chk_In_End_Dttm;
				var url = attendeeDetailData.Ev_Web_Url;
				; // NOTE: https secure request
				webView.LoadRequest (new NSUrlRequest (new NSUrl (url)));
			}

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
			
	}
}


