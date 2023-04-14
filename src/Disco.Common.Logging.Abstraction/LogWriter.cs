// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
    using System;

    /// <summary>
    ///     提供了记录运行时日志相关的基本方法。
    /// </summary>
    /// <seealso cref="ILogWriter" />
    public abstract class LogWriter : ILogWriter
    {
        /// <summary>
        ///     记录 <see cref="LogLevel.Debug" /> 级别的运行时日志。
        /// </summary>
        /// <param name="debugInfo">
        ///     调试信息。
        /// </param>
        /// <seealso cref="LogLevel.Debug" />
        public virtual void WriteDebug(string debugInfo)
            => WriteDebug(debugInfo, null);

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
        public virtual void WriteDebug(string debugInfo, Exception exception)
            => WriteLog(debugInfo, exception, LogLevel.Debug);

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
        public virtual void WriteDebug<T>(string debugInfo)
            => WriteDebug<T>(debugInfo, null);

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
        public virtual void WriteDebug<T>(string debugInfo, Exception exception)
            => WriteLog<T>(debugInfo, exception, LogLevel.Debug);

        /// <summary>
        ///     记录 <see cref="LogLevel.Error" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     错误信息。
        /// </param>
        /// <seealso cref="LogLevel.Error" />
        public virtual void WriteError(string message)
            => WriteError(message, null);

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
        public virtual void WriteError(string message, Exception exception)
            => WriteLog(message, exception, LogLevel.Error);

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
        public virtual void WriteError<T>(string message)
            => WriteError<T>(message, null);

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
        public virtual void WriteError<T>(string message, Exception exception)
            => WriteLog<T>(message, exception, LogLevel.Error);

        /// <summary>
        ///     记录运行时异常日志。
        /// </summary>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <param name="causeReason">
        ///     引发运行时异常的原因。
        /// </param>
        public virtual void WriteException(Exception exception, string causeReason)
        {
#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET
            WriteFatal(exception.GetLoggingMessage(causeReason), exception);
#else
            WriteFatal(new ExceptionLoggingMessageBuilder().WithCauseReason(causeReason)
                                                           .WithException(exception)
                                                           .Build()
                                                           .ToString(),
                       exception);
#endif
        }

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
        public virtual void WriteException<T>(Exception exception, string causeReason)
        {
#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET
            WriteFatal<T>(exception.GetLoggingMessage(causeReason), exception);
#else
            WriteFatal<T>(new ExceptionLoggingMessageBuilder().WithCauseReason(causeReason)
                                                           .WithException(exception)
                                                           .Build()
                                                           .ToString(),
                       exception);
#endif
        }

        /// <summary>
        ///     记录 <see cref="LogLevel.Fatal" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     致命的日志描述信息。
        /// </param>
        /// <seealso cref="LogLevel.Fatal" />
        public virtual void WriteFatal(string message)
            => WriteFatal(message, null);

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
        public virtual void WriteFatal(string message, Exception exception)
            => WriteLog(message, exception, LogLevel.Fatal);

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
        public virtual void WriteFatal<T>(string message)
            => WriteFatal<T>(message, null);

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
        public virtual void WriteFatal<T>(string message, Exception exception)
            => WriteLog<T>(message, exception, LogLevel.Fatal);

        /// <summary>
        ///     记录 <see cref="LogLevel.Information" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     日志信息。
        /// </param>
        /// <seealso cref="LogLevel.Information" />
        public virtual void WriteInformation(string message)
            => WriteInformation(message, null);

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
        public virtual void WriteInformation(string message, Exception exception)
            => WriteLog(message, exception, LogLevel.Information);

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
        public virtual void WriteInformation<T>(string message)
            => WriteInformation<T>(message, null);

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
        public virtual void WriteInformation<T>(string message, Exception exception)
            => WriteLog<T>(message, exception, LogLevel.Information);

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
        public virtual void WriteLog(string message, LogLevel level = LogLevel.Default)
            => WriteLog(message, null, level);

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
        public virtual void WriteLog(string message, Exception exception, LogLevel level = LogLevel.Default)
        {
            if (CanWrite(message, exception))
            {
                if (HasException(exception))
                {
#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET
                    level = level.Or(LogLevel.Fatal);
#else
                    level = level | LogLevel.Fatal;
#endif
                }

                InternalWriteLog(message, exception, level);
            }
        }

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
        public virtual void WriteLog<T>(string message, LogLevel level = LogLevel.Default)
            => WriteLog<T>(message, null, level);

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
        public virtual void WriteLog<T>(string message, Exception exception, LogLevel level = LogLevel.Default)
        {
            if (CanWrite(message, exception))
            {
                if (HasException(exception))
                {
#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET
                    level = level.Or(LogLevel.Fatal);
#else
                    level = level | LogLevel.Fatal;
#endif
                }

                InternalWriteLog<T>(message, exception, level);
            }
        }

        /// <summary>
        ///     记录 <see cref="LogLevel.Trace" /> 级别的运行时日志。
        /// </summary>
        /// <param name="traceInfo">
        ///     追踪信息。
        /// </param>
        /// <seealso cref="LogLevel.Trace" />
        public virtual void WriteTrace(string traceInfo)
            => WriteTrace(traceInfo, null);

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
        public virtual void WriteTrace(string traceInfo, Exception exception)
            => WriteLog(traceInfo, exception, LogLevel.Trace);

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
        public virtual void WriteTrace<T>(string traceInfo)
            => WriteLog<T>(traceInfo, null);

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
        public virtual void WriteTrace<T>(string traceInfo, Exception exception)
            => WriteLog<T>(traceInfo, exception, LogLevel.Trace);

        /// <summary>
        ///     记录 <see cref="LogLevel.Warning" /> 级别的运行时日志。
        /// </summary>
        /// <param name="message">
        ///     警告信息。
        /// </param>
        /// <seealso cref="LogLevel.Warning" />
        public virtual void WriteWarning(string message)
            => WriteWarning(message, null);

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
        public virtual void WriteWarning(string message, Exception exception)
            => WriteLog(message, exception, LogLevel.Warning);

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
        public virtual void WriteWarning<T>(string message)
            => WriteWarning<T>(message, null);

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
        public virtual void WriteWarning<T>(string message, Exception exception)
            => WriteLog<T>(message, exception, LogLevel.Warning);

        /// <summary>
        ///     校验是否允许输出运行时日志。
        /// </summary>
        /// <param name="message">
        ///     运行时日志描述信息。
        /// </param>
        /// <param name="exception">
        ///     运行时异常。
        /// </param>
        /// <returns>
        ///     当 <see cref="ContainsMessage(string)" /> 和 <see cref="HasException(Exception)" /> 其中之一为 <c> true </c> 时，返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        /// <seealso cref="ContainsMessage(string)" />
        /// <seealso cref="HasException(Exception)" />
        /// <seealso cref="Exception" />
        protected virtual bool CanWrite(string message, Exception exception)
            => ContainsMessage(message) || HasException(exception);

        /// <summary>
        ///     校验是否包含有效的日志信息。
        /// </summary>
        /// <param name="message">
        ///     需要验证的日志信息。
        /// </param>
        /// <returns>
        ///     异常描述信息。
        /// </returns>
        protected virtual bool ContainsMessage(string message)
        {
#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET
            return !string.IsNullOrWhiteSpace(message);
#else
            return !string.IsNullOrEmpty(message);
#endif
        }

        /// <summary>
        ///     校验 <paramref name="exception" /> 是否不等于 <c> null </c>。
        /// </summary>
        /// <param name="exception">
        ///     需要校验的运行时异常。
        /// </param>
        /// <returns>
        ///     如果 <paramref name="exception" /> 不等于 <c> null </c>；则返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        /// <seealso cref="ReferenceEqualityComparer" />
        /// <seealso cref="ReferenceEqualityComparer.NotNull(object)" />
        /// <seealso cref="Exception" />
        protected virtual bool HasException(Exception exception)
            => ReferenceEqualityComparer.NotNull(exception);

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
        protected abstract void InternalWriteLog<T>(string message, Exception exception, LogLevel level);

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
        protected abstract void InternalWriteLog(string message, Exception exception, LogLevel level);
    }
}