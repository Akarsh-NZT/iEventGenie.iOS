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
	[Register ("NotificationView")]
	partial class NotificationView
	{
		[Outlet]
		UIKit.UITableView groupedTableSource { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (groupedTableSource != null) {
				groupedTableSource.Dispose ();
				groupedTableSource = null;
			}
		}
	}
}
