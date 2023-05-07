// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Security
{
    using System.Text;

    /// <summary>
    ///     提供了生成随机密钥种子相关的方法。
    /// </summary>
    /// <seealso cref="ISecretKeySalt" />
    public class SecretKeySalt : ISecretKeySalt
    {
        /// <summary>
        ///     区分大小写的英文字母密钥种子。
        /// </summary>
        /// <seealso cref="ISecretKeySalt" />
        /// <seealso cref="LetterSalt" />
        public static readonly ISecretKeySalt LetterSalt = new LetterSalt(false);

        /// <summary>
        ///     数字密钥种子。
        /// </summary>
        /// <seealso cref="ISecretKeySalt" />
        /// <seealso cref="NumberSalt" />
        public static readonly ISecretKeySalt NumberSalt = new NumberSalt();

        /// <summary>
        ///     特殊字符密钥种子。
        /// </summary>
        /// <seealso cref="ISecretKeySalt" />
        /// <seealso cref="SymbolSalt" />
        public static readonly ISecretKeySalt SymbolSalt = new SymbolSalt();

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

        /// <summary>
        ///     使用指定策略生成新的密钥种子。
        /// </summary>
        /// <param name="policy">
        ///     密钥生成策略。
        ///     <para> <see cref="SecretKeyGeneratePolicy" /> 中的一个或几个值。 </para>
        /// </param>
        /// <returns>
        ///     实现了 <see cref="ISecretKeySalt" /> 类型接口的对象实例。
        /// </returns>
        /// <seealso cref="ISecretKeySalt" />
        /// <seealso cref="SecretKeyGeneratePolicy" />
        public static ISecretKeySalt New(SecretKeyGeneratePolicy policy) 
            => new SecretKeySalt(GetSaltStringBuilder(policy).ToString());

        /// <summary>
        ///     获取密钥种子字符串。
        /// </summary>
        /// <param name="policy">
        ///     <see cref="SecretKeyGeneratePolicy" /> 中的一个或几个值。
        /// </param>
        /// <returns>
        ///     <see cref="StringBuilder" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="StringBuilder" />
        /// <seealso cref="SecretKeyGeneratePolicy" />
        private static StringBuilder GetSaltStringBuilder(SecretKeyGeneratePolicy policy)
        {
            var saltBuilder = new StringBuilder();
            if ((policy & SecretKeyGeneratePolicy.IncludeNumbers) == SecretKeyGeneratePolicy.IncludeNumbers)
                saltBuilder.Append(NumberSalt.Value);
            if ((policy & SecretKeyGeneratePolicy.IncludeLetters) == SecretKeyGeneratePolicy.IncludeLetters)
                saltBuilder.Append(LetterSalt.Value);
            if ((policy & SecretKeyGeneratePolicy.IncludeSymbols) == SecretKeyGeneratePolicy.IncludeSymbols)
                saltBuilder.Append(SymbolSalt.Value);
            return saltBuilder;
        }
    }
}