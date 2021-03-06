// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sublist of items for a list entity.
    /// </summary>
    public partial class SubClosedListResponse : SubClosedList
    {
        /// <summary>
        /// Initializes a new instance of the SubClosedListResponse class.
        /// </summary>
        public SubClosedListResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubClosedListResponse class.
        /// </summary>
        /// <param name="canonicalForm">The standard form that the list
        /// represents.</param>
        /// <param name="list">List of synonym words.</param>
        /// <param name="id">The sublist ID</param>
        public SubClosedListResponse(string canonicalForm = default(string), IList<string> list = default(IList<string>), int id = default(int))
            : base(canonicalForm, list)
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sublist ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

    }
}
