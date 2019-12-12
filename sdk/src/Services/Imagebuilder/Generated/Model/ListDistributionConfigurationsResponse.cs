/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the ListDistributionConfigurations operation.
    /// </summary>
    public partial class ListDistributionConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<DistributionConfigurationSummary> _distributionConfigurationSummaryList = new List<DistributionConfigurationSummary>();
        private string _nextToken;
        private string _requestId;

        /// <summary>
        /// Gets and sets the property DistributionConfigurationSummaryList. 
        /// <para>
        ///  The list of distributions. 
        /// </para>
        /// </summary>
        public List<DistributionConfigurationSummary> DistributionConfigurationSummaryList
        {
            get { return this._distributionConfigurationSummaryList; }
            set { this._distributionConfigurationSummaryList = value; }
        }

        // Check to see if DistributionConfigurationSummaryList property is set
        internal bool IsSetDistributionConfigurationSummaryList()
        {
            return this._distributionConfigurationSummaryList != null && this._distributionConfigurationSummaryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The next token used for paginated responses. When this is not empty then there are
        /// additional elements that the service that not include in this request. Use this token
        /// with the next request to retrieve additional object. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        ///  The request ID that uniquely identifies this request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

    }
}