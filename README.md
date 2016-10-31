# SkyWay-Android-SDK-forXamarin.Android
これは NTT Communications が提供している [SkyWay-Android-SDK](https://github.com/nttcom/SkyWay-Android-SDK) の
Xamarin.Android向けのラッパーライブラリです．

詳しくはラップ元のドキュメントをご覧ください．

C# と Java では命名規則が違うため，ベースのサンプルをコピペするだけでは動作しません．適宜読み替えてご利用ください．

一部インターフェースを実装し，CallbackにActionを渡せるようになっています．

例
```C#
PeerOption options;
options = new PeerOption();
options.Key = "<YOUR-API-KEY>";
options.Domain = "<YOUR-REGISTERED-DOMAIN>";

Peer peer = new Peer(/* Android.Context */this, options);

// It will be called when connection with server established
peer.On(Peer.PeerEventEnum.Open, new OnCallbackDelegate(obj =>
{
  if (obj is Java.Lang.String)
  {
    System.Diagnostics.Debug.WriteLine(obj);
  }
}));
```

Libraryディレクトリにビルド済みの物が同梱されているので，ビルドが面倒な方はこちらを利用すると便利です．
