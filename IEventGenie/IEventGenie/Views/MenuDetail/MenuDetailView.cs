using System;

using UIKit;
using Foundation;
using Mobstac;

namespace IEventGenie
{
	public partial class MenuDetailView : UIViewController 
	{
		
		public MainViewController mainViewController{ get; set;}
		public NavController NavController { get; private set; }


		public MenuDetailView () : base ("MenuDetailView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.NavigationController.NavigationBarHidden = false;
			this.NavigationController.NavigationBar.TintColor = UIColor.Blue;
			this.NavigationController.NavigationBar.BarTintColor = UIColor.White;
			 

		}

			// Perform any additional setup after loading the view, typically from a nib.



	}
}


