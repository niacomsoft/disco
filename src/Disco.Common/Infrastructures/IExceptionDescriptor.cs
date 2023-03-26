// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    using System;

    /// <summary>
    ///     定义了描述 <see cref="Exception" /> 类型的对象实例的接口。
    /// </summary>
    public interface IExceptionDescriptor
    {
        /// <summary>
        ///     是否包含 <see cref="Exception.InnerException" /> 属性值。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="bool" /> 类型值，用于表示是否包含 <see cref="Exception.InnerException" /> 属性值。
        /// </value>
        /// <seealso cref="Exception" />
        /// <seealso cref="Exception.InnerException" />
        bool HasInnerExceptions { get; set; }

        /// <summary>
        ///     异常描述集合。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="ExceptionDescriptors" /> 类型的对象实例，用于表示异常描述集合。
        /// </value>
        /// <seealso cref="ExceptionDescriptors" />
        ExceptionDescriptors InnerExceptions { get; set; }

        /// <summary>
        ///     包含程序集、命名空间的异常类型完全限定名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示包含程序集、命名空间的异常类型完全限定名称。
        /// </value>
        string QualifiedTypeName { get; set; }

        /// <summary>
        ///     异常堆栈信息。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示异常堆栈信息。
        /// </value>
        string StackTrace { get; set; }

        /// <summary>
        ///     引发异常的目标信息。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="IExceptionTargetSiteDescriptor" /> 类型的对象实例，用于表示引发异常的目标信息。
        /// </value>
        /// <seealso cref="IExceptionTargetSiteDescriptor" />
        IExceptionTargetSiteDescriptor TargetSite { get; set; }

        /// <summary>
        ///     异常类型名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示异常类型名称。
        /// </value>
        string TypeName { get; set; }
    }
}