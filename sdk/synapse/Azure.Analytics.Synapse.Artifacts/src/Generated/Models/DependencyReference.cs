// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Referenced dependency.
    /// Please note <see cref="DependencyReference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SelfDependencyTumblingWindowTriggerReference"/>, <see cref="TriggerDependencyReference"/> and <see cref="TumblingWindowTriggerDependencyReference"/>.
    /// </summary>
    public partial class DependencyReference
    {
        /// <summary> Initializes a new instance of DependencyReference. </summary>
        public DependencyReference()
        {
        }

        /// <summary> Initializes a new instance of DependencyReference. </summary>
        /// <param name="type"> The type of dependency reference. </param>
        internal DependencyReference(string type)
        {
            Type = type;
        }

        /// <summary> The type of dependency reference. </summary>
        internal string Type { get; set; }
    }
}
