// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Configuration.Options.Collections;
    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了连接串相关的配置选项。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public class ConnectionStringOptions : ISectionOptions
    {
        private string m_connectionName;
        private string m_connectionStr;

        /// <summary>
        ///     初始化 <see cref="ConnectionStringOptions" /> 的新实例。
        /// </summary>
        public ConnectionStringOptions()
        {
            ReadonlyConnectionStrings = new ConnectionStringCollection();
        }

        /// <summary>
        ///     连接串。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示连接串。
        /// </value>
        [SuppressMessage("Design", "Ex0101:Member accessor may throw undocumented exception", Justification = "<挂起>")]
        public virtual string ConnectionString
        {
            get { return m_connectionStr; }
            set
            {
                Guard.TrueThrow<ArgumentNullException>(StringEqualityComparer.IsNullOrWhitespace(value, EmptyStringCompareOptions.NullOrWhitespace),
                                       nameof(ConnectionString),
                                       SR.GetString("ConnectionStringOptions_invalid_connection_string"));
                m_connectionStr = value;
            }
        }

        /// <summary>
        ///     连接串名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示连接串名称。
        /// </value>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        [SuppressMessage("Design", "Ex0101:Member accessor may throw undocumented exception", Justification = "<挂起>")]
        public virtual string Name
        {
            get { return m_connectionName; }
            set
            {
                Guard.TrueThrow<ArgumentNullException>(StringEqualityComparer.IsNullOrWhitespace(value, EmptyStringCompareOptions.NullOrWhitespace),
                                                       nameof(Name),
                                                       SR.GetString("ConnectionStringOptions_invalid_name"));
                m_connectionName = value;
            }
        }

        /// <summary>
        ///     只读的连接串集合。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="ConnectionStringCollection" /> 类型的对象实例，用于表示只读的连接串集合。
        /// </value>
        /// <seealso cref="ConnectionStringCollection" />
        public virtual ConnectionStringCollection ReadonlyConnectionStrings { get; set; }
    }
}