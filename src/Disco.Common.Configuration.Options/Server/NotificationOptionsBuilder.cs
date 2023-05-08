// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using Niacomsoft.Disco.Patterns;

    /// <summary>
    ///     提供了构建 <see cref="NotificationOptions" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="NotificationOptions" />
    public class NotificationOptionsBuilder : IBuilder<NotificationOptions>
    {
        private EmailNotificationOptions m_emailNotification = null;

        /// <summary>
        ///     构建 <see cref="NotificationOptions" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="NotificationOptions" /> 类型的对象实例。
        /// </returns>
        public virtual NotificationOptions Build()
        {
            return new NotificationOptions
            {
                EmailNotification = m_emailNotification
            };
        }

        /// <summary>
        ///     设置 E-mail 通知配置。
        /// </summary>
        /// <param m_connectionName="options">
        ///     <see cref="EmailNotificationOptions" /> 类型的对象实例。
        /// </param>
        /// <returns>
        ///     <see cref="NotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="EmailNotificationOptions" />
        public virtual NotificationOptionsBuilder WithEmailNotification(EmailNotificationOptions options)
        {
            m_emailNotification = options;
            return this;
        }

        /// <summary>
        ///     设置 E-mail 通知配置。
        /// </summary>
        /// <param m_connectionName="builder">
        ///     构建 <see cref="EmailNotificationOptions" /> 类型的对象实例的方法。
        /// </param>
        /// <returns>
        ///     <see cref="NotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="IBuilder{T}" />
        /// <seealso cref="EmailNotificationOptions" />
        /// <seealso cref="EmailNotificationOptionsBuilder" />
        /// <seealso cref="WithEmailNotification(EmailNotificationOptions)" />
        public virtual NotificationOptionsBuilder WithEmailNotification(IBuilder<EmailNotificationOptions> builder)
        {
            return WithEmailNotification(builder.Build());
        }
    }
}