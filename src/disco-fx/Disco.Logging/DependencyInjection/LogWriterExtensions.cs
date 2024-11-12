/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.DependencyInjection.Logging
{
  using Disco.Logging;

  using Microsoft.Extensions.DependencyInjection;

  /// <summary>
  ///   为 <see cref="IServiceCollection" /> 类型提供了扩展方法。
  /// </summary>
  public static class LogWriterExtensions
  {
    #region Methods

    /// <summary>
    ///   注册 <see cref="LogWriterFactory" /> 服务。
    /// </summary>
    /// <param name="me">
    ///   实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。
    /// </param>
    /// <returns>
    ///   <paramref name="me" />。
    /// </returns>
    public static IServiceCollection RegisterLogWriterFactory(this IServiceCollection me)
    {
      return me.AddSingleton<LogWriterFactory>();
    }

    #endregion Methods
  }
}