/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using Disco.Resources;

  using System;

  /// <summary>
  ///   为 <see cref="DateTime" /> 类型提供了扩展方法。
  /// </summary>
  public static class DateTimeExtensions
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="me" /> 晚于 <paramref name="b" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="DateTime" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   可能为空的 <see cref="DateTime" /> 类型值。
    ///   <para>
    ///     当 <c> <paramref name="b" />.HasValue </c> 等于 <see langword="false" /> 时，将使用 <see cref="DateTime.UtcNow" />。
    ///   </para>
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 晚于 <paramref name="b" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool After(this DateTime me, DateTime? b = null)
    {
      return (me - b.DefaultIf(DateTime.UtcNow)).TotalSeconds.GreaterThanOrEquals();
    }

    /// <summary>
    ///   当 <paramref name="me" /> 早于 <paramref name="b" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="DateTime" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   可能为空的 <see cref="DateTime" /> 类型值。
    ///   <para>
    ///     当 <c> <paramref name="b" />.HasValue </c> 等于 <see langword="false" /> 时，将使用 <see cref="DateTime.UtcNow" />。
    ///   </para>
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 早于 <paramref name="b" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool Before(this DateTime me, DateTime? b = null)
    {
      return (me - b.DefaultIf(DateTime.UtcNow)).TotalSeconds.LessThanOrEquals();
    }

    /// <summary>
    ///   当 <c> <paramref name="me" />.HasValue </c> 等于 <see langword="true" /> 时，返回 <c> <paramref name="me" />.Value </c>；否则返回
    ///   <paramref name="default" />。
    /// </summary>
    /// <param name="me">
    ///   可能为空的 <see cref="DateTime" /> 类型值。
    /// </param>
    /// <param name="default">
    ///   当 <c> <paramref name="me" />.HasValue </c> 等于 <see langword="false" /> 时返回的默认值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="me" />.HasValue </c> 等于 <see langword="true" /> 时，返回 <c> <paramref name="me" />.Value </c>；否则返回
    ///   <paramref name="default" />。
    /// </returns>
    public static DateTime DefaultIf(this DateTime? me, DateTime @default)
    {
      return me ?? @default;
    }

    /// <summary>
    ///   获取 <paramref name="me" /> 的友好描述文本。
    /// </summary>
    /// <param name="me">
    ///   <see cref="DateTime" /> 类型的值。
    /// </param>
    /// <returns>
    ///   前端友好的描述文本。
    /// </returns>
    public static string FriendlyText(this DateTime me)
    {
      if (me.Before())
      {
        var timeSpan = DateTime.UtcNow - me;
        if (timeSpan.TotalSeconds.LessThanOrEquals(0x3C))
        {
          return Strings.DateTime_just_now;
        }
        else if (timeSpan.TotalSeconds.LessThanOrEquals(0xE10))
        {
          return string.Format(Strings.DateTime_several_minutes_ago, (int)timeSpan.TotalMinutes);
        }
        else if (timeSpan.TotalSeconds.LessThanOrEquals(0x15180))
        {
          return string.Format(Strings.DateTime_several_hours_ago, (int)timeSpan.TotalHours);
        }
        else if (timeSpan.TotalHours.LessThanOrEquals(0x278D00))
        {
          return string.Format(Strings.DateTime_several_days_ago, (int)timeSpan.TotalDays);
        }
        else if (me.Year.Equals(DateTime.UtcNow.Year))
        {
          return me.ToString(Strings.DateTime_same_year);
        }
      }
      return me.ToString(Strings.DateTime_date_only);
    }

    #endregion Methods
  }
}