// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The B2B partner content. </summary>
    internal partial class B2BPartnerContent
    {
        /// <summary> Initializes a new instance of B2BPartnerContent. </summary>
        public B2BPartnerContent()
        {
            BusinessIdentities = new ChangeTrackingList<IntegrationAccountBusinessIdentity>();
        }

        /// <summary> Initializes a new instance of B2BPartnerContent. </summary>
        /// <param name="businessIdentities"> The list of partner business identities. </param>
        internal B2BPartnerContent(IList<IntegrationAccountBusinessIdentity> businessIdentities)
        {
            BusinessIdentities = businessIdentities;
        }

        /// <summary> The list of partner business identities. </summary>
        public IList<IntegrationAccountBusinessIdentity> BusinessIdentities { get; }
    }
}
