/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using System;

  /// <summary>
  ///   提供了通用的事件参数相关的基本方法。
  /// </summary>
  /// <typeparam name="TData">
  ///   事件参数上下文数据类型。
  /// </typeparam>
  public class GenericEventArgs<TData> : EventArgs
  {
    #region Constructors

    /// <summary>
    ///   初始化 <see cref="GenericEventArgs{TData}" /> 类的新实例。
    /// </summary>
    public GenericEventArgs() : this(default)
    {
    }

    /// <summary>
    ///   初始化 <see cref="GenericEventArgs{TData}" /> 类的新实例。
    /// </summary>
    /// <param name="ctx">
    ///   事件参数上下文数据。
    /// </param>
    public GenericEventArgs(TData ctx)
    {
      ContextualData = ctx;
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    ///   事件参数上下文数据。
    /// </summary>
    /// <value>
    ///   获取 <typeparamref name="TData" /> 类型的值或对象实例，用于表示事件参数上下文数据。
    /// </value>
    public virtual TData ContextualData { get; }

    #endregion Properties

    #region Methods

    /// <summary>
    ///   创建一个通用事件参数 <see cref="GenericEventArgs{TData}" /> 类型的对象实例。
    /// </summary>
    /// <param name="ctx">
    ///   事件参数上下文数据。
    /// </param>
    /// <returns>
    ///   <see cref="GenericEventArgs{TData}" /> 类型的对象实例。
    /// </returns>
    public static GenericEventArgs<TData> Create(TData ctx)
    {
      return new GenericEventArgs<TData>(ctx);
    }

    /// <summary>
    ///   获取空白的通用事件参数 <see cref="GenericEventArgs{TData}" /> 类型的对象实例。
    /// </summary>
    /// <returns>
    ///   <see cref="GenericEventArgs{TData}" /> 类型的对象实例。
    /// </returns>
    public new static GenericEventArgs<TData> Empty()
    {
      return new GenericEventArgs<TData>();
    }

    #endregion Methods
  }
}