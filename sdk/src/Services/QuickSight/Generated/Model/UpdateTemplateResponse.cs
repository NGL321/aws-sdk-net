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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the UpdateTemplate operation.
    /// </summary>
    public partial class UpdateTemplateResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private ResourceStatus _creationStatus;
        private string _requestId;
        private int? _status;
        private string _templateId;
        private string _versionArn;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the template.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationStatus. 
        /// <para>
        /// The creation status of the template.
        /// </para>
        /// </summary>
        public ResourceStatus CreationStatus
        {
            get { return this._creationStatus; }
            set { this._creationStatus = value; }
        }

        // Check to see if CreationStatus property is set
        internal bool IsSetCreationStatus()
        {
            return this._creationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The AWS request ID for this operation.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionArn. 
        /// <para>
        /// The ARN for the template, including the version information of the first version.
        /// </para>
        /// </summary>
        public string VersionArn
        {
            get { return this._versionArn; }
            set { this._versionArn = value; }
        }

        // Check to see if VersionArn property is set
        internal bool IsSetVersionArn()
        {
            return this._versionArn != null;
        }

    }
}