// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Logging
{
    using System;

    /// <summary>
    ///     定义了日志级别枚举类型。
    /// </summary>
    /// <seealso cref="FlagsAttribute" />
    [Flags]
    public enum LogLevel
    {
        /// <summary>
        ///     追踪级。
        /// </summary>
        Trace = 1,

        /// <summary>
        ///     调试级。
        /// </summary>
        Debug = 2,

        /// <summary>
        ///     信息级。
        /// </summary>
        Information = 4,

        /// <summary>
        ///     警告级。
        /// </summary>
        Warning = 8,

        /// <summary>
        ///     错误级。
        /// </summary>
        Error = 16,

        /// <summary>
        ///     致命的。
        /// </summary>
        Fatal = 32,

#if DEBUG

        /// <summary>
        ///     默认的（等效于 <see cref="Debug" />）。
        /// </summary>
        Default = Debug

#else
        /// <summary>
        ///     默认的（等效于 <see cref="Information" />）。
        /// </summary>
        Default = Information
#endif
    }
}