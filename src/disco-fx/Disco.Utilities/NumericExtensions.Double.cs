/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  public static partial class NumericExtensions
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="me" /> 介于 <c> <paramref name="min" /> ~ <paramref name="max" /></c> 之间时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <param name="min">
    ///   下限 <see cref="double" /> 类型的值。
    /// </param>
    /// <param name="max">
    ///   上限 <see cref="double" /> 类型的值。
    /// </param>
    /// <param name="minInclusive">
    ///   比较时是否包含 <paramref name="min" />，即：是否使用 <c> <paramref name="me" /> &gt;= <paramref name="min" /></c>。
    /// </param>
    /// <param name="maxInclusive">
    ///   比较时是否包含 <paramref name="max" />，即：是否使用 <c> <paramref name="me" /> &lt;= <paramref name="max" /></c>。
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 介于 <c> <paramref name="min" /> ~ <paramref name="max" /></c> 之间时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool Between(this double me, double min = 0, double max = double.MaxValue, bool minInclusive = true, bool maxInclusive = true)
    {
      return
        ((maxInclusive && me.LessThanOrEquals(max)) || (!maxInclusive && me.LessThan(max)))
        &&
        ((minInclusive && me.GreaterThanOrEquals(min)) || (!minInclusive && me.GreaterThan(min)));
    }

    /// <summary>
    ///   当 <c> <paramref name="me" />.HasValue </c> 等于 <see langword="false" /> 时，返回 <paramref name="default" />；否则返回 <c>
    ///   <paramref name="me" />.Value </c>。
    /// </summary>
    /// <param name="me">
    ///   可能为空的 <see cref="double" /> 类型值。
    /// </param>
    /// <param name="default">
    ///   当 <c> <paramref name="me" />.HasValue </c> 等于 <see langword="false" /> 时需要返回的默认值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="me" />.HasValue </c> 等于 <see langword="false" /> 时，返回 <paramref name="default" />；否则返回 <c>
    ///   <paramref name="me" />.Value </c>。
    /// </returns>
    public static double DefaultIf(this double? me, double @default = 0)
    {
      return me ?? @default;
    }

    /// <summary>
    ///   当 <c> <paramref name="me" /> = <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="me" /> = <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool Equals(this double me, double b = 0)
    {
      return me.Equals(b);
    }

    /// <summary>
    ///   当 <c> <paramref name="me" /> &gt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </summary>
    /// <param name="me">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="me" /> &gt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool GreaterThan(this double me, double b = 0)
    {
      return me > b;
    }

    /// <summary>
    ///   当 <c> <paramref name="me" /> &gt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="me" /> &gt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool GreaterThanOrEquals(this double me, double b = 0)
    {
      return me >= b;
    }

    /// <summary>
    ///   当 <c> <paramref name="me" /> &lt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </summary>
    /// <param name="me">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="me" /> &lt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool LessThan(this double me, double b = 0)
    {
      return me < b;
    }

    /// <summary>
    ///   当 <c> <paramref name="me" /> &lt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="double" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="me" /> &lt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool LessThanOrEquals(this double me, double b = 0)
    {
      return me <= b;
    }

    #endregion Methods
  }
}