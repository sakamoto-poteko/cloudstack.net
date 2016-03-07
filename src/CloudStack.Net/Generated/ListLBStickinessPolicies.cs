using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLBStickinessPoliciesRequest : APIListRequest
    {
        public ListLBStickinessPoliciesRequest() : base("listLBStickinessPolicies") {}

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the load balancer stickiness policy
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
    /// Lists load balancer stickiness policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LBStickinessResponse> ListLBStickinessPolicies(ListLBStickinessPoliciesRequest request);
        Task<ListResponse<LBStickinessResponse>> ListLBStickinessPoliciesAsync(ListLBStickinessPoliciesRequest request);
        ListResponse<LBStickinessResponse> ListLBStickinessPoliciesAllPages(ListLBStickinessPoliciesRequest request);
        Task<ListResponse<LBStickinessResponse>> ListLBStickinessPoliciesAllPagesAsync(ListLBStickinessPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LBStickinessResponse> ListLBStickinessPolicies(ListLBStickinessPoliciesRequest request) => _proxy.Request<ListResponse<LBStickinessResponse>>(request);
        public Task<ListResponse<LBStickinessResponse>> ListLBStickinessPoliciesAsync(ListLBStickinessPoliciesRequest request) => _proxy.RequestAsync<ListResponse<LBStickinessResponse>>(request);
        public ListResponse<LBStickinessResponse> ListLBStickinessPoliciesAllPages(ListLBStickinessPoliciesRequest request) => _proxy.RequestAllPages<LBStickinessResponse>(request);
        public Task<ListResponse<LBStickinessResponse>> ListLBStickinessPoliciesAllPagesAsync(ListLBStickinessPoliciesRequest request) => _proxy.RequestAllPagesAsync<LBStickinessResponse>(request);
    }
}
