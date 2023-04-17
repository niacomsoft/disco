// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了处理 <typeparamref name="T" /> 类型构造方法的委托。
    /// </summary>
    /// <typeparam name="T">
    ///     应用类型。
    /// </typeparam>
    /// <param name="constructorArgs">
    ///     构造函数参数。
    /// </param>
    /// <returns>
    ///     <typeparamref name="T" /> 类型的对象实例。
    /// </returns>
    public delegate T ConstructorDelegation<T>(params object[] constructorArgs) where T : class;
}