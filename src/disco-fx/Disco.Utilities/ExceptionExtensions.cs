/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using Disco.Resources;

  using System;

  /// <summary>
  ///   为 <see cref="Exception" /> 类型提供了扩展方法。
  /// </summary>
  public static class ExceptionExtensions
  {
    #region Methods

    /// <summary>
    ///   获取异常的描述信息。
    /// </summary>
    /// <param name="me">
    ///   派生自 <see cref="Exception" /> 类型的对象实例。
    /// </param>
    /// <param name="cause">
    ///   引发运行时异常的原因。
    /// </param>
    /// <returns>
    ///   异常的描述信息。
    /// </returns>
    public static string GetDescription(this Exception me, string cause = null)
    {
      return string.IsNullOrWhiteSpace(cause)
        ? string.Format(Strings.Exception_get_description_without_cause, me.TargetSite?.Name, me.GetType().Name, me.Message)
        : string.Format(Strings.Exception_get_description_with_cause, cause.Trim(), me.GetType().Name, me.Message);
    }

    #endregion Methods
  }
}