/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Models
{
  #region Interfaces

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