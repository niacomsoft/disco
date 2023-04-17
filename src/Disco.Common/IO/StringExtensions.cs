// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.IO
{
    using System;

#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET

    /// <summary>
    ///     为 <see cref="String" /> 类型提供的扩展方法。
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     将路径字符串 <paramref name="path" /> 转换成 <see cref="IPathString" /> 类型的对象实例。
        /// </summary>
        /// <param name="path">
        ///     路径字符串。
        /// </param>
        /// <returns>
        ///     实现了 <see cref="IPathString" /> 类型接口的对象实例。
        /// </returns>
        /// <seealso cref="IPathString" />
        /// <seealso cref="PathString" />
        /// <seealso cref="PathString.FromString(string)" />
        public static IPathString ToPath(this string path)
            => PathString.FromString(path);
    }

#endif
}