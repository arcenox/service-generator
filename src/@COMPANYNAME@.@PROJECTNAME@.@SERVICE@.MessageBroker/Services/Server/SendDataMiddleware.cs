using _COMPANYNAME_._PROJECTNAME_._SERVICE_.MessageBroker.Protos.Server;
using Grpc.Core;
using GrpcToolkit.Attributes;
using GrpcToolkit.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.MessageBroker.Services.Server
{
    [GrpcServer]
    public class SendDataMiddleware : SendTestService.SendTestServiceBase
    {
        private readonly IServerTool<SendDataResponse> _serverTool;

        public SendDataMiddleware(IServerTool<SendDataResponse> serverTool)
        {
            _serverTool = serverTool ?? throw new ArgumentNullException(nameof(serverTool));
        }

        public override async Task<SendDataResponse> SendTest(SendDataRequest request, ServerCallContext context)
        {
            var cities = new List<object>();

            return await _serverTool.SetResult(cities);
        }
    }
}
