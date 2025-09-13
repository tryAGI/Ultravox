
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `lmnt` - LMNT<br/>
    /// * `cartesia` - Cartesia<br/>
    /// * `google` - Google<br/>
    /// * `eleven_labs` - Eleven Labs<br/>
    /// * `inworld` - Inworld
    /// </summary>
    public enum VoicesListProviderItem
    {
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        ElevenLabs,
        /// <summary>
        /// 
        /// </summary>
        Inworld,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesListProviderItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesListProviderItem value)
        {
            return value switch
            {
                VoicesListProviderItem.Lmnt => "lmnt",
                VoicesListProviderItem.Cartesia => "cartesia",
                VoicesListProviderItem.Google => "google",
                VoicesListProviderItem.ElevenLabs => "eleven_labs",
                VoicesListProviderItem.Inworld => "inworld",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesListProviderItem? ToEnum(string value)
        {
            return value switch
            {
                "lmnt" => VoicesListProviderItem.Lmnt,
                "cartesia" => VoicesListProviderItem.Cartesia,
                "google" => VoicesListProviderItem.Google,
                "eleven_labs" => VoicesListProviderItem.ElevenLabs,
                "inworld" => VoicesListProviderItem.Inworld,
                _ => null,
            };
        }
    }
}