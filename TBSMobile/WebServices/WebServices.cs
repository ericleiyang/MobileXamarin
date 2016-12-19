using System;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TBSMobile.Services
{
	public class WebServices
	{
		private static volatile WebServices instance;
		private static object syncRoot = new Object();

		private WebServices() { }

		private string baseURL { get; set; }

		public static WebServices Instance
		{
			get
			{
				if (instance == null)
				{
					lock (syncRoot)
					{
						if (instance == null)
							instance = new WebServices();
					}
				}

				return instance;
			}
		}

		private HttpClient getRequestClient()
		{
			var client = new HttpClient();

			client.BaseAddress = new Uri(baseURL);

			return client;
		}


		public async Task<dynamic> getRequestAsync(string url)
		{

			var response = await WebServices.instance.getRequestClient().GetAsync(url);

			var json = response.Content.ReadAsStringAsync().Result;

			var dynamicObject = JsonConvert.DeserializeObject<dynamic>(json);

			return dynamicObject;
		}
	}
}
