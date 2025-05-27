
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `paid` - paid<br/>
    /// * `unpaid` - unpaid
    /// </summary>
    public enum InvoiceStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Paid,
        /// <summary>
        /// 
        /// </summary>
        Unpaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvoiceStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvoiceStatusEnum value)
        {
            return value switch
            {
                InvoiceStatusEnum.Paid => "paid",
                InvoiceStatusEnum.Unpaid => "unpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvoiceStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "paid" => InvoiceStatusEnum.Paid,
                "unpaid" => InvoiceStatusEnum.Unpaid,
                _ => null,
            };
        }
    }
}