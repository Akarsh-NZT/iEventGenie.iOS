using System;
using System.Threading.Tasks;
using IEventGenie;

namespace IEventGenie
{
	public interface IPreCheckinService
	{
		Task<ResponseModel<PreCheckinModel>> GetPreCheckinStatus(string eventId,string attendeeId);
	}
}

