using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using ModernHttpClient;
using Newtonsoft.Json;

namespace IEventGenie
{
	public class CheckInWithConfirmationService : ICheckInWithConfirmationService
	{
		#region SERVICE
		public async  Task<ResponseModel<CheckInWithConfirmationCodeModel>> GetCheckInWithConfirmationCodeStatus(string confirmationNumber,string eventId,string attendeeId)
		{

			try   
			{																		
				Dictionary <string,string> param = new Dictionary<string, string>();
				param[AppConstant.CONFIRMATION_NUMBER] = confirmationNumber;
				param[AppConstant.PRECHECKIN_EVENT_ID] = eventId;
				param[AppConstant.ATTENDEE_ID] = attendeeId;

				//	HttpMessageHandler m = new HttpMessageHandler();
				HttpClient client = new HttpClient(new NativeMessageHandler());
				client.DefaultRequestHeaders.Add("Accept","application/json");

				String url = WebServiceHelper.GetWebServiceURL(AppConstant.CHECK_IN_WITH_CONFIRMATION_CODE,param);
				System.Diagnostics.Debug.WriteLine("URL : "+ url);

				var response = await client.GetAsync(url);

				string res = response.Content.ReadAsStringAsync().Result;

				System.Diagnostics.Debug.WriteLine ("ChekinWithConfirmation Code response : "+res);

				Dictionary <string,object> dict = JsonConvert.DeserializeObject<Dictionary<string,object>> (res);

				CheckInWithConfirmationCodeModel modal =  DataParser.GetCheckInDetails (dict);
				ResponseModel<CheckInWithConfirmationCodeModel> userReadResponse = new ResponseModel<CheckInWithConfirmationCodeModel>();
				if(dict != null)
				{
					userReadResponse.Content = modal;
					return userReadResponse as ResponseModel<CheckInWithConfirmationCodeModel>;
				}
				else
				{
					userReadResponse.Content = modal;
					return userReadResponse as ResponseModel<CheckInWithConfirmationCodeModel>;
				}

			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine (ex.StackTrace);
				ResponseModel<CheckInWithConfirmationCodeModel> responsemodal = new ResponseModel<CheckInWithConfirmationCodeModel>();
				responsemodal.Success= ResponseStatus.Fail;

				return responsemodal ;
			}

		}
		#endregion
	}
}

