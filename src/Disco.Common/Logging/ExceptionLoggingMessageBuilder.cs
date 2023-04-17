// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Patterns;
    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了构建 <see cref="ExceptionLoggingMessage" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="Builder{T}" />
    public class ExceptionLoggingMessageBuilder : Builder<ExceptionLoggingMessage>, IBuilder<ExceptionLoggingMessage>
    {
        private string m_causeReason;
        private Exception m_exception;

        /// <summary>
        ///     设置引发运行时异常的原因。
        /// </summary>
        /// <param name="reason">
        ///     引发异常的原因。
        /// </param>
        /// <returns>
        ///     <see cref="ExceptionLoggingMessageBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual ExceptionLoggingMessageBuilder WithCauseReason(string reason)
        {
            m_causeReason = reason;
            return this;
        }

        /// <summary>
        ///     设置运行时异常。
        /// </summary>
        /// <param name="exception">
        ///     运行时异常。
        ///     <para> <see cref="Exception" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns>
        ///     <see cref="ExceptionLoggingMessageBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="Exception" />
        public virtual ExceptionLoggingMessageBuilder WithException(Exception exception)
        {
            m_exception = exception;
            return this;
        }

        /// <summary>
        ///     构建 <see cref="ExceptionLoggingMessageBuilder" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="ExceptionLoggingMessageBuilder" /> 类型的对象实例。
        /// </returns>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        protected override ExceptionLoggingMessage InternalBuild()
        {
            Guard.TrueThrow<ArgumentNullException>(ReferenceEqualityComparer.IsNull(m_exception), nameof(m_exception));

            return new ExceptionLoggingMessage(m_exception,
                                               Guard.SafeGet(m_causeReason,
                                                             SR.Format("ExceptionExtensions_get_logging_message_no_cause_reason",
                                                                       null,
                                                                       m_exception.TargetSite.DeclaringType.FullName,
                                                                       m_exception.TargetSite.Name)));
        }
    }
}