using System;
using System.Diagnostics;
using System.ServiceModel;
using XigniteAnalysts.Api.Exceptions;
using XigniteAnalysts.Api.Responses;
using XigniteAnalysts.Api.XigniteAnalystsServiceReference;

namespace XigniteAnalysts.Api
{
	public class XigniteApiClient
	{
		
		public static TResponse GetResponse<TResponse, TRequest>(TRequest request, 
				Func<XigniteAnalystsSoapClient, TResponse> handler,
				string apiMethodName = "")
		where TResponse : class
		{
			Debug.WriteLine("Calling: " + typeof(TRequest).Name);
			if (string.IsNullOrEmpty(apiMethodName))
			{
				apiMethodName = typeof(TRequest).Name.Replace("Request", string.Empty);
			}
			
			var client = WebServiceClient.CreateXigniteAnalystsServiceInstance();
			TResponse response = null;
			try
			{
				response = handler(client);
				
				var responseDetail = response as IResponseDetail;
				if (responseDetail != null)
				{
					ProcessResponse(responseDetail);
				}
				
			}
			catch (FaultException exception)
			{
				var methodName = new StackTrace(1, false).GetFrame(0).GetMethod().Name;
				var error = exception.Unwrap();
				if (error != null)
				{
					throw new ApiException(methodName, error.Message);
				}

				throw new ApiException(string.Format("Api error on {0}.", methodName), exception);
			}
			//finally
			//{
			//	client.Close();
			//}

			return response;
		}

		
		private static void ProcessResponse(IResponseDetail response)
		{
			if ((response.Outcome == OutcomeTypes.Success)) return;
			var methodName = new StackTrace(2, false).GetFrame(0).GetMethod().Name;
			throw new ApiException(methodName, response.Message, response.Delay);
		}
	}
}
