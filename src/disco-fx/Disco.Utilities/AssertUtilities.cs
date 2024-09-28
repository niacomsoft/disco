/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  /// <summary>
  ///   提供了断言相关的静态 <see langword="static" /> 方法。
  /// </summary>
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="obj" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="obj">
    ///   需要校验的 <see cref="object" /> 类型的对象实例。
    /// </param>
    /// <returns>
    ///   当 <paramref name="obj" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool IsNull(object obj) => obj is null;

    /// <summary>
    ///   当 <paramref name="obj" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="obj">
    ///   需要校验的 <see cref="object" /> 类型的对象实例。
    /// </param>
    /// <returns>
    ///   当 <paramref name="obj" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool NotNull(object obj) => !IsNull(obj);

    #endregion Methods
  }
}