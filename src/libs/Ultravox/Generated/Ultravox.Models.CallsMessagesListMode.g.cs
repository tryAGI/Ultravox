
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
        LastStage,
        /// <summary>
        /// 
        /// </summary>
        InCall,
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
                CallsMessagesListMode.LastStage => "last_stage",
                CallsMessagesListMode.InCall => "in_call",
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
                "last_stage" => CallsMessagesListMode.LastStage,
                "in_call" => CallsMessagesListMode.InCall,
                _ => null,
            };
        }
    }
}