
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoicesListProvider
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
    public static class VoicesListProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesListProvider value)
        {
            return value switch
            {
                VoicesListProvider.Lmnt => "lmnt",
                VoicesListProvider.Cartesia => "cartesia",
                VoicesListProvider.Google => "google",
                VoicesListProvider.ElevenLabs => "eleven_labs",
                VoicesListProvider.Inworld => "inworld",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesListProvider? ToEnum(string value)
        {
            return value switch
            {
                "lmnt" => VoicesListProvider.Lmnt,
                "cartesia" => VoicesListProvider.Cartesia,
                "google" => VoicesListProvider.Google,
                "eleven_labs" => VoicesListProvider.ElevenLabs,
                "inworld" => VoicesListProvider.Inworld,
                _ => null,
            };
        }
    }
}