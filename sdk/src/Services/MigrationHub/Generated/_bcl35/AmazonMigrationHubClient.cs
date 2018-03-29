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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.MigrationHub.Model;
using Amazon.MigrationHub.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MigrationHub
{
    /// <summary>
    /// Implementation for accessing MigrationHub
    ///
    /// The AWS Migration Hub API methods help to obtain server and application migration
    /// status and integrate your resource-specific migration tool by providing a programmatic
    /// interface to Migration Hub.
    /// </summary>
    public partial class AmazonMigrationHubClient : AmazonServiceClient, IAmazonMigrationHub
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonMigrationHubClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonMigrationHubClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMigrationHubConfig()) { }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMigrationHubConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonMigrationHubClient Configuration Object</param>
        public AmazonMigrationHubClient(AmazonMigrationHubConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMigrationHubClient(AWSCredentials credentials)
            : this(credentials, new AmazonMigrationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMigrationHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Credentials and an
        /// AmazonMigrationHubClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMigrationHubClient Configuration Object</param>
        public AmazonMigrationHubClient(AWSCredentials credentials, AmazonMigrationHubConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMigrationHubClient Configuration Object</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMigrationHubConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMigrationHubClient Configuration Object</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMigrationHubConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AssociateCreatedArtifact

        /// <summary>
        /// Associates a created artifact of an AWS cloud resource, the target receiving the migration,
        /// with the migration task performed by a migration tool. This API has the following
        /// traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Migration tools can call the <code>AssociateCreatedArtifact</code> operation to indicate
        /// which AWS artifact is associated with a migration task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The created artifact name must be provided in ARN (Amazon Resource Name) format which
        /// will contain information about type and region; for example: <code>arn:aws:ec2:us-east-1:488216288981:image/ami-6d0ba87b</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Examples of the AWS resource behind the created artifact are, AMI's, EC2 instance,
        /// or DMS endpoint, etc.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCreatedArtifact service method.</param>
        /// 
        /// <returns>The response from the AssociateCreatedArtifact service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateCreatedArtifact">REST API Reference for AssociateCreatedArtifact Operation</seealso>
        public virtual AssociateCreatedArtifactResponse AssociateCreatedArtifact(AssociateCreatedArtifactRequest request)
        {
            var marshaller = AssociateCreatedArtifactRequestMarshaller.Instance;
            var unmarshaller = AssociateCreatedArtifactResponseUnmarshaller.Instance;

            return Invoke<AssociateCreatedArtifactRequest,AssociateCreatedArtifactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateCreatedArtifact operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateCreatedArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateCreatedArtifact">REST API Reference for AssociateCreatedArtifact Operation</seealso>
        public virtual IAsyncResult BeginAssociateCreatedArtifact(AssociateCreatedArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateCreatedArtifactRequestMarshaller.Instance;
            var unmarshaller = AssociateCreatedArtifactResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateCreatedArtifactRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateCreatedArtifact.</param>
        /// 
        /// <returns>Returns a  AssociateCreatedArtifactResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateCreatedArtifact">REST API Reference for AssociateCreatedArtifact Operation</seealso>
        public virtual AssociateCreatedArtifactResponse EndAssociateCreatedArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateCreatedArtifactResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateDiscoveredResource

        /// <summary>
        /// Associates a discovered resource ID from Application Discovery Service (ADS) with
        /// a migration task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDiscoveredResource service method.</param>
        /// 
        /// <returns>The response from the AssociateDiscoveredResource service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.PolicyErrorException">
        /// Exception raised when there are problems accessing ADS (Application Discovery Service);
        /// most likely due to a misconfigured policy or the <code>migrationhub-discovery</code>
        /// role is missing or not configured correctly.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateDiscoveredResource">REST API Reference for AssociateDiscoveredResource Operation</seealso>
        public virtual AssociateDiscoveredResourceResponse AssociateDiscoveredResource(AssociateDiscoveredResourceRequest request)
        {
            var marshaller = AssociateDiscoveredResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateDiscoveredResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateDiscoveredResourceRequest,AssociateDiscoveredResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDiscoveredResource operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDiscoveredResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateDiscoveredResource">REST API Reference for AssociateDiscoveredResource Operation</seealso>
        public virtual IAsyncResult BeginAssociateDiscoveredResource(AssociateDiscoveredResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateDiscoveredResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateDiscoveredResourceResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateDiscoveredResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDiscoveredResource.</param>
        /// 
        /// <returns>Returns a  AssociateDiscoveredResourceResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateDiscoveredResource">REST API Reference for AssociateDiscoveredResource Operation</seealso>
        public virtual AssociateDiscoveredResourceResponse EndAssociateDiscoveredResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDiscoveredResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProgressUpdateStream

        /// <summary>
        /// Creates a progress update stream which is an AWS resource used for access control
        /// as well as a namespace for migration task names that is implicitly linked to your
        /// AWS account. It must uniquely identify the migration tool as it is used for all updates
        /// made by the tool; however, it does not need to be unique for each AWS account because
        /// it is scoped to the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgressUpdateStream service method.</param>
        /// 
        /// <returns>The response from the CreateProgressUpdateStream service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/CreateProgressUpdateStream">REST API Reference for CreateProgressUpdateStream Operation</seealso>
        public virtual CreateProgressUpdateStreamResponse CreateProgressUpdateStream(CreateProgressUpdateStreamRequest request)
        {
            var marshaller = CreateProgressUpdateStreamRequestMarshaller.Instance;
            var unmarshaller = CreateProgressUpdateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateProgressUpdateStreamRequest,CreateProgressUpdateStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProgressUpdateStream operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProgressUpdateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/CreateProgressUpdateStream">REST API Reference for CreateProgressUpdateStream Operation</seealso>
        public virtual IAsyncResult BeginCreateProgressUpdateStream(CreateProgressUpdateStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateProgressUpdateStreamRequestMarshaller.Instance;
            var unmarshaller = CreateProgressUpdateStreamResponseUnmarshaller.Instance;

            return BeginInvoke<CreateProgressUpdateStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProgressUpdateStream.</param>
        /// 
        /// <returns>Returns a  CreateProgressUpdateStreamResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/CreateProgressUpdateStream">REST API Reference for CreateProgressUpdateStream Operation</seealso>
        public virtual CreateProgressUpdateStreamResponse EndCreateProgressUpdateStream(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProgressUpdateStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProgressUpdateStream

        /// <summary>
        /// Deletes a progress update stream, including all of its tasks, which was previously
        /// created as an AWS resource used for access control. This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The only parameter needed for <code>DeleteProgressUpdateStream</code> is the stream
        /// name (same as a <code>CreateProgressUpdateStream</code> call).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The call will return, and a background process will asynchronously delete the stream
        /// and all of its resources (tasks, associated resources, resource attributes, created
        /// artifacts).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the stream takes time to be deleted, it might still show up on a <code>ListProgressUpdateStreams</code>
        /// call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreateProgressUpdateStream</code>, <code>ImportMigrationTask</code>, <code>NotifyMigrationTaskState</code>,
        /// and all Associate[*] APIs realted to the tasks belonging to the stream will throw
        /// "InvalidInputException" if the stream of the same name is in the process of being
        /// deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Once the stream and all of its resources are deleted, <code>CreateProgressUpdateStream</code>
        /// for a stream of the same name will succeed, and that stream will be an entirely new
        /// logical resource (without any resources associated with the old stream).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgressUpdateStream service method.</param>
        /// 
        /// <returns>The response from the DeleteProgressUpdateStream service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DeleteProgressUpdateStream">REST API Reference for DeleteProgressUpdateStream Operation</seealso>
        public virtual DeleteProgressUpdateStreamResponse DeleteProgressUpdateStream(DeleteProgressUpdateStreamRequest request)
        {
            var marshaller = DeleteProgressUpdateStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteProgressUpdateStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteProgressUpdateStreamRequest,DeleteProgressUpdateStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgressUpdateStream operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProgressUpdateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DeleteProgressUpdateStream">REST API Reference for DeleteProgressUpdateStream Operation</seealso>
        public virtual IAsyncResult BeginDeleteProgressUpdateStream(DeleteProgressUpdateStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteProgressUpdateStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteProgressUpdateStreamResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteProgressUpdateStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProgressUpdateStream.</param>
        /// 
        /// <returns>Returns a  DeleteProgressUpdateStreamResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DeleteProgressUpdateStream">REST API Reference for DeleteProgressUpdateStream Operation</seealso>
        public virtual DeleteProgressUpdateStreamResponse EndDeleteProgressUpdateStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProgressUpdateStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplicationState

        /// <summary>
        /// Gets the migration status of an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationState service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationState service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.PolicyErrorException">
        /// Exception raised when there are problems accessing ADS (Application Discovery Service);
        /// most likely due to a misconfigured policy or the <code>migrationhub-discovery</code>
        /// role is missing or not configured correctly.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeApplicationState">REST API Reference for DescribeApplicationState Operation</seealso>
        public virtual DescribeApplicationStateResponse DescribeApplicationState(DescribeApplicationStateRequest request)
        {
            var marshaller = DescribeApplicationStateRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationStateResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationStateRequest,DescribeApplicationStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationState operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeApplicationState">REST API Reference for DescribeApplicationState Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplicationState(DescribeApplicationStateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeApplicationStateRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationStateResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeApplicationStateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationState.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationStateResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeApplicationState">REST API Reference for DescribeApplicationState Operation</seealso>
        public virtual DescribeApplicationStateResponse EndDescribeApplicationState(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationStateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMigrationTask

        /// <summary>
        /// Retrieves a list of all attributes associated with a specific migration task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationTask service method.</param>
        /// 
        /// <returns>The response from the DescribeMigrationTask service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeMigrationTask">REST API Reference for DescribeMigrationTask Operation</seealso>
        public virtual DescribeMigrationTaskResponse DescribeMigrationTask(DescribeMigrationTaskRequest request)
        {
            var marshaller = DescribeMigrationTaskRequestMarshaller.Instance;
            var unmarshaller = DescribeMigrationTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeMigrationTaskRequest,DescribeMigrationTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationTask operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMigrationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeMigrationTask">REST API Reference for DescribeMigrationTask Operation</seealso>
        public virtual IAsyncResult BeginDescribeMigrationTask(DescribeMigrationTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeMigrationTaskRequestMarshaller.Instance;
            var unmarshaller = DescribeMigrationTaskResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMigrationTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMigrationTask.</param>
        /// 
        /// <returns>Returns a  DescribeMigrationTaskResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeMigrationTask">REST API Reference for DescribeMigrationTask Operation</seealso>
        public virtual DescribeMigrationTaskResponse EndDescribeMigrationTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMigrationTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateCreatedArtifact

        /// <summary>
        /// Disassociates a created artifact of an AWS resource with a migration task performed
        /// by a migration tool that was previously associated. This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A migration user can call the <code>DisassociateCreatedArtifacts</code> operation
        /// to disassociate a created AWS Artifact from a migration task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The created artifact name must be provided in ARN (Amazon Resource Name) format which
        /// will contain information about type and region; for example: <code>arn:aws:ec2:us-east-1:488216288981:image/ami-6d0ba87b</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Examples of the AWS resource behind the created artifact are, AMI's, EC2 instance,
        /// or RDS instance, etc.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCreatedArtifact service method.</param>
        /// 
        /// <returns>The response from the DisassociateCreatedArtifact service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateCreatedArtifact">REST API Reference for DisassociateCreatedArtifact Operation</seealso>
        public virtual DisassociateCreatedArtifactResponse DisassociateCreatedArtifact(DisassociateCreatedArtifactRequest request)
        {
            var marshaller = DisassociateCreatedArtifactRequestMarshaller.Instance;
            var unmarshaller = DisassociateCreatedArtifactResponseUnmarshaller.Instance;

            return Invoke<DisassociateCreatedArtifactRequest,DisassociateCreatedArtifactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCreatedArtifact operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateCreatedArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateCreatedArtifact">REST API Reference for DisassociateCreatedArtifact Operation</seealso>
        public virtual IAsyncResult BeginDisassociateCreatedArtifact(DisassociateCreatedArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateCreatedArtifactRequestMarshaller.Instance;
            var unmarshaller = DisassociateCreatedArtifactResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateCreatedArtifactRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateCreatedArtifact.</param>
        /// 
        /// <returns>Returns a  DisassociateCreatedArtifactResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateCreatedArtifact">REST API Reference for DisassociateCreatedArtifact Operation</seealso>
        public virtual DisassociateCreatedArtifactResponse EndDisassociateCreatedArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateCreatedArtifactResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateDiscoveredResource

        /// <summary>
        /// Disassociate an Application Discovery Service (ADS) discovered resource from a migration
        /// task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDiscoveredResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateDiscoveredResource service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateDiscoveredResource">REST API Reference for DisassociateDiscoveredResource Operation</seealso>
        public virtual DisassociateDiscoveredResourceResponse DisassociateDiscoveredResource(DisassociateDiscoveredResourceRequest request)
        {
            var marshaller = DisassociateDiscoveredResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateDiscoveredResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateDiscoveredResourceRequest,DisassociateDiscoveredResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDiscoveredResource operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDiscoveredResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateDiscoveredResource">REST API Reference for DisassociateDiscoveredResource Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDiscoveredResource(DisassociateDiscoveredResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateDiscoveredResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateDiscoveredResourceResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateDiscoveredResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDiscoveredResource.</param>
        /// 
        /// <returns>Returns a  DisassociateDiscoveredResourceResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateDiscoveredResource">REST API Reference for DisassociateDiscoveredResource Operation</seealso>
        public virtual DisassociateDiscoveredResourceResponse EndDisassociateDiscoveredResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDiscoveredResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportMigrationTask

        /// <summary>
        /// Registers a new migration task which represents a server, database, etc., being migrated
        /// to AWS by a migration tool.
        /// 
        ///  
        /// <para>
        /// This API is a prerequisite to calling the <code>NotifyMigrationTaskState</code> API
        /// as the migration tool must first register the migration task with Migration Hub.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportMigrationTask service method.</param>
        /// 
        /// <returns>The response from the ImportMigrationTask service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ImportMigrationTask">REST API Reference for ImportMigrationTask Operation</seealso>
        public virtual ImportMigrationTaskResponse ImportMigrationTask(ImportMigrationTaskRequest request)
        {
            var marshaller = ImportMigrationTaskRequestMarshaller.Instance;
            var unmarshaller = ImportMigrationTaskResponseUnmarshaller.Instance;

            return Invoke<ImportMigrationTaskRequest,ImportMigrationTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportMigrationTask operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportMigrationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ImportMigrationTask">REST API Reference for ImportMigrationTask Operation</seealso>
        public virtual IAsyncResult BeginImportMigrationTask(ImportMigrationTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ImportMigrationTaskRequestMarshaller.Instance;
            var unmarshaller = ImportMigrationTaskResponseUnmarshaller.Instance;

            return BeginInvoke<ImportMigrationTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportMigrationTask.</param>
        /// 
        /// <returns>Returns a  ImportMigrationTaskResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ImportMigrationTask">REST API Reference for ImportMigrationTask Operation</seealso>
        public virtual ImportMigrationTaskResponse EndImportMigrationTask(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportMigrationTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCreatedArtifacts

        /// <summary>
        /// Lists the created artifacts attached to a given migration task in an update stream.
        /// This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Gets the list of the created artifacts while migration is taking place.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Shows the artifacts created by the migration tool that was associated by the <code>AssociateCreatedArtifact</code>
        /// API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lists created artifacts in a paginated interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCreatedArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListCreatedArtifacts service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListCreatedArtifacts">REST API Reference for ListCreatedArtifacts Operation</seealso>
        public virtual ListCreatedArtifactsResponse ListCreatedArtifacts(ListCreatedArtifactsRequest request)
        {
            var marshaller = ListCreatedArtifactsRequestMarshaller.Instance;
            var unmarshaller = ListCreatedArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListCreatedArtifactsRequest,ListCreatedArtifactsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCreatedArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCreatedArtifacts operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCreatedArtifacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListCreatedArtifacts">REST API Reference for ListCreatedArtifacts Operation</seealso>
        public virtual IAsyncResult BeginListCreatedArtifacts(ListCreatedArtifactsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListCreatedArtifactsRequestMarshaller.Instance;
            var unmarshaller = ListCreatedArtifactsResponseUnmarshaller.Instance;

            return BeginInvoke<ListCreatedArtifactsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCreatedArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCreatedArtifacts.</param>
        /// 
        /// <returns>Returns a  ListCreatedArtifactsResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListCreatedArtifacts">REST API Reference for ListCreatedArtifacts Operation</seealso>
        public virtual ListCreatedArtifactsResponse EndListCreatedArtifacts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCreatedArtifactsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDiscoveredResources

        /// <summary>
        /// Lists discovered resources associated with the given <code>MigrationTask</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            var marshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            var unmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredResourcesRequest,ListDiscoveredResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDiscoveredResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual IAsyncResult BeginListDiscoveredResources(ListDiscoveredResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            var unmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<ListDiscoveredResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoveredResources.</param>
        /// 
        /// <returns>Returns a  ListDiscoveredResourcesResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual ListDiscoveredResourcesResponse EndListDiscoveredResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDiscoveredResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMigrationTasks

        /// <summary>
        /// Lists all, or filtered by resource name, migration tasks associated with the user
        /// account making this call. This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Can show a summary list of the most recent migration tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can show a summary list of migration tasks associated with a given discovered resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lists migration tasks in a paginated interface.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMigrationTasks service method.</param>
        /// 
        /// <returns>The response from the ListMigrationTasks service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.PolicyErrorException">
        /// Exception raised when there are problems accessing ADS (Application Discovery Service);
        /// most likely due to a misconfigured policy or the <code>migrationhub-discovery</code>
        /// role is missing or not configured correctly.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTasks">REST API Reference for ListMigrationTasks Operation</seealso>
        public virtual ListMigrationTasksResponse ListMigrationTasks(ListMigrationTasksRequest request)
        {
            var marshaller = ListMigrationTasksRequestMarshaller.Instance;
            var unmarshaller = ListMigrationTasksResponseUnmarshaller.Instance;

            return Invoke<ListMigrationTasksRequest,ListMigrationTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMigrationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMigrationTasks operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMigrationTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTasks">REST API Reference for ListMigrationTasks Operation</seealso>
        public virtual IAsyncResult BeginListMigrationTasks(ListMigrationTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListMigrationTasksRequestMarshaller.Instance;
            var unmarshaller = ListMigrationTasksResponseUnmarshaller.Instance;

            return BeginInvoke<ListMigrationTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMigrationTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMigrationTasks.</param>
        /// 
        /// <returns>Returns a  ListMigrationTasksResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTasks">REST API Reference for ListMigrationTasks Operation</seealso>
        public virtual ListMigrationTasksResponse EndListMigrationTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMigrationTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProgressUpdateStreams

        /// <summary>
        /// Lists progress update streams associated with the user account making this call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProgressUpdateStreams service method.</param>
        /// 
        /// <returns>The response from the ListProgressUpdateStreams service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListProgressUpdateStreams">REST API Reference for ListProgressUpdateStreams Operation</seealso>
        public virtual ListProgressUpdateStreamsResponse ListProgressUpdateStreams(ListProgressUpdateStreamsRequest request)
        {
            var marshaller = ListProgressUpdateStreamsRequestMarshaller.Instance;
            var unmarshaller = ListProgressUpdateStreamsResponseUnmarshaller.Instance;

            return Invoke<ListProgressUpdateStreamsRequest,ListProgressUpdateStreamsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProgressUpdateStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProgressUpdateStreams operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProgressUpdateStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListProgressUpdateStreams">REST API Reference for ListProgressUpdateStreams Operation</seealso>
        public virtual IAsyncResult BeginListProgressUpdateStreams(ListProgressUpdateStreamsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListProgressUpdateStreamsRequestMarshaller.Instance;
            var unmarshaller = ListProgressUpdateStreamsResponseUnmarshaller.Instance;

            return BeginInvoke<ListProgressUpdateStreamsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProgressUpdateStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProgressUpdateStreams.</param>
        /// 
        /// <returns>Returns a  ListProgressUpdateStreamsResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListProgressUpdateStreams">REST API Reference for ListProgressUpdateStreams Operation</seealso>
        public virtual ListProgressUpdateStreamsResponse EndListProgressUpdateStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProgressUpdateStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  NotifyApplicationState

        /// <summary>
        /// Sets the migration state of an application. For a given application identified by
        /// the value passed to <code>ApplicationId</code>, its status is set or updated by passing
        /// one of three values to <code>Status</code>: <code>NOT_STARTED | IN_PROGRESS | COMPLETED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyApplicationState service method.</param>
        /// 
        /// <returns>The response from the NotifyApplicationState service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.PolicyErrorException">
        /// Exception raised when there are problems accessing ADS (Application Discovery Service);
        /// most likely due to a misconfigured policy or the <code>migrationhub-discovery</code>
        /// role is missing or not configured correctly.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyApplicationState">REST API Reference for NotifyApplicationState Operation</seealso>
        public virtual NotifyApplicationStateResponse NotifyApplicationState(NotifyApplicationStateRequest request)
        {
            var marshaller = NotifyApplicationStateRequestMarshaller.Instance;
            var unmarshaller = NotifyApplicationStateResponseUnmarshaller.Instance;

            return Invoke<NotifyApplicationStateRequest,NotifyApplicationStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyApplicationState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyApplicationState operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyApplicationState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyApplicationState">REST API Reference for NotifyApplicationState Operation</seealso>
        public virtual IAsyncResult BeginNotifyApplicationState(NotifyApplicationStateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = NotifyApplicationStateRequestMarshaller.Instance;
            var unmarshaller = NotifyApplicationStateResponseUnmarshaller.Instance;

            return BeginInvoke<NotifyApplicationStateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyApplicationState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyApplicationState.</param>
        /// 
        /// <returns>Returns a  NotifyApplicationStateResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyApplicationState">REST API Reference for NotifyApplicationState Operation</seealso>
        public virtual NotifyApplicationStateResponse EndNotifyApplicationState(IAsyncResult asyncResult)
        {
            return EndInvoke<NotifyApplicationStateResponse>(asyncResult);
        }

        #endregion
        
        #region  NotifyMigrationTaskState

        /// <summary>
        /// Notifies Migration Hub of the current status, progress, or other detail regarding
        /// a migration task. This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Migration tools will call the <code>NotifyMigrationTaskState</code> API to share the
        /// latest progress and status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MigrationTaskName</code> is used for addressing updates to the correct target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ProgressUpdateStream</code> is used for access control and to provide a namespace
        /// for each migration tool.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyMigrationTaskState service method.</param>
        /// 
        /// <returns>The response from the NotifyMigrationTaskState service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyMigrationTaskState">REST API Reference for NotifyMigrationTaskState Operation</seealso>
        public virtual NotifyMigrationTaskStateResponse NotifyMigrationTaskState(NotifyMigrationTaskStateRequest request)
        {
            var marshaller = NotifyMigrationTaskStateRequestMarshaller.Instance;
            var unmarshaller = NotifyMigrationTaskStateResponseUnmarshaller.Instance;

            return Invoke<NotifyMigrationTaskStateRequest,NotifyMigrationTaskStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyMigrationTaskState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyMigrationTaskState operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyMigrationTaskState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyMigrationTaskState">REST API Reference for NotifyMigrationTaskState Operation</seealso>
        public virtual IAsyncResult BeginNotifyMigrationTaskState(NotifyMigrationTaskStateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = NotifyMigrationTaskStateRequestMarshaller.Instance;
            var unmarshaller = NotifyMigrationTaskStateResponseUnmarshaller.Instance;

            return BeginInvoke<NotifyMigrationTaskStateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyMigrationTaskState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyMigrationTaskState.</param>
        /// 
        /// <returns>Returns a  NotifyMigrationTaskStateResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyMigrationTaskState">REST API Reference for NotifyMigrationTaskState Operation</seealso>
        public virtual NotifyMigrationTaskStateResponse EndNotifyMigrationTaskState(IAsyncResult asyncResult)
        {
            return EndInvoke<NotifyMigrationTaskStateResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourceAttributes

        /// <summary>
        /// Provides identifying details of the resource being migrated so that it can be associated
        /// in the Application Discovery Service (ADS)'s repository. This association occurs asynchronously
        /// after <code>PutResourceAttributes</code> returns.
        /// 
        ///  <important> <ul> <li> 
        /// <para>
        /// Keep in mind that subsequent calls to PutResourceAttributes will override previously
        /// stored attributes. For example, if it is first called with a MAC address, but later,
        /// it is desired to <i>add</i> an IP address, it will then be required to call it with
        /// <i>both</i> the IP and MAC addresses to prevent overiding the MAC address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Note the instructions regarding the special use case of the <code>ResourceAttributeList</code>
        /// parameter when specifying any "VM" related value.
        /// </para>
        ///  </li> </ul> </important> <note> 
        /// <para>
        /// Because this is an asynchronous call, it will always return 200, whether an association
        /// occurs or not. To confirm if an association was found based on the provided details,
        /// call <code>ListDiscoveredResources</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceAttributes service method.</param>
        /// 
        /// <returns>The response from the PutResourceAttributes service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (ADS configuration, update
        /// stream, migration task, etc.) that does not exist in ADS (Application Discovery Service)
        /// or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <code>DryRun</code>
        /// flag is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/PutResourceAttributes">REST API Reference for PutResourceAttributes Operation</seealso>
        public virtual PutResourceAttributesResponse PutResourceAttributes(PutResourceAttributesRequest request)
        {
            var marshaller = PutResourceAttributesRequestMarshaller.Instance;
            var unmarshaller = PutResourceAttributesResponseUnmarshaller.Instance;

            return Invoke<PutResourceAttributesRequest,PutResourceAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourceAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourceAttributes operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourceAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/PutResourceAttributes">REST API Reference for PutResourceAttributes Operation</seealso>
        public virtual IAsyncResult BeginPutResourceAttributes(PutResourceAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutResourceAttributesRequestMarshaller.Instance;
            var unmarshaller = PutResourceAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<PutResourceAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourceAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourceAttributes.</param>
        /// 
        /// <returns>Returns a  PutResourceAttributesResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/PutResourceAttributes">REST API Reference for PutResourceAttributes Operation</seealso>
        public virtual PutResourceAttributesResponse EndPutResourceAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourceAttributesResponse>(asyncResult);
        }

        #endregion
        
    }
}