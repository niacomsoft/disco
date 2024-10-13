/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Models
{
  #region Interfaces

  /// <summary>
  ///   提供了是否已经激活的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   描述是否已经激活的值类型。
  /// </typeparam>
  public interface IAvailable<T> where T : struct
  {
    #region Properties

    /// <summary>
    ///   是否已经激活。
    /// </summary>
    /// <value>
    ///   设置或获取 <typeparamref name="T" /> 类型的值，用于表示是否已经激活。
    /// </value>
    T Available { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了描述是否为内置的状态的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   描述是否为内置的状态的值类型。
  /// </typeparam>
  public interface IBuiltIn<T> where T : struct
  {
    #region Properties

    /// <summary>
    ///   是否为内置的。
    /// </summary>
    /// <value>
    ///   设置或获取 <typeparamref name="T" /> 类型的值，用于表示是否为内置的。
    /// </value>
    T BuiltIn { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了描述是否为默认的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   是否为默认的状态的值类型。
  /// </typeparam>
  public interface IDefault<T> where T : struct
  {
    #region Properties

    /// <summary>
    ///   是否为默认的。
    /// </summary>
    /// <value>
    ///   设置或获取 <typeparamref name="T" /> 类型的值，用于表示是否为默认的。
    /// </value>
    T IsDefault { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了描述是否启用状态的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   描述是否启用状态的值类型。
  /// </typeparam>
  public interface IEnabled<T> where T : struct
  {
    #region Properties

    /// <summary>
    ///   是否启用。
    /// </summary>
    /// <value>
    ///   设置 <typeparamref name="T" /> 类型的值，用于表示是否启用。
    /// </value>
    T Enabled { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了描述是否被冻结状态的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   描述是否被冻结状态的值类型。
  /// </typeparam>
  public interface IFrozen<T> where T : struct
  {
    #region Properties

    /// <summary>
    ///   是否已经被冻结。
    /// </summary>
    /// <value>
    ///   设置或获取 <typeparamref name="T" /> 类型的值，用于表示是否已经被冻结。
    /// </value>
    T Frozen { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了描述是否锁定状态的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   描述是否已经被锁定的值类型。
  /// </typeparam>
  public interface ILocked<T> where T : struct
  {
    #region Properties

    /// <summary>
    ///   是否已经锁定。
    /// </summary>
    /// <value>
    ///   设置或获取 <typeparamref name="T" /> 类型的值，用于表示是否已经锁定。
    /// </value>
    T Locked { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了描述逻辑删除状态的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   描述是否已经被逻辑删除的值类型。
  /// </typeparam>
  public interface IRemoved<T> where T : struct
  {
    #region Properties

    /// <summary>
    ///   是否已经被逻辑删除。
    /// </summary>
    /// <value>
    ///   设置 <typeparamref name="T" /> 类型的值，用于表示是否已经被逻辑删除。
    /// </value>
    T IsRemoved { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}