// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Resources;

#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET

    /// <summary>
    ///     为 <see cref="DateTime" /> 类型提供的扩展方法。
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        ///     获取 <paramref name="dateTime" /> 的描述信息。
        /// </summary>
        /// <param name="dateTime">
        ///     <see cref="DateTime" /> 类型的值。
        /// </param>
        /// <returns>
        ///     日期描述信息。
        /// </returns>
        /// <seealso cref="DateTime.UtcNow" />
        /// <seealso cref="TimeSpan" />
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public static string GetDescription(this DateTime dateTime)
        {
            var now = DateTime.UtcNow;
            var interval = now - dateTime;
            if (interval.TotalMilliseconds < 0 || (interval.TotalDays > 180 && dateTime.Year != now.Year))
            {
                return dateTime.ToString(SR.Format("DateExtensions_full_date {0}", null, "HH:mm"));
            }

            if (interval.TotalSeconds <= 60)
            {
                return SR.GetString("DateExtensions_just_now");
            }
            else if (interval.TotalMinutes <= 60)
            {
                return SR.Format("DateExtensions_a_few_minutes_ago", null, (int)interval.TotalMinutes);
            }
            else if (interval.TotalHours <= 24 && dateTime.Day == now.Day)
            {
                return dateTime.ToString("HH:mm");
            }
            else if (interval.TotalHours <= 24)
            {
                return SR.Format("DateExtensions_a_few_hours_ago", null, (int)interval.TotalHours);
            }
            else if (interval.TotalDays <= 180)
            {
                return SR.Format("DateExtensions_few_days_ago", null, (int)interval.TotalDays);
            }

            return dateTime.ToString(SR.GetString("DateExtensions_same_year"));
        }
    }

#endif
}