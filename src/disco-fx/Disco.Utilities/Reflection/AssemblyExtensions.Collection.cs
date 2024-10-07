/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Reflection
{
  using System;
  using System.Linq;
  using System.Reflection;

  public static partial class AssemblyExtensions
  {
    #region Methods

    /// <summary>
    ///   尝试检索 <paramref name="me" /> 中的 <paramref name="attributeType" /> 类型的注解。
    ///   <para>
    ///     当 <paramref name="attributes" /> 不等于 <see langword="null" /> 且至少包含一个注解时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <param name="me">
    ///   派生自 <see cref="Assembly" /> 类型的对象实例。
    /// </param>
    /// <param name="attributeType">
    ///   派生自 <see cref="Attribute" /> 的类型。
    /// </param>
    /// <param name="inherit">
    ///   是否检索继承关系。
    /// </param>
    /// <param name="attributes">
    ///   <paramref name="attributeType" /> 类型的注解数组。
    /// </param>
    /// <returns>
    ///   当 <paramref name="attributes" /> 不等于 <see langword="null" /> 且至少包含一个注解时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool TryGetCustomAttributes(this Assembly me, Type attributeType, bool inherit, out Attribute[] attributes)
    {
      attributes = me.GetCustomAttributes(attributeType, inherit)?.Select(item => (Attribute)item).ToArray();
      return attributes.HasItems();
    }

    /// <summary>
    ///   尝试检索 <paramref name="me" /> 中的 <typeparamref name="TAttribute" /> 类型的注解。
    ///   <para>
    ///     当 <paramref name="attributes" /> 不等于 <see langword="null" /> 且至少包含一个注解时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <typeparam name="TAttribute">
    ///   派生自 <see cref="Attribute" /> 的类型。
    /// </typeparam>
    /// <param name="me">
    ///   派生自 <see cref="Assembly" /> 类型的对象实例。
    /// </param>
    /// <param name="inherit">
    ///   是否检索继承关系。
    /// </param>
    /// <param name="attributes">
    ///   <typeparamref name="TAttribute" /> 类型的注解数组。
    /// </param>
    /// <returns>
    ///   当 <paramref name="attributes" /> 不等于 <see langword="null" /> 且至少包含一个注解时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool TryGetCustomAttributes<TAttribute>(this Assembly me, bool inherit, out TAttribute[] attributes) where TAttribute : Attribute
    {
      attributes = Attribute.GetCustomAttributes(me, typeof(TAttribute), inherit)?.Select(item => (TAttribute)item).ToArray();

      return attributes.HasItems();
    }

    /// <summary>
    ///   尝试检索 <paramref name="me" /> 中的 <typeparamref name="TAttribute" /> 类型的注解。
    ///   <para>
    ///     当 <paramref name="attributes" /> 不等于 <see langword="null" /> 且至少包含一个注解时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <typeparam name="TAttribute">
    ///   派生自 <see cref="Attribute" /> 的类型。
    /// </typeparam>
    /// <param name="me">
    ///   派生自 <see cref="Assembly" /> 类型的对象实例。
    /// </param>
    /// <param name="attributes">
    ///   <typeparamref name="TAttribute" /> 类型的注解数组。
    /// </param>
    /// <returns>
    ///   当 <paramref name="attributes" /> 不等于 <see langword="null" /> 且至少包含一个注解时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool TryGetCustomAttributes<TAttribute>(this Assembly me, out TAttribute[] attributes) where TAttribute : Attribute
    {
      return me.TryGetCustomAttributes(false, out attributes);
    }

    /// <summary>
    ///   尝试检索 <paramref name="me" /> 中的 <paramref name="attributeType" /> 类型的注解。
    ///   <para>
    ///     当 <paramref name="attributes" /> 不等于 <see langword="null" /> 且至少包含一个注解时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <param name="me">
    ///   派生自 <see cref="Assembly" /> 类型的对象实例。
    /// </param>
    /// <param name="attributeType">
    ///   派生自 <see cref="Attribute" /> 的类型。
    /// </param>
    /// <param name="attributes">
    ///   <paramref name="attributeType" /> 类型的注解数组。
    /// </param>
    /// <returns>
    ///   当 <paramref name="attributes" /> 不等于 <see langword="null" /> 且至少包含一个注解时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool TryGetCustomAttributes(this Assembly me, Type attributeType, out Attribute[] attributes)
    {
      return me.TryGetCustomAttributes(attributeType, false, out attributes);
    }

    #endregion Methods
  }
}