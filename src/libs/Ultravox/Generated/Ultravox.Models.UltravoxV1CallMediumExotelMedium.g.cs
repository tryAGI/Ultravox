
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for a Exotel call.
    /// </summary>
    public sealed partial class UltravoxV1CallMediumExotelMedium
    {
        /// <summary>
        /// Controls how DTMF digits received during the call are handled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtmfHandling")]
        public global::Ultravox.UltravoxV1CallMediumDtmfHandling? DtmfHandling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumExotelMedium" /> class.
        /// </summary>
        /// <param name="dtmfHandling">
        /// Controls how DTMF digits received during the call are handled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallMediumExotelMedium(
            global::Ultravox.UltravoxV1CallMediumDtmfHandling? dtmfHandling)
        {
            this.DtmfHandling = dtmfHandling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumExotelMedium" /> class.
        /// </summary>
        public UltravoxV1CallMediumExotelMedium()
        {
        }

    }
}