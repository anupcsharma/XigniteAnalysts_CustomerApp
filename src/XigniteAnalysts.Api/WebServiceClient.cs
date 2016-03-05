using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml;
using XigniteAnalysts.Api.Config;
using XigniteAnalysts.Api.XigniteAnalystsServiceReference;

namespace XigniteAnalysts.Api
{
	public static class WebServiceClient
	{
		public static XigniteAnalystsSoapClient CreateXigniteAnalystsServiceInstance()
		{
			var client = new XigniteAnalystsSoapClient();
			client.Endpoint.Address = new EndpointAddress(ApiSettings.Instance.XigniteAnalystsServiceUrl);
			var httpBinding = (BasicHttpBinding) client.Endpoint.Binding;
			if (client.Endpoint.Address.Uri.Scheme.ToUpper() == "HTTPS")
			{
				httpBinding.Security.Mode = BasicHttpSecurityMode.Transport;
			}

			//for handling large calls
			httpBinding.MaxReceivedMessageSize = 4194304;
			httpBinding.MaxBufferSize = 4194304;

			return client;
		}

		public static Response Unwrap(this FaultException exception)
		{
			var fault = exception.CreateMessageFault();
			if (fault.HasDetail)
			{
				return fault.GetDetail<Response>(new WrappedSerializer<Response>());
			}
			return null;
		}
	

		/// <summary>
		/// Because API always returns Response class, but sometimes it return class inherited from Response - we don't verify for object name
		/// </summary>
		private class WrappedSerializer<T> : XmlObjectSerializer
			where T : class
		{
			private readonly DataContractSerializer _serializer = new DataContractSerializer(typeof(T));

			public override void WriteStartObject(XmlDictionaryWriter writer, object graph)
			{
				throw new System.NotImplementedException();
			}

			public override void WriteObjectContent(XmlDictionaryWriter writer, object graph)
			{
				throw new System.NotImplementedException();
			}

			public override void WriteEndObject(XmlDictionaryWriter writer)
			{
				throw new System.NotImplementedException();
			}

			public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName)
			{
				return _serializer.ReadObject(reader, false) as T;
			}

			public override bool IsStartObject(XmlDictionaryReader reader)
			{
				return _serializer.IsStartObject(reader);
			}
		}

	}
}
