// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    /// <summary>
    ///     提供了 SMTP 电邮通知发信人相关的配置选项。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public class SmtpSenderOptions : ISectionOptions
    {
        /// <summary>
        ///     发信人电邮地址。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示发信人电邮地址。
        /// </value>
        public virtual string Address { get; set; }

        /// <summary>
        ///     发信人在通知邮件中显示的友好名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示发信人在通知邮件中显示的友好名称。
        /// </value>
        public virtual string FriendlyName { get; set; }

        /// <summary>
        ///     发信人登录 SMTP 服务器的密码。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示发信人登录 SMTP 服务器的密码。
        /// </value>
        public virtual string Password { get; set; }

        /// <summary>
        ///     发信人登录 SMTP 服务器的用户名。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示发信人登录 SMTP 服务器的用户名。
        /// </value>
        public virtual string UserName { get; set; }
    }
}