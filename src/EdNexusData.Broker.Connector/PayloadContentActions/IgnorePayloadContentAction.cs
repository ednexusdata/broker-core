
namespace EdNexusData.Broker.Connector.PayloadContentActions;

public class IgnorePayloadContentAction : IPayloadContentAction
{
    public static string DisplayName { get; } = "Ignore";
    
    public Task<bool> ExecuteAsync()
    {
        return Task.Run(() => {
            return true;
        });
    }
}