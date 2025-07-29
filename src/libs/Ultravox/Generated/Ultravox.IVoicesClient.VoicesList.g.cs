#nullable enable

namespace Ultravox
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List all voices in your account.
        /// </summary>
        /// <param name="billingStyle"></param>
        /// <param name="cursor"></param>
        /// <param name="ownership"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PaginatedVoiceList> VoicesListAsync(
            global::Ultravox.VoicesListBillingStyle? billingStyle = default,
            string? cursor = default,
            global::Ultravox.VoicesListOwnership? ownership = default,
            int? pageSize = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}