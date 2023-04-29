// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Globalization
{
    using System.Globalization;

    /// <summary>
    ///     定义了本地化文化区域切换的接口。
    /// </summary>
    public interface ILocalizationSwitcher
    {
        /// <summary>
        ///     本地文化区域变更事件。
        /// </summary>
        /// <seealso cref="CultureChangeEventHandler" />
        /// <seealso cref="CultureChangeEventArgs" />
        event CultureChangeEventHandler CultureChange;

        /// <summary>
        ///     切换本地文化区域。
        /// </summary>
        /// <param name="culture">
        ///     文化区域信息。
        ///     <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="CultureInfo" />
        void ChangeCulture(CultureInfo culture);

        /// <summary>
        ///     切换本地文化区域。
        /// </summary>
        /// <param name="cultureName">
        ///     新的文化区域名称。
        /// </param>
        void ChangeCulture(string cultureName);
    }
}