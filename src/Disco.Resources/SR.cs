// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Resources
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Resources;

    /// <summary>
    ///     提供了访问内部资源信息相关的方法。
    /// </summary>
    public static class SR
    {
        private static readonly ResourceManager s_internalResourceMgr = Strings.ResourceManager;

        /// <summary>
        ///     使用指定标识名称的资源字符串并格式化。
        /// </summary>
        /// <param name="resourceName">
        ///     资源名称。
        /// </param>
        /// <param name="culture">
        ///     指定的文化区域。
        ///     <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="args">
        ///     格式化参数。
        /// </param>
        /// <returns>
        ///     格式化字符串。
        /// </returns>
        /// <seealso cref="CultureInfo" />
        /// <exception cref="MissingManifestResourceException">
        /// </exception>
        /// <exception cref="MissingSatelliteAssemblyException">
        /// </exception>
        /// <exception cref="FormatException">
        /// </exception>
        /// <exception cref="ArgumentException">
        /// </exception>
        public static string Format(string resourceName, CultureInfo culture = null, params object[] args)
            => string.Format(GetString(resourceName), args);

        /// <summary>
        ///     获取指定标识名称的资源字符串。
        /// </summary>
        /// <param name="resourceName">
        ///     资源名称。
        /// </param>
        /// <param name="culture">
        ///     指定的文化区域。
        ///     <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns>
        ///     资源字符串。
        /// </returns>
        /// <seealso cref="CultureInfo" />
        /// <exception cref="ArgumentException">
        /// </exception>
        /// <exception cref="MissingManifestResourceException">
        /// </exception>
        /// <exception cref="MissingSatelliteAssemblyException">
        /// </exception>
        public static string GetString(string resourceName, CultureInfo culture = null)
        {
            InvalidResourceName(resourceName);
            return culture is null ? s_internalResourceMgr.GetString(resourceName) : s_internalResourceMgr.GetString(resourceName, culture);
        }

        /// <summary>
        ///     当 <paramref name="resourceName" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或空格符时，将引发一个 <see cref="ArgumentException" /> 类型的异常。
        /// </summary>
        /// <param name="resourceName">
        ///     需要验证的资源名称。
        /// </param>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        private static void InvalidResourceName(string resourceName)
        {
#if NET20

            if (string.IsNullOrEmpty(resourceName))
            {
                throw new ArgumentException(Strings.ArgumentException_wrong_resource_name, nameof(resourceName));
            }

#else

            if (string.IsNullOrWhiteSpace(resourceName))
            {
                throw new ArgumentException(Strings.ArgumentException_wrong_resource_name, nameof(resourceName));
            }

#endif
        }
    }
}