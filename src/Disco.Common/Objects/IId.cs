// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Objects
{
    /// <summary>
    ///     定义了 <typeparamref name="T" /> 类型标识的接口。
    /// </summary>
    /// <typeparam name="T">
    ///     标识类型。
    /// </typeparam>
    public interface IId<T>
    {
        /// <summary>
        ///     唯一标识。
        /// </summary>
        /// <value>
        ///     设置或获取 <typeparamref name="T" /> 类型的对象实例或值，用于表示唯一标识。
        /// </value>
        T Id { get; set; }
    }
}