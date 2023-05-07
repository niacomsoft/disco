// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Security
{
    using System;

    /// <summary>
    ///     定义了密钥生成策略枚举类型。
    /// </summary>
    [Flags]
    public enum SecretKeyGeneratePolicy
    {
        /// <summary>
        ///     是否包含数字。
        /// </summary>
        IncludeNumbers = 1,

        /// <summary>
        ///     是否包含英文字母。
        /// </summary>
        IncludeLetters = 2,

        /// <summary>
        ///     是否包含特殊字符。
        /// </summary>
        IncludeSymbols = 4
    }
}