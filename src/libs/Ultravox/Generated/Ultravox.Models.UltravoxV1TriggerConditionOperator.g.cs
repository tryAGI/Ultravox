
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// How the condition is evaluated.
    /// </summary>
    public enum UltravoxV1TriggerConditionOperator
    {
        /// <summary>
        ///
        /// </summary>
        OperatorAnd,
        /// <summary>
        ///
        /// </summary>
        OperatorEq,
        /// <summary>
        ///
        /// </summary>
        OperatorGt,
        /// <summary>
        ///
        /// </summary>
        OperatorGte,
        /// <summary>
        ///
        /// </summary>
        OperatorLt,
        /// <summary>
        ///
        /// </summary>
        OperatorLte,
        /// <summary>
        ///
        /// </summary>
        OperatorNeq,
        /// <summary>
        ///
        /// </summary>
        OperatorOr,
        /// <summary>
        ///
        /// </summary>
        OperatorUnspecified,
        /// <summary>
        ///
        /// </summary>
        OperatorXor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1TriggerConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1TriggerConditionOperator value)
        {
            return value switch
            {
                UltravoxV1TriggerConditionOperator.OperatorAnd => "OPERATOR_AND",
                UltravoxV1TriggerConditionOperator.OperatorEq => "OPERATOR_EQ",
                UltravoxV1TriggerConditionOperator.OperatorGt => "OPERATOR_GT",
                UltravoxV1TriggerConditionOperator.OperatorGte => "OPERATOR_GTE",
                UltravoxV1TriggerConditionOperator.OperatorLt => "OPERATOR_LT",
                UltravoxV1TriggerConditionOperator.OperatorLte => "OPERATOR_LTE",
                UltravoxV1TriggerConditionOperator.OperatorNeq => "OPERATOR_NEQ",
                UltravoxV1TriggerConditionOperator.OperatorOr => "OPERATOR_OR",
                UltravoxV1TriggerConditionOperator.OperatorUnspecified => "OPERATOR_UNSPECIFIED",
                UltravoxV1TriggerConditionOperator.OperatorXor => "OPERATOR_XOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1TriggerConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "OPERATOR_AND" => UltravoxV1TriggerConditionOperator.OperatorAnd,
                "OPERATOR_EQ" => UltravoxV1TriggerConditionOperator.OperatorEq,
                "OPERATOR_GT" => UltravoxV1TriggerConditionOperator.OperatorGt,
                "OPERATOR_GTE" => UltravoxV1TriggerConditionOperator.OperatorGte,
                "OPERATOR_LT" => UltravoxV1TriggerConditionOperator.OperatorLt,
                "OPERATOR_LTE" => UltravoxV1TriggerConditionOperator.OperatorLte,
                "OPERATOR_NEQ" => UltravoxV1TriggerConditionOperator.OperatorNeq,
                "OPERATOR_OR" => UltravoxV1TriggerConditionOperator.OperatorOr,
                "OPERATOR_UNSPECIFIED" => UltravoxV1TriggerConditionOperator.OperatorUnspecified,
                "OPERATOR_XOR" => UltravoxV1TriggerConditionOperator.OperatorXor,
                _ => null,
            };
        }
    }
}