
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A trigger to use in a call or an agent's calls.
    /// </summary>
    public sealed partial class UltravoxV1SelectedTrigger
    {
        /// <summary>
        /// A trigger defined only for this call or agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temporaryTrigger")]
        public global::Ultravox.UltravoxV1Trigger? TemporaryTrigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedTrigger" /> class.
        /// </summary>
        /// <param name="temporaryTrigger">
        /// A trigger defined only for this call or agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1SelectedTrigger(
            global::Ultravox.UltravoxV1Trigger? temporaryTrigger)
        {
            this.TemporaryTrigger = temporaryTrigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedTrigger" /> class.
        /// </summary>
        public UltravoxV1SelectedTrigger()
        {
        }

    }
}