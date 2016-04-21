using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using System.Linq;

namespace IEventGenie
{
	public class MenuDetailTableSource : UITableViewSource
	{
		readonly string cellIdentifier = "MenuDetailCell";

		protected List<CategoryTypesModel> tableItems;
		CategoryTypesModel childItem ;

		private NavController navController;

		public MenuDetailTableSource(GetAllEventAttendeeDetailByConfirmationCodeModel data)
		{

			SetDataOnTableSource(data);

		}
		//TODO : Change the data structure for multiple events
		public void SetDataOnTableSource (GetAllEventAttendeeDetailByConfirmationCodeModel data)
		{
			if (data == null )
				return;


			tableItems = data.categoryTypes ;

		
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
//			return 3;
			if (tableItems == null)
				return 0;

			return (int)tableItems.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			try{

				MenuDetailCell cell = tableView.DequeueReusableCell (cellIdentifier) as MenuDetailCell;


				if (cell == null) {
					cell = MenuDetailCell.Create ();
				}

				childItem = tableItems [indexPath.Row];

				cell.dataModel = childItem;
				cell.Binding();

				return cell;
			}
			catch (Exception ex) {
				return (MenuDetailCell) tableView.DequeueReusableCell(MenuDetailCell.Key, indexPath)  ;
			}

		}




	}
}

