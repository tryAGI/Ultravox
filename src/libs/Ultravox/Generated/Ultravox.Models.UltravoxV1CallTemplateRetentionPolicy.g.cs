
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The default retention policy for calls created with this agent.
    /// </summary>
    public enum UltravoxV1CallTemplateRetentionPolicy
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
    public static class UltravoxV1CallTemplateRetentionPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1CallTemplateRetentionPolicy value)
        {
            return value switch
            {
                UltravoxV1CallTemplateRetentionPolicy.CallRetentionPolicyUnspecified => "CALL_RETENTION_POLICY_UNSPECIFIED",
                UltravoxV1CallTemplateRetentionPolicy.CallRetentionPolicyRetain => "CALL_RETENTION_POLICY_RETAIN",
                UltravoxV1CallTemplateRetentionPolicy.CallRetentionPolicyAutoDelete => "CALL_RETENTION_POLICY_AUTO_DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1CallTemplateRetentionPolicy? ToEnum(string value)
        {
            return value switch
            {
                "CALL_RETENTION_POLICY_UNSPECIFIED" => UltravoxV1CallTemplateRetentionPolicy.CallRetentionPolicyUnspecified,
                "CALL_RETENTION_POLICY_RETAIN" => UltravoxV1CallTemplateRetentionPolicy.CallRetentionPolicyRetain,
                "CALL_RETENTION_POLICY_AUTO_DELETE" => UltravoxV1CallTemplateRetentionPolicy.CallRetentionPolicyAutoDelete,
                _ => null,
            };
        }
    }
}