using System;
using System.Threading.Tasks;
using IEventGenie;

namespace IEventGenie
{
	public interface ICheckOutWithConfirmationService
	{
		Task<ResponseModel<CheckInWithConfirmationCodeModel>> GetCheckOutWithConfirmationCodeStatus(string confirmationNumber,string eventId,string attendeeId);
	}
}

