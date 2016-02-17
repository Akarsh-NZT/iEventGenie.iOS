using System;

using UIKit;
using Foundation;

namespace iEventGenie
{
	public partial class HomeView : UIViewController
	{
		public HomeView () : base ("HomeView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.NavigationController.NavigationBar.BarTintColor = UIColor.Blue;
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			this.NavigationItem.Title ="iEventGenie";

			UIImage image = UIImage.FromFile ("menu.png");
			UIImage image2 = UIImage.FromFile ("blue.jpeg");

			image = image.ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal);
			this.NavigationItem.SetLeftBarButtonItem (
				new UIBarButtonItem (image2
					, UIBarButtonItemStyle.Plain
					, (sender, args) => {
						{	

							System.Diagnostics.Debug.WriteLine("LEFT SIDE MENU");
						}
					})
				, true);

			this.NavigationItem.SetRightBarButtonItem (
				new UIBarButtonItem (image
					, UIBarButtonItemStyle.Plain
					, (sender, args) => {
						{	
							System.Diagnostics.Debug.WriteLine("RIGHT SIDE MENU");
						}
					})
				, true);


			var url = "https://www.google.co.in/"; // NOTE: https secure request
			webView.LoadRequest(new NSUrlRequest(new NSUrl(url)));

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


