
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Whether a call's admission should prioritize fulfillment or cost.<br/>
    ///  This feature must be enabled for your account.
    /// </summary>
    public enum UltravoxV1StartCallRequestAdmissionPreference
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
    public static class UltravoxV1StartCallRequestAdmissionPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartCallRequestAdmissionPreference value)
        {
            return value switch
            {
                UltravoxV1StartCallRequestAdmissionPreference.CallAdmissionPreferenceLowestCost => "CALL_ADMISSION_PREFERENCE_LOWEST_COST",
                UltravoxV1StartCallRequestAdmissionPreference.CallAdmissionPreferencePriority => "CALL_ADMISSION_PREFERENCE_PRIORITY",
                UltravoxV1StartCallRequestAdmissionPreference.CallAdmissionPreferenceUnspecified => "CALL_ADMISSION_PREFERENCE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartCallRequestAdmissionPreference? ToEnum(string value)
        {
            return value switch
            {
                "CALL_ADMISSION_PREFERENCE_LOWEST_COST" => UltravoxV1StartCallRequestAdmissionPreference.CallAdmissionPreferenceLowestCost,
                "CALL_ADMISSION_PREFERENCE_PRIORITY" => UltravoxV1StartCallRequestAdmissionPreference.CallAdmissionPreferencePriority,
                "CALL_ADMISSION_PREFERENCE_UNSPECIFIED" => UltravoxV1StartCallRequestAdmissionPreference.CallAdmissionPreferenceUnspecified,
                _ => null,
            };
        }
    }
}