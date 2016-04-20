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
	[Register ("MyEventViewController")]
	partial class MyEventViewController
	{
		[Outlet]
		UIKit.UIButton activateButton { get; set; }

		[Outlet]
		UIKit.UIView hiddenView { get; set; }

		[Outlet]
		UIKit.UIImageView image1 { get; set; }

		[Outlet]
		UIKit.UIImageView image2 { get; set; }

		[Outlet]
		UIKit.UISegmentedControl segment { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Action ("Push:")]
		partial void Push (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (segment != null) {
				segment.Dispose ();
				segment = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (image1 != null) {
				image1.Dispose ();
				image1 = null;
			}

			if (activateButton != null) {
				activateButton.Dispose ();
				activateButton = null;
			}

			if (image2 != null) {
				image2.Dispose ();
				image2 = null;
			}

			if (hiddenView != null) {
				hiddenView.Dispose ();
				hiddenView = null;
			}
		}
	}
}
