//---------------------------------------------------------------------------------
// Microsoft (R)  Windows Azure SDK
// Software Development Kit
// 
// Copyright (c) Microsoft Corporation. All rights reserved.  
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//---------------------------------------------------------------------------------

namespace Microsoft.ServiceBus.Samples
{
    using System;
    using System.ServiceModel;

    [ServiceContract(Name = "IOnewayContract", Namespace = "http://samples.microsoft.com/ServiceModel/Relay/")]
    public interface IOnewayContract
    {
        [OperationContract(IsOneWay = true)]
        void Send(int count);
    }

    public interface IOnewayChannel : IOnewayContract, IClientChannel { }
}
