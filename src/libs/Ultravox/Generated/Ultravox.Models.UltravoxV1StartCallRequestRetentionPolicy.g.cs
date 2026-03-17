
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The retention policy for the call's data after it ends.<br/>
    ///  This feature must be enabled for your account.
    /// </summary>
    public enum UltravoxV1StartCallRequestRetentionPolicy
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
    public static class UltravoxV1StartCallRequestRetentionPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartCallRequestRetentionPolicy value)
        {
            return value switch
            {
                UltravoxV1StartCallRequestRetentionPolicy.CallRetentionPolicyUnspecified => "CALL_RETENTION_POLICY_UNSPECIFIED",
                UltravoxV1StartCallRequestRetentionPolicy.CallRetentionPolicyRetain => "CALL_RETENTION_POLICY_RETAIN",
                UltravoxV1StartCallRequestRetentionPolicy.CallRetentionPolicyAutoDelete => "CALL_RETENTION_POLICY_AUTO_DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartCallRequestRetentionPolicy? ToEnum(string value)
        {
            return value switch
            {
                "CALL_RETENTION_POLICY_UNSPECIFIED" => UltravoxV1StartCallRequestRetentionPolicy.CallRetentionPolicyUnspecified,
                "CALL_RETENTION_POLICY_RETAIN" => UltravoxV1StartCallRequestRetentionPolicy.CallRetentionPolicyRetain,
                "CALL_RETENTION_POLICY_AUTO_DELETE" => UltravoxV1StartCallRequestRetentionPolicy.CallRetentionPolicyAutoDelete,
                _ => null,
            };
        }
    }
}