/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  using Disco.Diagnostics;

  using Microsoft.Extensions.Logging;

  /// <summary>
  ///   为 <c> Microsoft.Extensions.Logging </c> 相关类型提供了扩展方法。
  /// </summary>
  internal static partial class InternalLoggingExtensions
  {
    /// <summary>
    ///   映射 <see cref="DiagnosticsLevel" /> 类型的值为 <see cref="LogLevel" /> 枚举类型中的一个值。。
    /// </summary>
    /// <param name="me">
    ///   <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。
    /// </param>
    /// <returns>
    ///   <see cref="LogLevel" /> 枚举类型中的一个值。
    /// </returns>
    internal static LogLevel MapToLogLevel(this DiagnosticsLevel me)
    {
      switch (me)
      {
        case DiagnosticsLevel.Trace: return LogLevel.Trace;
        case DiagnosticsLevel.Debug: return LogLevel.Debug;
        case DiagnosticsLevel.Information: return LogLevel.Information;
        case DiagnosticsLevel.Warning: return LogLevel.Warning;
        case DiagnosticsLevel.Error: return LogLevel.Error;
        case DiagnosticsLevel.Serious: return LogLevel.Critical;
        default: return DefaultLogLevel;
      }
    }
  }
}