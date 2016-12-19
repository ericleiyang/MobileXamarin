using System;
using System.Threading.Tasks;
using TBSMobile.Models;
using TBSMobile.Services;

namespace TBSMobile.Services
{
	public class UserAccountWebServices
	{
		public async Task<string> login(UserAccount user)
		{
			var url = "/AccountServices/Login?Username=" + user.Username + "&Password=" + user.Password;
			var response = await WebServices.Instance.getRequestAsync(url);

			return await response;
		}

	}
}
