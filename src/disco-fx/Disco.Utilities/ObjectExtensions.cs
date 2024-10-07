/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using Disco.Resources;

  using System;

  /// <summary>
  ///   为 <see cref="object" /> 类型提供了扩展方法。
  /// </summary>
  public static class ObjectExtensions
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，返回 <paramref name="default" /> 默认值。
    /// </summary>
    /// <param name="me">
    ///   <see cref="object" /> 类型的对象实例。
    /// </param>
    /// <param name="default">
    ///   默认值方法。
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，返回 <paramref name="default" /> 默认值。
    /// </returns>
    public static object DefaultIfNull(this object me, Func<object> @default)
    {
      return me.IsNull() ? @default() : me;
    }

    /// <summary>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，将引发一个 <see cref="ArgumentNullException" /> 类型的异常。
    /// </summary>
    /// <param name="me">
    ///   <see cref="object" /> 类型的对象实例。
    /// </param>
    /// <param name="paraName">
    ///   参数名称。
    /// </param>
    public static void IfNull(this object me, string paraName = null)
    {
      ExceptionHelper.ThrowIf<ArgumentNullException>(me.IsNull(), paraName, string.Format(Strings.ArgumentNullException_default_message_with_argumentname, paraName));
    }

    /// <summary>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="object" /> 类型的对象实例。
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool IsNull(this object me)
    {
      return me is null;
    }

    /// <summary>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，返回 <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="object" /> 类型的对象实例。
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，返回 <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </returns>
    public static bool NotNull(this object me)
    {
      return !IsNull(me);
    }

    #endregion Methods
  }
}