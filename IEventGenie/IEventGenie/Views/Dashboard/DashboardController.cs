using System;

using UIKit;
using Foundation;

namespace IEventGenie
{
	public partial class DashboardController : UIViewController
	{
		public SidebarNavigation.SidebarController SidebarController { get; private set; }
		public GetAllEventAttendeeDetailByConfirmationCodeModel attendeeDetailData { get; set;}
		public NavController NavController { get; private set; }
		public NotificationView notificationView{ get; set;}
		public MenuDetailView menuDetailView{ get; set;}

		public DashboardController () : base ("DashboardController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			AddObserver ();
			LoadSideoutMenu ();


			UIImageView logoImage = new UIImageView ();
			logoImage.Image = UIImage.FromBundle ("header-logo.png");
			logoImage.Frame = new CoreGraphics.CGRect (60,5,100,30);
			this.NavigationItem.TitleView = logoImage;
			this.View.Frame = new CoreGraphics.CGRect (0,0,0,870);

			this.NavigationController.NavigationBar.BarTintColor = UIColor.White;
			this.NavigationController.NavigationBar.TintColor = UIColor.Blue;

			NavigationItem.SetLeftBarButtonItem(
				new UIBarButtonItem(UIImage.FromBundle("back-black-arrow.png")
					, UIBarButtonItemStyle.Plain
					, (sender,args) => {
						this.NavigationController.PopViewController(true);
					}), true);

			var innerButton = new UIButton (UIButtonType.Custom) { 
				Frame = new CoreGraphics.CGRect (0, 0, 32, 32) 
			};
			innerButton.SetBackgroundImage (UIImage.FromBundle(ImageConstants.NOTIFICATION_ICON),UIControlState.Normal);

			UIBarButtonItem btn1 = new UIBarButtonItem(innerButton);
			innerButton.TouchUpInside += delegate(object sender, EventArgs e) {
				this.NavigationController.PushViewController(new NotificationView(),true);

			};

			UIBarButtonItem btn2 = new UIBarButtonItem();
			btn2.Image= UIImage.FromFile (ImageConstants.HAMBURGER_ICON);

			btn2.Clicked += delegate(object sender, EventArgs e) {
				SidebarController.ToggleMenu();

			};

			UIToolbar tb = new UIToolbar();

			tb.Frame = FrameConstants.NavBarFRame ();
			tb.Layer.CornerRadius = 5.0f;
			tb.ClipsToBounds = true;
			tb.BarTintColor = UIColor.White;
			tb.TintColor = UIColor.Blue;//Themes.NavBarColor ();
			tb.SetItems( new UIBarButtonItem[] { btn1, btn2 }, false );
			NavigationItem.RightBarButtonItem = new UIBarButtonItem( tb );
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			this.NavigationController.NavigationBarHidden = false;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

//			this.NavigationController.NavigationBarHidden = true;
		}

		public override void ViewDidUnload ()
		{
			RemoveObserver ();
			base.ViewDidUnload ();
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		void LoadSideoutMenu()
		{
			MainViewController mvc = new MainViewController ();
			MenuViewController menuC = new MenuViewController ();
			NavController = new NavController();
			mvc.attendeeDetailData = attendeeDetailData;
			menuC.attendeeDetailData = attendeeDetailData;
			SidebarController = new SidebarNavigation.SidebarController(this, mvc, menuC);

			SidebarController.MenuWidth = 240;
			SidebarController.ReopenOnRotate = false;
		}


		void AddObserver()
		{
			NSNotificationCenter.DefaultCenter.AddObserver(new NSString("ShowMenuDetailPage"),OnEventDetailRowTapped);
		}

		void RemoveObserver()
		{
			NSNotificationCenter.DefaultCenter.RemoveObserver(new NSString("ShowMenuDetailPage"));
		}

		void OnEventDetailRowTapped(NSNotification notify)
		{
			menuDetailView = new MenuDetailView();

			menuDetailView.attendeeDetailData = attendeeDetailData;

			this.NavigationController.PushViewController (menuDetailView,true);
		}


	}
}


