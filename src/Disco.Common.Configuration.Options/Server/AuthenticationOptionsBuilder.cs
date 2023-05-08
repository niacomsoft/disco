// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using Niacomsoft.Disco.Patterns;

    /// <summary>
    ///     提供了构建 <see cref="AuthenticationOptions" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="AuthenticationOptions" />
    public class AuthenticationOptionsBuilder : IBuilder<AuthenticationOptions>
    {
        private AdministratorCredentialsOptions m_adminCredentialsOptions;
        private bool m_authenRequired;

        /// <summary>
        ///     构建 <see cref="AuthenticationOptions" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="AuthenticationOptions" /> 类型的对象实例。
        /// </returns>
        public virtual AuthenticationOptions Build()
        {
            return new AuthenticationOptions
            {
                AuthenticateRequired = m_authenRequired,
                DefaultAdministratorCredentials = Guard.SafeGet(m_adminCredentialsOptions, (args) => new AdministratorCredentialsOptionsBuilder().WithUserName(AdministratorCredentialsOptions.DefaultUserName).WithChangePasswordRequired(true).Build())
            };
        }

        /// <summary>
        ///     设置登录 Disco 管理平台时，是否必须进行身份认证。
        /// </summary>
        /// <param name="authenRequired">
        ///     是否必须身份认证。
        /// </param>
        /// <returns>
        ///     <see cref="AuthenticationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual AuthenticationOptionsBuilder WithAuthenticateRequired(bool authenRequired)
        {
            m_authenRequired = authenRequired;
            return this;
        }

        /// <summary>
        ///     设置默认管理员身份凭据信息。
        /// </summary>
        /// <param name="credentialsOptions">
        ///     <see cref="AdministratorCredentialsOptions" /> 类型的对象实例。
        /// </param>
        /// <returns>
        ///     <see cref="AuthenticationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual AuthenticationOptionsBuilder WithDefaultAdministratorCredentials(AdministratorCredentialsOptions credentialsOptions)
        {
            m_adminCredentialsOptions = credentialsOptions;
            return this;
        }
    }
}