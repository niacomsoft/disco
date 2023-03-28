// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace System
{
    using System.Text;

    using Niacomsoft.Disco;

    /// <summary>
    ///     为 <see cref="string" /> 类型提供的扩展方法。
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     使用编码 <paramref name="encoding" /> 获取字符串 <paramref name="s" /> 的字节数组。当 <paramref name="s" /> 等于 <c> null </c> 时，将返回 <c> null </c>。
        /// </summary>
        /// <param name="s">
        ///     字符串。
        /// </param>
        /// <param name="encoding">
        ///     编码程序。
        ///     <para> 派生自 <see cref="Encoding" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns>
        ///     字节数组。
        /// </returns>
        /// <exception cref="ArgumentNullException">
        ///     当 <paramref name="encoding" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        /// <seealso cref="Encoding" />
        public static byte[] GetBytes(this string s, Encoding encoding)
        {
            ExceptionHelper.IfArgumentNull(encoding, nameof(encoding));
            return s is null ? null : encoding.GetBytes(s);
        }

        /// <summary>
        ///     使用 <see cref="UTF8Encoding" /> 编码获取字符串 <paramref name="s" /> 的字节数组。当 <paramref name="s" /> 等于 <c> null </c> 时，将返回 <c> null </c>。
        /// </summary>
        /// <param name="s">
        ///     字符串。
        /// </param>
        /// <returns>
        ///     字节数组。
        /// </returns>
        /// <seealso cref="UTF8Encoding" />
        /// <seealso cref="Encoding.UTF8" />
        /// <seealso cref="StringExtensions.GetBytes(string, Encoding)" />
        public static byte[] GetBytes(this string s) => StringExtensions.GetBytes(s, Encoding.UTF8);

        /// <summary>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <param name="default">
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 时返回的字符串。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </returns>
        /// <seealso cref="string.IsNullOrEmpty(string)" />
        public static string IfNullOrEmpty(this string s, string @default) => string.IsNullOrEmpty(s) ? @default : s;

        /// <summary>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 或空格符时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <param name="default">
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 或空格符时返回的字符串。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 或空格符时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </returns>
        /// <seealso cref="string.IsNullOrEmpty(string)" />
        /// <seealso cref="string.IsNullOrWhiteSpace(string)" />
        public static string IfNullOrWhitespace(this string s, string @default) => string.IsNullOrWhiteSpace(s) ? @default : s;
    }
}