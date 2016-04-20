using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using ModernHttpClient;

namespace IEventGenie
{
	public class LoginService : ILoginService
	{
		#region SERVICE
		public async  Task<ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel>> GetAllEventAttendeeDetailByConfirmationCode(string confirmationCode,string lastName)
		{

			try   
			{																		
				Dictionary <string,string> param = new Dictionary<string, string>();
				param[AppConstant.CONFIRMATION_CODE_FOR_LOGIN] = confirmationCode;
				param[AppConstant.LAST_NAME_FOR_LOGIN] = lastName;

				//	HttpMessageHandler m = new HttpMessageHandler();
				HttpClient client = new HttpClient(new NativeMessageHandler());
				client.DefaultRequestHeaders.Add("Accept","application/json");

				String url = WebServiceHelper.GetWebServiceURL(AppConstant.GET_ALL_EVENT_ATTENDEE_DETAIL_BY_CONFIRMATION_CODE,param);
				System.Diagnostics.Debug.WriteLine("URL : "+ url);

				var response = await client.GetAsync(url);

				string res = response.Content.ReadAsStringAsync().Result;

				System.Diagnostics.Debug.WriteLine ("Login response : "+res);

				Dictionary <string,object> dict = JsonConvert.DeserializeObject<Dictionary<string,object>> (res);
				GetAllEventAttendeeDetailByConfirmationCodeModel modal = DataParser.ParseGetAllEventAttendeeDetailByConfirmationCode ("data",dict);
				ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel> userReadResponse = new ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel>();
				if(dict != null)
				{
					userReadResponse.Content=  modal;

					return userReadResponse as ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel>;
				}
				else
				{
					return userReadResponse as ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel>;
				}

			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine (ex.StackTrace);
				ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel> responsemodal = new ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel>();
				responsemodal.Success= ResponseStatus.Fail;

				return responsemodal ;
			}

		}
		#endregion
	}
}

