// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;

    using Niacomsoft.Disco.Logging;

#if NET30_OR_GREATER || NETCOREAPP || NETSTANDARD || NET

    /// <summary>
    ///     为 <see cref="Exception" /> 类型提供的扩展方法。
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        ///     获取可以记录在运行时日志的异常描述信息。
        /// </summary>
        /// <param name="exception">
        ///     <see cref="Exception" /> 类型的对象实例。
        /// </param>
        /// <param name="causeReason">
        ///     引发异常的原因。
        /// </param>
        /// <returns>
        ///     可以记录在运行时日志的异常描述信息。
        /// </returns>
        public static string GetLoggingMessage(this Exception exception, string causeReason)
        {
            return new ExceptionLoggingMessageBuilder().WithException(exception)
                                                       .WithCauseReason(causeReason)
                                                       .Build()
                                                       .ToString();
        }
    }

#endif
}