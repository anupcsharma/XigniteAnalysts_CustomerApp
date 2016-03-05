using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using XigniteAnalysts.Api.Config;
using XigniteAnalysts.Api.Exceptions;
using XigniteAnalysts.Api.Requests;
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
				ProcessRequest<TRequest>(request);
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

		private static void GetResponseCallBack(IAsyncResult ar)
		{
			throw new NotImplementedException();
		}

		private static void ProcessResponse(IResponseDetail response)
		{
			if ((response.Outcome == OutcomeTypes.Success)) return;
			var methodName = new StackTrace(2, false).GetFrame(0).GetMethod().Name;
			throw new ApiException(methodName, response.Message, response.Delay);
		}


		private static void ProcessRequest<TRequest>(TRequest request)
		{
			var validRequest = request as IValidRequest;
			if (validRequest != null)
			{
				EnsureTokenExists(validRequest);
			}
		}

		private static void EnsureTokenExists(IValidRequest request)
		{
			if (request != null)
			{
				request.ApiToken = ApiSettings.Instance.ApiToken;
			}
		}
		
	}
}
