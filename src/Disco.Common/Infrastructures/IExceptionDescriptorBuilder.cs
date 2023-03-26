// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    using System;

    /// <summary>
    ///     定义了构建实现了 <see cref="IExceptionDescriptor" /> 类型接口的对象实例的方法。
    /// </summary>
    /// <typeparam name="T">
    ///     实现了 <see cref="IExceptionDescriptor" /> 类型接口的对象实例。
    /// </typeparam>
    /// <seealso cref="IObjectBuilder{T}" />
    /// <seealso cref="IExceptionDescriptor" />
    public interface IExceptionDescriptorBuilder<T> : IObjectBuilder<T>
        where T : class, IExceptionDescriptor
    {
        /// <summary>
        ///     设置运行时异常。
        /// </summary>
        /// <param name="exception">
        ///     派生自 <see cref="Exception" /> 类型的对象实例。
        /// </param>
        /// <returns>
        ///     实现了 <see cref="IExceptionDescriptorBuilder{T}" /> 类型接口的对象实例。
        /// </returns>
        IExceptionDescriptorBuilder<T> WithException(Exception exception);
    }
}