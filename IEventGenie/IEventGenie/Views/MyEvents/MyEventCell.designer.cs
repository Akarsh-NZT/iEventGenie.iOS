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
	[Register ("MyEventCell")]
	partial class MyEventCell
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
		
		void ReleaseDesignerOutlets ()
		{
			if (address != null) {
				address.Dispose ();
				address = null;
			}

			if (date != null) {
				date.Dispose ();
				date = null;
			}

			if (eventImage != null) {
				eventImage.Dispose ();
				eventImage = null;
			}

			if (eventName != null) {
				eventName.Dispose ();
				eventName = null;
			}

			if (precheckinButton != null) {
				precheckinButton.Dispose ();
				precheckinButton = null;
			}
		}
	}
}
