
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// For JSON responses, how audio bytes are encoded into the json_audio_field_path string.<br/>
    ///  Defaults to base64. Also supports hex.
    /// </summary>
    public enum UltravoxV1GenericVoiceJsonByteEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        JsonByteEncodingUnspecified,
        /// <summary>
        /// 
        /// </summary>
        JsonByteEncodingBase64,
        /// <summary>
        /// 
        /// </summary>
        JsonByteEncodingHex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1GenericVoiceJsonByteEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1GenericVoiceJsonByteEncoding value)
        {
            return value switch
            {
                UltravoxV1GenericVoiceJsonByteEncoding.JsonByteEncodingUnspecified => "JSON_BYTE_ENCODING_UNSPECIFIED",
                UltravoxV1GenericVoiceJsonByteEncoding.JsonByteEncodingBase64 => "JSON_BYTE_ENCODING_BASE64",
                UltravoxV1GenericVoiceJsonByteEncoding.JsonByteEncodingHex => "JSON_BYTE_ENCODING_HEX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1GenericVoiceJsonByteEncoding? ToEnum(string value)
        {
            return value switch
            {
                "JSON_BYTE_ENCODING_UNSPECIFIED" => UltravoxV1GenericVoiceJsonByteEncoding.JsonByteEncodingUnspecified,
                "JSON_BYTE_ENCODING_BASE64" => UltravoxV1GenericVoiceJsonByteEncoding.JsonByteEncodingBase64,
                "JSON_BYTE_ENCODING_HEX" => UltravoxV1GenericVoiceJsonByteEncoding.JsonByteEncodingHex,
                _ => null,
            };
        }
    }
}