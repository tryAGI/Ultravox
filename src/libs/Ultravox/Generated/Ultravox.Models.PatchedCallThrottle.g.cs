
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedCallThrottle
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttleId")]
        public global::System.Guid? ThrottleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottleRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCallThrottle" /> class.
        /// </summary>
        /// <param name="throttleId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedCallThrottle(
            global::System.Guid? throttleId,
            string? name,
            global::System.DateTime? created,
            global::System.Collections.Generic.IList<global::Ultravox.CallThrottleRule>? rules)
        {
            this.ThrottleId = throttleId;
            this.Name = name;
            this.Created = created;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCallThrottle" /> class.
        /// </summary>
        public PatchedCallThrottle()
        {
        }

    }
}