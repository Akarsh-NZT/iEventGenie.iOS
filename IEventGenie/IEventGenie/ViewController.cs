using System;
using UIKit;
using Foundation;
using Newtonsoft.Json;

namespace IEventGenie
{
	public partial class ViewController : UIViewController
	{
		UIButton activationButton, barCodeScanButton, myEventsButton, EventsNearMeButton, AllEventsButton;
		UIView bottomView, activationView, lastNameView;
		UITextField textField, lastNameTextField;
		ScanViewController scanViewController;
		private ILoginService loginService  ;
		String Scandata = string.Empty;
		public MyEventViewController MyEventViewController;
		LoadingOverlay loadingOverlay;

		public ViewController (IntPtr handle) : base (handle)
		{
			loginService = new LoginService ();
			MyEventViewController = new MyEventViewController ();
		}



		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.NavigationController.NavigationBarHidden = true;
			SetUpView ();
			AdjustSize ();
//			textField.Text ="987654321";
			lastNameTextField.Text= "Aditya";
			// Perform any additional setup after loading the view, typically from a nib.
		}
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.NavigationBarHidden = true;
			AddObserver ();
		}
		void AddObserver()
		{
			NSNotificationCenter.DefaultCenter.AddObserver(new NSString("BarCodeResult"),ScanBarData);
		}
		void ScanBarData(NSNotification notify)
		{
			NSDictionary dic = notify.UserInfo;

			Scandata = dic["Bar1"].ToString();

			textField.Text = Scandata;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
			

		void SetUpView()
		{

			#region ActivationButton
			activationButton = new UIButton ();
			activationButton.BackgroundColor = Themes.LoginButtonColor();
			activationButton.SetTitle (StringConstants.ACTIVATE_EVENT_TITLE, UIControlState.Normal);
			activationButton.TouchUpInside+= ActivationButton_TouchUpInside;
			activationButton.Layer.CornerRadius = 20f;
			#endregion

			#region ActivationRegion
			activationView = new UIView();
			activationView.BackgroundColor = Themes.TransparentColor();
			activationView.Layer.CornerRadius = 15f;
			activationView.Layer.BorderColor = UIColor.LightGray.CGColor;
			activationView.Layer.BorderWidth = 0.5f;
			activationView.ClipsToBounds = true;

			#endregion

			#region LastNameRegion
			lastNameView = new UIView();
			lastNameView.BackgroundColor = Themes.TransparentColor();
			lastNameView.Layer.CornerRadius = 15f;
			lastNameView.Layer.BorderColor = UIColor.LightGray.CGColor;
			lastNameView.Layer.BorderWidth = 0.5f;
			lastNameView.ClipsToBounds = true;

			#endregion
			#region ScanCodeButton
			barCodeScanButton = new UIButton ();
			barCodeScanButton.SetBackgroundImage(UIImage.FromFile(ImageConstants.SCANBAR_IMAGE),UIControlState.Normal);
			barCodeScanButton.TouchUpInside+= BarCodeScanButton_TouchUpInside;
			activationView.AddSubview(barCodeScanButton);
			#endregion

			#region TextView

			textField = new UITextField();
			textField.BackgroundColor = Themes.TransparentColor();
			textField.BorderStyle = UITextBorderStyle.None;
			textField.TextColor = UIColor.White;
			textField.AutocorrectionType = UITextAutocorrectionType.No;
			this.textField.ShouldReturn += (textField) => {
				textField.ResignFirstResponder();
				return true;
			};
			textField.AttributedPlaceholder = new NSAttributedString (
				StringConstants.ACTIVATION_PLACEHOLDER,
				font: UIFont.FromName (Themes.FONT_HELVETICA_REGULAR, 14.0f),
				foregroundColor: UIColor.White
			);

			activationView.AddSubview(textField);
			#endregion

			#region TextViewForLastName

			lastNameTextField = new UITextField();
			lastNameTextField.BackgroundColor = Themes.TransparentColor();
			lastNameTextField.BorderStyle = UITextBorderStyle.None;
			lastNameTextField.TextColor = UIColor.White;
			lastNameTextField.AutocorrectionType = UITextAutocorrectionType.No;
			this.lastNameTextField.ShouldReturn += (textField) => {
				lastNameTextField.ResignFirstResponder();
				return true;
			};
			lastNameTextField.AttributedPlaceholder = new NSAttributedString (
				StringConstants.LAST_NAME,
				font: UIFont.FromName (Themes.FONT_HELVETICA_REGULAR, 14.0f),
				foregroundColor: UIColor.White
			);

			lastNameView.AddSubview(lastNameTextField);
			#endregion


			#region BottomButtonRegion
			bottomView = new UIView(); 
			bottomView.BackgroundColor = UIColor.White;
			#endregion

			#region MyEventButton
			myEventsButton = new UIButton();		
			myEventsButton.BackgroundColor = Themes.LoginButtonColor();
			myEventsButton.SetTitle (StringConstants.MY_EVENTS_TITLE, UIControlState.Normal);
			myEventsButton.Font =UIFont.FromName(Themes.FONT_HELVETICA_BOLD, 11f);
			myEventsButton.TouchUpInside+= MyEventsButton_TouchUpInside;
			bottomView.AddSubview(myEventsButton);
			#endregion

			#region EventsNearMe
			EventsNearMeButton = new UIButton();
			EventsNearMeButton.BackgroundColor = Themes.LoginButtonColor();
			EventsNearMeButton.SetTitle (StringConstants.EVENTS_NEAR_ME_TITLE, UIControlState.Normal);
			EventsNearMeButton.Font =UIFont.FromName(Themes.FONT_HELVETICA_BOLD, 11f);
			EventsNearMeButton.TouchUpInside+= EventsNearMeButton_TouchUpInside;
			bottomView.AddSubview(EventsNearMeButton);
			#endregion

			#region AllEvents
			AllEventsButton = new UIButton();
			AllEventsButton.BackgroundColor = Themes.LoginButtonColor();
			AllEventsButton.SetTitle (StringConstants.ALL_EVENTS_TITLE, UIControlState.Normal);
			AllEventsButton.Font =UIFont.FromName(Themes.FONT_HELVETICA_BOLD, 11f);
			AllEventsButton.TouchUpInside+= AllEventsButton_TouchUpInside;;
			bottomView.AddSubview(AllEventsButton);
			#endregion


			this.View.AddSubview (bottomView);
			this.View.AddSubview (activationView);
			this.View.AddSubview (lastNameView);
			this.View.AddSubview (activationButton);
			scanViewController = new ScanViewController();

		}

		void AllEventsButton_TouchUpInside (object sender, EventArgs e)
		{
//			this.NavigationController.PushViewController (new MyEventViewController (), true);
		}

		void EventsNearMeButton_TouchUpInside (object sender, EventArgs e)
		{
//			this.NavigationController.PushViewController (new MyEventViewController (), true);
		}

		void MyEventsButton_TouchUpInside (object sender, EventArgs e)
		{
//			this.NavigationController.PushViewController (new MyEventViewController (), true);
		}

		void BarCodeScanButton_TouchUpInside (object sender, EventArgs e)
		{
			this.NavigationController.PushViewController (scanViewController, true);
		}

		void ActivationButton_TouchUpInside (object sender, EventArgs e)
		{
			var bounds = UIScreen.MainScreen.Bounds;


			loadingOverlay = new LoadingOverlay (bounds);
			View.Add (loadingOverlay);

			DoLogin ();

		}
		#region For IOS Upgrade Changes

		private void AdjustSize()
		{
			float width = (float)UIScreen.MainScreen.ApplicationFrame.Size.Width;
			float height = (float)UIScreen.MainScreen.ApplicationFrame.Size.Height;

			 
			if (height == 460f && width == 320f) {

				activationButton.Frame = FrameConstants.ActivationButtonForFour ();
				activationView.Frame = FrameConstants.ActivationViewForFour ();
				barCodeScanButton.Frame = FrameConstants.BarCodeScanButtonForFour ();
				textField.Frame = FrameConstants.TextFieldForFour ();
				bottomView.Frame = FrameConstants.BottomViewForFour ();
				myEventsButton.Frame = FrameConstants.MyEventButtonForFour ();
				EventsNearMeButton.Frame = FrameConstants.EventNearMeButtonForFour ();
				AllEventsButton.Frame = FrameConstants.AllEventButtonForFour ();
				lastNameView.Frame = FrameConstants.LastNameViewForFour ();
				lastNameTextField.Frame = FrameConstants.LastTextFieldForFour ();
			}

			else if (width == 320f && height == 548f) {

				activationButton.Frame = FrameConstants.ActivationButtonForFive ();
				activationView.Frame = FrameConstants.ActivationViewForFive ();
				barCodeScanButton.Frame = FrameConstants.BarCodeScanButtonForFive ();
				textField.Frame = FrameConstants.TextFieldForFive ();
				bottomView.Frame = FrameConstants.BottomViewForFive ();
				myEventsButton.Frame = FrameConstants.MyEventButtonForFive ();
				EventsNearMeButton.Frame = FrameConstants.EventNearMeButtonForFive ();
				AllEventsButton.Frame = FrameConstants.AllEventButtonForFive ();
				lastNameView.Frame = FrameConstants.LastNameViewForFive ();
				lastNameTextField.Frame = FrameConstants.LastTextFieldForFive ();


			}
			else if (width == 375f)
			{

				activationButton.Frame = FrameConstants.ActivationButtonForSix ();
				activationView.Frame = FrameConstants.ActivationViewForSix ();
				barCodeScanButton.Frame = FrameConstants.BarCodeScanButtonForSix ();
				textField.Frame = FrameConstants.TextFieldForSix ();
				bottomView.Frame = FrameConstants.BottomViewForSix ();
				myEventsButton.Frame = FrameConstants.MyEventButtonForSix ();
				EventsNearMeButton.Frame = FrameConstants.EventNearMeButtonForSix ();
				AllEventsButton.Frame = FrameConstants.AllEventButtonForSix ();
				lastNameView.Frame = FrameConstants.LastNameViewForSix ();
				lastNameTextField.Frame = FrameConstants.LastTextFieldForSix ();
			}
			else if(width > 375f)
			{

				activationButton.Frame = FrameConstants.ActivationButtonForSixPlus ();
				activationView.Frame = FrameConstants.ActivationViewForSixPlus ();
				barCodeScanButton.Frame = FrameConstants.BarCodeScanButtonForSixPlus ();
				textField.Frame = FrameConstants.TextFieldForSixPlus ();
				bottomView.Frame = FrameConstants.BottomViewForSixPlus ();
				myEventsButton.Frame = FrameConstants.MyEventButtonForSixPlus ();
				EventsNearMeButton.Frame = FrameConstants.EventNearMeButtonForSixPlus ();
				AllEventsButton.Frame = FrameConstants.AllEventButtonForSixPlus ();
				lastNameView.Frame = FrameConstants.LastNameViewForSixPlus ();
				lastNameTextField.Frame = FrameConstants.LastTextFieldForSixPlus ();
			}


		}
		#endregion

		#region DOLOGIN
		public async void DoLogin()
		{
			ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel> Response = await loginService.GetAllEventAttendeeDetailByConfirmationCode (textField.Text, lastNameTextField.Text);
			if (Response.Success == ResponseStatus.OK) {
				System.Diagnostics.Debug.WriteLine ("SUCCESS");

				loadingOverlay.Hide ();
				MyEventViewController.attendeeDetailData = Response.Content;

				this.NavigationController.PushViewController (MyEventViewController, true);
			}

		}
		#endregion

	}
}

