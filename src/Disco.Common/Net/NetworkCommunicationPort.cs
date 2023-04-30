// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Niacomsoft.Disco.Net
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了网络通信端口相关的方法。
    /// </summary>
    /// <seealso cref="INetworkCommunicationPort" />
    public class NetworkCommunicationPort : INetworkCommunicationPort
    {
        /// <summary>
        ///     网络允许的最大通信端口号。
        /// </summary>
        /// <seealso cref="INetworkCommunicationPort" />
        /// <seealso cref="NetworkCommunicationPort" />
        public static readonly INetworkCommunicationPort Max = new NetworkCommunicationPort(c_maximumPortNumber);

        /// <summary>
        ///     网络允许的最小通信端口号。
        /// </summary>
        /// <seealso cref="INetworkCommunicationPort" />
        /// <seealso cref="NetworkCommunicationPort" />
        public static readonly INetworkCommunicationPort Min = new NetworkCommunicationPort(c_minimumPortNumber);

        private const int c_maximumPortNumber = 65535;
        private const int c_minimumPortNumber = 1;

        /// <summary>
        ///     初始化 <see cref="NetworkCommunicationPort" /> 的新实例。
        /// </summary>
        /// <param name="portNumber">
        ///     通信端口号。
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        protected NetworkCommunicationPort(int portNumber)
        {
            Guard.TrueThrow<ArgumentOutOfRangeException>(portNumber < c_minimumPortNumber || portNumber > c_maximumPortNumber,
                                                         nameof(portNumber),
                                                         SR.GetString("NetworkCommunicationPort_invalid_port_number_range"));
            Value = portNumber;
        }

        /// <summary>
        ///     端口号数值。
        /// </summary>
        /// <portNumber>
        ///     获取一个 <see cref="int" /> 类型值，用于表示端口号数值。
        /// </portNumber>
        public virtual int Value { get; }

        /// <summary>
        ///     创建实现了 <see cref="INetworkCommunicationPort" /> 类型接口的对象实例。
        /// </summary>
        /// <param name="portNumber">
        ///     端口号。
        /// </param>
        /// <returns>
        ///     实现了 <see cref="INetworkCommunicationPort" /> 类型接口的对象实例。
        /// </returns>
        /// <seealso cref="INetworkCommunicationPort" />
        /// <seealso cref="NetworkCommunicationPort" />
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        public static INetworkCommunicationPort Create(int portNumber)
            => new NetworkCommunicationPort(portNumber);
    }
}