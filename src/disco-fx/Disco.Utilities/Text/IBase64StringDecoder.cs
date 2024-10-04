/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Text
{
  #region Interfaces

  /// <summary>
  ///   提供了 <c> BASE64 </c> 字符串解码的接口。
  /// </summary>
  public interface IBase64StringDecoder
  {
    #region Methods

    /// <summary>
    ///   将 <paramref name="base64Str" /> 字符串解码为字节数组。
    /// </summary>
    /// <param name="base64Str">
    ///   <c> BASE-64 </c> 编码的字符串。
    /// </param>
    /// <returns>
    ///   字节数组。
    /// </returns>
    byte[] FromBase64String(string base64Str);

    #endregion Methods
  }

  #endregion Interfaces
}