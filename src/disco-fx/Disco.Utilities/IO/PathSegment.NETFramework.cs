/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.IO
{
  public static partial class PathSegment
  {
#if NETFRAMEWORK

    /// <summary>
    ///   Windows 操作系统中路径分段符。
    /// </summary>
    public const char Value = '\\';

#endif
  }
}