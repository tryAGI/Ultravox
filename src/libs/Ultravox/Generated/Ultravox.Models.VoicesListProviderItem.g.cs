
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `lmnt` - LMNT<br/>
    /// * `cartesia` - Cartesia<br/>
    /// * `google` - Google<br/>
    /// * `respeecher` - Respeecher<br/>
    /// * `eleven_labs` - Eleven Labs<br/>
    /// * `inworld` - Inworld
    /// </summary>
    public enum VoicesListProviderItem
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        ElevenLabs,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        Respeecher,
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
                VoicesListProviderItem.Cartesia => "cartesia",
                VoicesListProviderItem.ElevenLabs => "eleven_labs",
                VoicesListProviderItem.Google => "google",
                VoicesListProviderItem.Inworld => "inworld",
                VoicesListProviderItem.Lmnt => "lmnt",
                VoicesListProviderItem.Respeecher => "respeecher",
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
                "cartesia" => VoicesListProviderItem.Cartesia,
                "eleven_labs" => VoicesListProviderItem.ElevenLabs,
                "google" => VoicesListProviderItem.Google,
                "inworld" => VoicesListProviderItem.Inworld,
                "lmnt" => VoicesListProviderItem.Lmnt,
                "respeecher" => VoicesListProviderItem.Respeecher,
                _ => null,
            };
        }
    }
}