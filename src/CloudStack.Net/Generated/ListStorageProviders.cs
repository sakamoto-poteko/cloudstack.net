using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageProvidersRequest : APIListRequest
    {
        public ListStorageProvidersRequest() : base("listStorageProviders") {}

        /// <summary>
        /// the type of storage provider: either primary or image
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists storage providers.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageProviderResponse> ListStorageProviders(ListStorageProvidersRequest request);
        Task<ListResponse<StorageProviderResponse>> ListStorageProvidersAsync(ListStorageProvidersRequest request);
        ListResponse<StorageProviderResponse> ListStorageProvidersAllPages(ListStorageProvidersRequest request);
        Task<ListResponse<StorageProviderResponse>> ListStorageProvidersAllPagesAsync(ListStorageProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageProviderResponse> ListStorageProviders(ListStorageProvidersRequest request) => _proxy.Request<ListResponse<StorageProviderResponse>>(request);
        public Task<ListResponse<StorageProviderResponse>> ListStorageProvidersAsync(ListStorageProvidersRequest request) => _proxy.RequestAsync<ListResponse<StorageProviderResponse>>(request);
        public ListResponse<StorageProviderResponse> ListStorageProvidersAllPages(ListStorageProvidersRequest request) => _proxy.RequestAllPages<StorageProviderResponse>(request);
        public Task<ListResponse<StorageProviderResponse>> ListStorageProvidersAllPagesAsync(ListStorageProvidersRequest request) => _proxy.RequestAllPagesAsync<StorageProviderResponse>(request);
    }
}
