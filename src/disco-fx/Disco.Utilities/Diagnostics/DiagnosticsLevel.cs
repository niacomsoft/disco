/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Diagnostics
{
  #region Enums

  /// <summary>
  ///   提供了诊断级别的枚举类型。
  /// </summary>
  public enum DiagnosticsLevel
  {
    /// <summary>
    ///   追踪级别。
    /// </summary>
    Trace = 1,

    /// <summary>
    ///   调试级别。
    /// </summary>
    Debug = 2,

    /// <summary>
    ///   信息级别。
    /// </summary>
    Information = 3,

    /// <summary>
    ///   警告级别。
    /// </summary>
    Warning = 4,

    /// <summary>
    ///   错误级别。
    /// </summary>
    Error = 5,

    /// <summary>
    ///   严重级别。
    /// </summary>
    Serious = 6,

#if DEBUG

    /// <summary>
    ///   默认的诊断级别：等同于 <see cref="Debug" />。
    /// </summary>
    Default = Debug

#else

    /// <summary>
    ///   默认的诊断级别：等同于 <see cref="Information" />。
    /// </summary>
    Default = Information

#endif
  }

  #endregion Enums
}