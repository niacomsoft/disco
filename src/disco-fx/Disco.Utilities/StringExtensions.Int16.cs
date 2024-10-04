﻿/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using System;

  public static partial class StringExtensions
  {
    #region Methods

    /// <summary>
    ///   将等效的字符串 <paramref name="me" /> 转换为等效的 <see cref="short" /> 类型的值。
    /// </summary>
    /// <param name="me">
    ///   等效的 <see cref="short" /> 类型字符串。
    /// </param>
    /// <returns>
    ///   <see cref="short" /> 类型的值。
    /// </returns>
    /// <exception cref="FormatException">
    ///   当调用 <see cref="short.Parse(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException">
    ///   当调用 <see cref="short.Parse(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static short ToInt16(this string me)
    {
      return short.Parse(me);
    }

    /// <summary>
    ///   尝试将字符串 <paramref name="me" /> 转换成等效的 <see cref="short" /> 类型的值。
    /// </summary>
    /// <param name="me">
    ///   等效的 <see cref="short" /> 类型字符串。
    /// </param>
    /// <param name="value">
    ///   等效的 <see cref="short" /> 类型的值。
    /// </param>
    /// <returns>
    ///   类型转换是否成功。
    /// </returns>
    public static bool TryToInt16(this string me, out short value)
    {
      return short.TryParse(me, out value);
    }

    #endregion Methods
  }
}