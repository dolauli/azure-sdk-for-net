// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DevTestLabResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DevTestLabResources and their operations over a DevTestLabResource. </returns>
        public virtual DevTestLabCollection GetDevTestLabs()
        {
            return GetCachedClient(Client => new DevTestLabCollection(Client, Id));
        }

        /// <summary> Gets a collection of DevTestLabGlobalScheduleResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DevTestLabGlobalScheduleResources and their operations over a DevTestLabGlobalScheduleResource. </returns>
        public virtual DevTestLabGlobalScheduleCollection GetDevTestLabGlobalSchedules()
        {
            return GetCachedClient(Client => new DevTestLabGlobalScheduleCollection(Client, Id));
        }
    }
}
