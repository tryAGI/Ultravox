
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
        SipTerminationNormal,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationInvalidNumber,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationTimeout,
        /// <summary>
        /// 
        /// </summary>
        SipTerminationDestinationUnavailable,
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
        SipTerminationRejected,
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
                TerminationReasonEnum.SipTerminationNormal => "SIP_TERMINATION_NORMAL",
                TerminationReasonEnum.SipTerminationInvalidNumber => "SIP_TERMINATION_INVALID_NUMBER",
                TerminationReasonEnum.SipTerminationTimeout => "SIP_TERMINATION_TIMEOUT",
                TerminationReasonEnum.SipTerminationDestinationUnavailable => "SIP_TERMINATION_DESTINATION_UNAVAILABLE",
                TerminationReasonEnum.SipTerminationBusy => "SIP_TERMINATION_BUSY",
                TerminationReasonEnum.SipTerminationCanceled => "SIP_TERMINATION_CANCELED",
                TerminationReasonEnum.SipTerminationRejected => "SIP_TERMINATION_REJECTED",
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
                "SIP_TERMINATION_NORMAL" => TerminationReasonEnum.SipTerminationNormal,
                "SIP_TERMINATION_INVALID_NUMBER" => TerminationReasonEnum.SipTerminationInvalidNumber,
                "SIP_TERMINATION_TIMEOUT" => TerminationReasonEnum.SipTerminationTimeout,
                "SIP_TERMINATION_DESTINATION_UNAVAILABLE" => TerminationReasonEnum.SipTerminationDestinationUnavailable,
                "SIP_TERMINATION_BUSY" => TerminationReasonEnum.SipTerminationBusy,
                "SIP_TERMINATION_CANCELED" => TerminationReasonEnum.SipTerminationCanceled,
                "SIP_TERMINATION_REJECTED" => TerminationReasonEnum.SipTerminationRejected,
                "SIP_TERMINATION_UNKNOWN" => TerminationReasonEnum.SipTerminationUnknown,
                _ => null,
            };
        }
    }
}