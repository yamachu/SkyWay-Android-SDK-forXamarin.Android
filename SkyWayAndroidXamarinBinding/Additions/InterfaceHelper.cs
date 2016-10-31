using System;
namespace IO.Skyway.Peer
{
	/// <summary>
	/// This class is wrapper for IO.Skyway.Peer.IOnCallback
	/// </summary>
	public class OnCallbackDelegate : Java.Lang.Object, IO.Skyway.Peer.IOnCallback
	{
		private Action<Java.Lang.Object> _callback;

		/// <summary>
		/// Using this helper class, you can call lambda function.
		/// </summary>
		/// <example>
		/// This sample shows when connection with server established,
		/// show own PeerID on debug console.
		/// <code>
		/// peer.On(Peer.PeerEventEnum.OPEN, new OnCallbackDelegate(arg => 
		/// {
		/// 	if (arg is Java.Lang.String) {
		/// 		System.Diagnostics.Debug.WriteLine(arg);
		/// 	}
		/// }));
		/// </code>
		/// </example>
		public OnCallbackDelegate(Action<Java.Lang.Object> callback) 
		{
			_callback = callback;
		}

		/// <summary>
		/// Do not override or implement.
		/// If you want to override this method, use original IO.Skyway.Peer.IOnCallback
		/// </summary>
		public void OnCallback(Java.Lang.Object arg) 
		{
			_callback(arg);
		}
	}
}
