// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options
{
    using System.Collections.Generic;

    using Niacomsoft.Disco.Configuration.Options.Collections;
    using Niacomsoft.Disco.Patterns;

    /// <summary>
    ///     提供了构建 <see cref="ConnectionStringOptions" /> 类型的对象实例相关的方法。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="ConnectionStringOptions" />
    public class ConnectionStringOptionsBuilder : IBuilder<ConnectionStringOptions>
    {
        private string m_connectionName;
        private string m_connectionStr;
        private readonly ConnectionStringCollection m_readonlyConnections;

        /// <summary>
        ///     初始化 <see cref="ConnectionStringOptionsBuilder" /> 的新实例。
        /// </summary>
        public ConnectionStringOptionsBuilder()
        {
            m_readonlyConnections = new ConnectionStringCollection();
        }

        /// <summary>
        ///     构建 <see cref="ConnectionStringOptions" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="ConnectionStringOptions" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="ConnectionStringOptions" />
        public virtual ConnectionStringOptions Build()
        {
            return new ConnectionStringOptions
            {
                ConnectionString = m_connectionStr,
                Name = m_connectionName,
                ReadonlyConnectionStrings = m_readonlyConnections
            };
        }

        /// <summary>
        ///     设置连接串。
        /// </summary>
        /// <param name="connectionStr">
        ///     连接串。
        /// </param>
        /// <returns>
        ///     <see cref="ConnectionStringOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual ConnectionStringOptionsBuilder WithConnectionString(string connectionStr)
        {
            m_connectionStr = connectionStr;
            return this;
        }

        /// <summary>
        ///     设置连接串名称。
        /// </summary>
        /// <param name="name">
        ///     连接串名称。
        /// </param>
        /// <returns>
        ///     <see cref="ConnectionStringOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual ConnectionStringOptionsBuilder WithName(string name)
        {
            m_connectionName = name;
            return this;
        }

        /// <summary>
        ///     设置只读连接串集合。
        /// </summary>
        /// <param name="connectionStrings">
        ///     只读的连接串。
        /// </param>
        /// <returns>
        ///     <see cref="ConnectionStringOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public virtual ConnectionStringOptionsBuilder WithReadonlyConnectionStrings(IEnumerable<string> connectionStrings)
        {
            m_readonlyConnections.AddRange(connectionStrings);
            return this;
        }
    }
}