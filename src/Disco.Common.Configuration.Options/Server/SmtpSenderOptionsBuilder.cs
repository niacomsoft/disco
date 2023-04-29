// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Patterns;
    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了构建 <see cref="SmtpSenderOptions" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="SmtpSenderOptions" />
    public class SmtpSenderOptionsBuilder : IBuilder<SmtpSenderOptions>
    {
        private string m_address = "";
        private string m_friendlyName = "";
        private string m_password = "";
        private string m_userName = "";

        /// <summary>
        ///     构建 <see cref="SmtpSenderOptions" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="SmtpSenderOptions" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="SmtpSenderOptions" />
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public SmtpSenderOptions Build()
        {
            return new SmtpSenderOptions
            {
                Address = m_address,
                FriendlyName = Guard.SafeGet(m_friendlyName, SR.GetString("SmtpSenderOptionsl_friendly_name")),
                Password = m_password,
                UserName = m_userName
            };
        }

        /// <summary>
        ///     设置发信人电邮地址。
        /// </summary>
        /// <param name="addr">
        ///     发信人电邮地址。
        /// </param>
        /// <returns>
        ///     <see cref="SmtpSenderOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public SmtpSenderOptionsBuilder WithAddress(string addr)
        {
            m_address = addr;
            return this;
        }

        /// <summary>
        ///     设置发信人在通知邮件中显示的友好名称。
        /// </summary>
        /// <param name="friendlyName">
        ///     发信人在通知邮件中显示的友好名称。
        /// </param>
        /// <returns>
        ///     <see cref="SmtpSenderOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public SmtpSenderOptionsBuilder WithFriendlyName(string friendlyName)
        {
            m_friendlyName = friendlyName;
            return this;
        }

        /// <summary>
        ///     设置发信人登录 SMTP 服务器的密码。
        /// </summary>
        /// <param name="pwd">
        ///     发信人登录 SMTP 服务器的密码。
        /// </param>
        /// <returns>
        ///     <see cref="SmtpSenderOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public SmtpSenderOptionsBuilder WithPassword(string pwd)
        {
            m_password = pwd;
            return this;
        }

        /// <summary>
        ///     设置发信人登录 SMTP 服务器的用户名。
        /// </summary>
        /// <param name="userName">
        ///     发信人登录 SMTP 服务器的用户名。
        /// </param>
        /// <returns>
        ///     <see cref="SmtpSenderOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public SmtpSenderOptionsBuilder WithUserName(string userName)
        {
            m_userName = userName;
            return this;
        }
    }
}