/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Patterns
{
  #region Interfaces

  /// <summary>
  ///   提供了构建 <typeparamref name="T" /> 类型的对象实例的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   目标类型。
  /// </typeparam>
  public interface IBuilder<T> where T : class
  {
    #region Methods

    /// <summary>
    ///   构建 <typeparamref name="T" /> 类型的对象实例。
    /// </summary>
    /// <returns>
    ///   <typeparamref name="T" /> 类型的对象实例。
    /// </returns>
    T Build();

    /// <summary>
    ///   构建 <typeparamref name="T" /> 类型的对象实例。
    /// </summary>
    /// <param name="args">
    ///   初始化 <typeparamref name="T" /> 类的新实例参数数组。
    /// </param>
    /// <returns>
    ///   <typeparamref name="T" /> 类型的对象实例。
    /// </returns>
    T Build(params object[] args);

    #endregion Methods
  }

  #endregion Interfaces
}