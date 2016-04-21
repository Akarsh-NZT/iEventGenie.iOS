using System;

using Foundation;
using UIKit;

namespace IEventGenie
{
	public partial class MenuDetailCell : UITableViewCell
	{
		public CategoryTypesModel dataModel{ get; set;}

		public static readonly NSString Key = new NSString ("MenuDetailCell");
		public static readonly UINib Nib = UINib.FromName ("MenuDetailCell", NSBundle.MainBundle);


		static MenuDetailCell ()
		{
		}

		public MenuDetailCell (IntPtr handle) : base (handle)
		{
		}

		public void Binding()
		{
			name.Text = "Name";
			value.Text = dataModel.Text;


		}

		public static MenuDetailCell Create ()
		{
			return (MenuDetailCell)Nib.Instantiate (null, null) [0];
		}
	}
}
