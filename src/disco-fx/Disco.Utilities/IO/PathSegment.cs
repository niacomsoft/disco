/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.IO
{
  using System.IO;

  /// <summary>
  ///   提供了路径分段符相关的静态 <see langword="static" /> 方法。
  /// </summary>
  public static class PathSegment
  {
    #region Fields

    /// <summary>
    ///   Windows 操作系统中路径分段符。
    /// </summary>
    public static readonly char Value = Path.DirectorySeparatorChar;

    #endregion Fields
  }
}