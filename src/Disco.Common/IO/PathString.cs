// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.IO
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了路径字符串相关的方法。
    /// </summary>
    /// <seealso cref="IPathString" />
    public class PathString : IPathString
    {
        /// <summary>
        ///     初始化 <see cref="PathString" /> 的新实例。
        /// </summary>
        public PathString() : this(string.Empty)
        {
        }

        /// <summary>
        ///     初始化 <see cref="PathString" /> 的新实例。
        /// </summary>
        /// <param name="basePath">
        ///     基础路径。
        /// </param>
        public PathString(string basePath)
        {
            BasePath = Guard.SafeGet(basePath, string.Empty);
        }

        /// <summary>
        ///     基础路径。
        /// </summary>
        /// <value>
        ///     获取一个字符串，用于表示基础路径。
        /// </value>
        public virtual string BasePath { get; }

        /// <summary>
        ///     路径字符串。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示路径字符串。
        /// </value>
        protected virtual string InternalPath { get; set; }

        /// <summary>
        ///     从字符串 <paramref name="basePath" /> 创建一个 <see cref="IPathString" /> 类型的对象实例。
        /// </summary>
        /// <param name="basePath">
        ///     基础路径字符串。
        /// </param>
        /// <returns>
        ///     实现了 <see cref="IPathString" /> 类型接口的对象实例。
        /// </returns>
        /// <seealso cref="IPathString" />
        /// <seealso cref="PathString" />
        public static IPathString FromString(string basePath)
            => new PathString(basePath);

        /// <summary>
        ///     拼接字符串数组为路径字符串。
        /// </summary>
        /// <param name="pathParts">
        ///     组成路径的部分字符串。
        /// </param>
        /// <returns>
        ///     实现了 <see cref="IPathString" /> 类型接口的对象实例。
        /// </returns>
        public virtual IPathString Combine(params string[] pathParts)
        {
            InternalPath = Guard.SafeGet(InternalPath, BasePath);

#if NET45_OR_GREATER || NETCOREAPP || NETSTANDARD || NET
            InternalPath = Path.Combine(InternalPath, Path.Combine(pathParts));
#else

            foreach (var path in pathParts)
            {
                InternalPath = Path.Combine(InternalPath, path);
            }

#endif
            return this;
        }

        /// <summary>
        ///     从路径字符串创建 <see cref="DirectoryInfo" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="DirectoryInfo" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="DirectoryInfo" />
        /// <exception cref="System.Security.SecurityException">
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// </exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        [SuppressMessage("Design", "Ex0200:Member is documented as throwing exception not documented on member in base or interface type", Justification = "<挂起>")]
        public virtual DirectoryInfo CreateDirectory()
        {
#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET
            Guard.TrueThrow<ArgumentNullException>(string.IsNullOrWhiteSpace(InternalPath), nameof(InternalPath), SR.GetString("ArgumentNullException_null_path_string"));
#else
            Guard.TrueThrow<ArgumentNullException>(string.IsNullOrEmpty(InternalPath), nameof(InternalPath), SR.GetString("ArgumentNullException_null_path_string"));
#endif

            return new DirectoryInfo(InternalPath);
        }

        /// <summary>
        ///     从路径字符串创建 <see cref="FileInfo" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="FileInfo" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="FileInfo" />
        /// <exception cref="System.Security.SecurityException">
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// </exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        [SuppressMessage("Design", "Ex0200:Member is documented as throwing exception not documented on member in base or interface type", Justification = "<挂起>")]
        public FileInfo CreateFile()
        {
#if NET40_OR_GREATER || NETCOREAPP || NETSTANDARD || NET
            Guard.TrueThrow<ArgumentNullException>(string.IsNullOrWhiteSpace(InternalPath), nameof(InternalPath), SR.GetString("ArgumentNullException_null_path_string"));
#else
            Guard.TrueThrow<ArgumentNullException>(string.IsNullOrEmpty(InternalPath), nameof(InternalPath), SR.GetString("ArgumentNullException_null_path_string"));
#endif

            return new FileInfo(InternalPath);
        }
    }
}