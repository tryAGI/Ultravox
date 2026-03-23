
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Default Value: last_stage
    /// </summary>
    public enum CallsMessagesListMode
    {
        /// <summary>
        /// 
        /// </summary>
        InCall,
        /// <summary>
        /// 
        /// </summary>
        LastStage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallsMessagesListModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallsMessagesListMode value)
        {
            return value switch
            {
                CallsMessagesListMode.InCall => "in_call",
                CallsMessagesListMode.LastStage => "last_stage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallsMessagesListMode? ToEnum(string value)
        {
            return value switch
            {
                "in_call" => CallsMessagesListMode.InCall,
                "last_stage" => CallsMessagesListMode.LastStage,
                _ => null,
            };
        }
    }
}