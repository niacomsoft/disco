/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  using Disco.Patterns;

  #region Interfaces

  /// <summary>
  ///   提供了创建实现了 <see cref="ILogWriter" /> 类型接口的对象实例的工厂方法接口。
  /// </summary>
  public interface ILogWriterFactory : IFactory<ILogWriter>
  {
  }

  /// <summary>
  ///   提供了创建实现了 <see cref="ILogWriter{TCategoryName}" /> 类型接口的对象实例的工厂方法接口。
  /// </summary>
  /// <typeparam name="TCategoryName">
  ///   标识类别名称的类型。
  /// </typeparam>
  public interface ILogWriterFactory<TCategoryName> : IFactory<ILogWriter<TCategoryName>>
  {
  }

  #endregion Interfaces
}