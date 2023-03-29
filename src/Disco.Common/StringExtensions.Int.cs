// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace System
{
    using Niacomsoft.Disco;

    public static partial class StringExtensions
    {
        /// <summary>
        ///     将字符串 <paramref name="s" /> 转换成等效的 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数字字符串。
        /// </param>
        /// <returns>
        ///     将字符串 <paramref name="s" /> 转换成等效的 <see cref="int" /> 类型的值。
        ///     <para> 当转换失败时，返回 <c> null </c> 值。 </para>
        /// </returns>
        /// <seealso cref="Nullable{T}"/>
        public static int? AsInt(this string s) => s.TryParseToInt(out int value) ? value : (int?)null;

        /// <summary>
        ///     将字符串 <paramref name="s" /> 转换成等效的 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数字字符串。
        /// </param>
        /// <returns>
        ///     <see cref="int" /> 类型的值。
        /// </returns>
        /// <exception cref="InvalidCastException">
        /// </exception>
        public static int ParseToInt(this string s)
        {
            if (s.TryParseToInt(out int value))
                ExceptionHelper.InvalidStringParse<int>(s);
            return value;
        }

        /// <summary>
        ///     尝试将字符串 <paramref name="s" /> 转换成等效的 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数值字符串。
        /// </param>
        /// <param name="value">
        ///     <see cref="int" /> 类型的值。
        /// </param>
        /// <returns>
        ///     是否可以转换为 <see cref="int" /> 类型的值。
        /// </returns>
        /// <seealso cref="int.TryParse(string, out int)" />
        public static bool TryParseToInt(this string s, out int value) => int.TryParse(s, out value);
    }
}