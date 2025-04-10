
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for an outgoing SIP call.
    /// </summary>
    public sealed partial class UltravoxV1SipMediumSipOutgoing
    {
        /// <summary>
        /// The SIP URI to connect to. (Phone numbers are not allowed.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// The SIP URI to connect from. This is the "from" field in the SIP INVITE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The SIP username to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The password for the specified username.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SipMediumSipOutgoing" /> class.
        /// </summary>
        /// <param name="to">
        /// The SIP URI to connect to. (Phone numbers are not allowed.)
        /// </param>
        /// <param name="from">
        /// The SIP URI to connect from. This is the "from" field in the SIP INVITE.
        /// </param>
        /// <param name="username">
        /// The SIP username to use for authentication.
        /// </param>
        /// <param name="password">
        /// The password for the specified username.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1SipMediumSipOutgoing(
            string? to,
            string? from,
            string? username,
            string? password)
        {
            this.To = to;
            this.From = from;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SipMediumSipOutgoing" /> class.
        /// </summary>
        public UltravoxV1SipMediumSipOutgoing()
        {
        }
    }
}