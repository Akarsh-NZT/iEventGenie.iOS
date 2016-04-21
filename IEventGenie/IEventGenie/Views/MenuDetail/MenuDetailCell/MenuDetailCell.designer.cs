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
	[Register ("MenuDetailCell")]
	partial class MenuDetailCell
	{
		[Outlet]
		UIKit.UILabel name { get; set; }

		[Outlet]
		UIKit.UILabel value { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (name != null) {
				name.Dispose ();
				name = null;
			}

			if (value != null) {
				value.Dispose ();
				value = null;
			}
		}
	}
}
