// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     提供了引用类型是否相等相关的比较方法。
    /// </summary>
    public static class ReferenceEqualityComparer
    {
        /// <summary>
        ///     用于校验 <paramref name="value" /> 是否等于 <c> null </c> 值。
        /// </summary>
        /// <param name="value">
        ///     需要验证的对象实例或值。
        /// </param>
        /// <returns>
        ///     当 <paramref name="value" /> 等于 <c> null </c> 时，返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        public static bool IsNull(object value) 
            => value is null;

        /// <summary>
        ///     用于校验 <paramref name="value" /> 是否不等于 <c> null </c> 值。
        /// </summary>
        /// <param name="value">
        ///     需要验证的对象实例或值。
        /// </param>
        /// <returns>
        ///     当 <paramref name="value" /> 等于 <c> null </c> 时，返回 <c> false </c>；否则返回 <c> true </c>。
        /// </returns>
        /// <seealso cref="ReferenceEqualityComparer.IsNull(object)" />
        public static bool NotNull(object value) 
            => !IsNull(value);
    }
}