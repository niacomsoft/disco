// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED.
//
// LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco.Diagnostics
{
    /// <summary>
    /// 为 <see cref="TraceLevel" /> 类型提供的扩展方法。
    /// </summary>
    public static class TraceLevelExtensions
    {
        /// <summary>
        /// 获取多个 <see cref="TraceLevel" /> 类型的值。
        /// </summary>
        /// <param name="contextualLevel">
        /// <see cref="TraceLevel" /> 类型的值。
        /// </param>
        /// <param name="other">
        /// 需要合并的 <see cref="TraceLevel" /> 类型的值。
        /// </param>
        /// <returns>
        /// 合并后的 <see cref="TraceLevel" /> 类型的值。
        /// </returns>
        /// <seealso cref="System.FlagsAttribute" />
        public static TraceLevel Or(this TraceLevel contextualLevel, TraceLevel other)
            => contextualLevel | other;

        /// <summary>
        /// 校验 <paramref name="contextualLevel" /> 与 <paramref name="comparableLevel" /> 是否相等。
        /// </summary>
        /// <param name="contextualLevel">
        /// <see cref="TraceLevel" /> 类型的值。
        /// </param>
        /// <param name="comparableLevel">
        /// 需要对比的 <see cref="TraceLevel" /> 类型的值。
        /// </param>
        /// <returns>
        /// 当 <paramref name="contextualLevel" /> 与 <paramref name="comparableLevel" /> 相等时，返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        internal static bool IsEquals(this TraceLevel contextualLevel, TraceLevel comparableLevel = TraceLevel.Default)
            => (contextualLevel & comparableLevel) == comparableLevel;
    }
}