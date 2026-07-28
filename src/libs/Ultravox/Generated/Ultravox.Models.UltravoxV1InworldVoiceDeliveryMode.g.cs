
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// How to balance consistency and expressiveness in generated speech. Only used by<br/>
    ///  inworld-tts-2 models (ignored for other models).<br/>
    ///  See https://docs.inworld.ai/api-reference/ttsAPI/texttospeech/synthesize-speech-stream#body-delivery-mode
    /// </summary>
    public enum UltravoxV1InworldVoiceDeliveryMode
    {
        /// <summary>
        /// 
        /// </summary>
        DeliveryModeBalanced,
        /// <summary>
        /// 
        /// </summary>
        DeliveryModeCreative,
        /// <summary>
        /// 
        /// </summary>
        DeliveryModeStable,
        /// <summary>
        /// 
        /// </summary>
        DeliveryModeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1InworldVoiceDeliveryModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1InworldVoiceDeliveryMode value)
        {
            return value switch
            {
                UltravoxV1InworldVoiceDeliveryMode.DeliveryModeBalanced => "DELIVERY_MODE_BALANCED",
                UltravoxV1InworldVoiceDeliveryMode.DeliveryModeCreative => "DELIVERY_MODE_CREATIVE",
                UltravoxV1InworldVoiceDeliveryMode.DeliveryModeStable => "DELIVERY_MODE_STABLE",
                UltravoxV1InworldVoiceDeliveryMode.DeliveryModeUnspecified => "DELIVERY_MODE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1InworldVoiceDeliveryMode? ToEnum(string value)
        {
            return value switch
            {
                "DELIVERY_MODE_BALANCED" => UltravoxV1InworldVoiceDeliveryMode.DeliveryModeBalanced,
                "DELIVERY_MODE_CREATIVE" => UltravoxV1InworldVoiceDeliveryMode.DeliveryModeCreative,
                "DELIVERY_MODE_STABLE" => UltravoxV1InworldVoiceDeliveryMode.DeliveryModeStable,
                "DELIVERY_MODE_UNSPECIFIED" => UltravoxV1InworldVoiceDeliveryMode.DeliveryModeUnspecified,
                _ => null,
            };
        }
    }
}