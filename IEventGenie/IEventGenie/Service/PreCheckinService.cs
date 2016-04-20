using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using ModernHttpClient;

namespace IEventGenie
{
	public class PreCheckinService : IPreCheckinService
	{
		#region SERVICE
		public async  Task<ResponseModel<PreCheckinModel>> GetPreCheckinStatus(string eventId,string attendeeId)
		{

			try   
			{																		
				Dictionary <string,string> param = new Dictionary<string, string>();
				param[AppConstant.PRECHECKIN_EVENT_ID] = eventId;
				param[AppConstant.ATTENDEE_ID] = attendeeId;

				//	HttpMessageHandler m = new HttpMessageHandler();
				HttpClient client = new HttpClient(new NativeMessageHandler());
				client.DefaultRequestHeaders.Add("Accept","application/json");

				String url = WebServiceHelper.GetWebServiceURL(AppConstant.SUBMIT_PRECHECKIN,param);
				System.Diagnostics.Debug.WriteLine("URL : "+ url);

				var response = await client.GetAsync(url);

				string res = response.Content.ReadAsStringAsync().Result;

				System.Diagnostics.Debug.WriteLine ("Pre-Chekin response : "+res);

				Dictionary <string,object> dict = JsonConvert.DeserializeObject<Dictionary<string,object>> (res);
				ResponseModel<PreCheckinModel> userReadResponse = new ResponseModel<PreCheckinModel>();
				if(dict != null)
				{
					return userReadResponse as ResponseModel<PreCheckinModel>;
				}
				else
				{
					return userReadResponse as ResponseModel<PreCheckinModel>;
				}

			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine (ex.StackTrace);
				ResponseModel<PreCheckinModel> responsemodal = new ResponseModel<PreCheckinModel>();
				responsemodal.Success= ResponseStatus.Fail;

				return responsemodal ;
			}

		}
		#endregion
	}
}

