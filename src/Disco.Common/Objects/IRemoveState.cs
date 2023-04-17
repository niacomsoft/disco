// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Objects
{
    /// <summary>
    ///     定义了描述逻辑删除状态的接口。
    /// </summary>
    /// <typeparam name="T">
    ///     值类型。
    /// </typeparam>
    public interface IRemoveState<T> where T : struct
    {
        /// <summary>
        ///     是否被逻辑删除。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <typeparamref name="T" /> 类型值，用于表示是否被逻辑删除。
        /// </value>
        T Removed { get; set; }
    }
}