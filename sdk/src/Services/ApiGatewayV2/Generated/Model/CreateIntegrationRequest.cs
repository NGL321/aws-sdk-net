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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntegration operation.
    /// Creates an Integration.
    /// </summary>
    public partial class CreateIntegrationRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private string _connectionId;
        private ConnectionType _connectionType;
        private ContentHandlingStrategy _contentHandlingStrategy;
        private string _credentialsArn;
        private string _description;
        private string _integrationMethod;
        private IntegrationType _integrationType;
        private string _integrationUri;
        private PassthroughBehavior _passthroughBehavior;
        private string _payloadFormatVersion;
        private Dictionary<string, string> _requestParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _requestTemplates = new Dictionary<string, string>();
        private string _templateSelectionExpression;
        private int? _timeoutInMillis;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The connection ID.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the network connection to the integration endpoint. Currently the only
        /// valid value is INTERNET, for connections through the public routable internet.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property ContentHandlingStrategy. 
        /// <para>
        /// Supported only for WebSocket APIs. Specifies how to handle response payload content
        /// type conversions. Supported values are CONVERT_TO_BINARY and CONVERT_TO_TEXT, with
        /// the following behaviors:
        /// </para>
        ///  
        /// <para>
        /// CONVERT_TO_BINARY: Converts a response payload from a Base64-encoded string to the
        /// corresponding binary blob.
        /// </para>
        ///  
        /// <para>
        /// CONVERT_TO_TEXT: Converts a response payload from a binary blob to a Base64-encoded
        /// string.
        /// </para>
        ///  
        /// <para>
        /// If this property is not defined, the response payload will be passed through from
        /// the integration response to the route response or method response without modification.
        /// </para>
        /// </summary>
        public ContentHandlingStrategy ContentHandlingStrategy
        {
            get { return this._contentHandlingStrategy; }
            set { this._contentHandlingStrategy = value; }
        }

        // Check to see if ContentHandlingStrategy property is set
        internal bool IsSetContentHandlingStrategy()
        {
            return this._contentHandlingStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsArn. 
        /// <para>
        /// Specifies the credentials required for the integration, if any. For AWS integrations,
        /// three options are available. To specify an IAM Role for API Gateway to assume, use
        /// the role's Amazon Resource Name (ARN). To require that the caller's identity be passed
        /// through from the request, specify the string arn:aws:iam::*:user/*. To use resource-based
        /// permissions on supported AWS services, specify null.
        /// </para>
        /// </summary>
        public string CredentialsArn
        {
            get { return this._credentialsArn; }
            set { this._credentialsArn = value; }
        }

        // Check to see if CredentialsArn property is set
        internal bool IsSetCredentialsArn()
        {
            return this._credentialsArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the integration.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationMethod. 
        /// <para>
        /// Specifies the integration's HTTP method type.
        /// </para>
        /// </summary>
        public string IntegrationMethod
        {
            get { return this._integrationMethod; }
            set { this._integrationMethod = value; }
        }

        // Check to see if IntegrationMethod property is set
        internal bool IsSetIntegrationMethod()
        {
            return this._integrationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The integration type of an integration. One of the following:
        /// </para>
        ///  
        /// <para>
        /// AWS: for integrating the route or method request with an AWS service action, including
        /// the Lambda function-invoking action. With the Lambda function-invoking action, this
        /// is referred to as the Lambda custom integration. With any other AWS service action,
        /// this is known as AWS integration. Supported only for WebSocket APIs.
        /// </para>
        ///  
        /// <para>
        /// AWS_PROXY: for integrating the route or method request with the Lambda function-invoking
        /// action with the client request passed through as-is. This integration is also referred
        /// to as Lambda proxy integration.
        /// </para>
        ///  
        /// <para>
        /// HTTP: for integrating the route or method request with an HTTP endpoint. This integration
        /// is also referred to as the HTTP custom integration. Supported only for WebSocket APIs.
        /// </para>
        ///  
        /// <para>
        /// HTTP_PROXY: for integrating route or method request with an HTTP endpoint, with the
        /// client request passed through as-is. This is also referred to as HTTP proxy integration.
        /// </para>
        ///  
        /// <para>
        /// MOCK: for integrating the route or method request with API Gateway as a "loopback"
        /// endpoint without invoking any backend. Supported only for WebSocket APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrationType IntegrationType
        {
            get { return this._integrationType; }
            set { this._integrationType = value; }
        }

        // Check to see if IntegrationType property is set
        internal bool IsSetIntegrationType()
        {
            return this._integrationType != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationUri. 
        /// <para>
        /// For a Lambda proxy integration, this is the URI of the Lambda function.
        /// </para>
        /// </summary>
        public string IntegrationUri
        {
            get { return this._integrationUri; }
            set { this._integrationUri = value; }
        }

        // Check to see if IntegrationUri property is set
        internal bool IsSetIntegrationUri()
        {
            return this._integrationUri != null;
        }

        /// <summary>
        /// Gets and sets the property PassthroughBehavior. 
        /// <para>
        /// Specifies the pass-through behavior for incoming requests based on the Content-Type
        /// header in the request, and the available mapping templates specified as the requestTemplates
        /// property on the Integration resource. There are three valid values: WHEN_NO_MATCH,
        /// WHEN_NO_TEMPLATES, and NEVER. Supported only for WebSocket APIs.
        /// </para>
        ///  
        /// <para>
        /// WHEN_NO_MATCH passes the request body for unmapped content types through to the integration
        /// backend without transformation.
        /// </para>
        ///  
        /// <para>
        /// NEVER rejects unmapped content types with an HTTP 415 Unsupported Media Type response.
        /// </para>
        ///  
        /// <para>
        /// WHEN_NO_TEMPLATES allows pass-through when the integration has no content types mapped
        /// to templates. However, if there is at least one content type defined, unmapped content
        /// types will be rejected with the same HTTP 415 Unsupported Media Type response.
        /// </para>
        /// </summary>
        public PassthroughBehavior PassthroughBehavior
        {
            get { return this._passthroughBehavior; }
            set { this._passthroughBehavior = value; }
        }

        // Check to see if PassthroughBehavior property is set
        internal bool IsSetPassthroughBehavior()
        {
            return this._passthroughBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadFormatVersion. 
        /// <para>
        /// Specifies the format of the payload sent to an integration. Required for HTTP APIs.
        /// Currently, the only supported value is 1.0.
        /// </para>
        /// </summary>
        public string PayloadFormatVersion
        {
            get { return this._payloadFormatVersion; }
            set { this._payloadFormatVersion = value; }
        }

        // Check to see if PayloadFormatVersion property is set
        internal bool IsSetPayloadFormatVersion()
        {
            return this._payloadFormatVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// A key-value map specifying request parameters that are passed from the method request
        /// to the backend. The key is an integration request parameter name and the associated
        /// value is a method request parameter value or static value that must be enclosed within
        /// single quotes and pre-encoded as required by the backend. The method request parameter
        /// value must match the pattern of method.request.<replaceable>{location}</replaceable>.<replaceable>{name}</replaceable>
        ///               , where                   <replaceable>{location}</replaceable>    
        ///            is querystring, path, or header; and                   <replaceable>{name}</replaceable>
        ///                must be a valid and unique method request parameter name. Supported
        /// only for WebSocket APIs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestParameters
        {
            get { return this._requestParameters; }
            set { this._requestParameters = value; }
        }

        // Check to see if RequestParameters property is set
        internal bool IsSetRequestParameters()
        {
            return this._requestParameters != null && this._requestParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestTemplates. 
        /// <para>
        /// Represents a map of Velocity templates that are applied on the request payload based
        /// on the value of the Content-Type header sent by the client. The content type value
        /// is the key in this map, and the template (as a String) is the value. Supported only
        /// for WebSocket APIs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestTemplates
        {
            get { return this._requestTemplates; }
            set { this._requestTemplates = value; }
        }

        // Check to see if RequestTemplates property is set
        internal bool IsSetRequestTemplates()
        {
            return this._requestTemplates != null && this._requestTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateSelectionExpression. 
        /// <para>
        /// The template selection expression for the integration.
        /// </para>
        /// </summary>
        public string TemplateSelectionExpression
        {
            get { return this._templateSelectionExpression; }
            set { this._templateSelectionExpression = value; }
        }

        // Check to see if TemplateSelectionExpression property is set
        internal bool IsSetTemplateSelectionExpression()
        {
            return this._templateSelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMillis. 
        /// <para>
        /// Custom timeout between 50 and 29,000 milliseconds. The default value is 29,000 milliseconds
        /// or 29 seconds for WebSocket APIs. The default value is 5,000 milliseconds, or 5 seconds
        /// for HTTP APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=29000)]
        public int TimeoutInMillis
        {
            get { return this._timeoutInMillis.GetValueOrDefault(); }
            set { this._timeoutInMillis = value; }
        }

        // Check to see if TimeoutInMillis property is set
        internal bool IsSetTimeoutInMillis()
        {
            return this._timeoutInMillis.HasValue; 
        }

    }
}