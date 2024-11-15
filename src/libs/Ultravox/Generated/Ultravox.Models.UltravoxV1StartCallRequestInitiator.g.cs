
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Who was responsible for staring this call. Typically set to agent for outgoing calls and left as the default (user) otherwise.<br/>
    ///  DEPRECATED: Use first_speaker instead. Will be removed in November 2024.
    /// </summary>
    public enum UltravoxV1StartCallRequestInitiator
    {
        /// <summary>
        /// 
        /// </summary>
        INITIATORUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        INITIATORUSER,
        /// <summary>
        /// 
        /// </summary>
        INITIATORAGENT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1StartCallRequestInitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartCallRequestInitiator value)
        {
            return value switch
            {
                UltravoxV1StartCallRequestInitiator.INITIATORUNSPECIFIED => "INITIATOR_UNSPECIFIED",
                UltravoxV1StartCallRequestInitiator.INITIATORUSER => "INITIATOR_USER",
                UltravoxV1StartCallRequestInitiator.INITIATORAGENT => "INITIATOR_AGENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartCallRequestInitiator? ToEnum(string value)
        {
            return value switch
            {
                "INITIATOR_UNSPECIFIED" => UltravoxV1StartCallRequestInitiator.INITIATORUNSPECIFIED,
                "INITIATOR_USER" => UltravoxV1StartCallRequestInitiator.INITIATORUSER,
                "INITIATOR_AGENT" => UltravoxV1StartCallRequestInitiator.INITIATORAGENT,
                _ => null,
            };
        }
    }
}