// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco.Infrastructures
{
    using System;

    using Niacomsoft.Disco.Resources;
    using Niacomsoft.Disco.Utilities;

    /// <summary>
    ///     Disco 运行时异常。
    /// </summary>
    /// <seealso cref="Exception" />
    public class DiscoException : Exception
    {
        /// <summary>
        ///     用于初始化一个 <see cref="DiscoException" /> 类型的对象实例。
        /// </summary>
        public DiscoException() : base(Strings.DiscoException_default_message)
        {
        }

        /// <summary>
        ///     用于初始化一个 <see cref="DiscoException" /> 类型的对象实例。
        /// </summary>
        /// <param name="message">
        ///     异常描述信息。
        /// </param>
        public DiscoException(string message) : base(IfExceptionMessageNullOrEmpty(message))
        {
        }

        /// <summary>
        ///     用于初始化一个 <see cref="DiscoException" /> 类型的对象实例。
        /// </summary>
        /// <param name="message">
        ///     异常描述信息。
        /// </param>
        /// <param name="innerException">
        ///     导致当前异常的异常；如果未指定内部异常，则是一个 null 引用。
        /// </param>
        public DiscoException(string message, Exception innerException) : base(IfExceptionMessageNullOrEmpty(message), innerException)
        {
        }

        /// <summary>
        ///     当异常信息 <paramref name="message" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时，将返回默认异常描述信息。
        /// </summary>
        /// <param name="message">
        ///     异常描述信息。
        /// </param>
        /// <returns>
        ///     当异常信息 <paramref name="message" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时，将返回默认异常描述信息；否则返回 <paramref name="message" />。
        /// </returns>
        /// <seealso cref="StringGuard" />
        /// <seealso cref="StringGuard.SafeGet(string, string, bool)" />
        protected static string IfExceptionMessageNullOrEmpty(string message)
            => StringGuard.SafeGet(message, Strings.DiscoException_default_message);
    }
}