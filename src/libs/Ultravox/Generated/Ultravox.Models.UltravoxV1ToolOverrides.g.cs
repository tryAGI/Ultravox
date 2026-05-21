
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Overrides for a set of selected tools. Items in remove are applied before<br/>
    ///  items in add. Use remove + add for replacements.
    /// </summary>
    public sealed partial class UltravoxV1ToolOverrides
    {
        /// <summary>
        /// Tools to remove from the set, identified by their unique model-facing name<br/>
        ///  (i.e. nameOverride if set, otherwise modelToolName). May not be set<br/>
        ///  together with removeAll.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove")]
        public global::System.Collections.Generic.IList<string>? Remove { get; set; }

        /// <summary>
        /// If true, all existing tools are removed. May not be set together with<br/>
        ///  remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeAll")]
        public bool? RemoveAll { get; set; }

        /// <summary>
        /// Tools to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? Add { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ToolOverrides" /> class.
        /// </summary>
        /// <param name="remove">
        /// Tools to remove from the set, identified by their unique model-facing name<br/>
        ///  (i.e. nameOverride if set, otherwise modelToolName). May not be set<br/>
        ///  together with removeAll.
        /// </param>
        /// <param name="removeAll">
        /// If true, all existing tools are removed. May not be set together with<br/>
        ///  remove.
        /// </param>
        /// <param name="add">
        /// Tools to add.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1ToolOverrides(
            global::System.Collections.Generic.IList<string>? remove,
            bool? removeAll,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? add)
        {
            this.Remove = remove;
            this.RemoveAll = removeAll;
            this.Add = add;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ToolOverrides" /> class.
        /// </summary>
        public UltravoxV1ToolOverrides()
        {
        }

    }
}