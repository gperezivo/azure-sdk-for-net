// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.ResourceManager.Network.Tests
{
    public class NetworkManagementTestEnvironment : TestEnvironment
    {
        public NetworkManagementTestEnvironment() : base("network")
        {
        }
    }
}
