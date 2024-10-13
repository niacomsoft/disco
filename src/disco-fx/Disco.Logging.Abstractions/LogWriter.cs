/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  using Disco.Diagnostics;

  using System;

  /// <summary>
  ///   提供了记录运行时日志相关的抽象 <see langword="abstract" /> 方法。
  /// </summary>
  public abstract class LogWriter : ILogWriter
  {
    #region Constructors

    /// <summary>
    ///   初始化 <see cref="LogWriter" /> 类的新实例。
    /// </summary>
    protected LogWriter()
    {
    }

    #endregion Constructors

    #region Methods

    /// <summary>
    ///   记录包含运行时异常的运行时日志。
    /// </summary>
    /// <param name="error">
    ///   运行时异常。
    ///   <para> 派生自 <see cref="Exception" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="message">
    ///   运行时日志描述信息。
    /// </param>
    /// <param name="level">
    ///   运行时诊断级别。
    /// </param>
    /// <param name="contextData">
    ///   随运行时日志一起输出的上下文数据。
    /// </param>
    protected abstract void InternalLog(Exception error, string message, DiagnosticsLevel level = DiagnosticsLevel.Debug, params object[] contextData);

    /// <inheritdoc />
    public virtual void Debug(Exception error, string message, params object[] contextData)
    {
      Log(error, message, DiagnosticsLevel.Debug, contextData);
    }

    /// <inheritdoc />
    public virtual void Debug(string message, params object[] contextData)
    {
      Debug(null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool DebugElse(bool where, Exception error, string message, params object[] contextData)
    {
      return DebugIf(!where, error, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool DebugElse(bool where, string message, params object[] contextData)
    {
      return DebugElse(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool DebugIf(bool where, Exception error, string message, params object[] contextData)
    {
      return LogIf(where, error, message, DiagnosticsLevel.Debug, contextData);
    }

    /// <inheritdoc />
    public virtual bool DebugIf(bool where, string message, params object[] contextData)
    {
      return DebugIf(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual void Error(Exception error, string message, params object[] contextData)
    {
      Log(error, message, DiagnosticsLevel.Error, contextData);
    }

    /// <inheritdoc />
    public virtual void Error(string message, params object[] contextData)
    {
      Error(null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool ErrorElse(bool where, Exception error, string message, params object[] contextData)
    {
      return ErrorIf(!where, error, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool ErrorElse(bool where, string message, params object[] contextData)
    {
      return ErrorElse(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool ErrorIf(bool where, Exception error, string message, params object[] contextData)
    {
      return LogIf(where, error, message, DiagnosticsLevel.Error, contextData);
    }

    /// <inheritdoc />
    public virtual bool ErrorIf(bool where, string message, params object[] contextData)
    {
      return ErrorIf(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual void Information(Exception error, string message, params object[] contextData)
    {
      Log(error, message, DiagnosticsLevel.Information, contextData);
    }

    /// <inheritdoc />
    public virtual void Information(string message, params object[] contextData)
    {
      Information(null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool InformationElse(bool where, Exception error, string message, params object[] contextData)
    {
      return InformationIf(!where, error, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool InformationElse(bool where, string message, params object[] contextData)
    {
      return InformationElse(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool InformationIf(bool where, Exception error, string message, params object[] contextData)
    {
      return LogIf(where, error, message, DiagnosticsLevel.Information, contextData);
    }

    /// <inheritdoc />
    public virtual bool InformationIf(bool where, string message, params object[] contextData)
    {
      return InformationIf(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual void Log(Exception error, string message, DiagnosticsLevel level = DiagnosticsLevel.Debug, params object[] contextData)
    {
      if (error.NotNull() || !string.IsNullOrWhiteSpace(message))
      {
        InternalLog(error, message.DefaultIfNullOrWhiteSpace(error.GetDescription()), level, contextData);
      }
    }

    /// <inheritdoc />
    public virtual void Log(string message, DiagnosticsLevel level = DiagnosticsLevel.Debug, params object[] contextData)
    {
      Log(null, message, level, contextData);
    }

    /// <inheritdoc />
    public virtual bool LogElse(bool where, Exception error, string message, DiagnosticsLevel level = DiagnosticsLevel.Debug, params object[] contextData)
    {
      return LogIf(!where, error, message, level, contextData);
    }

    /// <inheritdoc />
    public virtual bool LogElse(bool where, string message, DiagnosticsLevel level = DiagnosticsLevel.Debug, params object[] contextData)
    {
      return LogElse(where, null, message, level, contextData);
    }

    /// <inheritdoc />
    public virtual bool LogIf(bool where, Exception error, string message, DiagnosticsLevel level = DiagnosticsLevel.Debug, params object[] contextData)
    {
      if (where)
      {
        Log(error, message, level, contextData);
      }
      return where;
    }

    /// <inheritdoc />
    public virtual bool LogIf(bool where, string message, DiagnosticsLevel level = DiagnosticsLevel.Debug, params object[] contextData)
    {
      return LogIf(where, null, message, level, contextData);
    }

    /// <inheritdoc />
    public virtual void Serious(Exception error, string message, params object[] contextData)
    {
      Log(error, message, DiagnosticsLevel.Serious, contextData);
    }

    /// <inheritdoc />
    public virtual void Serious(string message, params object[] contextData)
    {
      Serious(null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool SeriousElse(bool where, Exception error, string message, params object[] contextData)
    {
      return SeriousIf(!where, error, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool SeriousElse(bool where, string message, params object[] contextData)
    {
      return SeriousElse(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool SeriousIf(bool where, Exception error, string message, params object[] contextData)
    {
      return LogIf(where, error, message, DiagnosticsLevel.Serious, contextData);
    }

    /// <inheritdoc />
    public virtual bool SeriousIf(bool where, string message, params object[] contextData)
    {
      return SeriousIf(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual void Trace(Exception error, string message, params object[] contextData)
    {
      Log(error, message, DiagnosticsLevel.Trace, contextData);
    }

    /// <inheritdoc />
    public virtual void Trace(string message, params object[] contextData)
    {
      Trace(null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool TraceElse(bool where, Exception error, string message, params object[] contextData)
    {
      return TraceIf(!where, error, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool TraceElse(bool where, string message, params object[] contextData)
    {
      return TraceElse(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool TraceIf(bool where, Exception error, string message, params object[] contextData)
    {
      return LogIf(where, error, message, DiagnosticsLevel.Trace, contextData);
    }

    /// <inheritdoc />
    public virtual bool TraceIf(bool where, string message, params object[] contextData)
    {
      return TraceIf(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual void Warning(Exception error, string message, params object[] contextData)
    {
      Log(error, message, DiagnosticsLevel.Warning, contextData);
    }

    /// <inheritdoc />
    public virtual void Warning(string message, params object[] contextData)
    {
      Warning(null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool WarningElse(bool where, Exception error, string message, params object[] contextData)
    {
      return WarningIf(!where, error, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool WarningElse(bool where, string message, params object[] contextData)
    {
      return WarningElse(where, null, message, contextData);
    }

    /// <inheritdoc />
    public virtual bool WarningIf(bool where, Exception error, string message, params object[] contextData)
    {
      return LogIf(where, error, message, DiagnosticsLevel.Warning, contextData);
    }

    /// <inheritdoc />
    public virtual bool WarningIf(bool where, string message, params object[] contextData)
    {
      return WarningIf(where, null, message, contextData);
    }

    #endregion Methods
  }
}