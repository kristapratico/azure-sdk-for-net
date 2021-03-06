// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The PolicyDefinitions service client. </summary>
    public partial class PolicyDefinitionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PolicyDefinitionsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of PolicyDefinitionsOperations for mocking. </summary>
        protected PolicyDefinitionsOperations()
        {
        }
        /// <summary> Initializes a new instance of PolicyDefinitionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal PolicyDefinitionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new PolicyDefinitionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> This operation creates or updates a policy definition in the given subscription with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyDefinition>> CreateOrUpdateAsync(string policyDefinitionName, PolicyDefinition parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(policyDefinitionName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy definition in the given subscription with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyDefinition> CreateOrUpdate(string policyDefinitionName, PolicyDefinition parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(policyDefinitionName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy definition in the given subscription with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy definition in the given subscription with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(policyDefinitionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy definition in the given subscription with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyDefinition>> GetAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy definition in the given subscription with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyDefinition> Get(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(policyDefinitionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the built-in policy definition with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyDefinition>> GetBuiltInAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.GetBuiltIn");
            scope.Start();
            try
            {
                return await RestClient.GetBuiltInAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the built-in policy definition with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyDefinition> GetBuiltIn(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.GetBuiltIn");
            scope.Start();
            try
            {
                return RestClient.GetBuiltIn(policyDefinitionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="managementGroupId"> The ID of the management group. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyDefinition>> CreateOrUpdateAtManagementGroupAsync(string policyDefinitionName, string managementGroupId, PolicyDefinition parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.CreateOrUpdateAtManagementGroup");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAtManagementGroupAsync(policyDefinitionName, managementGroupId, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="managementGroupId"> The ID of the management group. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyDefinition> CreateOrUpdateAtManagementGroup(string policyDefinitionName, string managementGroupId, PolicyDefinition parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.CreateOrUpdateAtManagementGroup");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdateAtManagementGroup(policyDefinitionName, managementGroupId, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to delete. </param>
        /// <param name="managementGroupId"> The ID of the management group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAtManagementGroupAsync(string policyDefinitionName, string managementGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.DeleteAtManagementGroup");
            scope.Start();
            try
            {
                return await RestClient.DeleteAtManagementGroupAsync(policyDefinitionName, managementGroupId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to delete. </param>
        /// <param name="managementGroupId"> The ID of the management group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteAtManagementGroup(string policyDefinitionName, string managementGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.DeleteAtManagementGroup");
            scope.Start();
            try
            {
                return RestClient.DeleteAtManagementGroup(policyDefinitionName, managementGroupId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="managementGroupId"> The ID of the management group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyDefinition>> GetAtManagementGroupAsync(string policyDefinitionName, string managementGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.GetAtManagementGroup");
            scope.Start();
            try
            {
                return await RestClient.GetAtManagementGroupAsync(policyDefinitionName, managementGroupId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="managementGroupId"> The ID of the management group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyDefinition> GetAtManagementGroup(string policyDefinitionName, string managementGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.GetAtManagementGroup");
            scope.Start();
            try
            {
                return RestClient.GetAtManagementGroup(policyDefinitionName, managementGroupId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves a list of all the policy definitions in a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PolicyDefinition> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the policy definitions in a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PolicyDefinition> List(CancellationToken cancellationToken = default)
        {
            Page<PolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the built-in policy definitions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PolicyDefinition> ListBuiltInAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.ListBuiltIn");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBuiltInAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.ListBuiltIn");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBuiltInNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the built-in policy definitions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PolicyDefinition> ListBuiltIn(CancellationToken cancellationToken = default)
        {
            Page<PolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.ListBuiltIn");
                scope.Start();
                try
                {
                    var response = RestClient.ListBuiltIn(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.ListBuiltIn");
                scope.Start();
                try
                {
                    var response = RestClient.ListBuiltInNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the policy definitions in a given management group. </summary>
        /// <param name="managementGroupId"> The ID of the management group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> is null. </exception>
        public virtual AsyncPageable<PolicyDefinition> ListByManagementGroupAsync(string managementGroupId, CancellationToken cancellationToken = default)
        {
            if (managementGroupId == null)
            {
                throw new ArgumentNullException(nameof(managementGroupId));
            }

            async Task<Page<PolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.ListByManagementGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByManagementGroupAsync(managementGroupId, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.ListByManagementGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByManagementGroupNextPageAsync(nextLink, managementGroupId, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the policy definitions in a given management group. </summary>
        /// <param name="managementGroupId"> The ID of the management group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> is null. </exception>
        public virtual Pageable<PolicyDefinition> ListByManagementGroup(string managementGroupId, CancellationToken cancellationToken = default)
        {
            if (managementGroupId == null)
            {
                throw new ArgumentNullException(nameof(managementGroupId));
            }

            Page<PolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.ListByManagementGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByManagementGroup(managementGroupId, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionsOperations.ListByManagementGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByManagementGroupNextPage(nextLink, managementGroupId, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
