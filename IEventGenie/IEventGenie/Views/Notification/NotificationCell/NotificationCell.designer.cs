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
	[Register ("NotificationCell")]
	partial class NotificationCell
	{
		[Outlet]
		UIKit.UILabel date { get; set; }

		[Outlet]
		UIKit.UIImageView image { get; set; }

		[Outlet]
		UIKit.UILabel notificationLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (image != null) {
				image.Dispose ();
				image = null;
			}

			if (notificationLabel != null) {
				notificationLabel.Dispose ();
				notificationLabel = null;
			}

			if (date != null) {
				date.Dispose ();
				date = null;
			}
		}
	}
}
