namespace BridgePattern.Sync;

public interface IDestinationConfig : IAuthenticationConfig
{
    string ApiEndpoint { get; set; }
}

public interface IAuthenticationConfig
{
    string clientid { get; set; }
    string clientsecret { get; set; }
}