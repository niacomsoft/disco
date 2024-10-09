/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Models
{
  using System;

  #region Interfaces

  /// <summary>
  ///   提供了描述创建时间的接口。
  /// </summary>
  public interface ICreationTime
  {
    #region Properties

    /// <summary>
    ///   创建时间。
    /// </summary>
    /// <value>
    ///   设置或获取 <see cref="DateTime" /> 类型的值，用于表示创建时间。
    /// </value>
    DateTime CreatedAt { get; set; }

    #endregion Properties
  }

  /// <summary>
  ///   提供了描述修改时间的接口。
  /// </summary>
  public interface IModificationTime : ICreationTime
  {
    #region Properties

    /// <summary>
    ///   最后的修改时间。
    /// </summary>
    /// <value>
    ///   设置或获取可能为空的 <see cref="DateTime" /> 类型值，用于表示最后的修改时间。
    /// </value>
    DateTime? ModifiedAt { get; set; }

    /// <summary>
    ///   最后的更新时间。
    ///   <para>
    ///     当 <c> <see cref="ModifiedAt" />.HasValue </c> 等于 <see langword="false" /> 时将返回
    ///     <see cref="ICreationTime.CreatedAt" />。
    ///   </para>
    /// </summary>
    /// <value>
    ///   获取 <see cref="DateTime" /> 类型的值，用于表示最后的更新时间。
    /// </value>
    DateTime UpdatedAt { get; }

    #endregion Properties
  }

  #endregion Interfaces
}