// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
    using System;

    using Microsoft.Extensions.Logging;

    /// <summary>
    ///     提供了基于 Microsoft.Extensions.Logging 实现记录运行时日志相关的方法。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="LogWriter" />
    /// <seealso cref="ILogWriter" />
    public sealed class DefaultLogWriter : LogWriter
    {
        private readonly ILogger m_defaultLogger;
        private readonly ILoggerFactory m_loggerFactory;

        /// <summary>
        ///     初始化 <see cref="DefaultLogWriter" /> 的新实例。
        /// </summary>
        /// <param name="defaultLogger">
        ///     默认的记录运行时日志的方法。
        ///     <para> 实现了 <see cref="ILogger{TCategoryName}" /> 类型接口的对象实例。 </para>
        /// </param>
        /// <param name="loggerFactory">
        ///     实现了 <see cref="ILoggerFactory" /> 类型接口的对象实例。
        /// </param>
        /// <seealso cref="ILoggerFactory" />
        /// <seealso cref="ILogger" />
        /// <seealso cref="ILogger{TCategoryName}" />
        /// <seealso cref="DefaultLogWriter" />
        public DefaultLogWriter(ILogger<DefaultLogWriter> defaultLogger, ILoggerFactory loggerFactory)
        {
            m_defaultLogger = defaultLogger;
            m_loggerFactory = loggerFactory;
        }

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
        /// <seealso cref="Exception" />
        protected override void InternalWriteLog<T>(string message, Exception exception, LogLevel level) 
            => InternalWriteLogImpl(m_loggerFactory.CreateLogger<T>(), message, exception, level);

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
        /// <seealso cref="Exception" />
        protected override void InternalWriteLog(string message, Exception exception, LogLevel level) 
            => InternalWriteLogImpl(m_defaultLogger, message, exception, level);

        /// <summary>
        ///     记录运行时日志的方法实现。
        /// </summary>
        /// <param name="loggerImplements">
        ///     实现了 <see cref="ILogger" /> 类型接口的对象实例。
        /// </param>
        /// <param name="message">
        ///     异常描述信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <param name="level">
        ///     异常级别。
        /// </param>
        private static void InternalWriteLogImpl(ILogger loggerImplements, string message, Exception exception, LogLevel level)
        {
            if (level.IsEquals(LogLevel.Trace))
                loggerImplements.LogTrace(exception, message);
            if (level.IsEquals(LogLevel.Debug))
                loggerImplements.LogDebug(exception, message);
            if (level.IsEquals(LogLevel.Information))
                loggerImplements.LogInformation(exception, message);
            if (level.IsEquals(LogLevel.Warning))
                loggerImplements.LogWarning(exception, message);
            if (level.IsEquals(LogLevel.Error))
                loggerImplements.LogError(exception, message);
            if (level.IsEquals(LogLevel.Fatal))
                loggerImplements.LogCritical(exception, message);
        }
    }
}