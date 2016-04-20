using System;
using UIKit;
using Mobstac;
using System.Collections.Generic;
using Foundation;

namespace IEventGenie
{
	public class CardViewConroller : UIViewController
	{
		MSMedia m;
		String src;
		UIView subView;

		public CardViewConroller (IntPtr handle) : base (handle)
		{

		}
		public CardViewConroller (MSCard card)
		{
			nfloat screenwidth = UIScreen.MainScreen.Bounds.Width;
			nfloat screenheight = UIScreen.MainScreen.Bounds.Height;
			this.View.BackgroundColor = UIColor.FromRGBA (0,0,0,0.6f);
			subView = new UIView ();
			subView.BackgroundColor = UIColor.White;
			subView.Layer.CornerRadius = 10.0f;


			if (screenwidth == 320f && screenheight == 480f) {
				this.View.Frame = new CoreGraphics.CGRect (0, 0, 320f, 480f);
				subView.Frame = new CoreGraphics.CGRect (20f, 60f, 280f, 360f);
			} 
			else if(screenwidth == 320f && screenheight == 568f)
			{
				this.View.Frame = new CoreGraphics.CGRect (0, 0, 320f, 568f);
				subView.Frame = new CoreGraphics.CGRect (20f, 60f, 280f, 448f);
			}else if (screenwidth == 375f) {
				this.View.Frame = new CoreGraphics.CGRect (0, 0, 375f, 667f);
				subView.Frame = new CoreGraphics.CGRect (20f, 60f, 335f, 547f);
			} else if (screenwidth == 414f) {
				this.View.Frame = new CoreGraphics.CGRect (0, 0, 414f, 736f);
				subView.Frame = new CoreGraphics.CGRect (20f, 60f, 374f, 616f);
			}


				
//				UIAlertView alert = new UIAlertView (card.Title, card.Body, null, "OK", null);
//				 alert.Show ();
			this.View.AddSubview (subView);
			SubViewItems (card);
		}

		private void SubViewItems(MSCard cd)
		{
			UILabel title = new UILabel ();
			UIWebView webView = new UIWebView ();
			UITextView desc = new UITextView ();
			UIButton okbtn = new UIButton ();
			UIView lineView = new UIView ();
			lineView.BackgroundColor = UIColor.Gray;
			okbtn.SetTitleColor (UIColor.Black, UIControlState.Normal);
			title.TextAlignment = UITextAlignment.Center;	
			title.LineBreakMode = UILineBreakMode.WordWrap;
			title.Lines = 2;
			desc.UserInteractionEnabled = false;
			nfloat screenwidth = UIScreen.MainScreen.Bounds.Width;
			nfloat screenheight = UIScreen.MainScreen.Bounds.Height;
			if (screenwidth == 320f && screenheight == 480f) {
				title.Frame = new CoreGraphics.CGRect (10, 10, UIScreen.MainScreen.Bounds.Width - 50f, 44f);
				desc.Frame = new CoreGraphics.CGRect (10, 300, UIScreen.MainScreen.Bounds.Width - 50f, 100f);
				webView.Frame = new CoreGraphics.CGRect (10, 80, UIScreen.MainScreen.Bounds.Width - 50f, 180f);
				lineView.Frame = new CoreGraphics.CGRect (10,390,UIScreen.MainScreen.Bounds.Width-60f,1f);
				okbtn.Frame = new CoreGraphics.CGRect (10, 400f, UIScreen.MainScreen.Bounds.Width - 50f, 44f);
			} 
			else if(screenwidth == 320f && screenheight == 568f)
			{
				title.Frame = new CoreGraphics.CGRect (10, 10, UIScreen.MainScreen.Bounds.Width - 50f, 44f);
				desc.Frame = new CoreGraphics.CGRect (10, 300, UIScreen.MainScreen.Bounds.Width - 50f, 100f);
				webView.Frame = new CoreGraphics.CGRect (10, 80, UIScreen.MainScreen.Bounds.Width - 50f, 180f);
				lineView.Frame = new CoreGraphics.CGRect (10,390,UIScreen.MainScreen.Bounds.Width-60f,1f);
				okbtn.Frame = new CoreGraphics.CGRect (10, 400f, UIScreen.MainScreen.Bounds.Width - 50f, 44f);
			}else if (screenwidth == 375f) {
				title.Frame = new CoreGraphics.CGRect (10, 10, UIScreen.MainScreen.Bounds.Width - 50f, 44f);
				desc.Frame = new CoreGraphics.CGRect (10, 300, UIScreen.MainScreen.Bounds.Width - 50f, 100f);
				webView.Frame = new CoreGraphics.CGRect (10, 80, UIScreen.MainScreen.Bounds.Width - 50f, 180f);
				lineView.Frame = new CoreGraphics.CGRect (10,480,UIScreen.MainScreen.Bounds.Width-60f,1f);
				okbtn.Frame = new CoreGraphics.CGRect (10, 490f, UIScreen.MainScreen.Bounds.Width - 50f, 44f);
			} else if (screenwidth == 414f) {
				title.Frame = new CoreGraphics.CGRect (10, 10, UIScreen.MainScreen.Bounds.Width - 50f, 44f);
				desc.Frame = new CoreGraphics.CGRect (10, 300, UIScreen.MainScreen.Bounds.Width - 50f, 100f);
				webView.Frame = new CoreGraphics.CGRect (10, 80, UIScreen.MainScreen.Bounds.Width - 50f, 180f);
				lineView.Frame = new CoreGraphics.CGRect (10,520,UIScreen.MainScreen.Bounds.Width-60f,1f);
				okbtn.Frame = new CoreGraphics.CGRect (10, 530f, UIScreen.MainScreen.Bounds.Width - 50f, 44f);
			}

			subView.Add (title);
			subView.Add (desc);
			subView.Add (webView);
			subView.Add (okbtn);
			subView.Add (lineView);


			List<String> cardUrls = new List<String> ();
			for (nuint i = 0; i <  cd.MediaArray.Count; i++) {
				m = cd.MediaArray.GetItem<MSMedia>(i);
				src = m.MediaUrl.ToString ();
				cardUrls.Add (src);
			}

			try {
				System.Diagnostics.Debug.WriteLine (cardUrls[0]);	
			} catch (Exception ex) {

			}

			title.Text = cd.Title;
			desc.Text = cd.Body;
			var url = cardUrls[0]; // NOTE: https secure request
			webView.LoadRequest(new NSUrlRequest(new NSUrl(url)));
			okbtn.SetTitle ("OK", UIControlState.Normal);
			okbtn.TouchUpInside+= (object sender, EventArgs e) => {
				subView.RemoveFromSuperview();
				this.View.RemoveFromSuperview();
			};
		}
	}
}

