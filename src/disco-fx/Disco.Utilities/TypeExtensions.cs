/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using System;

  /// <summary>
  ///   为 <see cref="Type" /> 类型提供了扩展方法。
  /// </summary>
  public static partial class TypeExtensions
  {
    #region Methods

    /// <summary>
    ///   当 <c> <paramref name="a" /> = <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a">
    ///   <see cref="Type" /> 类型的对象实例。
    /// </param>
    /// <param name="b">
    ///   <see cref="Type" /> 类型的对象实例。
    /// </param>
    /// <returns>
    ///   当 <c> <paramref name="a" /> = <paramref name="b" /></c> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    private static bool InstanceOf(Type a, Type b)
    {
      if (b == typeof(object) || a == b)
      {
        return true;
      }
      else
      {
        return a.BaseType.NotNull() && (a.BaseType != typeof(object)) && InstanceOf(a.BaseType, b);
      }
    }

    /// <summary>
    ///   当 <paramref name="me" /> 等于 <paramref name="target" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me">
    ///   <see cref="Type" /> 类型的对象实例。
    /// </param>
    /// <param name="target">
    ///   目标类型。
    /// </param>
    /// <param name="ifNull">
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时需要返回的结果值。
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 等于 <paramref name="target" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="target" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    public static bool Is(this Type me, Type target, bool ifNull = true)
    {
      if (me.IsNull())
      {
        return ifNull;
      }

      target.IfNull(nameof(target));
      return InstanceOf(me, target);
    }

    #endregion Methods
  }
}