
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `unjoined` - Client never joined<br/>
    /// * `hangup` - Client hung up<br/>
    /// * `timeout` - Call timed out
    /// </summary>
    public enum EndReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Unjoined,
        /// <summary>
        /// 
        /// </summary>
        Hangup,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndReasonEnum value)
        {
            return value switch
            {
                EndReasonEnum.Unjoined => "unjoined",
                EndReasonEnum.Hangup => "hangup",
                EndReasonEnum.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "unjoined" => EndReasonEnum.Unjoined,
                "hangup" => EndReasonEnum.Hangup,
                "timeout" => EndReasonEnum.Timeout,
                _ => null,
            };
        }
    }
}