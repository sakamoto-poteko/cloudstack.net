using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNicsRequest : APIListRequest
    {
        public ListNicsRequest() : base("listNics") {}

        /// <summary>
        /// the ID of the vm
        /// </summary>
        public Guid Virtualmachineid {
            get { return (Guid) Parameters[nameof(Virtualmachineid).ToLower()]; }
            set { Parameters[nameof(Virtualmachineid).ToLower()] = value; }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// list nic of the specific vm's network
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the nic to to list IPs
        /// </summary>
        public Guid NicId {
            get { return (Guid) Parameters[nameof(NicId).ToLower()]; }
            set { Parameters[nameof(NicId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// list the vm nics  IP to NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NicResponse> ListNics(ListNicsRequest request);
        Task<ListResponse<NicResponse>> ListNicsAsync(ListNicsRequest request);
        ListResponse<NicResponse> ListNicsAllPages(ListNicsRequest request);
        Task<ListResponse<NicResponse>> ListNicsAllPagesAsync(ListNicsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NicResponse> ListNics(ListNicsRequest request) => _proxy.Request<ListResponse<NicResponse>>(request);
        public Task<ListResponse<NicResponse>> ListNicsAsync(ListNicsRequest request) => _proxy.RequestAsync<ListResponse<NicResponse>>(request);
        public ListResponse<NicResponse> ListNicsAllPages(ListNicsRequest request) => _proxy.RequestAllPages<NicResponse>(request);
        public Task<ListResponse<NicResponse>> ListNicsAllPagesAsync(ListNicsRequest request) => _proxy.RequestAllPagesAsync<NicResponse>(request);
    }
}
