// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco.Resources
{
    using System;
    using System.Globalization;
    using System.Resources;

    /// <summary>
    ///     提供了读取字符串资源相关的方法。
    /// </summary>
    public static class SR
    {
        /// <summary>
        ///     使用资源标识名称为 <paramref name="resKey" /> 的格式化。
        /// </summary>
        /// <param name="resKey">
        ///     资源标识名称。
        /// </param>
        /// <param name="args">
        ///     格式化参数数组。
        /// </param>
        /// <returns>
        ///     格式化字符串。
        /// </returns>
        /// <exception cref="MissingManifestResourceException">
        /// </exception>
        /// <exception cref="MissingSatelliteAssemblyException">
        /// </exception>
        /// <exception cref="FormatException">
        /// </exception>
        /// <seealso cref="GetString(string, CultureInfo)" />
        /// <seealso cref="string.Format(string, object[])" />
        public static string Format(string resKey, params object[] args) => string.Format(GetString(resKey), args);

        /// <summary>
        ///     使用资源标识名称为 <paramref name="resKey" /> 的格式化。
        /// </summary>
        /// <param name="resKey">
        ///     资源标识名称。
        /// </param>
        /// <param name="culture">
        ///     指定的文化区域。
        /// </param>
        /// <param name="args">
        ///     格式化参数数组。
        /// </param>
        /// <returns>
        ///     格式化字符串。
        /// </returns>
        /// <exception cref="MissingManifestResourceException">
        /// </exception>
        /// <exception cref="MissingSatelliteAssemblyException">
        /// </exception>
        /// <exception cref="FormatException">
        /// </exception>
        /// <seealso cref="CultureInfo" />
        /// <seealso cref="GetString(string, CultureInfo)" />
        /// <seealso cref="string.Format(string, object[])" />
        public static string Format(string resKey, CultureInfo culture, params object[] args) => string.Format(GetString(resKey, culture), args);

        /// <summary>
        ///     获取指定文化区域设置中标识名称为 <paramref name="resKey" /> 的字符串资源值。
        /// </summary>
        /// <param name="resKey">
        ///     资源标识名称。
        /// </param>
        /// <param name="culture">
        ///     指定的文化区域。
        /// </param>
        /// <returns>
        ///     字符串资源值。
        /// </returns>
        /// <seealso cref="CultureInfo" />
        /// <exception cref="ArgumentNullException">
        ///     当 <paramref name="resKey" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时，将引发此类型的异常。
        /// </exception>
        /// <exception cref="MissingManifestResourceException">
        ///     当调用方法 <see cref="ResourceManager.GetString(string, CultureInfo)" /> 时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="MissingSatelliteAssemblyException">
        ///     当调用方法 <see cref="ResourceManager.GetString(string, CultureInfo)" /> 时，可能引发此类型的异常。
        /// </exception>
        public static string GetString(string resKey, CultureInfo culture = null)
        {
            InvalidResourceKey(resKey);
            return Strings.ResourceManager.GetString(resKey, culture);
        }

        /// <summary>
        ///     当 <paramref name="resKey" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时，将引发一个 <see cref="ArgumentNullException" /> 类型的异常。
        /// </summary>
        /// <param name="resKey">
        ///     资源标识名称。
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        private static void InvalidResourceKey(string resKey)
        {
            if (string.IsNullOrWhiteSpace(resKey))
            {
                throw new ArgumentNullException(nameof(resKey), Strings.SR_null_or_empty_resource_key);
            }
        }
    }
}