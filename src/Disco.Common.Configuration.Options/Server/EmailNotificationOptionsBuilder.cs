// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Net;
    using Niacomsoft.Disco.Net.SmtpProtocols;
    using Niacomsoft.Disco.Patterns;
    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了构建 <see cref="EmailNotificationOptions" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="EmailNotificationOptions" />
    public class EmailNotificationOptionsBuilder : IBuilder<EmailNotificationOptions>
    {
        private SmtpSenderOptions m_sender = null;
        private int m_smtpServerPort = SmtpProtocolDefaults.DefaultPort.Value;
        private string m_smtpServerUri = "";
        private string m_subjectTemplate = "";

        /// <summary>
        ///     构建 <see cref="EmailNotificationOptions" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="EmailNotificationOptions" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="EmailNotificationOptions" />
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public virtual EmailNotificationOptions Build()
        {
            return new EmailNotificationOptions
            {
                Sender = Guard.SafeGet(m_sender, (args) => new SmtpSenderOptionsBuilder().Build()),
                SmtpServerPort = m_smtpServerPort,
                SmtpServerUri = m_smtpServerUri,
                SubjectTemplate = Guard.SafeGet(m_subjectTemplate, SR.GetString("EmailNotificationOptions_default_subject_template"))
            };
        }

        /// <summary>
        ///     使用默认的 SMTP 服务器通信端口号。
        /// </summary>
        /// <returns>
        ///     <see cref="EmailNotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="INetworkCommunicationPort" />
        /// <seealso cref="SmtpProtocolDefaults" />
        /// <seealso cref="SmtpProtocolDefaults.DefaultPort" />
        public virtual EmailNotificationOptionsBuilder WithDefaultPort()
            => WithSmtpServerPort(SmtpProtocolDefaults.DefaultPort);

        /// <summary>
        ///     设置用于发布邮件通知的发信人 SMTP 服务器配置。
        /// </summary>
        /// <param m_connectionName="options">
        ///     发信人 SMTP 服务器配置选项。
        /// </param>
        /// <returns>
        ///     <see cref="EmailNotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="SmtpSenderOptions" />
        public virtual EmailNotificationOptionsBuilder WithSender(SmtpSenderOptions options)
        {
            m_sender = options;
            return this;
        }

        /// <summary>
        ///     设置用于发布邮件通知的发信人 SMTP 服务器配置。
        /// </summary>
        /// <param m_connectionName="builder">
        ///     实现了 <see cref="IBuilder{T}" /> 类型接口的对象实例。
        /// </param>
        /// <returns>
        ///     <see cref="EmailNotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="IBuilder{T}" />
        /// <seealso cref="SmtpSenderOptions" />
        /// <seealso cref="SmtpSenderOptionsBuilder" />
        public virtual EmailNotificationOptionsBuilder WithSender(IBuilder<SmtpSenderOptions> builder)
            => WithSender(builder.Build());

        /// <summary>
        ///     设置 SMTP 服务器通信端口号。
        /// </summary>
        /// <param m_connectionName="smtpServerPort">
        ///     通信端口号数字。
        /// </param>
        /// <returns>
        ///     <see cref="EmailNotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual EmailNotificationOptionsBuilder WithSmtpServerPort(int smtpServerPort)
        {
            m_smtpServerPort = smtpServerPort;
            return this;
        }

        /// <summary>
        ///     设置 SMTP 服务器通信端口号。
        /// </summary>
        /// <param m_connectionName="smtpServerPort">
        ///     SMTP 通信端口号。
        ///     <para> 实现了 <see cref="INetworkCommunicationPort" /> 类型接口的对象实例。 </para>
        /// </param>
        /// <returns>
        ///     <see cref="EmailNotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="INetworkCommunicationPort" />
        public virtual EmailNotificationOptionsBuilder WithSmtpServerPort(INetworkCommunicationPort smtpServerPort)
            => WithSmtpServerPort(smtpServerPort.Value);

        /// <summary>
        ///     设置 SMTP 服务器主机 URI 地址。
        /// </summary>
        /// <param m_connectionName="uri">
        ///     SMTP 服务器主机 URI 地址。
        /// </param>
        /// <returns>
        ///     <see cref="EmailNotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual EmailNotificationOptionsBuilder WithSmtpServerUri(string uri)
        {
            m_smtpServerUri = uri;
            return this;
        }

        /// <summary>
        ///     使用支持 SSL 协议的 SMTP 服务器通信端口。
        /// </summary>
        /// <returns>
        ///     <see cref="EmailNotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="INetworkCommunicationPort" />
        /// <seealso cref="SmtpProtocolDefaults" />
        /// <seealso cref="SmtpProtocolDefaults.SslProtocolPort" />
        public virtual EmailNotificationOptionsBuilder WithSslPort()
            => WithSmtpServerPort(SmtpProtocolDefaults.SslProtocolPort);

        /// <summary>
        ///     设置通知主题模板字符串。
        /// </summary>
        /// <param m_connectionName="template">
        ///     模板字符串。
        /// </param>
        /// <returns>
        ///     <see cref="EmailNotificationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual EmailNotificationOptionsBuilder WithSubjectTemplate(string template)
        {
            m_subjectTemplate = template;
            return this;
        }
    }
}