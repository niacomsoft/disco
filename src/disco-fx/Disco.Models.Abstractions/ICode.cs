/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Models
{
  #region Interfaces

  /// <summary>
  ///   提供了编码的接口。
  /// </summary>
  public interface ICode
  {
    #region Properties

    /// <summary>
    ///   编码。
    /// </summary>
    /// <value>
    ///   设置或获取一个字符串，用于表示编码。
    /// </value>
    string Code { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}