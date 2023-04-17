// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
    using System;

    public partial interface ILogWriter
    {
        /// <summary>
        ///     记录 <see cref="LogLevel.Debug" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="debugInfo">
        ///     调试信息。
        /// </param>
        /// <seealso cref="LogLevel.Debug" />
        void WriteDebug<T>(string debugInfo);

        /// <summary>
        ///     记录 <see cref="LogLevel.Debug" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="debugInfo">
        ///     调试信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Debug" />
        /// <seealso cref="Exception" />
        void WriteDebug<T>(string debugInfo, Exception exception);

        /// <summary>
        ///     记录 <see cref="LogLevel.Error" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     错误信息。
        /// </param>
        /// <seealso cref="LogLevel.Error" />
        void WriteError<T>(string message);

        /// <summary>
        ///     记录 <see cref="LogLevel.Error" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     错误信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Error" />
        /// <seealso cref="Exception" />
        void WriteError<T>(string message, Exception exception);

        /// <summary>
        ///     记录运行时异常日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <param name="causeReason">
        ///     引发运行时异常的原因。
        /// </param>
        void WriteException<T>(Exception exception, string causeReason);

        /// <summary>
        ///     记录 <see cref="LogLevel.Fatal" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     致命的日志描述信息。
        /// </param>
        /// <seealso cref="LogLevel.Fatal" />
        void WriteFatal<T>(string message);

        /// <summary>
        ///     记录 <see cref="LogLevel.Fatal" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     致命的日志描述信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Fatal" />
        /// <seealso cref="Exception" />
        void WriteFatal<T>(string message, Exception exception);

        /// <summary>
        ///     记录 <see cref="LogLevel.Information" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     日志信息。
        /// </param>
        /// <seealso cref="LogLevel.Information" />
        void WriteInformation<T>(string message);

        /// <summary>
        ///     记录 <see cref="LogLevel.Information" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     日志信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Information" />
        /// <seealso cref="Exception" />
        void WriteInformation<T>(string message, Exception exception);

        /// <summary>
        ///     写入运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     日志描述信息。
        /// </param>
        /// <param name="level">
        ///     <see cref="LogLevel" /> 中的一个或几个值。
        /// </param>
        /// <seealso cref="LogLevel" />
        /// <seealso cref="LogLevel.Default" />
        void WriteLog<T>(string message, LogLevel level = LogLevel.Default);

        /// <summary>
        ///     记录运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
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
        void WriteLog<T>(string message, Exception exception, LogLevel level = LogLevel.Default);

        /// <summary>
        ///     记录 <see cref="LogLevel.Trace" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="traceInfo">
        ///     追踪信息。
        /// </param>
        /// <seealso cref="LogLevel.Trace" />
        void WriteTrace<T>(string traceInfo);

        /// <summary>
        ///     记录 <see cref="LogLevel.Trace" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="traceInfo">
        ///     追踪信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Trace" />
        /// <seealso cref="Exception" />
        void WriteTrace<T>(string traceInfo, Exception exception);

        /// <summary>
        ///     记录 <see cref="LogLevel.Warning" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     警告信息。
        /// </param>
        /// <seealso cref="LogLevel.Warning" />
        void WriteWarning<T>(string message);

        /// <summary>
        ///     记录 <see cref="LogLevel.Warning" /> 级别的运行时日志。
        /// </summary>
        /// <typeparam name="T">
        ///     记录日志的类别。
        /// </typeparam>
        /// <param name="message">
        ///     警告信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <seealso cref="LogLevel.Warning" />
        /// <seealso cref="Exception" />
        void WriteWarning<T>(string message, Exception exception);
    }
}