// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Objects
{
    /// <summary>
    ///     定义了名称相关的接口。
    /// </summary>
    public interface IName
    {
        /// <summary>
        ///     显示名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示显示名称。
        /// </value>
        string DisplayName { get; set; }

        /// <summary>
        ///     友好名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示友好名称。
        /// </value>
        string FriendlyName { get; set; }

        /// <summary>
        ///     名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示名称。
        /// </value>
        string Name { get; set; }
    }
}