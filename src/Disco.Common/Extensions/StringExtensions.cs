// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace System
{
    using System.Text;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     为 <see cref="String" /> 类型提供的扩展方法。
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     使用指定编码 <paramref name="encoding" /> 获取字符串 <paramref name="s" /> 的字节数组。
        /// </summary>
        /// <param name="s">
        ///     字符串。
        /// </param>
        /// <param name="encoding">
        ///     指定的编码。
        /// </param>
        /// <returns>
        ///     字节数组。
        /// </returns>
        /// <seealso cref="Encoding" />
        /// <exception cref="FormatException">
        /// </exception>
        /// <exception cref="ArgumentNullException">
        ///     当 <paramref name="encoding" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        /// <seealso cref="Encoding" />
        public static byte[] GetBytes(this string s, Encoding encoding)
        {
            if (encoding is null) throw new ArgumentNullException(nameof(encoding), string.Format(Strings.ArgumentNullException_null_encoding, nameof(encoding)));
            if (s is null) return null;
            return encoding.GetBytes(s);
        }

        /// <summary>
        ///     使用 <see cref="UTF8Encoding" /> 编码获取字符串 <paramref name="s" /> 的字节数组。
        /// </summary>
        /// <param name="s">
        ///     字符串。
        /// </param>
        /// <returns>
        ///     字节数组。
        /// </returns>
        /// <seealso cref="UTF8Encoding" />
        /// <seealso cref="Encoding.UTF8" />
        /// <seealso cref="GetBytes(string, Encoding)" />
        public static byte[] GetBytes(this string s) => s.GetBytes(Encoding.UTF8);
    }
}