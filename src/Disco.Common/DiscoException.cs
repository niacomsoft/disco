// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了 Disco 运行时异常。
    /// </summary>
    /// <seealso cref="Exception" />
    public class DiscoException : Exception
    {
        /// <summary>
        ///     初始化 <see cref="DiscoException" /> 的新实例。
        /// </summary>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public DiscoException() : this(SR.GetString("Exception_default_message"))
        {
        }

        /// <summary>
        ///     初始化 <see cref="DiscoException" /> 的新实例。
        /// </summary>
        /// <param name="message">
        ///     描述异常的信息。
        /// </param>
        public DiscoException(string message) : this(message, null)
        {
        }

        /// <summary>
        ///     初始化 <see cref="DiscoException" /> 的新实例。
        /// </summary>
        /// <param name="cause">
        ///     引发此异常的 <see cref="Exception" /> 类型的对象实例。
        /// </param>
        public DiscoException(Exception cause) : this(null, cause)
        {
        }

        /// <summary>
        ///     初始化 <see cref="DiscoException" /> 的新实例。
        /// </summary>
        /// <param name="message">
        ///     描述异常的信息。
        /// </param>
        /// <param name="cause">
        ///     引发此异常的 <see cref="Exception" /> 类型的对象实例。
        /// </param>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public DiscoException(string message, Exception cause) : base(Guard.SafeGet(message, SR.GetString("Exception_default_message")), cause)
        {
        }
    }
}