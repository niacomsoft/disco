// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    /// <summary>
    ///     提供了管理后台身份认证相关的配置选项。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public class AuthenticationOptions : ISectionOptions
    {
        /// <summary>
        ///     管理后台是否必须身份认证。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="bool" /> 类型值，用于表示管理后台是否必须身份认证。
        /// </value>
        public virtual bool AuthenticateRequired { get; set; }

        /// <summary>
        ///     默认管理员身份凭据配置。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="AdministratorCredentialsOptions" /> 类型的对象实例，用于表示默认管理员身份凭据配置。
        /// </value>
        /// <seealso cref="AdministratorCredentialsOptions" />
        public virtual AdministratorCredentialsOptions DefaultAdministratorCredentials { get; set; }
    }
}