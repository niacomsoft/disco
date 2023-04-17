// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Objects
{
    /// <summary>
    ///     定义了是否可用状态的接口。
    /// </summary>
    /// <seealso cref="IEnableState{T}" />
    /// <seealso cref="IRemoveState{T}" />
    public interface IAvailableState
    {
        /// <summary>
        ///     是否可用。
        /// </summary>
        /// <value>
        ///     获取一个 <see cref="bool" /> 类型值，用于表示是否可用。
        /// </value>
        bool Available { get; }
    }
}