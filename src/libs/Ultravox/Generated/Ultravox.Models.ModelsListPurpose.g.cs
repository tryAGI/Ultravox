
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Default Value: generation
    /// </summary>
    public enum ModelsListPurpose
    {
        /// <summary>
        /// generation for a call's model, or thread for models that the call's threads can use.
        /// </summary>
        Generation,
        /// <summary>
        /// generation for a call's model, or thread for models that the call's threads can use.
        /// </summary>
        Thread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsListPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsListPurpose value)
        {
            return value switch
            {
                ModelsListPurpose.Generation => "generation",
                ModelsListPurpose.Thread => "thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsListPurpose? ToEnum(string value)
        {
            return value switch
            {
                "generation" => ModelsListPurpose.Generation,
                "thread" => ModelsListPurpose.Thread,
                _ => null,
            };
        }
    }
}