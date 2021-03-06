using System.Net.Http;
using System.Threading;

namespace Faithlife.WebRequests
{
	/// <summary>
	/// Information provided to web service response handlers.
	/// </summary>
	public abstract class WebServiceResponseHandlerInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WebServiceResponseHandlerInfo&lt;TResponse&gt;"/> class.
		/// </summary>
		/// <param name="webResponse">The web response.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
		protected WebServiceResponseHandlerInfo(HttpResponseMessage webResponse, CancellationToken cancellationToken)
		{
			WebResponse = webResponse;
			CancellationToken = cancellationToken;
		}

		/// <summary>
		/// Gets the web response.
		/// </summary>
		/// <value>The web response.</value>
		public HttpResponseMessage? WebResponse { get; private set; }

		/// <summary>
		/// True if the content has been read from the web response.
		/// </summary>
		/// <value>True if the content has been read from the web response.</value>
		public bool IsContentRead { get; private set; }

		/// <summary>
		/// Gets the cancellation token.
		/// </summary>
		/// <value>The cancellation token.</value>
		public CancellationToken CancellationToken { get; }

		/// <summary>
		/// Marks the content as having been read from the web response.
		/// </summary>
		public void MarkContentAsRead() => IsContentRead = true;

		/// <summary>
		/// Detaches the web response.
		/// </summary>
		/// <returns>The detached web response.</returns>
		public HttpResponseMessage? DetachWebResponse()
		{
			var webResponse = WebResponse;
			WebResponse = null;
			return webResponse;
		}
	}

	/// <summary>
	/// Information provided to web service response handlers.
	/// </summary>
	public sealed class WebServiceResponseHandlerInfo<TResponse> : WebServiceResponseHandlerInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WebServiceResponseHandlerInfo&lt;TResponse&gt;"/> class.
		/// </summary>
		/// <param name="webResponse">The web response.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
		public WebServiceResponseHandlerInfo(HttpResponseMessage webResponse, CancellationToken cancellationToken)
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
			: base(webResponse, cancellationToken)
		{
		}

		/// <summary>
		/// Gets or sets the response.
		/// </summary>
		/// <value>The response.</value>
		public TResponse Response { get; set; }
	}
}
