#nullable enable

namespace Ultravox
{
    public partial interface ISipClient
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task SipRegistrationsDestroyAsync(
            string registrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}