/* ********************************************************************************************************************************************************** *\
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
    ///   将字符串 <paramref name="me" /> 转换成 <typeparamref name="TEnum" /> 枚举类型中的一个值。
    /// </summary>
    /// <typeparam name="TEnum">
    ///   枚举类型。
    /// </typeparam>
    /// <param name="me">
    ///   <typeparamref name="TEnum" /> 枚举类型中一个字段名称。
    /// </param>
    /// <param name="ignoreCase">
    ///   是否忽略 <paramref name="me" /> 的大小写。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TEnum" /> 枚举类型中的一个值。
    /// </returns>
    /// <exception cref="OverflowException">
    ///   当调用 <see cref="Enum.Parse(Type, string, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static TEnum ToEnum<TEnum>(this string me, bool ignoreCase = false) where TEnum : struct, Enum
    {
      return (TEnum)Enum.Parse(typeof(TEnum), me, ignoreCase);
    }

    /// <summary>
    ///   尝试将字符串 <paramref name="me" /> 转换成 <typeparamref name="TEnum" /> 枚举类型中的一个值。
    /// </summary>
    /// <typeparam name="TEnum">
    ///   枚举类型。
    /// </typeparam>
    /// <param name="me">
    ///   <typeparamref name="TEnum" /> 枚举类型中一个字段名称。
    /// </param>
    /// <param name="ignoreCase">
    ///   是否忽略 <paramref name="me" /> 的大小写。
    /// </param>
    /// <param name="value">
    ///   <typeparamref name="TEnum" /> 枚举类型中的一个值。
    /// </param>
    /// <returns>
    ///   转换是否成功。
    /// </returns>
    public static bool ToEnum<TEnum>(this string me, bool ignoreCase, out TEnum value) where TEnum : struct, Enum
    {
      return Enum.TryParse(me, ignoreCase, out value);
    }

    #endregion Methods
  }
}