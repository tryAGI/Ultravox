
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Default Value: minute
    /// </summary>
    public enum AccountsMeUsageConcurrencyRetrieveBucket
    {
        /// <summary>
        /// 
        /// </summary>
        x5min,
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Minute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountsMeUsageConcurrencyRetrieveBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountsMeUsageConcurrencyRetrieveBucket value)
        {
            return value switch
            {
                AccountsMeUsageConcurrencyRetrieveBucket.x5min => "5min",
                AccountsMeUsageConcurrencyRetrieveBucket.Day => "day",
                AccountsMeUsageConcurrencyRetrieveBucket.Hour => "hour",
                AccountsMeUsageConcurrencyRetrieveBucket.Minute => "minute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountsMeUsageConcurrencyRetrieveBucket? ToEnum(string value)
        {
            return value switch
            {
                "5min" => AccountsMeUsageConcurrencyRetrieveBucket.x5min,
                "day" => AccountsMeUsageConcurrencyRetrieveBucket.Day,
                "hour" => AccountsMeUsageConcurrencyRetrieveBucket.Hour,
                "minute" => AccountsMeUsageConcurrencyRetrieveBucket.Minute,
                _ => null,
            };
        }
    }
}