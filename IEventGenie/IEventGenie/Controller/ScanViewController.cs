using System;
using UIKit;
using ZXing.Mobile;
using MonoTouch.Dialog;
using Foundation;

namespace IEventGenie
{
	public class ScanViewController :DialogViewController
	{
		string barCodeResult = string.Empty;
		public ScanViewController () : base (UITableViewStyle.Grouped, new RootElement ("ZXing.Net.Mobile"), false)
		{
		}

		MobileBarcodeScanner scanner;

		public override void ViewDidLoad ()
		{			
			//Create a new instance of our scanner
			scanner = new MobileBarcodeScanner(this.NavigationController);

			Root = new RootElement ("ZXing.Net.Mobile") {
				new Section {


					new StyledStringElement ("Tap to scan", async () => {
						//Tell our scanner to use the default overlay
						scanner.UseCustomOverlay = false;
						//We can customize the top and bottom text of the default overlay
						scanner.TopText = "Hold camera up to barcode to scan";
						scanner.BottomText = "Barcode will automatically scan";

						//Start scanning
						var result = await scanner.Scan (true);

						HandleScanResult (result);  
					}),

				}
			};
		}

		void HandleScanResult(ZXing.Result result)
		{

			string msg = "";

			if (result != null && !string.IsNullOrEmpty (result.Text)) {
				msg = "Found Barcode: " + result.Text;

				barCodeResult = result.Text;

			}

			else
				msg = "Scanning Canceled!";
			
			var keys = new object [] { "Bar1" };
			var values = new object [] { barCodeResult };
			var dict = NSDictionary.FromObjectsAndKeys (values, keys);

			NSNotificationCenter.DefaultCenter.PostNotificationName("BarCodeResult",null,dict);
			this.NavigationController.PopToRootViewController (true);//.PushViewController (viewController,true);

//			this.InvokeOnMainThread(() => {
//				var av = new UIAlertView("Barcode Result", msg, null, "OK", null);
//				av.Show();
//			});
		}
	}
}


