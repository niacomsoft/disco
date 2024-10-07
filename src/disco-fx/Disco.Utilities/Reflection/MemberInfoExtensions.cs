/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Reflection
{
  using System;
  using System.Reflection;

  /// <summary>
  ///   为 <see cref="MemberInfo" /> 类型提供了扩展方法。
  /// </summary>
  public static partial class MemberInfoExtensions
  {
    #region Methods

    /// <summary>
    ///   尝试检索 <paramref name="me" /> 中的 <paramref name="attributeType" /> 类型的注解。
    ///   <para>
    ///     当 <paramref name="attribute" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <param name="me">
    ///   派生自 <see cref="MemberInfo" /> 类型的对象实例。
    /// </param>
    /// <param name="attributeType">
    ///   派生自 <see cref="Attribute" /> 的类型。
    /// </param>
    /// <param name="inherit">
    ///   是否检索继承关系。
    /// </param>
    /// <param name="attribute">
    ///   <paramref name="attributeType" /> 类型的注解。
    /// </param>
    /// <returns>
    ///   当 <paramref name="attribute" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool TryGetCustomAttribute(this MemberInfo me, Type attributeType, bool inherit, out Attribute attribute)
    {
      return (attribute = me.GetCustomAttribute(attributeType, inherit)).NotNull();
    }

    /// <summary>
    ///   尝试检索 <paramref name="me" /> 中的 <typeparamref name="TAttribute" /> 类型的注解。
    ///   <para>
    ///     当 <paramref name="attribute" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <typeparam name="TAttribute">
    ///   派生自 <see cref="Attribute" /> 的类型。
    /// </typeparam>
    /// <param name="me">
    ///   派生自 <see cref="MemberInfo" /> 类型的对象实例。
    /// </param>
    /// <param name="inherit">
    ///   是否检索继承关系。
    /// </param>
    /// <param name="attribute">
    ///   <typeparamref name="TAttribute" /> 类型的注解。
    /// </param>
    /// <returns>
    ///   当 <paramref name="attribute" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool TryGetCustomAttribute<TAttribute>(this MemberInfo me, bool inherit, out TAttribute attribute) where TAttribute : Attribute
    {
      return (attribute = me.GetCustomAttribute<TAttribute>(inherit)).NotNull();
    }

    /// <summary>
    ///   尝试检索 <paramref name="me" /> 中的 <paramref name="attributeType" /> 类型的注解。
    ///   <para>
    ///     当 <paramref name="attribute" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <param name="me">
    ///   派生自 <see cref="MemberInfo" /> 类型的对象实例。
    /// </param>
    /// <param name="attributeType">
    ///   派生自 <see cref="Attribute" /> 的类型。
    /// </param>
    /// <param name="attribute">
    ///   <paramref name="attributeType" /> 类型的注解。
    /// </param>
    /// <returns>
    ///   当 <paramref name="attribute" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool TryGetCustomAttribute(this MemberInfo me, Type attributeType, out Attribute attribute)
    {
      return me.TryGetCustomAttribute(attributeType, false, out attribute);
    }

    /// <summary>
    ///   尝试检索 <paramref name="me" /> 中的 <typeparamref name="TAttribute" /> 类型的注解。
    ///   <para>
    ///     当 <paramref name="attribute" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <typeparam name="TAttribute">
    ///   派生自 <see cref="Attribute" /> 的类型。
    /// </typeparam>
    /// <param name="me">
    ///   派生自 <see cref="MemberInfo" /> 类型的对象实例。
    /// </param>
    /// <param name="attribute">
    ///   <typeparamref name="TAttribute" /> 类型的注解。
    /// </param>
    /// <returns>
    ///   当 <paramref name="attribute" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///   。
    /// </returns>
    public static bool TryGetCustomAttribute<TAttribute>(this MemberInfo me, out TAttribute attribute) where TAttribute : Attribute
    {
      return me.TryGetCustomAttribute(false, out attribute);
    }

    #endregion Methods
  }
}