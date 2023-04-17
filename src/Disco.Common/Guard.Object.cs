// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;

    public static partial class Guard
    {
        /// <summary>
        ///     当 <paramref name="instance" /> 等于 <c> null </c> 时，将返回 <paramref name="safeInstance" /> 返回值；否则返回 <paramref name="instance" />。
        /// </summary>
        /// <typeparam name="T">
        ///     引用类型。
        /// </typeparam>
        /// <param name="instance">
        ///     <typeparamref name="T" /> 类型的对象实例。
        /// </param>
        /// <param name="safeInstance">
        ///     当 <paramref name="instance" /> 等于 <c> null </c> 时，构造 <typeparamref name="T" /> 类型的对象实例的方法。
        /// </param>
        /// <param name="constructorArgs">
        ///     初始化 <typeparamref name="T" /> 的新实例所需的参数。
        /// </param>
        /// <returns>
        ///     当 <paramref name="instance" /> 等于 <c> null </c> 时，将返回 <paramref name="safeInstance" /> 返回值；否则返回 <paramref name="instance" />。
        /// </returns>
        /// <seealso cref="ConstructorDelegation{T}" />
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public static T SafeGet<T>(T instance, ConstructorDelegation<T> safeInstance, params object[] constructorArgs) where T : class
        {
            if (ReferenceEqualityComparer.NotNull(instance)) return instance;
            TrueThrow<ArgumentNullException>(ReferenceEqualityComparer.IsNull(safeInstance), nameof(safeInstance));
            return safeInstance(constructorArgs);
        }
    }
}