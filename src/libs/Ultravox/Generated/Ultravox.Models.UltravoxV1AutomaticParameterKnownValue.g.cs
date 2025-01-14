
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The value to set for the parameter.
    /// </summary>
    public enum UltravoxV1AutomaticParameterKnownValue
    {
        /// <summary>
        /// 
        /// </summary>
        KNOWNPARAMUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        KNOWNPARAMCALLID,
        /// <summary>
        /// 
        /// </summary>
        KNOWNPARAMCONVERSATIONHISTORY,
        /// <summary>
        /// 
        /// </summary>
        KNOWNPARAMOUTPUTSAMPLERATE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1AutomaticParameterKnownValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1AutomaticParameterKnownValue value)
        {
            return value switch
            {
                UltravoxV1AutomaticParameterKnownValue.KNOWNPARAMUNSPECIFIED => "KNOWN_PARAM_UNSPECIFIED",
                UltravoxV1AutomaticParameterKnownValue.KNOWNPARAMCALLID => "KNOWN_PARAM_CALL_ID",
                UltravoxV1AutomaticParameterKnownValue.KNOWNPARAMCONVERSATIONHISTORY => "KNOWN_PARAM_CONVERSATION_HISTORY",
                UltravoxV1AutomaticParameterKnownValue.KNOWNPARAMOUTPUTSAMPLERATE => "KNOWN_PARAM_OUTPUT_SAMPLE_RATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1AutomaticParameterKnownValue? ToEnum(string value)
        {
            return value switch
            {
                "KNOWN_PARAM_UNSPECIFIED" => UltravoxV1AutomaticParameterKnownValue.KNOWNPARAMUNSPECIFIED,
                "KNOWN_PARAM_CALL_ID" => UltravoxV1AutomaticParameterKnownValue.KNOWNPARAMCALLID,
                "KNOWN_PARAM_CONVERSATION_HISTORY" => UltravoxV1AutomaticParameterKnownValue.KNOWNPARAMCONVERSATIONHISTORY,
                "KNOWN_PARAM_OUTPUT_SAMPLE_RATE" => UltravoxV1AutomaticParameterKnownValue.KNOWNPARAMOUTPUTSAMPLERATE,
                _ => null,
            };
        }
    }
}