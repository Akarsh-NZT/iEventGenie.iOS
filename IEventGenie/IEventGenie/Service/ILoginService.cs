using System;
using System.Threading.Tasks;

namespace IEventGenie
{
	public interface ILoginService
	{
		Task<ResponseModel<GetAllEventAttendeeDetailByConfirmationCodeModel>> GetAllEventAttendeeDetailByConfirmationCode(string confirmationCode,string lastName);
	}
}

