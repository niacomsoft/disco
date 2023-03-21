// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED.
//
// LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco.Diagnostics
{
    using System;

    /// <summary>
    /// 定义了诊断器追踪级别枚举类型。
    /// </summary>
    /// <seealso cref="FlagsAttribute" />
    [Flags]
    public enum TraceLevel
    {
        /// <summary>
        /// 追踪。
        /// </summary>
        Trace = 1,

        /// <summary>
        /// 调试。
        /// </summary>
        Debug = 2,

        /// <summary>
        /// 信息。
        /// </summary>
        Information = 4,

        /// <summary>
        /// 警告。
        /// </summary>
        Warning = 8,

        /// <summary>
        /// 错误。
        /// </summary>
        Error = 16,

        /// <summary>
        /// 默认的。等效于 <see cref="Debug" />。
        /// </summary>
        /// <seealso cref="Debug" />
        Default = Debug
    }
}