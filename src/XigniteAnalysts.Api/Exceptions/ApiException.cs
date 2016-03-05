using System;
using System.Runtime.Serialization;

namespace XigniteAnalysts.Api.Exceptions
{
	public class ApiException : ApplicationException
	{
		public ApiException()
		{
		}

		public ApiException(string message)
			: base(message)
		{
		}

		public ApiException(string methodName, string errorMessage)
			: this(methodName, errorMessage, 0)
		{
		}

		public ApiException(string methodName, string errorMessage, double delay)
			: this(string.Format("Api error on {0}. Error: '{1}'", methodName, errorMessage))
		{
			MethodName = methodName;
			ErrorMessage = errorMessage;
			Delay = delay;
		}

		public ApiException(string message, Exception innerException)
			: base (message, innerException)
		{
		}

		protected ApiException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public string MethodName { get; set; }

		public string ErrorMessage { get; set; }

		public double Delay { get; set; }
	}
}
