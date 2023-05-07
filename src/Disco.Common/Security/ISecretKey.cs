// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Security
{
    /// <summary>
    ///     定义了生成密钥的接口。
    /// </summary>
    public interface ISecretKey
    {
        /// <summary>
        ///     生成新的密钥。
        /// </summary>
        /// <param name="length">
        ///     密钥长度。
        /// </param>
        /// <returns>
        ///     新的密钥。
        /// </returns>
        string New(int length);
    }
}