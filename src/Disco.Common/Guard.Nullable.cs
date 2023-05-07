// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;

    public static partial class Guard
    {
#if NET45_OR_GREATER || NETCOREAPP || NETSTANDARD || NET

        /// <summary>
        ///     当 <c> m_value.HasValue </c> 等于 <c> false </c> 时，返回 <paramref name="safeValue" />；否则返回 <c> m_value.Value </c>。
        /// </summary>
        /// <typeparam name="TValue">
        ///     值类型。
        /// </typeparam>
        /// <param name="value">
        ///     可为空的 <typeparamref name="TValue" /> 类型的值。
        /// </param>
        /// <param name="safeValue">
        ///     当 <c> m_value.HasValue </c> 等于 <c> false </c> 时返回的 <typeparamref name="TValue" /> 类型的值。
        /// </param>
        /// <returns>
        ///     当 <c> m_value.HasValue </c> 等于 <c> false </c> 时，返回 <paramref name="safeValue" />；否则返回 <c> m_value.Value </c>。
        /// </returns>
        /// <seealso cref="Nullable{T}" />
        public static TValue SafeGet<TValue>(TValue? value, TValue safeValue) where TValue : struct
            => value.HasValue ? safeValue : value.Value;

#endif
    }
}