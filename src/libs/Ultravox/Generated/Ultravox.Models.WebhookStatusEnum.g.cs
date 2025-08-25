
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `normal` - NORMAL<br/>
    /// * `unhealthy` - UNHEALTHY
    /// </summary>
    public enum WebhookStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookStatusEnum value)
        {
            return value switch
            {
                WebhookStatusEnum.Normal => "normal",
                WebhookStatusEnum.Unhealthy => "unhealthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "normal" => WebhookStatusEnum.Normal,
                "unhealthy" => WebhookStatusEnum.Unhealthy,
                _ => null,
            };
        }
    }
}