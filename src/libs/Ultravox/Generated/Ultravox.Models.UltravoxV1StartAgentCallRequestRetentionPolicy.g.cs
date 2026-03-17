
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The (overridden) retention policy for the call's data after it ends.
    /// </summary>
    public enum UltravoxV1StartAgentCallRequestRetentionPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        CallRetentionPolicyUnspecified,
        /// <summary>
        /// 
        /// </summary>
        CallRetentionPolicyRetain,
        /// <summary>
        /// 
        /// </summary>
        CallRetentionPolicyAutoDelete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1StartAgentCallRequestRetentionPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartAgentCallRequestRetentionPolicy value)
        {
            return value switch
            {
                UltravoxV1StartAgentCallRequestRetentionPolicy.CallRetentionPolicyUnspecified => "CALL_RETENTION_POLICY_UNSPECIFIED",
                UltravoxV1StartAgentCallRequestRetentionPolicy.CallRetentionPolicyRetain => "CALL_RETENTION_POLICY_RETAIN",
                UltravoxV1StartAgentCallRequestRetentionPolicy.CallRetentionPolicyAutoDelete => "CALL_RETENTION_POLICY_AUTO_DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartAgentCallRequestRetentionPolicy? ToEnum(string value)
        {
            return value switch
            {
                "CALL_RETENTION_POLICY_UNSPECIFIED" => UltravoxV1StartAgentCallRequestRetentionPolicy.CallRetentionPolicyUnspecified,
                "CALL_RETENTION_POLICY_RETAIN" => UltravoxV1StartAgentCallRequestRetentionPolicy.CallRetentionPolicyRetain,
                "CALL_RETENTION_POLICY_AUTO_DELETE" => UltravoxV1StartAgentCallRequestRetentionPolicy.CallRetentionPolicyAutoDelete,
                _ => null,
            };
        }
    }
}