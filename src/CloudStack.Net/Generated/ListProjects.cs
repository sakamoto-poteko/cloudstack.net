using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListProjectsRequest : APIListRequest
    {
        public ListProjectsRequest() : base("listProjects") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list projects by display text
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// list projects by project ID
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
        /// list projects by name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// list projects by state
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// List projects by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists projects and provides detailed information for listed projects
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProjectResponse> ListProjects(ListProjectsRequest request);
        Task<ListResponse<ProjectResponse>> ListProjectsAsync(ListProjectsRequest request);
        ListResponse<ProjectResponse> ListProjectsAllPages(ListProjectsRequest request);
        Task<ListResponse<ProjectResponse>> ListProjectsAllPagesAsync(ListProjectsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProjectResponse> ListProjects(ListProjectsRequest request) => _proxy.Request<ListResponse<ProjectResponse>>(request);
        public Task<ListResponse<ProjectResponse>> ListProjectsAsync(ListProjectsRequest request) => _proxy.RequestAsync<ListResponse<ProjectResponse>>(request);
        public ListResponse<ProjectResponse> ListProjectsAllPages(ListProjectsRequest request) => _proxy.RequestAllPages<ProjectResponse>(request);
        public Task<ListResponse<ProjectResponse>> ListProjectsAllPagesAsync(ListProjectsRequest request) => _proxy.RequestAllPagesAsync<ProjectResponse>(request);
    }
}
