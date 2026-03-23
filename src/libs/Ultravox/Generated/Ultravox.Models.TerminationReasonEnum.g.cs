
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum TerminationReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        SipTerminationBusy,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationCanceled,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationDestinationUnavailable,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationInvalidNumber,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationNormal,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationRejected,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationTimeout,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerminationReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerminationReasonEnum value)
        {
            return value switch
            {
                TerminationReasonEnum.SipTerminationBusy => "SIP_TERMINATION_BUSY",
                TerminationReasonEnum.SipTerminationCanceled => "SIP_TERMINATION_CANCELED",
                TerminationReasonEnum.SipTerminationDestinationUnavailable => "SIP_TERMINATION_DESTINATION_UNAVAILABLE",
                TerminationReasonEnum.SipTerminationInvalidNumber => "SIP_TERMINATION_INVALID_NUMBER",
                TerminationReasonEnum.SipTerminationNormal => "SIP_TERMINATION_NORMAL",
                TerminationReasonEnum.SipTerminationRejected => "SIP_TERMINATION_REJECTED",
                TerminationReasonEnum.SipTerminationTimeout => "SIP_TERMINATION_TIMEOUT",
                TerminationReasonEnum.SipTerminationUnknown => "SIP_TERMINATION_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerminationReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "SIP_TERMINATION_BUSY" => TerminationReasonEnum.SipTerminationBusy,
                "SIP_TERMINATION_CANCELED" => TerminationReasonEnum.SipTerminationCanceled,
                "SIP_TERMINATION_DESTINATION_UNAVAILABLE" => TerminationReasonEnum.SipTerminationDestinationUnavailable,
                "SIP_TERMINATION_INVALID_NUMBER" => TerminationReasonEnum.SipTerminationInvalidNumber,
                "SIP_TERMINATION_NORMAL" => TerminationReasonEnum.SipTerminationNormal,
                "SIP_TERMINATION_REJECTED" => TerminationReasonEnum.SipTerminationRejected,
                "SIP_TERMINATION_TIMEOUT" => TerminationReasonEnum.SipTerminationTimeout,
                "SIP_TERMINATION_UNKNOWN" => TerminationReasonEnum.SipTerminationUnknown,
                _ => null,
            };
        }
    }
}