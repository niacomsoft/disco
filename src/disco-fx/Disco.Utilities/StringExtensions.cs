/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using Disco.Text;

  using System;
  using System.Text;

  /// <summary>
  ///   为 <see cref="string" /> 类型提供了扩展方法。
  /// </summary>
  public static class StringExtensions
  {
    #region Methods

    /// <summary>
    ///   使用指定的编码 <paramref name="encoding" /> 获取字符串 <paramref name="me" /> 的字节数组。
    /// </summary>
    /// <param name="me">
    ///   字符串。
    /// </param>
    /// <param name="encoding">
    ///   指定的编码程序。
    ///   <para> 派生自 <see cref="Encoding" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns>
    ///   字节数组。
    /// </returns>
    public static byte[] GetBytes(this string me, Encoding encoding)
    {
      encoding.IfNull(nameof(encoding));
      return string.IsNullOrEmpty(me) ? null : encoding.GetBytes(me);
    }

    /// <summary>
    ///   使用默认的编码 <see cref="DefaultEncodingProvider.DefaultEncoding" /> 获取字符串 <paramref name="me" /> 的字节数组。
    /// </summary>
    /// <param name="me">
    ///   字符串。
    /// </param>
    /// <returns>
    ///   字节数组。
    /// </returns>
    public static byte[] GetBytes(this string me)
    {
      return me.GetBytes(DefaultEncodingProvider.DefaultEncoding);
    }

    /// <summary>
    ///   使用指定的编码程序 <paramref name="encoding" /> 获取字节数组等效的字符串。
    /// </summary>
    /// <param name="me">
    ///   字节数组。
    /// </param>
    /// <param name="encoding">
    ///   指定的编码程序。
    ///   <para> 派生自 <see cref="Encoding" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="start">
    ///   需要解码的字节索引。
    /// </param>
    /// <param name="offset">
    ///   需要解码的字节长度。
    /// </param>
    /// <returns>
    ///   字符串。
    ///   <para>
    ///     当字节数组 <paramref name="me" /> 等于 <see langword="null" /> 或者长度等于 <c> 0 </c> 时，返回 <see langword="null" />。
    ///   </para>
    /// </returns>
    /// <exception cref="OverflowException">
    ///   当访问 <c> <paramref name="me" />.Length </c> 属性时，可能引发此类型的异常。
    /// </exception>
    public static string GetString(this byte[] me, Encoding encoding, int start = 0, int? offset = null)
    {
      encoding.IfNull(nameof(encoding));
      return me.HasItems() ? encoding.GetString(me, start, offset.DefaultIf(me.Length)) : null;
    }

    /// <summary>
    ///   使用默认的编码程序 <see cref="DefaultEncodingProvider.DefaultEncoding" /> 获取字节数组等效的字符串。
    /// </summary>
    /// <param name="me">
    ///   字节数组。
    /// </param>
    /// <param name="start">
    ///   需要解码的字节索引。
    /// </param>
    /// <param name="offset">
    ///   需要解码的字节长度。
    /// </param>
    /// <returns>
    ///   字符串。
    ///   <para>
    ///     当字节数组 <paramref name="me" /> 等于 <see langword="null" /> 或者长度等于 <c> 0 </c> 时，返回 <see langword="null" />。
    ///   </para>
    /// </returns>
    public static string GetString(this byte[] me, int start = 0, int? offset = null)
    {
      return me.GetString(DefaultEncodingProvider.DefaultEncoding, start, offset);
    }

    #endregion Methods
  }
}