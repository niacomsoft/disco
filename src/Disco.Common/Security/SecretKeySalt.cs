// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Security
{
    /// <summary>
    ///     提供了生成随机密钥种子相关的方法。
    /// </summary>
    /// <seealso cref="ISecretKeySalt" />
    public abstract class SecretKeySalt : ISecretKeySalt
    {
        /// <summary>
        ///     初始化 <see cref="SecretKeySalt" /> 的新实例。
        /// </summary>
        /// <param name="salt">
        ///     密钥种子字符串。
        /// </param>
        protected SecretKeySalt(string salt)
        {
            Value = salt;
        }

        /// <summary>
        ///     随机密钥种子字符串。
        /// </summary>
        /// <value>
        ///     获取一个字符串，用于表示随机密钥种子字符串。
        /// </value>
        public virtual string Value { get; }
    }
}