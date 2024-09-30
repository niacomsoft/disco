/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using System;

  /// <summary>
  ///   为 <see cref="Array" /> 类型提供了扩展方法。
  /// </summary>
  public static class ArrayExtensions
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="me" /> 不等于 <see langword="null" /> 且 <see cref="Array.Length" /> &gt; 0 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   需要验证的数组。
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 不等于 <see langword="null" /> 且 <see cref="Array.Length" /> &gt; 0 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool HasItems(this Array me)
    {
      return me.NotNull() && me.LongLength.GreaterThan();
    }

    /// <summary>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 或 <see cref="Array.Length" /> = 0 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   需要验证的数组。
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 或 <see cref="Array.Length" /> = 0 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool NoItems(this Array me)
    {
      return !me.HasItems();
    }

    #endregion Methods
  }
}