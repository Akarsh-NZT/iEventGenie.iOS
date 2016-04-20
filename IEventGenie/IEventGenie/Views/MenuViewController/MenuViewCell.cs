using System;

using Foundation;
using UIKit;

namespace IEventGenie
{
	public partial class MenuViewCell : UITableViewCell
	{
		public AttendeeCustomFieldSettingsModel dataModel{ get; set;}

		public static readonly NSString Key = new NSString ("MenuViewCell");
		public static readonly UINib Nib = UINib.FromName ("MenuViewCell", NSBundle.MainBundle);


		static MenuViewCell ()
		{
		}

		public MenuViewCell (IntPtr handle) : base (handle)
		{
		}

		public void Binding()
		{
			
			menuName.Text = dataModel.fieldName;
			

		}

		public static MenuViewCell Create ()
		{
			return (MenuViewCell)Nib.Instantiate (null, null) [0];
		}
	}
}
