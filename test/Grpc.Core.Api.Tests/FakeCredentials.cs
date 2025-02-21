#region Copyright notice and license

// Copyright 2015 gRPC authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using Grpc.Core.Internal;

namespace Grpc.Core.Tests;

internal class FakeChannelCredentials : ChannelCredentials
{
    readonly bool composable;

    public FakeChannelCredentials(bool composable)
    {
        this.composable = composable;
    }

    internal override bool IsComposable
    {
        get { return composable; }
    }

    public override void InternalPopulateConfiguration(ChannelCredentialsConfiguratorBase configurator, object state)
    {
        // not invoking configuration on purpose
    }
}

internal class FakeCallCredentials : CallCredentials
{
    public override void InternalPopulateConfiguration(CallCredentialsConfiguratorBase configurator, object state)
    {
        // not invoking the configurator on purpose
    }
}
