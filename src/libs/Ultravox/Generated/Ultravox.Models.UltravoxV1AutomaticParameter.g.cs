
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A parameter that is automatically set by the system.
    /// </summary>
    public sealed partial class UltravoxV1AutomaticParameter
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Where the parameter is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterLocationJsonConverter))]
        public global::Ultravox.UltravoxV1AutomaticParameterLocation? Location { get; set; }

        /// <summary>
        /// The value to set for the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knownValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterKnownValueJsonConverter))]
        public global::Ultravox.UltravoxV1AutomaticParameterKnownValue? KnownValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1AutomaticParameter" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the parameter.
        /// </param>
        /// <param name="location">
        /// Where the parameter is used.
        /// </param>
        /// <param name="knownValue">
        /// The value to set for the parameter.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1AutomaticParameter(
            string? name,
            global::Ultravox.UltravoxV1AutomaticParameterLocation? location,
            global::Ultravox.UltravoxV1AutomaticParameterKnownValue? knownValue)
        {
            this.Name = name;
            this.Location = location;
            this.KnownValue = knownValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1AutomaticParameter" /> class.
        /// </summary>
        public UltravoxV1AutomaticParameter()
        {
        }
    }
}