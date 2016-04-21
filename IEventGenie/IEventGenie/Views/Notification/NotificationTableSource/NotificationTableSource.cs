﻿using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using System.Linq;

namespace IEventGenie
{
	public class NotificationTableSource : UITableViewSource
	{
		readonly string cellIdentifier = "NotificationCell";

		protected List<AttendeeCustomFieldSettingsModel> tableItems;

		private NavController navController;

		public NotificationTableSource(GetAllEventAttendeeDetailByConfirmationCodeModel data)
		{
			SetDataOnTableSource(data);
		}

		//TODO : Change the data structure for multiple events
		public void SetDataOnTableSource (GetAllEventAttendeeDetailByConfirmationCodeModel data)
		{
			if (data == null )
				return;
			
			tableItems = data.AttendeeCustomFieldSettings ;
			tableItems = tableItems.Where (p => p.isOn.Equals ("True")).ToList();
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			if (tableItems == null)
				return 0;

			return (int)tableItems.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			try{

				NotificationCell cell = tableView.DequeueReusableCell (cellIdentifier) as NotificationCell;


				if (cell == null) {
					cell = NotificationCell.Create ();
				}

				AttendeeCustomFieldSettingsModel childItem = tableItems [indexPath.Row];

				cell.dataModel = childItem;
				cell.Binding();

				return cell;
			}
			catch (Exception ex) {
				return (NotificationCell) tableView.DequeueReusableCell(NotificationCell.Key, indexPath)  ;
			}

		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			NSNotificationCenter.DefaultCenter.PostNotificationName("ShowMyNotification",null);
			tableView.DeselectRow (indexPath, true);


		}


	}
}

