
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Trigger
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerId")]
        public global::System.Guid TriggerId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// A rule that sends data messages into a call when an event occurs and a condition is met.<br/>
        ///  Triggers run shortly after their events, in the order the events occur, so their actions<br/>
        ///  may interleave with other activity in the call. If one of its conditions can't be<br/>
        ///  evaluated, that run of the trigger stops, and a trigger whose runs fail three times in a<br/>
        ///  row is dropped for the rest of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.UltravoxV1Trigger Trigger1 { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.OwnershipEnumJsonConverter))]
        public global::Ultravox.OwnershipEnum Ownership { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        /// <param name="trigger1">
        /// A rule that sends data messages into a call when an event occurs and a condition is met.<br/>
        ///  Triggers run shortly after their events, in the order the events occur, so their actions<br/>
        ///  may interleave with other activity in the call. If one of its conditions can't be<br/>
        ///  evaluated, that run of the trigger stops, and a trigger whose runs fail three times in a<br/>
        ///  row is dropped for the rest of the call.
        /// </param>
        /// <param name="triggerId">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="ownership">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Trigger(
            global::Ultravox.UltravoxV1Trigger trigger1,
            global::System.Guid triggerId = default!,
            global::System.DateTime created = default!,
            global::Ultravox.OwnershipEnum ownership = default!)
        {
            this.TriggerId = triggerId;
            this.Created = created;
            this.Trigger1 = trigger1 ?? throw new global::System.ArgumentNullException(nameof(trigger1));
            this.Ownership = ownership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        public Trigger()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Trigger"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static Trigger FromTrigger1(global::Ultravox.UltravoxV1Trigger trigger1)
        {
            return new Trigger
            {
                Trigger1 = trigger1,
            };
        }

    }
}