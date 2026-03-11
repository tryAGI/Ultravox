
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SipRegistration
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("registrationId")]
        public string RegistrationId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// The SIP username to register as.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Username { get; set; } = default!;

        /// <summary>
        /// The SIP password for username.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// The SIP server to register with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Proxy { get; set; } = default!;

        /// <summary>
        /// A proxy used to reach your SIP server for registration. Most often unset, but may be used if you need to register as `alice@trunk.com` using `proxy.trunk.com` for example.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outboundProxy")]
        public string? OutboundProxy { get; set; }

        /// <summary>
        /// The authentication username, if different from the SIP username. Most often unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authUser")]
        public string? AuthUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipRegistration" /> class.
        /// </summary>
        /// <param name="registrationId">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="username">
        /// The SIP username to register as.
        /// </param>
        /// <param name="password">
        /// The SIP password for username.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="proxy">
        /// The SIP server to register with.
        /// </param>
        /// <param name="outboundProxy">
        /// A proxy used to reach your SIP server for registration. Most often unset, but may be used if you need to register as `alice@trunk.com` using `proxy.trunk.com` for example.
        /// </param>
        /// <param name="authUser">
        /// The authentication username, if different from the SIP username. Most often unset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SipRegistration(
            string username,
            string proxy,
            string? password,
            string? outboundProxy,
            string? authUser,
            string registrationId = default!,
            global::System.DateTime created = default!)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Proxy = proxy ?? throw new global::System.ArgumentNullException(nameof(proxy));
            this.RegistrationId = registrationId;
            this.Created = created;
            this.Password = password;
            this.OutboundProxy = outboundProxy;
            this.AuthUser = authUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipRegistration" /> class.
        /// </summary>
        public SipRegistration()
        {
        }
    }
}