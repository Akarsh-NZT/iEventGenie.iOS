using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace IEventGenie
{
	public class MyEventTableSource : UITableViewSource
	{
		readonly string cellIdentifier = "MyEventCell";

		protected List<GetAllEventAttendeeDetailByConfirmationCodeModel> tableItems;

		private NavController navController;

		public MyEventTableSource(GetAllEventAttendeeDetailByConfirmationCodeModel data)
		{

			SetDataOnTableSource(data);

		}
		//TODO : Change the data structure for multiple events
		public void SetDataOnTableSource (GetAllEventAttendeeDetailByConfirmationCodeModel data)
		{
			if (data == null )
				return;
			if (tableItems == null)
				tableItems = new List<GetAllEventAttendeeDetailByConfirmationCodeModel> ();
			tableItems.Add(data);
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

				MyEventCell cell = tableView.DequeueReusableCell (cellIdentifier) as MyEventCell;


				if (cell == null) {
					cell = MyEventCell.Create ();
				}

				GetAllEventAttendeeDetailByConfirmationCodeModel childItem = tableItems [indexPath.Row];

				cell.dataModel = childItem;
				cell.Binding();

				return cell;
			}
			catch (Exception ex) {
				return (MyEventCell) tableView.DequeueReusableCell(MyEventCell.Key, indexPath)  ;
			}

		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			GetAllEventAttendeeDetailByConfirmationCodeModel childItem = tableItems [indexPath.Row];

			string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(childItem);

			System.Diagnostics.Debug.WriteLine ("M : " + jsonString);
		
			var keys = new object [] { "key1" };
			var values = new object [] { jsonString };
			var dict = NSDictionary.FromObjectsAndKeys (values, keys);


			NSNotificationCenter.DefaultCenter.PostNotificationName("ShowMyEventDetailNotification",null,dict);
			tableView.DeselectRow (indexPath, true);
		}
			

	}
}

