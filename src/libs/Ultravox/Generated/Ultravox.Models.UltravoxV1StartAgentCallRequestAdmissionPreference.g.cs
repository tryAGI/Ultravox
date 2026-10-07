
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The (overridden) admission preference for the call.
    /// </summary>
    public enum UltravoxV1StartAgentCallRequestAdmissionPreference
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
    public static class UltravoxV1StartAgentCallRequestAdmissionPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartAgentCallRequestAdmissionPreference value)
        {
            return value switch
            {
                UltravoxV1StartAgentCallRequestAdmissionPreference.CallAdmissionPreferenceLowestCost => "CALL_ADMISSION_PREFERENCE_LOWEST_COST",
                UltravoxV1StartAgentCallRequestAdmissionPreference.CallAdmissionPreferencePriority => "CALL_ADMISSION_PREFERENCE_PRIORITY",
                UltravoxV1StartAgentCallRequestAdmissionPreference.CallAdmissionPreferenceUnspecified => "CALL_ADMISSION_PREFERENCE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartAgentCallRequestAdmissionPreference? ToEnum(string value)
        {
            return value switch
            {
                "CALL_ADMISSION_PREFERENCE_LOWEST_COST" => UltravoxV1StartAgentCallRequestAdmissionPreference.CallAdmissionPreferenceLowestCost,
                "CALL_ADMISSION_PREFERENCE_PRIORITY" => UltravoxV1StartAgentCallRequestAdmissionPreference.CallAdmissionPreferencePriority,
                "CALL_ADMISSION_PREFERENCE_UNSPECIFIED" => UltravoxV1StartAgentCallRequestAdmissionPreference.CallAdmissionPreferenceUnspecified,
                _ => null,
            };
        }
    }
}