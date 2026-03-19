
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedSipRegistration
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registrationId")]
        public string? RegistrationId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The SIP username to register as.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

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
        public string? Proxy { get; set; }

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
        /// Whether the registration was successfully created and is now active. May be null if status is not available yet.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedSipRegistration" /> class.
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
        /// <param name="successful">
        /// Whether the registration was successfully created and is now active. May be null if status is not available yet.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedSipRegistration(
            string? registrationId,
            global::System.DateTime? created,
            string? username,
            string? password,
            string? proxy,
            string? outboundProxy,
            string? authUser,
            bool? successful)
        {
            this.RegistrationId = registrationId;
            this.Created = created;
            this.Username = username;
            this.Password = password;
            this.Proxy = proxy;
            this.OutboundProxy = outboundProxy;
            this.AuthUser = authUser;
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedSipRegistration" /> class.
        /// </summary>
        public PatchedSipRegistration()
        {
        }
    }
}