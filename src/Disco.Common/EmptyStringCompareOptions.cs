// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了空字符串对比选项枚举。
    /// </summary>
    public enum EmptyStringCompareOptions
    {
        /// <summary>
        ///     仅对比字符串是否为 <c> null </c> 值。
        /// </summary>
        OnlyNull = 1,

        /// <summary>
        ///     对比字符串是否为 <c> null </c> 或 <see cref="string.Empty" />。
        /// </summary>
        NullOrEmpty = 2,

        /// <summary>
        ///     对比字符串是否为 <c> null </c>、 <see cref="string.Empty" /> 或空白符。
        /// </summary>
        NullOrWhitespace = 3,

        /// <summary>
        ///     默认的对比选项。等同于 <see cref="NullOrEmpty" />。
        /// </summary>
        Default = NullOrEmpty
    }
}