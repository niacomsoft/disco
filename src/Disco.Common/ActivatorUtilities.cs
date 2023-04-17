// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;

    /// <summary>
    ///     提供了动态创建类型对象实例相关的方法。
    /// </summary>
    public static class ActivatorUtilities
    {
        /// <summary>
        ///     创建 <paramref name="target" /> 类型的对象实例。
        /// </summary>
        /// <param name="target">
        ///     类类型。
        /// </param>
        /// <param name="constructorArgs">
        ///     构造函数参数。
        /// </param>
        /// <returns>
        ///     类型为 <paramref name="target" /> 的对象实例。
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// </exception>
        /// <exception cref="System.Reflection.TargetInvocationException">
        /// </exception>
        /// <exception cref="MethodAccessException">
        /// </exception>
        /// <exception cref="MemberAccessException">
        /// </exception>
        /// <exception cref="System.Runtime.InteropServices.InvalidComObjectException">
        /// </exception>
        /// <exception cref="System.Runtime.InteropServices.COMException">
        /// </exception>
        /// <exception cref="TypeLoadException">
        /// </exception>
        /// <seealso cref="Type" />
        /// <seealso cref="Activator" />
        /// <seealso cref="Activator.CreateInstance(Type, object[])" />
        public static object CreateInstance(Type target, params object[] constructorArgs)
            => Activator.CreateInstance(target, constructorArgs);

        /// <summary>
        ///     创建 <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T">
        ///     引用类型。
        /// </typeparam>
        /// <param name="constructorArgs">
        ///     构造函数参数。
        /// </param>
        /// <returns>
        ///     <typeparamref name="T" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="ActivatorUtilities.CreateInstance(Type, object[])" />
        /// <exception cref="NotSupportedException">
        /// </exception>
        /// <exception cref="System.Reflection.TargetInvocationException">
        /// </exception>
        /// <exception cref="MethodAccessException">
        /// </exception>
        /// <exception cref="MemberAccessException">
        /// </exception>
        /// <exception cref="System.Runtime.InteropServices.InvalidComObjectException">
        /// </exception>
        /// <exception cref="System.Runtime.InteropServices.COMException">
        /// </exception>
        /// <exception cref="TypeLoadException">
        /// </exception>
        public static T CreateInstance<T>(params object[] constructorArgs) where T : class
            => CreateInstance(typeof(T), constructorArgs) as T;

        /// <summary>
        ///     创建 <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T">
        ///     引用类型。
        /// </typeparam>
        /// <param name="ctor">
        ///     构造函数。
        ///     <para> <see cref="ConstructorDelegation{T}" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="constructorArgs">
        ///     改造函数参数。
        /// </param>
        /// <returns>
        ///     <typeparamref name="T" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="ConstructorDelegation{T}" />
        public static T CreateInstance<T>(ConstructorDelegation<T> ctor, params object[] constructorArgs) where T : class
            => ctor(constructorArgs);
    }
}