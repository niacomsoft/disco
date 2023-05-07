// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    /// <summary>
    ///     提供了通知相关的配置选项。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public class NotificationOptions : ISectionOptions
    {
        /// <summary>
        ///     E-mail 通知配置。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="EmailNotificationOptions" /> 类型的对象实例，用于表示 E-mail 通知配置。
        /// </value>
        /// <seealso cref="EmailNotificationOptions" />
        public virtual EmailNotificationOptions EmailNotification { get; set; }

        /// <summary>
        ///     是否启用 E-mail 电邮通知。
        /// </summary>
        /// <value>
        ///     获取一个 <see cref="bool" /> 类型值，用于表示是否启用 E-mail 电邮通知。
        /// </value>
        public virtual bool EmailNotificationAvailable
        {
            get
            {
                return ReferenceEqualityComparer.NotNull(EmailNotification) && EmailNotification.Enabled;
            }
        }
    }
}