// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了默认管理员身份认证凭据相关的配置选项。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public class AdministratorCredentialsOptions : ISectionOptions
    {
        /// <summary>
        ///     默认用户名。
        /// </summary>
        public const string DefaultUserName = "sa";

        private string m_initialPwd;
        private string m_userName;

        /// <summary>
        ///     首次登录是否必须修改密码。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="bool" /> 类型值，用于表示首次登录是否必须修改密码。
        /// </value>
        public virtual bool ChangePasswordRequired { get; set; }

        /// <summary>
        ///     管理员初始密码。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示管理员初始密码。
        /// </value>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        [SuppressMessage("Design", "Ex0101:Member accessor may throw undocumented exception", Justification = "<挂起>")]
        public virtual string InitialPassword
        {
            get { return m_initialPwd; }
            set
            {
                Guard.TrueThrow<ArgumentNullException>(StringEqualityComparer.IsNullOrWhitespace(value),
                                                       nameof(InitialPassword),
                                                       SR.GetString("AdministratorCredentialsOptions_invalid_intial_pwd"));
                m_initialPwd = value;
            }
        }

        /// <summary>
        ///     默认管理员登录用户名。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示默认管理员登录用户名。
        /// </value>
        public virtual string UserName
        {
            get { return Guard.SafeGet(m_userName, DefaultUserName); }
            set { m_userName = value; }
        }
    }
}