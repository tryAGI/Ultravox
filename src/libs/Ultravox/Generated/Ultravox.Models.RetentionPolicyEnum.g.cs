
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `retain` - Retain indefinitely<br/>
    /// * `auto_delete` - Auto-delete after billing
    /// </summary>
    public enum RetentionPolicyEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AutoDelete,
        /// <summary>
        /// 
        /// </summary>
        Retain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionPolicyEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionPolicyEnum value)
        {
            return value switch
            {
                RetentionPolicyEnum.AutoDelete => "auto_delete",
                RetentionPolicyEnum.Retain => "retain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionPolicyEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto_delete" => RetentionPolicyEnum.AutoDelete,
                "retain" => RetentionPolicyEnum.Retain,
                _ => null,
            };
        }
    }
}