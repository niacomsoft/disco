// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Resources;

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
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public static string GetLoggingMessage(this Exception exception, string causeReason)
        {
            return SR.Format("ExceptionExtensions_get_logging_message",
                             null,
                             Guard.SafeGet(causeReason,
                                           SR.Format("ExceptionExtensions_get_logging_message_no_cause_reason",
                                                     null,
                                                     exception.TargetSite.DeclaringType.FullName,
                                                     exception.TargetSite.Name)),
                             exception.GetType().FullName,
                             exception.Message);
        }
    }

#endif
}