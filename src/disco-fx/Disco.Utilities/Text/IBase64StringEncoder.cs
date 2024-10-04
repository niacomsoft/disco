/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Text
{
  using System;

  #region Interfaces

  /// <summary>
  ///   提供了 <c> BASE64 </c> 字符串编码的接口。
  /// </summary>
  public interface IBase64StringEncoder
  {
    #region Methods

    /// <summary>
    ///   对字节数组 <paramref name="input" /> 进行编码，并获取 BASE-64 字符串。
    /// </summary>
    /// <param name="input">
    ///   字节数组。
    /// </param>
    /// <param name="start">
    ///   编码的字节起始索引数字。
    /// </param>
    /// <param name="length">
    ///   需要编码的字节长度。
    /// </param>
    /// <param name="options">
    ///   <c> BASE-64 </c> 格式化配置选项。
    ///   <para> <see cref="Base64FormattingOptions" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns>
    ///   <c> BASE-64 </c> 编码的字符串。
    /// </returns>
    string ToBase64String(byte[] input, int start = 0, int? length = null, Base64FormattingOptions options = Base64FormattingOptions.None);

    #endregion Methods
  }

  #endregion Interfaces
}