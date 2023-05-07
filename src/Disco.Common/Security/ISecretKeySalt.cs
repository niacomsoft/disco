// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Security
{
    /// <summary>
    ///     定义了生成密钥所需的种子字符的接口。
    /// </summary>
    public interface ISecretKeySalt
    {
        /// <summary>
        ///     随机密钥种子字符串。
        /// </summary>
        /// <value>
        ///     获取一个字符串，用于表示随机密钥种子字符串。
        /// </value>
        string Value { get; }
    }
}