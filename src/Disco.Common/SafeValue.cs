// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了获取 <typeparamref name="T" /> 类型安全值相关的基本方法。
    /// </summary>
    /// <typeparam name="T">
    ///     安全值类型。
    /// </typeparam>
    public abstract class SafeValue<T> : ISafeValue<T>
    {
        /// <summary>
        ///     <typeparamref name="T" /> 类型的原值。
        /// </summary>
        /// <value>
        ///     获取 <typeparamref name="T" /> 类型的对象实例或值，用于表示原值。
        /// </value>
        protected virtual T RawValue { get; }

        /// <summary>
        ///     当原始 <typeparamref name="T" /> 类型值等于 <c> null </c> 时，返回 <paramref name="safeValue" />。
        /// </summary>
        /// <param name="safeValue">
        ///     安全值。
        /// </param>
        /// <returns>
        ///     当原始 <typeparamref name="T" /> 类型值等于 <c> null </c> 时，返回 <paramref name="safeValue" />；否则返回原始值。
        /// </returns>
        public virtual T IfNull(T safeValue)
            => ReferenceEqualityComparer.IsNull(RawValue) ? safeValue : RawValue;

#if (NET45_OR_GREATER || NETCOREAPP || NETSTANDARD || NET)

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
        /// <exception cref="ArgumentNullException">
        /// </exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        [SuppressMessage("Design", "Ex0200:Member is documented as throwing exception not documented on member in base or interface type", Justification = "<挂起>")]
        public virtual T IfNull(Func<T> safeValue)
        {
            if (ReferenceEqualityComparer.IsNull(safeValue))
                throw new ArgumentNullException(nameof(safeValue), SR.GetString("SafeValue_ifnull_safevalue_func"));
            return ReferenceEqualityComparer.IsNull(RawValue) ? safeValue() : RawValue;
        }

#endif
    }
}