using System;
using System.Collections.Generic;

namespace IEventGenie
{
	static public class WebServiceHelper
	{

		public static string GetWebServiceURL(string webServiceName, Dictionary<string,string> requestParameters = null)
		{
			if ( webServiceName == null)
				return null;

			string url = String.Format (AppConstant.BASE_URL + "/" + webServiceName);

			if (requestParameters == null)
				return url;

			string requestString = String.Empty;

			//			int index = requestParameters.Count;

			string and = "";

			foreach(KeyValuePair<string, string> kvp in requestParameters)
			{
				if (kvp.Value == null)
					continue;

				requestString += String.Format (and +"{0}={1}", kvp.Key, kvp.Value);

				if(and.Equals(""))
					and = "&";
			}

			if(requestString.Length > 0){
				url += "?" + requestString;
			}

			return url;
		}
	}
}