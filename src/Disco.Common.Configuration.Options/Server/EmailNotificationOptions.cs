// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using Niacomsoft.Disco.Net;

    /// <summary>
    ///     提供了电邮通知相关的配置选项。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public class EmailNotificationOptions : ISectionOptions
    {
        /// <summary>
        ///     是否启用 E-mail 通知。
        /// </summary>
        /// <value>
        ///     获取一个 <see cref="bool" /> 类型值，用于表示是否启用 E-mail 通知。
        /// </value>
        public virtual bool Enabled
        {
            get
            {
                return ReferenceEqualityComparer.NotNull(Sender)
                       && Sender.IsValid
                       && !StringEqualityComparer.IsNullOrWhitespace(SmtpServerUri, EmptyStringCompareOptions.NullOrWhitespace)
                       && SmtpServerPort >= NetworkCommunicationPort.Min.Value
                       && SmtpServerPort <= NetworkCommunicationPort.Max.Value;
            }
        }

        /// <summary>
        ///     SMTP 通知发布者电邮配置。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="SmtpSenderOptions" /> 类型的对象实例，用于表示 SMTP 通知发布者电邮配置。
        /// </value>
        /// <seealso cref="SmtpSenderOptions" />
        public virtual SmtpSenderOptions Sender { get; set; }

        /// <summary>
        ///     SMTP 服务器通信端口号。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="int" /> 类型值，用于表示 SMTP 服务器通信端口号。
        /// </value>
        public virtual int SmtpServerPort { get; set; }

        /// <summary>
        ///     SMTP 服务器 URI 地址。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示 SMTP 服务器 URI 地址。
        /// </value>
        public virtual string SmtpServerUri { get; set; }

        /// <summary>
        ///     通知电邮主题模板字符串。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示通知电邮主题模板字符串。
        /// </value>
        public virtual string SubjectTemplate { get; set; }
    }
}