using System;

using UIKit;
using Foundation;
using Mobstac;
using Newtonsoft.Json;

namespace IEventGenie
{
	public partial class MenuDetailView : UIViewController 
	{
		public GetAllEventAttendeeDetailByConfirmationCodeModel attendeeDetailData { get; set;}
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

			InitStoreListView ();
		}

		public void InitStoreListView ()
		{
			menuTableSource.Source = new MenuDetailTableSource (attendeeDetailData);
		}


			// Perform any additional setup after loading the view, typically from a nib.



	}
}


