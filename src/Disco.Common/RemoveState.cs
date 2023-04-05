// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了逻辑删除状态枚举类型。
    /// </summary>
    public enum RemoveState
    {
        /// <summary>
        ///     尚未逻辑删除。
        /// </summary>
        NotRemove = 0,

        /// <summary>
        ///     已经逻辑删除（可以还原）。
        /// </summary>
        IsRemoved = 1,

        /// <summary>
        ///     已经逻辑删除（不可以还原，等同于物理删除）。
        /// </summary>
        IsDeleted = 2,

        /// <summary>
        ///     默认的状态，等效于 <see cref="NotRemove" />。
        /// </summary>
        Default = NotRemove
    }
}