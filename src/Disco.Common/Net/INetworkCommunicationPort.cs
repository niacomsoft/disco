// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Net
{
    /// <summary>
    ///     定义了网络通信端口的接口。
    /// </summary>
    public interface INetworkCommunicationPort
    {
        /// <summary>
        ///     端口号数值。
        /// </summary>
        /// <value>
        ///     获取一个 <see cref="int" /> 类型值，用于表示端口号数值。
        /// </value>
        int Value { get; }
    }
}