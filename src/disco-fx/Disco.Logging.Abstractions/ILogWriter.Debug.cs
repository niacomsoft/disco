/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  using System;

  #region Interfaces

  public partial interface ILogWriter
  {
    #region Methods

    /// <summary>
    ///   记录包含运行时异常的调试级别运行时日志。
    /// </summary>
    /// <param name="error">
    ///   运行时异常。
    ///   <para> 派生自 <see cref="Exception" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="message">
    ///   调试级别运行时日志描述信息。
    /// </param>
    /// <param name="contextData">
    ///   随调试级别运行时日志一起输出的上下文数据。
    /// </param>
    void Debug(Exception error, string message, params object[] contextData);

    /// <summary>
    ///   记录调试级别运行时日志。
    /// </summary>
    /// <param name="message">
    ///   调试级别运行时日志描述信息。
    /// </param>
    /// <param name="contextData">
    ///   随调试级别运行时日志一起输出的上下文数据。
    /// </param>
    void Debug(string message, params object[] contextData);

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="false" /> 时记录包含运行时异常的调试级别运行时日志。
    /// </summary>
    /// <param name="where">
    ///   条件表达式。
    /// </param>
    /// <param name="error">
    ///   运行时异常。
    ///   <para> 派生自 <see cref="Exception" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="message">
    ///   调试级别运行时日志描述信息。
    /// </param>
    /// <param name="contextData">
    ///   随调试级别运行时日志一起输出的上下文数据。
    /// </param>
    /// <returns>
    ///   条件表达式 <paramref name="where" />。
    /// </returns>
    bool DebugElse(bool where, Exception error, string message, params object[] contextData);

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="false" /> 时记录调试级别运行时日志。
    /// </summary>
    /// <param name="where">
    ///   条件表达式。
    /// </param>
    /// <param name="message">
    ///   调试级别运行时日志描述信息。
    /// </param>
    /// <param name="contextData">
    ///   随调试级别运行时日志一起输出的上下文数据。
    /// </param>
    /// <returns>
    ///   条件表达式 <paramref name="where" />。
    /// </returns>
    bool DebugElse(bool where, string message, params object[] contextData);

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="true" /> 时记录包含运行时异常的调试级别运行时日志。
    /// </summary>
    /// <param name="where">
    ///   条件表达式。
    /// </param>
    /// <param name="error">
    ///   运行时异常。
    ///   <para> 派生自 <see cref="Exception" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="message">
    ///   调试级别运行时日志描述信息。
    /// </param>
    /// <param name="contextData">
    ///   随调试级别运行时日志一起输出的上下文数据。
    /// </param>
    /// <returns>
    ///   条件表达式 <paramref name="where" />。
    /// </returns>
    bool DebugIf(bool where, Exception error, string message, params object[] contextData);

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="true" /> 时记录调试级别运行时日志。
    /// </summary>
    /// <param name="where">
    ///   条件表达式。
    /// </param>
    /// <param name="message">
    ///   调试级别运行时日志描述信息。
    /// </param>
    /// <param name="contextData">
    ///   随调试级别运行时日志一起输出的上下文数据。
    /// </param>
    /// <returns>
    ///   条件表达式 <paramref name="where" />。
    /// </returns>
    bool DebugIf(bool where, string message, params object[] contextData);

    #endregion Methods
  }

  #endregion Interfaces
}