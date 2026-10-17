
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public enum VoicesListReplacementStatus
    {
        /// <summary>
        ///
        /// </summary>
        Replaced,
        /// <summary>
        ///
        /// </summary>
        Replacement,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesListReplacementStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesListReplacementStatus value)
        {
            return value switch
            {
                VoicesListReplacementStatus.Replaced => "replaced",
                VoicesListReplacementStatus.Replacement => "replacement",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesListReplacementStatus? ToEnum(string value)
        {
            return value switch
            {
                "replaced" => VoicesListReplacementStatus.Replaced,
                "replacement" => VoicesListReplacementStatus.Replacement,
                _ => null,
            };
        }
    }
}