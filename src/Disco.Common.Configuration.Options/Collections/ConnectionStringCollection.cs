// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Collections
{
    using System.Collections.Generic;

    /// <summary>
    ///     提供了连接串集合。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="IList{T}" />
    /// <seealso cref="List{T}" />
    public sealed class ConnectionStringCollection : List<string>, IList<string>
    {
        /// <summary>
        ///     初始化 <see cref="ConnectionStringCollection" /> 的新实例。
        /// </summary>
        public ConnectionStringCollection() : base()
        {
        }

        /// <summary>
        ///     初始化 <see cref="ConnectionStringCollection" /> 的新实例。
        /// </summary>
        /// <param m_connectionName="connectionStrings">
        ///     用于初始化的连接串集合。
        /// </param>
        /// <seealso cref="IEnumerable{T}" />
        public ConnectionStringCollection(IEnumerable<string> connectionStrings)
            : base(connectionStrings)
        {
        }
    }
}