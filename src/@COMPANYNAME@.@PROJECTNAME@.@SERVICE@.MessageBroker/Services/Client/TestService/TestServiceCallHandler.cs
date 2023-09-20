﻿using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Interfaces;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.MessageBroker.ChannelConfig.Client;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.MessageBroker.Protos.Client.TestService;
using GrpcToolkit.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.MessageBroker.Services.Client.TestService
{
    public class TestServiceCallHandler : ITestServiceBrokerContext
    {
        private readonly IClientTool _clientTool;
        private readonly IClient _clientChannel;
        public TestServiceCallHandler(IClientTool clientTool, IClient clientChannel)
        {
            _clientTool = clientTool ?? throw new ArgumentNullException(nameof(clientTool));
            _clientChannel = clientChannel ?? throw new ArgumentNullException(nameof(clientChannel));
        }

        public async Task<IList<object>> GetData()
        {
            using var channel = _clientChannel.CoreChannel;

            var result = await new GetTestService.GetTestServiceClient(channel).GetTestAsync(new GetDataRequest { });

            return await _clientTool.Response<IList<object>>(result.Value, false);
        }
    }
}
