using System;
using System.Threading.Tasks;
using IEventGenie;

namespace IEventGenie
{
	public interface ICheckInWithConfirmationService
	{
		Task<ResponseModel<CheckInWithConfirmationCodeModel>> GetCheckInWithConfirmationCodeStatus(string confirmationNumber,string eventId,string attendeeId);
	}
}

