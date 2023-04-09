// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.IO
{
    using System.IO;

    /// <summary>
    ///     定义了与磁盘路径字符串相关的接口。
    /// </summary>
    public interface IPathString
    {
        /// <summary>
        ///     基础路径。
        /// </summary>
        /// <value>
        ///     获取一个字符串，用于表示基础路径。
        /// </value>
        string BasePath { get; }

        /// <summary>
        ///     拼接字符串数组为路径字符串。
        /// </summary>
        /// <param name="pathParts">
        ///     组成路径的部分字符串。
        /// </param>
        /// <returns>
        ///     实现了 <see cref="IPathString" /> 类型接口的对象实例。
        /// </returns>
        IPathString Combine(params string[] pathParts);

        /// <summary>
        ///     从路径字符串创建 <see cref="DirectoryInfo" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="DirectoryInfo" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="DirectoryInfo" />
        DirectoryInfo CreateDirectory();

        /// <summary>
        ///     从路径字符串创建 <see cref="FileInfo" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="FileInfo" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="FileInfo" />
        FileInfo CreateFile();
    }
}