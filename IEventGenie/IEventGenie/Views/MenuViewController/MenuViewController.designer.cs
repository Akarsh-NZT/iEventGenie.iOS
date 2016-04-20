// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace IEventGenie
{
	[Register ("MenuViewController")]
	partial class MenuViewController
	{
		[Outlet]
		UIKit.UIButton logoutButton { get; set; }

		[Outlet]
		UIKit.UILabel name { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Outlet]
		UIKit.UIImageView userImage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (userImage != null) {
				userImage.Dispose ();
				userImage = null;
			}

			if (name != null) {
				name.Dispose ();
				name = null;
			}

			if (logoutButton != null) {
				logoutButton.Dispose ();
				logoutButton = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
		}
	}
}
