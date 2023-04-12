// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
    using System;

    /// <summary>
    ///     定义了记录运行时日志的接口。
    /// </summary>
    public interface ILogWriter
    {
        /// <summary>
        ///     记录运行时日志信息。
        /// </summary>
        /// <param name="message">
        ///     日志描述信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <param name="level">
        ///     <see cref="LogLevel" /> 类型的值。
        /// </param>
        /// <seealso cref="LogLevel" />
        /// <seealso cref="LogLevel.Default" />
        /// <seealso cref="Exception" />
        void Write(string message, Exception exception = null, LogLevel level = LogLevel.Default);

        /// <summary>
        ///     记录运行时异常日志。
        /// </summary>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <param name="causeReason">
        ///     引发此异常的原因。
        /// </param>
        /// <seealso cref="Exception" />
        void WriteException(Exception exception, string causeReason);

        /// <summary>
        ///     记录追踪信息。
        /// </summary>
        /// <param name="message">
        ///     日志描述信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="Exception" />
        void WriteTrace(string message, Exception exception = null);
    }
}