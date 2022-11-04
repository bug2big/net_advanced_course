namespace CartingService.API.Controllers.Routing;

internal static class Routes
{
    internal static class CartController
    {
        internal const string Endpoint = "cart";

        internal static class Action
        {
            internal const string GetDevicesByCompanyId = "company";
            internal const string PatchDeviceAvAsync = "{deviceId:required}/antivirus";
            internal const string PostScanResultByDeviceIdAsync = "scan-result";
            internal const string GetDevicesAsync = "get";
            internal const string UpdateDeviceInfoAsync = "";
        }
    }
}

