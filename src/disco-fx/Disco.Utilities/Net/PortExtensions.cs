/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Net
{
  /// <summary>
  ///   为 <see cref="Port" /> 类型提供了扩展方法。
  /// </summary>
  public static class PortExtensions
  {
    #region Methods

    /// <summary>
    ///   将整型值 <paramref name="me" /> 转换成等效的端口号。
    /// </summary>
    /// <param name="me">
    ///   <see cref="int" /> 类型的值。
    /// </param>
    /// <returns>
    ///   <see cref="Port" /> 类型的值。
    /// </returns>
    public static Port ToPort(this int me)
    {
      return new Port(me);
    }

    #endregion Methods
  }
}