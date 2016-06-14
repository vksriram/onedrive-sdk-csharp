// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System.Collections.Generic;
    
    using Microsoft.Graph;

    /// <summary>
    /// The type ItemContentRequestBuilder.
    /// </summary>
    public partial class ItemContentRequestBuilder : BaseRequestBuilder, IItemContentRequestBuilder
    {
        /// <summary>
        /// Constructs a new ItemContentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ItemContentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IItemContentRequest Request()
        {
            return this.Request(null);
        }
        
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IItemContentRequest Request(IList<Option> options)
        {
            return new ItemContentRequest(this.RequestUrl, this.Client, options);
        }
    }
}
