using System;

namespace ComicBook
{
	public static class ServerInfo
	{
		public static Uri AuthorizationEndpoint = new Uri("URL AuthorizationEndpoint");
		public static Uri TokenEndpoint         = new Uri("URL TokenEndpoint");
		public static Uri ApiEndpoint           = new Uri("URL ApiEndpoint");
		public static Uri RedirectionEndpoint 		= new Uri("URL RedirectionEndpoint");
		public static string ClientId 				= "ClientId";
		public static string ClientSecret 			= "ClientSecret";
	}
}