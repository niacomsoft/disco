/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.IO
{
  using System.Runtime.InteropServices;

  public static partial class PathSegment
  {
#if NETSTANDARD || NETCOREAPP || NET
    /// <summary>
    ///   基于平台的路径分段符。
    /// </summary>
    public static readonly char Value = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? '\\' : '/';
#endif
  }
}