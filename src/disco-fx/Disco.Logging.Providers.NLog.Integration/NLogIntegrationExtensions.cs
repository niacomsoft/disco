/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.DependencyInjection.Logging.NLog
{
  using Disco.IO;

  using global::NLog.Config;
  using global::NLog.Extensions.Logging;

  using Microsoft.Extensions.DependencyInjection;

  using System;
  using System.IO;

  /// <summary>
  ///   为 <c> NLog </c> 类型提供了扩展方法。
  /// </summary>
  public static class NLogIntegrationExtensions
  {
    #region Methods

    /// <summary>
    ///   使用配置文件 <paramref name="configFile" /> 配置并注册 <c> NLog </c> 日志服务。
    /// </summary>
    /// <param name="me">
    ///   实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。
    /// </param>
    /// <param name="configFile">
    ///   配置文件信息。
    /// </param>
    /// <param name="optional">
    ///   当 <paramref name="optional" /> 等于 <see langword="false" /> 时，配置文件 <paramref name="configFile" /> 不存在时将抛出
    ///   <see cref="FileNotFoundException" /> 类型的异常。
    /// </param>
    /// <returns>
    ///   <paramref name="me" />。
    /// </returns>
    /// <exception cref="FileNotFoundException">
    ///   当配置文件 <paramref name="configFile" /> 不存在时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="IOException">
    ///   当配置文件 <paramref name="configFile" /> 不存在时，可能引发此类型的异常。
    /// </exception>
    public static IServiceCollection RegisterNLog(this IServiceCollection me, FileInfo configFile, bool optional = false)
    {
      configFile.IfNull(nameof(configFile));
      if (!optional)
      {
        configFile.NotFound();
      }
      return configFile.Exists ? me.RegisterNLog(() => new XmlLoggingConfiguration(configFile.FullName)) : me;
    }

    /// <summary>
    ///   配置并注册 <c> NLog </c> 日志服务。
    /// </summary>
    /// <param name="me">
    ///   实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。
    /// </param>
    /// <param name="builder">
    ///   构建 <c> NLog </c> 服务配置的方法。
    /// </param>
    /// <returns>
    ///   <paramref name="me" />
    /// </returns>
    public static IServiceCollection RegisterNLog(this IServiceCollection me, Func<LoggingConfiguration> builder)
    {
      builder.IfNull(nameof(builder));

      return me
        .RegisterLogWriterFactory()
        .AddLogging(loggingBuilder => loggingBuilder.AddNLog(builder()));
    }

    #endregion Methods
  }
}