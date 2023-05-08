// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using Niacomsoft.Disco.Patterns;
    using Niacomsoft.Disco.Security;

    /// <summary>
    ///     提供了构建 <see cref="AdministratorCredentialsOptions" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="AdministratorCredentialsOptions" />
    public class AdministratorCredentialsOptionsBuilder : IBuilder<AdministratorCredentialsOptions>
    {
        private bool m_changePwdRequired;
        private string m_initialPwd;
        private string m_userName;

        /// <summary>
        ///     构建 <see cref="AdministratorCredentialsOptions" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="AdministratorCredentialsOptions" /> 类型的对象实例。
        /// </returns>
        public virtual AdministratorCredentialsOptions Build()
        {
            return new AdministratorCredentialsOptions
            {
                UserName = Guard.SafeGet(m_userName, AdministratorCredentialsOptions.DefaultUserName),
                InitialPassword = Guard.SafeGet(m_initialPwd, SecretKey.Default.New(8)),
                ChangePasswordRequired = m_changePwdRequired
            };
        }

        /// <summary>
        ///     设置初次登录是否必须修改密码。
        /// </summary>
        /// <param name="changePwdRequired">
        ///     设置初次登录是否必须修改密码。
        /// </param>
        /// <returns>
        ///     <see cref="AdministratorCredentialsOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual AdministratorCredentialsOptionsBuilder WithChangePasswordRequired(bool changePwdRequired)
        {
            m_changePwdRequired = changePwdRequired;
            return this;
        }

        /// <summary>
        ///     设置初始登录密码。
        /// </summary>
        /// <param name="initialPwd">
        ///     初始密码。
        /// </param>
        /// <returns>
        ///     <see cref="AdministratorCredentialsOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual AdministratorCredentialsOptionsBuilder WithInitialPassword(string initialPwd)
        {
            m_initialPwd = initialPwd;
            return this;
        }

        /// <summary>
        ///     设置初始登录用户名。
        /// </summary>
        /// <param name="userName">
        ///     初始用户名。
        /// </param>
        /// <returns>
        ///     <see cref="AdministratorCredentialsOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual AdministratorCredentialsOptionsBuilder WithUserName(string userName)
        {
            m_userName = userName;
            return this;
        }
    }
}