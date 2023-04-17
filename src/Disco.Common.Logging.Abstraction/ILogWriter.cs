// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
    using System;

    /// <summary>
    ///     定义了记录运行时日志的接口。
    /// </summary>
    public partial interface ILogWriter
    {
        /// <summary>
        ///     记录 <see cref="LogLevel.Debug" /> 级别的运行时日志。
        /// </summary>
        /// <param name="debugInfo">
        ///     调试信息。
        /// </param>
        /// <seealso cref="LogLevel.Debug" />
        void WriteDebug(string debugInfo);

        /// <summary>
        ///     记录 <see cref="LogLevel.Debug" /> 级别的运行时日志。
        /// </summary>
        /// <param name="debugInfo">
        ///     调试信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Debug" />
        /// <seealso cref="Exception" />
        void WriteDebug(string debugInfo, Exception exception);

        /// <summary>
        ///     记录 <see cref="LogLevel.Error" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     错误信息。
        /// </param>
        /// <seealso cref="LogLevel.Error" />
        void WriteError(string message);

        /// <summary>
        ///     记录 <see cref="LogLevel.Error" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     错误信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Error" />
        /// <seealso cref="Exception" />
        void WriteError(string message, Exception exception);

        /// <summary>
        ///     记录运行时异常日志。
        /// </summary>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <param name="causeReason">
        ///     引发运行时异常的原因。
        /// </param>
        void WriteException(Exception exception, string causeReason);

        /// <summary>
        ///     记录 <see cref="LogLevel.Fatal" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     致命的日志描述信息。
        /// </param>
        /// <seealso cref="LogLevel.Fatal" />
        void WriteFatal(string message);

        /// <summary>
        ///     记录 <see cref="LogLevel.Fatal" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     致命的日志描述信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Fatal" />
        /// <seealso cref="Exception" />
        void WriteFatal(string message, Exception exception);

        /// <summary>
        ///     记录 <see cref="LogLevel.Information" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     日志信息。
        /// </param>
        /// <seealso cref="LogLevel.Information" />
        void WriteInformation(string message);

        /// <summary>
        ///     记录 <see cref="LogLevel.Information" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     日志信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Information" />
        /// <seealso cref="Exception" />
        void WriteInformation(string message, Exception exception);

        /// <summary>
        ///     写入运行时日志。
        /// </summary>
        /// <param name="message">
        ///     日志描述信息。
        /// </param>
        /// <param name="level">
        ///     <see cref="LogLevel" /> 中的一个或几个值。
        /// </param>
        /// <seealso cref="LogLevel" />
        /// <seealso cref="LogLevel.Default" />
        void WriteLog(string message, LogLevel level = LogLevel.Default);

        /// <summary>
        ///     记录运行时日志。
        /// </summary>
        /// <param name="message">
        ///     日志描述信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <param name="level">
        ///     <see cref="LogLevel" /> 中的一个或几个值。
        /// </param>
        /// <seealso cref="LogLevel" />
        /// <seealso cref="LogLevel.Default" />
        /// <seealso cref="Exception" />
        void WriteLog(string message, Exception exception, LogLevel level = LogLevel.Default);

        /// <summary>
        ///     记录 <see cref="LogLevel.Trace" /> 级别的运行时日志。
        /// </summary>
        /// <param name="traceInfo">
        ///     追踪信息。
        /// </param>
        /// <seealso cref="LogLevel.Trace" />
        void WriteTrace(string traceInfo);

        /// <summary>
        ///     记录 <see cref="LogLevel.Trace" /> 级别的运行时日志。
        /// </summary>
        /// <param name="traceInfo">
        ///     追踪信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Trace" />
        /// <seealso cref="Exception" />
        void WriteTrace(string traceInfo, Exception exception);

        /// <summary>
        ///     记录 <see cref="LogLevel.Warning" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     警告信息。
        /// </param>
        /// <seealso cref="LogLevel.Warning" />
        void WriteWarning(string message);

        /// <summary>
        ///     记录 <see cref="LogLevel.Warning" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     警告信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Warning" />
        /// <seealso cref="Exception" />
        void WriteWarning(string message, Exception exception);
    }
}