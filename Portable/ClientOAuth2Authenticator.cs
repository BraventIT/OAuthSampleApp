using System;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace ComicBookPCL
{
    public class ClientOAuth2Authenticator : OAuth2Authenticator
    {
        public ClientOAuth2Authenticator(string clientId, string clientSecret, string scope, Uri authorizeUrl, Uri redirectUrl, Uri accessTokenUrl, GetUsernameAsyncFunc getUsernameAsync = null, bool isUsingNativeUI = false) : base(clientId, clientSecret, scope, authorizeUrl, redirectUrl, accessTokenUrl, getUsernameAsync, isUsingNativeUI)
        {
        }

        protected override void OnCreatingInitialUrl(System.Collections.Generic.IDictionary<string, string> query)
        {
            base.OnCreatingInitialUrl(query);

   //         query["response_type"] = "code+id_token";
   //         //query["response_type"] = "code";
			//query["nonce"] = Guid.NewGuid().ToString("N");
            //query["scope"] = "openid";
            //query["response_mode"] = "query";

        }

        public override void OnPageLoaded(Uri url)
        {
            base.OnPageLoaded(url);
        }

        protected override void OnRedirectPageLoaded(Uri url, System.Collections.Generic.IDictionary<string, string> query, System.Collections.Generic.IDictionary<string, string> fragment)
        {
            base.OnRedirectPageLoaded(url, query, fragment);
        }
	}
}
