// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace System
{
    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     为 <see cref="DateTime" /> 类型提供的扩展方法。
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        ///     获取日期时间的描述信息。
        /// </summary>
        /// <param name="dateTime">
        ///     可为空的 <see cref="DateTime" /> 类型的值。
        /// </param>
        /// <returns>
        ///     描述信息。
        /// </returns>
        /// <seealso cref="DateTime" />
        /// <seealso cref="Nullable{T}" />
        /// <exception cref="FormatException">
        ///     当调用 <see cref="DateTime.ToString(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public static string GetDescription(this DateTime? dateTime)
        {
            if (!dateTime.HasValue) return "-";
            var interval = DateTime.UtcNow - dateTime.Value;
            if (interval.TotalMilliseconds <= 0) return dateTime.Value.ToString(Strings.DateTime_formatter);
            if (interval.TotalSeconds <= 60) return Strings.Just_now;
            if (interval.TotalMinutes < 60) return string.Format(Strings.An_hour_ago, (int)interval.TotalMinutes);
            if (interval.TotalHours < 24) return string.Format(Strings.A_day_ago, (int)interval.TotalHours);
            if (interval.TotalDays < 180) return string.Format(Strings.Several_days_ago, (int)interval.TotalDays);
            return dateTime.Value.Year == DateTime.UtcNow.Year
                ? dateTime.Value.ToString(Strings.Same_year)
                : dateTime.Value.ToString(Strings.DateTime_formatter);
        }
    }
}