// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Security
{
    /// <summary>
    ///     提供了生成随机密钥特殊字符串相关的方法。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="SecretKeySalt" />
    public sealed class SymbolSalt : SecretKeySalt
    {
        /// <summary>
        ///     初始化 <see cref="SecretKeySalt" /> 的新实例。
        /// </summary>
        public SymbolSalt() : base(@"!@#$%^&*-=_+<>|\/")
        {
        }
    }
}