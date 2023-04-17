// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了异常日志信息相关的方法。
    /// </summary>
    public class ExceptionLoggingMessage
    {
        /// <summary>
        ///     初始化 <see cref="ExceptionLoggingMessage" /> 的新实例。
        /// </summary>
        public ExceptionLoggingMessage()
        {
        }

        /// <summary>
        ///     初始化 <see cref="ExceptionLoggingMessage" /> 的新实例。
        /// </summary>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <param name="causeReason">
        ///     引发异常的原因。
        /// </param>
        public ExceptionLoggingMessage(Exception exception, string causeReason) : this(exception.GetType(), exception.Message, causeReason)
        {
        }

        /// <summary>
        ///     初始化 <see cref="ExceptionLoggingMessage" /> 的新实例。
        /// </summary>
        /// <param name="exceptionType">
        ///     异常类型。
        /// </param>
        /// <param name="exceptionMessage">
        ///     异常描述信息。
        /// </param>
        /// <param name="causeReason">
        ///     引发异常的原因。
        /// </param>
        public ExceptionLoggingMessage(Type exceptionType, string exceptionMessage, string causeReason)
        {
            ExceptionType = exceptionType;
            ExceptionMessage = exceptionMessage;
            Reason = causeReason;
        }

        /// <summary>
        ///     异常描述信息。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示异常描述信息。
        /// </value>
        public virtual string ExceptionMessage { get; set; }

        /// <summary>
        ///     异常类型。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="Type" /> 类型的对象实例，用于表示异常类型。
        /// </value>
        /// <seealso cref="Type" />
        public virtual Type ExceptionType { get; set; }

        /// <summary>
        ///     抛出异常的原因。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示抛出异常的原因。
        /// </value>
        public virtual string Reason { get; set; }

        /// <summary>
        ///     获取用于记录在运行时日志的异常信息。
        /// </summary>
        /// <returns>
        ///     用于记录在运行时日志的异常信息。
        /// </returns>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public override string ToString()
            => SR.Format("ExceptionExtensions_get_logging_message", null, Reason, ExceptionType.FullName, ExceptionMessage);
    }
}