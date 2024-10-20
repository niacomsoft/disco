/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  using Disco.Patterns;

  using Microsoft.Extensions.Logging;

  using System;

  /// <summary>
  ///   提供了创建运行时日志服务相关的基本方法。
  /// </summary>
  public class LogWriterFactory : IFactory<string, ILogWriter>, IFactory<Type, ILogWriter>
  {
    #region Constructors

    /// <summary>
    ///   初始化 <see cref="LogWriterFactory" /> 类的新实例。
    /// </summary>
    /// <param name="loggerFactory">
    ///   实现了 <see cref="ILoggerFactory" /> 类型接口的类型。
    /// </param>
    public LogWriterFactory(ILoggerFactory loggerFactory)
    {
      LoggerFactory = loggerFactory;
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    ///   创建 <see cref="ILogWriter" /> 的工厂服务。
    /// </summary>
    /// <value>
    ///   获取 <see cref="ILoggerFactory" /> 类型的对象实例，用于表示创建 <see cref="ILogWriter" /> 的工厂服务。
    /// </value>
    protected virtual ILoggerFactory LoggerFactory { get; }

    #endregion Properties

    #region Methods

    /// <summary>
    ///   创建一个 <see cref="ILogWriter{TCategoryName}" /> 类型的对象实例。
    /// </summary>
    /// <typeparam name="TCategoryName">
    ///   标识日志类别名称的类型。
    /// </typeparam>
    /// <returns>
    ///   实现了 <see cref="ILogWriter{TCategoryName}" /> 类型接口的对象实例。
    /// </returns>
    public virtual ILogWriter<TCategoryName> CreateInstance<TCategoryName>()
    {
      return new LogWriter<TCategoryName>(LoggerFactory.CreateLogger<TCategoryName>());
    }

    /// <summary>
    ///   创建一个 <see cref="ILogWriter" /> 类型的对象实例。
    /// </summary>
    /// <param name="categoryName">
    ///   日志类别名称。
    /// </param>
    /// <returns>
    ///   <see cref="ILogWriter" /> 类型的对象实例。
    /// </returns>
    public virtual ILogWriter CreateInstance(string categoryName)
    {
      return new LogWriter(LoggerFactory.CreateLogger(categoryName));
    }

    /// <summary>
    ///   创建一个 <see cref="ILogWriter" /> 类型的对象实例。
    /// </summary>
    /// <param name="categoryName">
    ///   标识日志类别的类型。
    /// </param>
    /// <returns>
    ///   <see cref="ILogWriter" /> 类型的对象实例。
    /// </returns>
    public virtual ILogWriter CreateInstance(Type categoryName)
    {
      return new LogWriter(LoggerFactory.CreateLogger(categoryName));
    }

    #endregion Methods
  }
}