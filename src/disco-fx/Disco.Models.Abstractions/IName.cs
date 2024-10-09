/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Models
{
  #region Interfaces

  /// <summary>
  ///   提供了别名的接口。
  /// </summary>
  public interface IAlias
  {
    #region Properties

    /// <summary>
    ///   别名。
    /// </summary>
    /// <value>
    ///   设置或获取一个字符串，用于表示别名。
    /// </value>
    string Alias { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了显示名称的接口。
  /// </summary>
  public interface IDisplayName
  {
    #region Properties

    /// <summary>
    ///   显示名称。
    /// </summary>
    /// <value>
    ///   设置或获取一个字符串，用于表示显示名称。
    /// </value>
    string DisplayName { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了友好名称的接口。
  /// </summary>
  public interface IFriendlyName
  {
    #region Properties

    /// <summary>
    ///   友好名称。
    /// </summary>
    /// <value>
    ///   设置或获取一个字符串，用于表示友好名称。
    /// </value>
    string FriendlyName { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了描述名称的接口。
  /// </summary>
  public interface IName
  {
    #region Properties

    /// <summary>
    ///   名称。
    /// </summary>
    /// <value>
    ///   设置或获取一个字符串，用于表示名称。
    /// </value>
    string Name { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}