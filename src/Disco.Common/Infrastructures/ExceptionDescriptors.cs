// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    using System.Collections.Generic;

    /// <summary>
    ///     实现了 <see cref="IExceptionDescriptor" /> 类型接口的对象实例的集合。
    ///     <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IList{T}" />
    /// <seealso cref="List{T}" />
    /// <seealso cref="IExceptionDescriptor" />
    /// <remarks>
    ///     密闭的，不可以从此类型派生。
    /// </remarks>
    public sealed class ExceptionDescriptors : List<IExceptionDescriptor>, IList<IExceptionDescriptor>
    {
        /// <summary>
        ///     用于初始化一个 <see cref="ExceptionDescriptors" /> 类型的对象实例。
        /// </summary>
        public ExceptionDescriptors()
        {
        }

        /// <summary>
        ///     用于初始化一个 <see cref="ExceptionDescriptors" /> 类型的对象实例。
        /// </summary>
        /// <param name="collection">
        ///     用于初始化的实现了 <see cref="IExceptionDescriptor" /> 类型接口的对象实例集合。
        /// </param>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="IExceptionDescriptor" />
        public ExceptionDescriptors(IEnumerable<IExceptionDescriptor> collection) : base(collection)
        {
        }
    }
}