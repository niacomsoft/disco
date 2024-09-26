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
    ///   当 <c> <paramref name="a" /> = <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a">
    ///   <see cref="int" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="int" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> = <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool Equals(int a, int b = 0) => a == b;

    /// <summary>
    ///   当 <c> <paramref name="a" /> &gt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </summary>
    /// <param name="a">
    ///   <see cref="int" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="int" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> &gt; <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool GreaterThan(int a, int b = 0) => a > b;

    /// <summary>
    ///   当 <c> <paramref name="a" /> &gt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </summary>
    /// <param name="a">
    ///   <see cref="int" /> 类型的值。
    /// </param>
    /// <param name="b">
    ///   <see cref="int" /> 类型的值。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> &gt;= <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool GreaterThanOrEquals(int a, int b = 0) => a >= b;

    #endregion Methods
  }
}