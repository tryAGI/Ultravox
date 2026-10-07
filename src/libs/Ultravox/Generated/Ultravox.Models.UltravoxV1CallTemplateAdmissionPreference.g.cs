
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The default admission preference for calls created with this agent.
    /// </summary>
    public enum UltravoxV1CallTemplateAdmissionPreference
    {
        /// <summary>
        ///
        /// </summary>
        CallAdmissionPreferenceLowestCost,
        /// <summary>
        ///
        /// </summary>
        CallAdmissionPreferencePriority,
        /// <summary>
        ///
        /// </summary>
        CallAdmissionPreferenceUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1CallTemplateAdmissionPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1CallTemplateAdmissionPreference value)
        {
            return value switch
            {
                UltravoxV1CallTemplateAdmissionPreference.CallAdmissionPreferenceLowestCost => "CALL_ADMISSION_PREFERENCE_LOWEST_COST",
                UltravoxV1CallTemplateAdmissionPreference.CallAdmissionPreferencePriority => "CALL_ADMISSION_PREFERENCE_PRIORITY",
                UltravoxV1CallTemplateAdmissionPreference.CallAdmissionPreferenceUnspecified => "CALL_ADMISSION_PREFERENCE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1CallTemplateAdmissionPreference? ToEnum(string value)
        {
            return value switch
            {
                "CALL_ADMISSION_PREFERENCE_LOWEST_COST" => UltravoxV1CallTemplateAdmissionPreference.CallAdmissionPreferenceLowestCost,
                "CALL_ADMISSION_PREFERENCE_PRIORITY" => UltravoxV1CallTemplateAdmissionPreference.CallAdmissionPreferencePriority,
                "CALL_ADMISSION_PREFERENCE_UNSPECIFIED" => UltravoxV1CallTemplateAdmissionPreference.CallAdmissionPreferenceUnspecified,
                _ => null,
            };
        }
    }
}