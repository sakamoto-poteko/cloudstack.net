using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListInstanceGroupsRequest : APIListRequest
    {
        public ListInstanceGroupsRequest() : base("listInstanceGroups") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// list instance groups by ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
        }

        /// <summary>
        /// list instance groups by name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists vm groups
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<InstanceGroupResponse> ListInstanceGroups(ListInstanceGroupsRequest request);
        Task<ListResponse<InstanceGroupResponse>> ListInstanceGroupsAsync(ListInstanceGroupsRequest request);
        ListResponse<InstanceGroupResponse> ListInstanceGroupsAllPages(ListInstanceGroupsRequest request);
        Task<ListResponse<InstanceGroupResponse>> ListInstanceGroupsAllPagesAsync(ListInstanceGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<InstanceGroupResponse> ListInstanceGroups(ListInstanceGroupsRequest request) => _proxy.Request<ListResponse<InstanceGroupResponse>>(request);
        public Task<ListResponse<InstanceGroupResponse>> ListInstanceGroupsAsync(ListInstanceGroupsRequest request) => _proxy.RequestAsync<ListResponse<InstanceGroupResponse>>(request);
        public ListResponse<InstanceGroupResponse> ListInstanceGroupsAllPages(ListInstanceGroupsRequest request) => _proxy.RequestAllPages<InstanceGroupResponse>(request);
        public Task<ListResponse<InstanceGroupResponse>> ListInstanceGroupsAllPagesAsync(ListInstanceGroupsRequest request) => _proxy.RequestAllPagesAsync<InstanceGroupResponse>(request);
    }
}
