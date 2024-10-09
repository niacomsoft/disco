/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Models
{
  #region Interfaces

  /// <summary>
  ///   提供了描述或备注信息的接口。
  /// </summary>
  public interface IDescription
  {
    #region Properties

    /// <summary>
    ///   描述信息。
    /// </summary>
    /// <value>
    ///   设置或获取一个字符串，用于表示描述信息。
    /// </value>
    string Description { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}