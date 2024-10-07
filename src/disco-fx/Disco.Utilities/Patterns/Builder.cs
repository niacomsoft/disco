/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Patterns
{
  using Disco.Resources;

  using System;
  using System.Collections.Generic;

  /// <summary>
  ///   提供了构建 <typeparamref name="T" /> 类型的对象实例相关的抽象 <see langword="abstract" /> 方法。
  /// </summary>
  /// <typeparam name="T">
  ///   目标类型。
  /// </typeparam>
  public abstract class Builder<T> : IBuilder<T> where T : class
  {
    #region Constructors

    /// <summary>
    ///   初始化 <see cref="Builder{T}" /> 类的新实例。
    /// </summary>
    protected Builder()
    {
      PropertyContext = new Dictionary<string, object>();
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    ///   <typeparamref name="T" /> 类型属性上下文数据。
    /// </summary>
    /// <value>
    ///   获取 <see cref="IDictionary{TKey, TValue}" /> 类型的对象实例，用于表示 <typeparamref name="T" /> 类型属性上下文数据。
    /// </value>
    protected virtual IDictionary<string, object> PropertyContext { get; }

    #endregion Properties

    #region Methods

    /// <summary>
    ///   设置指定名称的属性值，并获取构建器。
    /// </summary>
    /// <param name="propertyName">
    ///   属性名称。
    /// </param>
    /// <param name="propertyValue">
    ///   属性值。
    /// </param>
    /// <returns>
    ///   实现了 <see cref="IBuilder{T}" /> 类型接口的对象实例 <see langword="this" />。
    /// </returns>
    // ExceptionAdjustment: M:System.String.Format(System.String,System.Object) -T:System.FormatException
    protected virtual IBuilder<T> InternalSetAndGet(string propertyName, object propertyValue)
    {
      ExceptionHelper.ThrowIf<ArgumentException>(string.IsNullOrWhiteSpace(propertyName), string.Format(Strings.ArgumentException_empty_or_whitespace, nameof(propertyName)), nameof(propertyName));

      PropertyContext[propertyName.Trim()] = propertyValue;

      return this;
    }

    /// <summary>
    ///   尝试获取名称为 <paramref name="propertyName" /> 的数值型。
    /// </summary>
    /// <param name="propertyName">
    ///   属性名称。
    /// </param>
    /// <param name="propertyValue">
    ///   属性值。
    /// </param>
    /// <returns>
    ///   当 <see cref="PropertyContext" /> 包含了名称为 <paramref name="propertyName" /> 属性值 （无论是否为 <see langword="null" />） 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    protected virtual bool TryGetPropertyValue(string propertyName, out object propertyValue)
    {
      return PropertyContext.TryGetValue(propertyName.Trim(), out propertyValue);
    }

    /// <inheritdoc />
    public abstract T Build();

    /// <inheritdoc />
    public abstract T Build(params object[] args);

    #endregion Methods
  }
}