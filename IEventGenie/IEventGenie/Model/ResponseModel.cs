using System;

namespace IEventGenie
{
	public class ResponseModel<T> : BaseModel
	{
		public string ResponseCode{ get; set;}
		public T Content { get; set; }
		//For parsing total entries of Journalists on server :  USED IN JOURNALIST LIST SCREEN 
		public string TotalCount{ get; set;}
	}
}

