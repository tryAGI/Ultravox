
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum SetOutputMediumPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        SetOutputMedium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SetOutputMediumPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetOutputMediumPayloadType value)
        {
            return value switch
            {
                SetOutputMediumPayloadType.SetOutputMedium => "set_output_medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetOutputMediumPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "set_output_medium" => SetOutputMediumPayloadType.SetOutputMedium,
                _ => null,
            };
        }
    }
}