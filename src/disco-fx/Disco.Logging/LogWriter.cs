/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  using Disco.Diagnostics;

  using Microsoft.Extensions.Logging;

  using System;

  /// <summary>
  ///   提供了记录运行时日志相关的基本方法。
  /// </summary>
  public class LogWriter : LogWriterBase
  {
    #region Constructors

    /// <summary>
    ///   初始化 <see cref="LogWriter" /> 类的新实例。
    /// </summary>
    /// <param name="logger">
    ///   记录运行时日志的 <c> Microsoft.Extensions.Logging </c> 服务。
    /// </param>
    public LogWriter(ILogger logger)
    {
      Logger = logger;
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    ///   记录运行时日志的 <c> Microsoft.Extensions.Logging </c> 服务。
    /// </summary>
    /// <value>
    ///   获取 <see cref="ILogger" /> 类型的对象实例，用于表示记录运行时日志的 <c> Microsoft.Extensions.Logging </c> 服务。
    /// </value>
    protected virtual ILogger Logger { get; }

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    protected override void InternalLog(Exception error, string message, DiagnosticsLevel level = DiagnosticsLevel.Debug, params object[] contextData)
    {
      Logger.Log(level.MapToLogLevel(), error, message, contextData);
    }

    #endregion Methods
  }

  /// <summary>
  ///   提供了记录运行时日志相关的基本方法。
  /// </summary>
  /// <typeparam name="TCategoryName">
  ///   标识日志类别名称的类型。
  /// </typeparam>
  public class LogWriter<TCategoryName> : LogWriter, ILogWriter<TCategoryName>
  {
    #region Constructors

    /// <summary>
    ///   初始化 <see cref="LogWriter{TCategoryName}" /> 类的新实例。
    /// </summary>
    /// <param name="logger">
    ///   记录运行时日志的 <c> Microsoft.Extensions.Logging </c> 服务。
    /// </param>
    public LogWriter(ILogger<TCategoryName> logger) : base(logger)
    {
    }

    #endregion Constructors
  }
}