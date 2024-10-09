/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Models
{
  using System;

  #region Interfaces

  /// <summary>
  ///   提供了 <see cref="Guid" /> 类型的数据标识的接口。
  /// </summary>
  public interface IGuid : IID<Guid>
  {
  }

  /// <summary>
  ///   提供了数据标识的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   数据标识类型。
  /// </typeparam>
  public interface IID<T>
  {
    #region Properties

    /// <summary>
    ///   数据标识。
    /// </summary>
    /// <value>
    ///   设置或获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示数据标识。
    /// </value>
    T Id { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了长整型的数据标识的接口。
  /// </summary>
  public interface ILongId : IID<long>
  {
  }

  /// <summary>
  ///   提供了字符串类型的数据标识的接口。
  /// </summary>
  public interface IStringId : IID<string>
  {
  }

  #endregion Interfaces
}