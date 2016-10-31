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

	public static class PeerOnEventExtension
	{
		public static void OnOpen(this IO.Skyway.Peer.Peer peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Open, null);
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Open, new OnCallbackDelegate(callback));
		}

		public static void OnConnection(this IO.Skyway.Peer.Peer peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Connection, null);
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Connection, new OnCallbackDelegate(callback));
		}

		public static void OnCall(this IO.Skyway.Peer.Peer peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Call, null);
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Call, new OnCallbackDelegate(callback));
		}

		public static void OnClose(this IO.Skyway.Peer.Peer peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Close, null);
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Close, new OnCallbackDelegate(callback));
		}

		public static void OnDisconnected(this IO.Skyway.Peer.Peer peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Disconnected, null);
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Disconnected, new OnCallbackDelegate(callback));
		}

		public static void OnError(this IO.Skyway.Peer.Peer peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Error, null);
			peer.On(IO.Skyway.Peer.Peer.PeerEventEnum.Error, new OnCallbackDelegate(callback));
		}
	}

	public static class DataConnectionOnEventExtension
	{
		public static void OnData(this IO.Skyway.Peer.DataConnection peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.DataConnection.DataEventEnum.Data, null);
			peer.On(IO.Skyway.Peer.DataConnection.DataEventEnum.Data, new OnCallbackDelegate(callback));
		}

		public static void OnOpen(this IO.Skyway.Peer.DataConnection peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.DataConnection.DataEventEnum.Open, null);
			peer.On(IO.Skyway.Peer.DataConnection.DataEventEnum.Open, new OnCallbackDelegate(callback));
		}

		public static void OnClose(this IO.Skyway.Peer.DataConnection peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.DataConnection.DataEventEnum.Close, null);
			peer.On(IO.Skyway.Peer.DataConnection.DataEventEnum.Close, new OnCallbackDelegate(callback));
		}

		public static void OnError(this IO.Skyway.Peer.DataConnection peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.DataConnection.DataEventEnum.Error, null);
			peer.On(IO.Skyway.Peer.DataConnection.DataEventEnum.Error, new OnCallbackDelegate(callback));
		}
	}

	public static class MediaConnectionOnEventExtension
	{
		public static void OnStream(this IO.Skyway.Peer.MediaConnection peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.MediaConnection.MediaEventEnum.Stream, null);
			peer.On(IO.Skyway.Peer.MediaConnection.MediaEventEnum.Stream, new OnCallbackDelegate(callback));
		}

		public static void OnClose(this IO.Skyway.Peer.MediaConnection peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.MediaConnection.MediaEventEnum.Close, null);
			peer.On(IO.Skyway.Peer.MediaConnection.MediaEventEnum.Close, new OnCallbackDelegate(callback));
		}

		public static void OnError(this IO.Skyway.Peer.MediaConnection peer, Action<Java.Lang.Object> callback)
		{
			peer.On(IO.Skyway.Peer.MediaConnection.MediaEventEnum.Error, null);
			peer.On(IO.Skyway.Peer.MediaConnection.MediaEventEnum.Error, new OnCallbackDelegate(callback));
		}
	}
}
