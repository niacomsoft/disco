// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Security
{
    /// <summary>
    ///     提供了生成随机密钥英文字母种子相关的方法。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="SecretKeySalt" />
    public sealed class LetterSalt : SecretKeySalt
    {
        /// <summary>
        ///     初始化 <see cref="LetterSalt" /> 的新实例。
        /// </summary>
        /// <param name="lowerOnly">
        ///     是否仅需要小写的英文字母种子。
        /// </param>
        public LetterSalt(bool lowerOnly = false) : base(lowerOnly ? "abcdefghijklmnopqrstuvwxyz" : "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
        }
    }
}