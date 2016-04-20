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
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UILabel address { get; set; }

		[Outlet]
		UIKit.UILabel date { get; set; }

		[Outlet]
		UIKit.UIImageView eventImage { get; set; }

		[Outlet]
		UIKit.UILabel eventName { get; set; }

		[Outlet]
		UIKit.UIButton precheckinButton { get; set; }

		[Outlet]
		UIKit.UIWebView webView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (webView != null) {
				webView.Dispose ();
				webView = null;
			}

			if (eventImage != null) {
				eventImage.Dispose ();
				eventImage = null;
			}

			if (eventName != null) {
				eventName.Dispose ();
				eventName = null;
			}

			if (address != null) {
				address.Dispose ();
				address = null;
			}

			if (date != null) {
				date.Dispose ();
				date = null;
			}

			if (precheckinButton != null) {
				precheckinButton.Dispose ();
				precheckinButton = null;
			}
		}
	}
}
