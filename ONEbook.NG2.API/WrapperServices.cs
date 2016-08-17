using System;
using ONEbook.NG2.API.Log;

namespace ONEbook.NG2.API
{
    internal static class WrapperServices<T> where T : MarshalByRefObject
    {
        public static T Wrap()
        {
            var proxy = new ProxyServices<T>();
            return (T)proxy.GetTransparentProxy();
        }
    }
}