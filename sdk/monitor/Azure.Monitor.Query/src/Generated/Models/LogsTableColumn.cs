// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> A column in a table. </summary>
    public partial class LogsTableColumn
    {
        /// <summary> Initializes a new instance of LogsTableColumn. </summary>
        /// <param name="name"> The name of this column. </param>
        /// <param name="type"> The data type of this column. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal LogsTableColumn(string name, LogsColumnType type)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Type = type;
        }

        /// <summary> The name of this column. </summary>
        public string Name { get; }
        /// <summary> The data type of this column. </summary>
        public LogsColumnType Type { get; }
    }
}
