
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `priority` - Prioritize this call as much as possible<br/>
    /// * `lowest_cost` - Run this call as inexpensively as possible
    /// </summary>
    public enum AdmissionPreferenceEnum
    {
        /// <summary>
        ///
        /// </summary>
        LowestCost,
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdmissionPreferenceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdmissionPreferenceEnum value)
        {
            return value switch
            {
                AdmissionPreferenceEnum.LowestCost => "lowest_cost",
                AdmissionPreferenceEnum.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdmissionPreferenceEnum? ToEnum(string value)
        {
            return value switch
            {
                "lowest_cost" => AdmissionPreferenceEnum.LowestCost,
                "priority" => AdmissionPreferenceEnum.Priority,
                _ => null,
            };
        }
    }
}