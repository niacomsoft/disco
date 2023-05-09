// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options
{
    using Niacomsoft.Disco.Configuration.Options.Collections;
    using Niacomsoft.Disco.Configuration.Options.Server;
    using Niacomsoft.Disco.Globalization;
    using Niacomsoft.Disco.Security;

    /// <summary>
    ///     提供了 Disco 服务相关的配置选项。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public class ServerOptions : ISectionOptions
    {
        /// <summary>
        ///     初始化 <see cref="ServerOptions" /> 的新实例。
        /// </summary>
        public ServerOptions()
        {
            ConnectionStrings = new ConnectionStringOptionsCollection();
            Authentication = new AuthenticationOptionsBuilder().WithAuthenticateRequired(true)
                                                               .WithDefaultAdministratorCredentials(new AdministratorCredentialsOptionsBuilder().WithUserName("sa")
                                                                                                                                                .WithChangePasswordRequired(true)
                                                                                                                                                .WithInitialPassword(SecretKey.Default.New(8))
                                                                                                                                                .Build())
                                                               .Build();
            Localization = new LocalizationOptionsBuilder().WithCulture(LocalizationDefaults.CultureName)
                                                           .Build();
            Notification = new NotificationOptionsBuilder().WithEmailNotification(new EmailNotificationOptionsBuilder())
                                                           .Build();
            Security = new SecurityOptionsBuilder().WithDefaultSecretKey(SecretKey.Default.New(16))
                                                   .Build();
        }

        /// <summary>
        ///     Disco 管理后台身份认证配置。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="AuthenticationOptions" /> 类型的对象实例，用于表示 Disco 管理后台身份认证配置。
        /// </value>
        /// <seealso cref="AuthenticationOptions" />
        public virtual AuthenticationOptions Authentication { get; set; }

        /// <summary>
        ///     连接串配置。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="ConnectionStringOptionsCollection" /> 类型的对象实例，用于表示连接串配置。
        /// </value>
        /// <seealso cref="ConnectionStringOptionsCollection" />
        public virtual ConnectionStringOptionsCollection ConnectionStrings { get; set; }

        /// <summary>
        ///     本地化配置。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="LocalizationOptions" /> 类型的对象实例，用于表示本地化配置。
        /// </value>
        /// <seealso cref="LocalizationOptions" />
        public virtual LocalizationOptions Localization { get; set; }

        /// <summary>
        ///     通知配置。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="NotificationOptions" /> 类型的对象实例，用于表示通知配置。
        /// </value>
        /// <seealso cref="NotificationOptions" />
        public virtual NotificationOptions Notification { get; set; }

        /// <summary>
        ///     安全配置。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="SecurityOptions" /> 类型的对象实例，用于表示安全配置。
        /// </value>
        /// <seealso cref="ServerOptions" />
        public virtual SecurityOptions Security { get; set; }

        /// <summary>
        ///     获取默认的 Disco 服务配置选项。
        /// </summary>
        /// <returns>
        ///     <see cref="ServerOptions" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="ServerOptions" />
        public static ServerOptions CreateDefault() => new ServerOptions();
    }
}