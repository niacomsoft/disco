// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED.
//
// LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco.Diagnostics
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// 提供了记录追踪信息相关的方法。
    /// </summary>
    public static class TraceWriter
    {
        private static readonly Lazy<IDictionary<TraceLevel, string>> sr_categoryDictionary = new Lazy<IDictionary<TraceLevel, string>>(() => new Dictionary<TraceLevel, string>
            {
                { TraceLevel.Debug, "[DEBUG]: " },
                { TraceLevel.Trace, "[TRACE]: " },
                { TraceLevel.Error, "[ERROR]: " },
                { TraceLevel.Information, "[INFO]: " },
                { TraceLevel.Warning, "[WARN]: " }
            }, true);

        /// <summary>
        /// 当 <paramref name="condition" /> 等于 <c> true </c> 时，输出追踪信息。
        /// </summary>
        /// <param name="condition">
        /// 条件表达式。
        /// </param>
        /// <param name="message">
        /// 追踪信息。
        /// </param>
        /// <param name="level">
        /// 追踪级别。
        /// <para> <see cref="TraceLevel" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 条件表达式。
        /// <para> 参见： <paramref name="condition" />。 </para>
        /// </returns>
        /// <seealso cref="TraceLevel" />
        public static bool TrueWrite(bool condition, string message, TraceLevel level = TraceLevel.Default)
        {
            if (condition)
                Write(message, level);
            return condition;
        }

        /// <summary>
        /// 输出追踪信息。
        /// </summary>
        /// <param name="message">
        /// 追踪信息。
        /// </param>
        /// <param name="level">
        /// 追踪级别。
        /// <para> <see cref="TraceLevel" /> 类型的值。 </para>
        /// </param>
        /// <seealso cref="TraceLevel" />
        public static void Write(string message, TraceLevel level = TraceLevel.Default)
            => InternalWrite(level, message);

        /// <summary>
        /// 输出追踪信息。
        /// </summary>
        /// <param name="message">
        /// 追踪消息模板。
        /// </param>
        /// <param name="level">
        /// 追踪级别。
        /// <para> <see cref="TraceLevel" /> 类型的值。 </para>
        /// </param>
        /// <param name="args">
        /// 追踪消息格式化参数数组。
        /// </param>
        /// <seealso cref="TraceLevel" />
        /// <exception cref="FormatException">
        /// </exception>
        public static void Write(string message, TraceLevel level = TraceLevel.Default, params object[] args)
        {
            if (args is null) InternalWrite(level, message);
            else InternalWrite(level, string.Format(message, args));
        }

        /// <summary>
        /// 输出追踪信息。
        /// </summary>
        /// <param name="level">
        /// 追踪级别。
        /// <para> <see cref="TraceLevel" /> 类型的值。 </para>
        /// </param>
        /// <param name="message">
        /// 追踪信息。
        /// </param>
        /// <seealso cref="TraceLevel" />
        private static void InternalWrite(TraceLevel level, string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                if (level.IsEquals(TraceLevel.Trace))
                    Trace.WriteLine($"{sr_categoryDictionary.Value[TraceLevel.Trace]}{message}");
                if (level.IsEquals(TraceLevel.Debug))
                    Trace.WriteLine($"{sr_categoryDictionary.Value[TraceLevel.Debug]}{message}");
                if (level.IsEquals(TraceLevel.Information))
                    Trace.TraceInformation($"{sr_categoryDictionary.Value[TraceLevel.Information]}{message}");
                if (level.IsEquals(TraceLevel.Warning))
                    Trace.TraceWarning($"{sr_categoryDictionary.Value[TraceLevel.Warning]}{message}");
                if (level.IsEquals(TraceLevel.Error))
                    Trace.TraceError($"{sr_categoryDictionary.Value[TraceLevel.Error]}{message}");
            }
        }
    }
}