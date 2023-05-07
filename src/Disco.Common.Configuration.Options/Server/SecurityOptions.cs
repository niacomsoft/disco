// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    /// <summary>
    ///     提供了服务器安全相关的配置选项。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public class SecurityOptions : ISectionOptions
    {
        /// <summary>
        ///     默认的加密密钥。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示默认的加密密钥。
        /// </value>
        public virtual string DefaultSecretKey { get; set; }
    }
}