﻿namespace Sanderling
{
	public class ExeConfig
	{
		public const string ConfigLicenseKeyFree = "Sanderling.Free";
		public const string ConfigServiceId = "Sanderling.16-04-18";
		public const string ConfigApiVersionAddressDefault = @"http://service.botengine.de:4074/api";

		public const string EveOnlineProcessMainModuleFileName = "ExeFile.exe";

		public BotEngine.Client.LicenseClientConfig LicenseClient;

		static public BotEngine.Client.AuthRequest InterfaceLicenseClientRequestDefault => new BotEngine.Client.AuthRequest
		{
			LicenseKey = ConfigLicenseKeyFree,
			ServiceId = ConfigServiceId,
			Consume = true,
		};

		static public BotEngine.Client.LicenseClientConfig LicenseClientDefault => new BotEngine.Client.LicenseClientConfig
		{
			ApiVersionAddress = ConfigApiVersionAddressDefault,
			Request = InterfaceLicenseClientRequestDefault,
		};
	}
}
