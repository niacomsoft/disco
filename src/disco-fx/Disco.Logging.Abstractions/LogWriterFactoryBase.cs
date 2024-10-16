/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  /// <summary>
  ///   提供了创建实现了 <see cref="ILogWriter" /> 类型接口的对象实例相关的抽象工厂 <see langword="abstract" /> 方法。
  /// </summary>
  public abstract class LogWriterFactoryBase : ILogWriterFactory
  {
    #region Methods

    /// <inheritdoc />
    public abstract ILogWriter CreateInstance();

    #endregion Methods
  }

  /// <summary>
  ///   提供了创建实现了 <see cref="ILogWriter{TCategoryName}" /> 类型接口的对象实例相关的抽象工厂 <see langword="abstract" /> 方法。
  /// </summary>
  /// <typeparam name="TCategoryName">
  ///   标识日志类别名称的类型。
  /// </typeparam>
  public abstract class LogWriterFactoryBase<TCategoryName> : ILogWriterFactory<TCategoryName>
  {
    #region Methods

    /// <inheritdoc />
    public abstract ILogWriter<TCategoryName> CreateInstance();

    #endregion Methods
  }
}