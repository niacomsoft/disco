// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Objects
{
    using Niacomsoft.Disco.Collections;

    /// <summary>
    ///     定义了描述信息的接口。
    /// </summary>
    public interface IDescription
    {
        /// <summary>
        ///     描述信息。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示描述信息。
        /// </value>
        string Description { get; set; }

        /// <summary>
        ///     多行的描述信息。
        /// </summary>
        /// <value>
        ///     获取 <see cref="MultiLineDescription" /> 类型的对象实例，用于表示多行的描述信息。
        /// </value>
        /// <seealso cref="Collections.MultiLineDescription" />
        MultiLineDescription MultiLineDescription { get; }
    }
}