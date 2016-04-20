using System;
using UIKit;

namespace IEventGenie
{
	public static class Themes
	{
		#region ColorConstants
		public static UIColor LoginButtonColor()
		{
			return UIColor.FromRGB(235,66,31);
		}

		public static UIColor TransparentColor()
		{
			return UIColor.FromHSBA(255,255,255,0.0f);
		}
		public static UIColor NavBarColor()
		{
			return UIColor.FromRGB(11,58,132);
		}
		#endregion



		#region FONT

		public const string FONT_HELVETICA_REGULAR = "Helvetica-Regular";
		public const string FONT_HELVETICA_BOLD = "Helvetica-Bold";


		#endregion
	}
}

