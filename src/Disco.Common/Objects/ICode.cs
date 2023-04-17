// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Objects
{
    /// <summary>
    ///     定义了唯一编码的接口。
    /// </summary>
    public interface ICode
    {
        /// <summary>
        ///     唯一编码。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示唯一编码。
        /// </value>
        string Code { get; set; }
    }
}