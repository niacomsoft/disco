// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Security
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了生成随机密钥相关的方法。
    /// </summary>
    /// <seealso cref="ISecretKey" />
    public class SecretKey : ISecretKey
    {
        /// <summary>
        ///     初始化 <see cref="SecretKey" /> 的新实例。
        /// </summary>
        /// <param name="salt">
        ///     生成随机密钥的种子。
        ///     <para> 实现了 <see cref="ISecretKeySalt" /> 类型接口的对象实例。 </para>
        /// </param>
        /// <seealso cref="ISecretKeySalt" />
        public SecretKey(ISecretKeySalt salt)
        {
            Salt = salt.Value.ToCharArray();
            Random = new Random();
        }

        /// <summary>
        ///     生成随机值的方法。
        /// </summary>
        /// <value>
        ///     获取 <see cref="Random" /> 类型的对象实例，用于表示生成随机值的方法。
        /// </value>
        /// <seealso cref="Random" />
        protected virtual Random Random { get; }

        /// <summary>
        ///     生成随机密钥的种子字符数组。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="char" /> 类型值数组，用于表示生成随机密钥的种子字符数组。
        /// </value>
        protected virtual char[] Salt { get; set; }

        /// <summary>
        ///     生成新的密钥。
        /// </summary>
        /// <param name="length">
        ///     密钥长度。
        /// </param>
        /// <returns>
        ///     新的密钥。
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public virtual string New(int length)
        {
            Guard.TrueThrow<ArgumentOutOfRangeException>(length < 6, nameof(length), SR.GetString("SecretKey_invalid_length"));
            var keyChars = new char[length];
            ReorderAgain();
            for(var index = 0; index < length; index++)
            {
                keyChars[index] = Salt[Random.Next(Salt.Length)];
            }
            return new string(keyChars);
        }

        /// <summary>
        ///     将种子数组打乱一次顺序。
        /// </summary>
        protected virtual void ReorderAgain()
        {
            var randomIndex = 0;
            var currentBuf = ' ';
            for (int currentIndex = 0; currentIndex < Salt.Length; currentIndex++)
            {
                randomIndex = Random.Next(0, Salt.Length - 1);
                currentBuf = Salt[currentIndex];
                Salt[currentIndex] = Salt[randomIndex];
                Salt[randomIndex] = currentBuf;
            }
        }
    }
}