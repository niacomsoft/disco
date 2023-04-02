// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;

    /// <summary>
    ///     定义了 <typeparamref name="T" /> 类型安全值的接口。
    /// </summary>
    /// <typeparam name="T">
    ///     目标安全值类型。
    /// </typeparam>
    public interface ISafeValue<T>
    {
        /// <summary>
        ///     当原始 <typeparamref name="T" /> 类型值等于 <c> null </c> 时，返回 <paramref name="safeValue" />。
        /// </summary>
        /// <param name="safeValue">
        ///     安全值。
        /// </param>
        /// <returns>
        ///     当原始 <typeparamref name="T" /> 类型值等于 <c> null </c> 时，返回 <paramref name="safeValue" />；否则返回原始值。
        /// </returns>
        T IfNull(T safeValue);

#if !(NET20)

        /// <summary>
        ///     当原始 <typeparamref name="T" /> 类型值等于 <c> null </c> 时，返回 <paramref name="safeValue" /> 的返回值。
        /// </summary>
        /// <param name="safeValue">
        ///     安全值构造方法。
        /// </param>
        /// <returns>
        ///     当原始 <typeparamref name="T" /> 类型值等于 <c> null </c> 时，返回 <paramref name="safeValue" /> 的返回值；否则返回原始值。
        /// </returns>
        /// <seealso cref="Func{TResult}" />
        T IfNull(Func<T> safeValue);

#endif
    }
}