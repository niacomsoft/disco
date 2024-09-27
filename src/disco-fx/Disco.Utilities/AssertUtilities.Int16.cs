/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="value" /> 在 <paramref name="minimum" /> 和 <paramref name="maximum" /> 之间时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="value">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <param name="minimum">
    ///   下限 <see cref="short" /> 类型的值。
    /// </param>
    /// <param name="maximum">
    ///   上限 <see cref="short" /> 类型的值。
    /// </param>
    /// <param name="minimumInclusive">
    ///   判断时是否包含下限值 <paramref name="minimum" />。即当 <paramref name="minimumInclusive" /> 等于 <see langword="true" /> 时，将使用
    ///   <paramref name="value" /> &gt;= <paramref name="minimum" />。
    /// </param>
    /// <param name="maximumInclusive">
    ///   判断时是否包含上限值 <paramref name="minimum" />。即当 <paramref name="minimumInclusive" /> 等于 <see langword="true" /> 时，将使用
    ///   <paramref name="value" /> &lt;= <paramref name="minimum" />。
    /// </param>
    /// <returns>
    ///   当 <paramref name="value" /> 在 <paramref name="minimum" /> 和 <paramref name="maximum" /> 之间时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool BetweenAnd(short value, short minimum = short.MinValue, short maximum = short.MaxValue, bool minimumInclusive = true, bool maximumInclusive = false)
    {
      return ((!minimumInclusive && GreaterThan(value, minimum)) || (minimumInclusive && GreaterThanOrEquals(value, minimum)))
        &&
        ((!maximumInclusive && GreaterThan(maximum, value)) || (maximumInclusive && GreaterThanOrEquals(maximum, value)));
    }

    /// <summary>
    ///   当 <c> <paramref name="a" /> = <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> = <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool Equals(short a, short b = 0) => a == b;

    /// <summary>
    ///   当 <c> <paramref name="a" /> &gt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </summary>
    /// <param name="a">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> &gt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool GreaterThan(short a, short b = 0) => a > b;

    /// <summary>
    ///   当 <c> <paramref name="a" /> &gt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </summary>
    /// <param name="a">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> &gt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool GreaterThanOrEquals(short a, short b = 0) => a >= b;

    /// <summary>
    ///   当 <c> <paramref name="a" /> &lt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </summary>
    /// <param name="a">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> &lt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool LessThan(short a, short b = 0) => a < b;

    /// <summary>
    ///   当 <c> <paramref name="a" /> &lt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </summary>
    /// <param name="a">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="short" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> &lt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool LessThanOrEquals(short a, short b = 0) => a <= b;

    #endregion Methods
  }
}