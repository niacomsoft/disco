/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  public static partial class AssertUtilities
  {
#if DEBUG

    /// <summary>
    ///   是否为调试模式。
    /// </summary>
    public static readonly bool DebugMode = true;

#else

    /// <summary>
    ///   是否为调试模式。
    /// </summary>
    public static readonly bool DebugMode = false;

#endif
  }
}