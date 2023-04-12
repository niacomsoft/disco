// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
#if NET40_OR_GREATER || NETSTANDARD || NETCOREAPP || NET

    /// <summary>
    ///     为 <see cref="LogLevel" /> 类型提供的扩展方法。
    /// </summary>
    public static class LogLevelExtensions
    {
        /// <summary>
        ///     使用与运算验证 <paramref name="lv1" /> 和 <paramref name="lv2" /> 是否相等。
        /// </summary>
        /// <param name="lv1">
        ///     <see cref="LogLevel" /> 类型的值。
        /// </param>
        /// <param name="lv2">
        ///     <see cref="LogLevel" /> 类型的值。
        /// </param>
        /// <returns>
        ///     如果相等则返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        public static bool IsEquals(this LogLevel lv1, LogLevel lv2) 
            => (lv1 & lv2) == lv2;

        /// <summary>
        ///     使用或运算获取多个 <see cref="LogLevel" /> 类型的组合值。
        /// </summary>
        /// <param name="lv1">
        ///     <see cref="LogLevel" /> 类型的值。
        /// </param>
        /// <param name="lv2">
        ///     <see cref="LogLevel" /> 类型的值。
        /// </param>
        /// <returns>
        ///     <see cref="LogLevel" /> 类型的值。
        /// </returns>
        public static LogLevel Or(this LogLevel lv1, LogLevel lv2)
            => lv1 | lv2;
    }

#endif
}