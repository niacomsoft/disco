/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.IO
{
  using Disco.Resources;

  using System.IO;

  /// <summary>
  ///   为 <see cref="FileInfo" /> 类型提供了扩展方法。
  /// </summary>
  public static class FileInfoExtensions
  {
    #region Methods

    /// <summary>
    ///   当 <c> <see cref="FileInfo" />.Exists </c> 为 <see langword="false" /> 时，将引发一个 <see cref="FileNotFoundException" />
    ///   类型的异常。
    /// </summary>
    /// <param name="me">
    ///   <see cref="FileInfo" /> 类型的对象实例。
    /// </param>
    /// <exception cref="FileNotFoundException">
    ///   当 <c> <see cref="FileInfo" />.Exists </c> 为 <see langword="false" /> 时，将引发此类型的异常。
    /// </exception>
    /// <exception cref="IOException">
    ///   当调用 <c> <see cref="FileInfo" />.Refresh() </c> 方法时，可能引发此类型的异常。
    /// </exception>
    // ExceptionAdjustment: M:System.String.Format(System.String,System.Object) -T:System.FormatException
    public static void NotFound(this FileInfo me)
    {
      me.Refresh();
      ExceptionHelper.ThrowElse<FileNotFoundException>(me.Exists, string.Format(Strings.FileNotFoundException_default_message, me.FullName), me.FullName);
    }

    #endregion Methods
  }
}