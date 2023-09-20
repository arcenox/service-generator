using Grpc.Net.Client;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.MessageBroker.ChannelConfig.Client
{
    public interface IClient
    {
        GrpcChannel CoreChannel { get; }
    }
}
