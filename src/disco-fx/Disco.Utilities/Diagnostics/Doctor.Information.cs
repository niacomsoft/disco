/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Diagnostics
{
  /// <summary>
  ///   提供了输出调试期诊断信息相关的静态 <see langword="static" /> 方法。
  /// </summary>
  public static partial class Doctor
  {
    #region Methods

    /// <summary>
    ///   输出一行调试诊断信息。
    /// </summary>
    /// <param name="message">
    ///   诊断信息。
    /// </param>
    public static void Information(string message)
    {
      WriteLine(message, DiagnosticsLevel.Information);
    }

    /// <summary>
    ///   输出一行调试诊断信息。
    /// </summary>
    /// <typeparam name="TCategory">
    ///   用于标识类别的类型。
    /// </typeparam>
    /// <param name="message">
    ///   诊断信息。
    /// </param>
    public static void Information<TCategory>(string message)
    {
      WriteLine<TCategory>(message, DiagnosticsLevel.Information);
    }

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="true" /> 输出一行调试诊断信息。
    /// </summary>
    /// <param name="where">
    ///   条件表达式。
    /// </param>
    /// <param name="message">
    ///   诊断信息。
    /// </param>
    public static bool InformationIf(bool where, string message)
    {
      return WriteLineIf(where, message, DiagnosticsLevel.Information);
    }

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="true" /> 输出一行调试诊断信息。
    /// </summary>
    /// <typeparam name="TCategory">
    ///   用于标识类别的类型。
    /// </typeparam>
    /// <param name="where">
    ///   条件表达式。
    /// </param>
    /// <param name="message">
    ///   诊断信息。
    /// </param>
    public static bool InformationIf<TCategory>(bool where, string message)
    {
      return WriteLineIf<TCategory>(where, message, DiagnosticsLevel.Information);
    }

    #endregion Methods
  }
}