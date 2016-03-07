using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLBHealthCheckPoliciesRequest : APIListRequest
    {
        public ListLBHealthCheckPoliciesRequest() : base("listLBHealthCheckPolicies") {}

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the health check policy
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId {
            get { return (Guid) Parameters[nameof(LbRuleId).ToLower()]; }
            set { Parameters[nameof(LbRuleId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists load balancer health check policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LBHealthCheckResponse> ListLBHealthCheckPolicies(ListLBHealthCheckPoliciesRequest request);
        Task<ListResponse<LBHealthCheckResponse>> ListLBHealthCheckPoliciesAsync(ListLBHealthCheckPoliciesRequest request);
        ListResponse<LBHealthCheckResponse> ListLBHealthCheckPoliciesAllPages(ListLBHealthCheckPoliciesRequest request);
        Task<ListResponse<LBHealthCheckResponse>> ListLBHealthCheckPoliciesAllPagesAsync(ListLBHealthCheckPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LBHealthCheckResponse> ListLBHealthCheckPolicies(ListLBHealthCheckPoliciesRequest request) => _proxy.Request<ListResponse<LBHealthCheckResponse>>(request);
        public Task<ListResponse<LBHealthCheckResponse>> ListLBHealthCheckPoliciesAsync(ListLBHealthCheckPoliciesRequest request) => _proxy.RequestAsync<ListResponse<LBHealthCheckResponse>>(request);
        public ListResponse<LBHealthCheckResponse> ListLBHealthCheckPoliciesAllPages(ListLBHealthCheckPoliciesRequest request) => _proxy.RequestAllPages<LBHealthCheckResponse>(request);
        public Task<ListResponse<LBHealthCheckResponse>> ListLBHealthCheckPoliciesAllPagesAsync(ListLBHealthCheckPoliciesRequest request) => _proxy.RequestAllPagesAsync<LBHealthCheckResponse>(request);
    }
}
