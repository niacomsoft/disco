/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  /// <summary>
  ///   提供了 Disco 默认值相关的静态 <see langword="static" /> 方法。
  /// </summary>
  public static class DefaultValue
  {
    #region Constants

    /// <summary>
    ///   与 <see langword="false" /> 等效的值。
    /// </summary>
    public const int FalseValue = 0;

    /// <summary>
    ///   <see langword="null" /> 等效的 <see cref="bool" /> 类型的值。
    /// </summary>
    public const bool NullValue = false;

    /// <summary>
    ///   与 <see langword="true" /> 等效的值。
    /// </summary>
    public const int TrueValue = 1;

    #endregion Constants
  }
}