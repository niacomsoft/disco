/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Diagnostics
{
  using DotNetTrace = System.Diagnostics.Trace;

  /// <summary>
  ///   提供了输出调试期诊断信息相关的静态 <see langword="static" /> 方法。
  /// </summary>
  public static partial class Doctor
  {
    #region Constants

    /// <summary>
    ///   输出类别名称。
    /// </summary>
    public const string Category = "DISCO";

    #endregion Constants

    #region Methods

    /// <summary>
    ///   输出一行调试诊断信息。
    /// </summary>
    /// <param name="message">
    ///   诊断信息。
    /// </param>
    /// <param name="category">
    ///   日志类别。
    /// </param>
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    private static void InternalWriteLine(string message, string category, DiagnosticsLevel level)
    {
      DotNetTrace.WriteLine($"[{level.ToString().ToUpper()}]: {message}", category);
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
    /// <param name="category">
    ///   日志类别。
    /// </param>
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    private static bool InternalWriteLineIf(bool where, string message, string category, DiagnosticsLevel level)
    {
      if (where)
      {
        InternalWriteLine(message, category, level);
      }
      return where;
    }

    /// <summary>
    ///   输出一行调试诊断信息。
    /// </summary>
    /// <param name="message">
    ///   诊断信息。
    /// </param>
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    public static void WriteLine(string message, DiagnosticsLevel level = DiagnosticsLevel.Default)
    {
      InternalWriteLine(message, Category, level);
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
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    public static void WriteLine<TCategory>(string message, DiagnosticsLevel level = DiagnosticsLevel.Default)
    {
      InternalWriteLine(message, typeof(TCategory).FullName, level);
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
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    public static bool WriteLineIf(bool where, string message, DiagnosticsLevel level = DiagnosticsLevel.Default)
    {
      return InternalWriteLineIf(where, message, Category, level);
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
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    public static bool WriteLineIf<TCategory>(bool where, string message, DiagnosticsLevel level = DiagnosticsLevel.Default)
    {
      return InternalWriteLineIf(where, message, typeof(TCategory).FullName, level);
    }

    #endregion Methods
  }
}