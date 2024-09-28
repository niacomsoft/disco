/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using System;

  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="a" /> 晚于 <paramref name="b" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a">
    ///   <see cref="DateTime" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   可能为空的 <see cref="DateTime" /> 类型值。
    ///   <para> 当 <paramref name="b" /> 为 <see langword="null" /> 时，使用 <see cref="DateTime.UtcNow" />。 </para>
    /// </param>
    /// <returns>
    ///   当 <paramref name="a" /> 晚于 <paramref name="b" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool After(DateTime a, DateTime? b = null) => GreaterThanOrEquals((a - (b ?? DateTime.UtcNow)).TotalMilliseconds);

    /// <summary>
    ///   当 <paramref name="a" /> 早于 <paramref name="b" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a">
    ///   <see cref="DateTime" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   可能为空的 <see cref="DateTime" /> 类型值。
    ///   <para> 当 <paramref name="b" /> 为 <see langword="null" /> 时，使用 <see cref="DateTime.UtcNow" />。 </para>
    /// </param>
    /// <returns>
    ///   当 <paramref name="a" /> 早于 <paramref name="b" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool Before(DateTime a, DateTime? b = null) => LessThanOrEquals((a - (b ?? DateTime.UtcNow)).TotalMilliseconds);

    #endregion Methods
  }
}