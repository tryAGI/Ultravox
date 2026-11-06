
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallTrigger
    {
        /// <summary>
        /// The ID of the existing trigger the call or its agent selected. Null for triggers defined in the call or agent itself.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerId")]
        public global::System.Guid? TriggerId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public global::Ultravox.UltravoxV1Trigger Trigger { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallTrigger" /> class.
        /// </summary>
        /// <param name="triggerId">
        /// The ID of the existing trigger the call or its agent selected. Null for triggers defined in the call or agent itself.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="trigger">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallTrigger(
            global::System.Guid? triggerId,
            global::Ultravox.UltravoxV1Trigger trigger = default!)
        {
            this.TriggerId = triggerId;
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallTrigger" /> class.
        /// </summary>
        public CallTrigger()
        {
        }

    }
}