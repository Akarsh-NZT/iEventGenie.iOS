using System;
using UIKit;
using Foundation;
using Mobstac;
using CoreLocation;
using System.Collections.Generic;

namespace IEventGenie
{
	public sealed class BeaconsManager
	{
		UIWebView webView;
		public MainViewController mainViewController{ get; set;}
		public NavController NavController { get; private set; }
		public BeaconView beaconView{ get; set;}
		private BeaconstacDelegate bstacDelegate;
		private Beaconstac bstac;
		public static BeaconsManager instance = null;
		public BeaconsManager ()
		{
		}
		public static BeaconsManager Instance
		{
			get
			{
				if (instance==null)
				{
					instance = new BeaconsManager();
				}
				return instance;
			}
		}

		public void BeaconSearch()
		{
			bstac = Beaconstac.SharedInstanceWithOrganizationId (1018,"349f884991f08ea9ddfa4503c983f40a19ac4984");
			bstac.AllowRangingInBackground = true;

			bstacDelegate = new MyBeaconstacDelegate ();
			bstac.Delegate = bstacDelegate;


			// Starts ranging beacons with given UUID and a string as region identifier
			var options = new NSDictionary ("myBeacons", true);
			bstac.StartRangingBeaconsWithUUIDString ("F94DBB23-2266-7822-3782-57BEAC0952AC","MobstacRegion",options);
		}

		class MyBeaconstacDelegate : BeaconstacDelegate 
		{
			private MyWebhookDelegate webhookDelegate;


			public override void RangedBeacons (Beaconstac beaconstac, NSDictionary beaconsDictionary)
			{
				Console.WriteLine ("Ranged beacons");
			}

			public override void CampedOnBeacon (Beaconstac beaconstac, MSBeacon beacon, NSDictionary beaconsDictionary)
			{
//				Console.WriteLine ("Camped On Beacon "+ beacon.BeaconKey);
//				UIAlertView alert = new UIAlertView ("Camped On beacon "+beacon.BeaconKey, "Yay", null, "OK", null);
//				alert.Show ();
			}

			public override void TriggeredRuleWithRuleName (Beaconstac beaconstac, string ruleName, NSObject[] actionArray)
			{
				Console.WriteLine ("Triggered Rule with Name "+ ruleName);

				// actionArray contains the list of actions to trigger for the rule that matched.
				foreach (MSAction action in actionArray) {
					switch (action.Type) {

					case MSActionType.Notification:
						Console.WriteLine ("Webhook");
						MSNotification notify = (MSNotification)action;
						notify.ShowInApplication (UIApplication.SharedApplication);
						break;

					case MSActionType.Webhook:
						
						MSWebhook webhook = (MSWebhook)action;
						webhookDelegate = new MyWebhookDelegate ();
						webhook.Delegate = webhookDelegate;
						break;

					case MSActionType.Card:
						MSMedia m;
						String src;
						MSCard card = (MSCard)action;
						cardView (card);
						break;

					case MSActionType.Popup:
						MSPopupAction pop = (MSPopupAction)action;
						UIAlertView alert = new UIAlertView (pop.Title, pop.MessageBody, null, "OK", null);
						alert.Show ();
						break;
						

					default:
						Console.WriteLine (action.Type);
						break;
					}
				}
			}

			public override void DidEnterBeaconRegion (Beaconstac beaconstac, CLBeaconRegion region)
			{
//				Console.WriteLine ("Entered Beacon region "+ region.Identifier);
//				UIAlertView alert = new UIAlertView ("Entered Beacon region "+ region.Identifier, "Yay", null, "OK", null);
//				alert.Show ();
			}

			public override void DidExitBeaconRegion (Beaconstac beaconstac, CLBeaconRegion region)
			{
//				Console.WriteLine ("Exited Beacon region "+ region.Identifier);
//				UIAlertView alert = new UIAlertView ("Exited Beacon region "+ region.Identifier, "Yay", null, "OK", null);
//				alert.Show ();
			}

			// Webhook Delegates
			class MyWebhookDelegate : MSWebhookDelegate
			{
				public override bool WebhookShouldExecute (MSWebhook webhook)
				{
					// return false if you don't want the webhook to execute
					return true;
				}

				public override void Webhook (MSWebhook webhook, NSUrlResponse response, NSError error)
				{
					if (error!=null) {
						Console.WriteLine ("Webhook execution failed with error "+error.Description);
					} else {
						Console.WriteLine ("Webhook executed successfully");
					}
				}
			}


		}

		// Transitions to a new viewController with a webpage with given URL
		public void openWebViewController(NSUrl url)
		{	
			
			var webVC = new webViewController (url);
			this.NavController.PushViewController (webVC, true);
		}

		public static  void cardView (MSCard card)
		{
			System.Diagnostics.Debug.Write("Result:- + "+  card);

			var cardVC = new CardViewConroller (card);
			UIApplication.SharedApplication.KeyWindow.AddSubview (cardVC.View);

		}



	}
}

