// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> A piece of evidence from a clinical note (text document). </summary>
    public partial class ClinicalNoteEvidence
    {
        /// <summary> Initializes a new instance of ClinicalNoteEvidence. </summary>
        /// <param name="id"> The identifier of the document containing the evidence. </param>
        /// <param name="offset"> The start index of the evidence text span in the document (0 based). </param>
        /// <param name="length"> The length of the evidence text span. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal ClinicalNoteEvidence(string id, int offset, int length)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Offset = offset;
            Length = length;
        }

        /// <summary> Initializes a new instance of ClinicalNoteEvidence. </summary>
        /// <param name="id"> The identifier of the document containing the evidence. </param>
        /// <param name="text"> The actual text span which is evidence for the inference. </param>
        /// <param name="offset"> The start index of the evidence text span in the document (0 based). </param>
        /// <param name="length"> The length of the evidence text span. </param>
        internal ClinicalNoteEvidence(string id, string text, int offset, int length)
        {
            Id = id;
            Text = text;
            Offset = offset;
            Length = length;
        }

        /// <summary> The identifier of the document containing the evidence. </summary>
        public string Id { get; }
        /// <summary> The actual text span which is evidence for the inference. </summary>
        public string Text { get; }
        /// <summary> The start index of the evidence text span in the document (0 based). </summary>
        public int Offset { get; }
        /// <summary> The length of the evidence text span. </summary>
        public int Length { get; }
    }
}
