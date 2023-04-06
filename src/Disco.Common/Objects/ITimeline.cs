// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Objects
{
    using System;

    /// <summary>
    ///     定义了记录重要时间节点的接口。
    /// </summary>
    public interface ITimeline
    {
        /// <summary>
        ///     首次创建时间。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="DateTime" /> 类型值，用于表示首次创建时间。
        /// </value>
        /// <seealso cref="DateTime" />
        DateTime FirstCreated { get; set; }

#if NET45_OR_GREATER || NETCOREAPP || NETSTANDARD || NET

        /// <summary>
        ///     最后修改时间。
        ///     <para> 当 <c> LastUpdated.HasValue </c> 等于 <c> true </c> 时，返回 <c> LastUpdated.Value </c>；否则返回 <see cref="FirstCreated" />。 </para>
        /// </summary>
        /// <value>
        ///     获取一个 <see cref="DateTime" /> 类型值，用于表示最后修改时间。
        /// </value>
        /// <seealso cref="DateTime" />
        DateTime LastModified { get; }

        /// <summary>
        ///     最后更新时间。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="DateTime" /> 类型值，用于表示最后更新时间。
        /// </value>
        /// <seealso cref="DateTime" />
        /// <seealso cref="Nullable{T}" />
        DateTime? LastUpdated { get; set; }

#else
        /// <summary>
        ///     最后更新时间。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="DateTime" /> 类型值，用于表示最后更新时间。
        /// </value>
        /// <seealso cref="DateTime" />
        DateTime LastUpdated { get; set; }

        /// <summary>
        ///     最后修改时间。
        ///     <para> 返回 <see cref="FirstCreated" /> 和 <see cref="LastUpdated" /> 中更晚的一个值。 </para>
        /// </summary>
        /// <value>
        ///     获取一个 <see cref="DateTime" /> 类型值，用于表示最后修改时间。
        /// </value>
        /// <seealso cref="DateTime" />
        DateTime LastModified { get; }
#endif
    }
}