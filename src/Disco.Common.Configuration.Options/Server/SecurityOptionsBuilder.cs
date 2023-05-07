// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using Niacomsoft.Disco.Patterns;
    using Niacomsoft.Disco.Security;

    /// <summary>
    ///     提供了构建 <see cref="SecurityOptions" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="SecurityOptions" />
    public class SecurityOptionsBuilder : IBuilder<SecurityOptions>
    {
        private string m_defaultSecretKey;

        /// <summary>
        ///     构建 <see cref="SecurityOptions" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="SecurityOptions" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="SecurityOptions" />
        public virtual SecurityOptions Build()
        {
            return new SecurityOptions
            {
                DefaultSecretKey = Guard.SafeGet(m_defaultSecretKey, SecretKey.Default.New(16))
            };
        }

        /// <summary>
        ///     设置默认的加密密钥。
        /// </summary>
        /// <param name="secretKey">
        ///     加密密钥。
        /// </param>
        /// <returns>
        ///     <see cref="SecurityOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual SecurityOptionsBuilder WithDefaultSecretKey(string secretKey)
        {
            m_defaultSecretKey = secretKey;
            return this;
        }
    }
}