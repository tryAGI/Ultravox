
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Changes to an agent's triggers for one call. The call's triggers are the agent's, in<br/>
    ///  their order and without those removed, followed by those added.
    /// </summary>
    public sealed partial class UltravoxV1TriggerOverrides
    {
        /// <summary>
        /// The names of the agent's triggers to remove. May not be set together with removeAll.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove")]
        public global::System.Collections.Generic.IList<string>? Remove { get; set; }

        /// <summary>
        /// If true, all of the agent's triggers are removed. May not be set together with remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeAll")]
        public bool? RemoveAll { get; set; }

        /// <summary>
        /// Triggers to add. Their names may not match those of the agent's triggers that remain,<br/>
        ///  so replacing one of the agent's triggers requires removing it too.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTrigger>? Add { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerOverrides" /> class.
        /// </summary>
        /// <param name="remove">
        /// The names of the agent's triggers to remove. May not be set together with removeAll.
        /// </param>
        /// <param name="removeAll">
        /// If true, all of the agent's triggers are removed. May not be set together with remove.
        /// </param>
        /// <param name="add">
        /// Triggers to add. Their names may not match those of the agent's triggers that remain,<br/>
        ///  so replacing one of the agent's triggers requires removing it too.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerOverrides(
            global::System.Collections.Generic.IList<string>? remove,
            bool? removeAll,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTrigger>? add)
        {
            this.Remove = remove;
            this.RemoveAll = removeAll;
            this.Add = add;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerOverrides" /> class.
        /// </summary>
        public UltravoxV1TriggerOverrides()
        {
        }

    }
}