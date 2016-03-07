using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaTariffListRequest : APIListRequest
    {
        public QuotaTariffListRequest() : base("quotaTariffList") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// The effective start date on/after which the quota tariff is effective and older tariffs are no longer used for the usage type. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-03.
        /// </summary>
        public DateTime? Startdate {
            get { return (DateTime?) Parameters[nameof(Startdate).ToLower()]; }
            set { Parameters[nameof(Startdate).ToLower()] = value; }
        }

        /// <summary>
        /// Usage type of the resource
        /// </summary>
        public int? UsageType {
            get { return (int?) Parameters[nameof(UsageType).ToLower()]; }
            set { Parameters[nameof(UsageType).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all quota tariff plans
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<QuotaTariffResponse> QuotaTariffList(QuotaTariffListRequest request);
        Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAsync(QuotaTariffListRequest request);
        ListResponse<QuotaTariffResponse> QuotaTariffListAllPages(QuotaTariffListRequest request);
        Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAllPagesAsync(QuotaTariffListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<QuotaTariffResponse> QuotaTariffList(QuotaTariffListRequest request) => _proxy.Request<ListResponse<QuotaTariffResponse>>(request);
        public Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAsync(QuotaTariffListRequest request) => _proxy.RequestAsync<ListResponse<QuotaTariffResponse>>(request);
        public ListResponse<QuotaTariffResponse> QuotaTariffListAllPages(QuotaTariffListRequest request) => _proxy.RequestAllPages<QuotaTariffResponse>(request);
        public Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAllPagesAsync(QuotaTariffListRequest request) => _proxy.RequestAllPagesAsync<QuotaTariffResponse>(request);
    }
}
