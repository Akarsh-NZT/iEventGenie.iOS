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
	[Register ("BeaconView")]
	partial class BeaconView
	{
		[Outlet]
		UIKit.UIButton crossButton { get; set; }

		[Outlet]
		UIKit.UILabel name { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (crossButton != null) {
				crossButton.Dispose ();
				crossButton = null;
			}

			if (name != null) {
				name.Dispose ();
				name = null;
			}
		}
	}
}
