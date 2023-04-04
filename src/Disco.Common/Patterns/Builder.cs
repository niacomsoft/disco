// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Patterns
{
    /// <summary>
    ///     提供了构建 <typeparamref name="T" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <typeparam name="T">
    ///     引用类型。
    /// </typeparam>
    /// <seealso cref="IBuilder{T}" />
    public abstract class Builder<T> : IBuilder<T> where T : class
    {
        /// <summary>
        ///     初始化 <see cref="Builder{T}" /> 的新实例。
        /// </summary>
        protected Builder()
        {
        }

        /// <summary>
        ///     构建 <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <typeparamref name="T" /> 类型的对象实例。
        /// </returns>
        public virtual T Build()
            => InternalBuild();

        /// <summary>
        ///     构建 <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <typeparamref name="T" /> 类型的对象实例。
        /// </returns>
        protected abstract T InternalBuild();
    }
}