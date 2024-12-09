
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedModelAliasList
    {
        /// <summary>
        /// Example: http://api.example.org/accounts/?cursor=cD00ODY%3D"
        /// </summary>
        /// <example>http://api.example.org/accounts/?cursor=cD00ODY%3D"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Example: http://api.example.org/accounts/?cursor=cj0xJnA9NDg3
        /// </summary>
        /// <example>http://api.example.org/accounts/?cursor=cj0xJnA9NDg3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ultravox.ModelAlias> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedModelAliasList" /> class.
        /// </summary>
        /// <param name="next">
        /// Example: http://api.example.org/accounts/?cursor=cD00ODY%3D"
        /// </param>
        /// <param name="previous">
        /// Example: http://api.example.org/accounts/?cursor=cj0xJnA9NDg3
        /// </param>
        /// <param name="results"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PaginatedModelAliasList(
            global::System.Collections.Generic.IList<global::Ultravox.ModelAlias> results,
            string? next,
            string? previous)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Next = next;
            this.Previous = previous;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedModelAliasList" /> class.
        /// </summary>
        public PaginatedModelAliasList()
        {
        }
    }
}