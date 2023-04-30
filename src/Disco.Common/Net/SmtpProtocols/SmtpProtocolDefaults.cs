// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Net.SmtpProtocols
{
    /// <summary>
    ///     提供了 SMTP 通信协议相关的默认值。
    /// </summary>
    public static class SmtpProtocolDefaults
    {
        /// <summary>
        ///     默认的 SMTP 通信协议端口号。
        /// </summary>
        /// <seealso cref="INetworkCommunicationPort" />
        /// <seealso cref="NetworkCommunicationPort.Create(int)" />
        public static readonly INetworkCommunicationPort DefaultPort = NetworkCommunicationPort.Create(25);

        /// <summary>
        ///     支持 SSL 的 SMTP 通信协议端口号。
        /// </summary>
        /// <seealso cref="INetworkCommunicationPort" />
        /// <seealso cref="NetworkCommunicationPort.Create(int)" />
        public static readonly INetworkCommunicationPort SslProtocolPort = NetworkCommunicationPort.Create(465);
    }
}