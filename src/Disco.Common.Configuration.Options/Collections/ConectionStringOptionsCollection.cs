// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Collections
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

#if NET40_OR_GREATER || NETSTANDARD || NETCOREAPP || NET

    using System.Linq;

#endif

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     派生自 <see cref="ConnectionStringOptions" /> 类型的对象实例集合。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="IList{T}" />
    /// <seealso cref="List{T}" />
    /// <seealso cref="ConnectionStringOptions" />
    public sealed class ConectionStringOptionsCollection : List<ConnectionStringOptions>, IList<ConnectionStringOptions>
    {
        /// <summary>
        ///     初始化 <see cref="ConnectionStringCollection" /> 的新实例。
        /// </summary>
        public ConectionStringOptionsCollection() : base()
        {
        }

        /// <summary>
        ///     初始化 <see cref="ConnectionStringCollection" /> 的新实例。
        /// </summary>
        /// <param name="options">
        ///     连接串配置选项集合。
        /// </param>
        /// <seealso cref="IEnumerable{T}" />
        public ConectionStringOptionsCollection(IEnumerable<ConnectionStringOptions> options) : base(options)
        {
        }

        /// <summary>
        ///     获取指定名称的连接串配置选项。
        /// </summary>
        /// <param name="connectionName">
        ///     连接串名称。
        /// </param>
        /// <returns>
        ///     连接串配置选项。
        /// </returns>
        /// <seealso cref="ConnectionStringOptions" />
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public ConnectionStringOptions Get(string connectionName)
        {
            Guard.TrueThrow<ArgumentNullException>(StringEqualityComparer.IsNullOrWhitespace(connectionName, EmptyStringCompareOptions.NullOrWhitespace),
                                                   nameof(connectionName),
                                                   SR.GetString("ConnectionStringOptions_invalid_name"));

#if NET20 || NET30 || NET35
            ConnectionStringOptions options = null;
            foreach (var item in this)
            {
                if (item.Name.Equals(connectionName))
                {
                    options = item;
                    break;
                }
            }
            return options;
#else
            return this.SingleOrDefault(item => item.Name.Equals(connectionName));
#endif
        }
    }
}