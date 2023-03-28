// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    using System;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了 “Disco” 运行时异常相关的基本方法。
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class DiscoException : Exception
    {
        private static readonly string sr_exceptionMessage = SR.GetString("DiscoException_default_exception_message");

        /// <summary>
        ///     初始化 <see cref="DiscoException" /> 类的新实例。
        /// </summary>
        public DiscoException() : base(sr_exceptionMessage)
        {
        }

        /// <summary>
        ///     用指定的错误消息初始化 <see cref="DiscoException" /> 类的新实例。
        /// </summary>
        /// <param name="message">
        ///     描述错误的消息。
        /// </param>
        public DiscoException(string message) : base(StringExtensions.IfNullOrWhitespace(message, sr_exceptionMessage))
        {
        }

        /// <summary>
        ///     使用指定的错误消息和对作为此异常原因的内部异常的引用来初始化 <see cref="DiscoException" /> 类的新实例。
        /// </summary>
        /// <param name="message">
        ///     解释异常原因的错误消息。
        /// </param>
        /// <param name="innerException">
        ///     导致当前异常的异常；如果未指定内部异常，则是一个 null 引用（在 Visual Basic 中为 <see langword="Nothing" />）。
        /// </param>
        public DiscoException(string message, Exception innerException) : base(StringExtensions.IfNullOrWhitespace(message, sr_exceptionMessage), innerException)
        {
        }
    }
}