// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace System
{
    using System.Collections.Generic;
    using System.Linq;

    using Niacomsoft.Disco;

    public static partial class StringExtensions
    {
        /// <summary>
        ///     从 BASE-64 字符串 <paramref name="base64Str" /> 转换为字节数组。
        /// </summary>
        /// <param name="base64Str">
        ///     BASE-64 字符串。
        /// </param>
        /// <returns>
        ///     字节数组。
        /// </returns>
        /// <exception cref="FormatException">
        /// </exception>
        /// <exception cref="ArgumentNullException">
        ///     当 <paramref name="base64Str" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        /// <seealso cref="Convert" />
        /// <seealso cref="Convert.FromBase64String(string)" />
        public static byte[] FromBase64String(this string base64Str)
        {
            ExceptionHelper.IfArgumentNull(base64Str, nameof(base64Str));
            return Convert.FromBase64String(base64Str);
        }

        /// <summary>
        ///     将字节数据 <paramref name="bytes" /> 转换成 BASE-64 字符串。
        /// </summary>
        /// <param name="bytes">
        ///     字节数据。
        /// </param>
        /// <param name="options">
        ///     BASE-64 格式化选项。
        /// </param>
        /// <returns>
        ///     BASE-64 字符串。
        /// </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <exception cref="ArgumentNullException">
        ///     当 <paramref name="bytes" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Convert" />
        /// <seealso cref="Convert.ToBase64String(byte[], Base64FormattingOptions)" />
        /// <seealso cref="Base64FormattingOptions" />
        public static string ToBase64String(this IEnumerable<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
        {
            ExceptionHelper.IfArgumentNull(bytes, nameof(bytes));
            return Convert.ToBase64String(bytes.ToArray(), options);
        }
    }
}