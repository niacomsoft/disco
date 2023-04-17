// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Objects
{
    /// <summary>
    ///     定义了开放标识的接口。
    /// </summary>
    public interface IOpenId
    {
        /// <summary>
        ///     开放标识。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示开放标识。
        /// </value>
        string OpenId { get; set; }
    }
}