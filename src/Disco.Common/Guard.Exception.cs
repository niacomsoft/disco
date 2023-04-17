// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    public static partial class Guard
    {
        /// <summary>
        ///     当条件表达式 <paramref name="condition" /> 等于 <c> true </c> 时，将引发一个 <typeparamref name="TException" /> 类型的异常。
        /// </summary>
        /// <typeparam name="TException">
        ///     派生自 <see cref="Exception" /> 的类型。
        /// </typeparam>
        /// <param name="condition">
        ///     条件表达式。
        /// </param>
        /// <param name="exceptionArgs">
        ///     初始化 <typeparamref name="TException" /> 的新实例所需的参数数组。
        /// </param>
        /// <seealso cref="Exception" />
        /// <seealso cref="ActivatorUtilities" />
        /// <seealso cref="ActivatorUtilities.CreateInstance{T}(object[])" />
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public static void TrueThrow<TException>(bool condition, params object[] exceptionArgs) where TException : Exception
        {
            if (condition)
            {
                throw ActivatorUtilities.CreateInstance<TException>(exceptionArgs);
            }
        }

#if NET45_OR_GREATER || NETCOREAPP || NETSTANDARD || NET

        /// <summary>
        ///     当条件表达式 <paramref name="condition" /> 返回 <c> true </c> 时，将引发一个 <typeparamref name="TException" /> 类型的异常。
        /// </summary>
        /// <typeparam name="TException">
        ///     派生自 <see cref="Exception" /> 的类型。
        /// </typeparam>
        /// <param name="condition">
        ///     条件表达式。
        /// </param>
        /// <param name="exceptionArgs">
        ///     初始化 <typeparamref name="TException" /> 的新实例所需的参数数组。
        /// </param>
        /// <seealso cref="Func{TResult}" />
        /// <seealso cref="Exception" />
        /// <seealso cref="ActivatorUtilities" />
        /// <seealso cref="ActivatorUtilities.CreateInstance{T}(object[])" />
        public static void TrueThrow<TException>(Func<bool> condition, params object[] exceptionArgs) where TException : Exception 
            => TrueThrow<TException>(ReferenceEqualityComparer.NotNull(condition) && condition(), exceptionArgs);

#endif
    }
}