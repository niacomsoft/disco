/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  #region Interfaces

  /// <summary>
  ///   提供了记录运行时日志的接口。
  /// </summary>
  /// <typeparam name="TCategoryName">
  ///   标识类别名称的类型。
  /// </typeparam>
  public interface ILogWriter<TCategoryName> : ILogWriter
  {
  }

  #endregion Interfaces
}