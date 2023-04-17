// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.IO
{
    using System.IO;

#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET

    /// <summary>
    ///     为 <see cref="DirectoryInfo" /> 类型提供的扩展方法。
    /// </summary>
    public static class DirectoryInfoExtensions
    {
        /// <summary>
        ///     当 <paramref name="dir" /> 不存在时，将自动创建并返回。
        /// </summary>
        /// <param name="dir">
        ///     需要确认的路径信息。
        /// </param>
        /// <returns>
        ///     <see cref="DirectoryInfo" /> 类型的对象实例。
        /// </returns>
        /// <exception cref="IOException">
        /// </exception>
        public static DirectoryInfo EnsureDirectoryExists(this DirectoryInfo dir)
        {
            if (!dir.Exists)
            {
                dir.Create();
                dir.Refresh();
            }

            return dir;
        }
    }

#endif
}