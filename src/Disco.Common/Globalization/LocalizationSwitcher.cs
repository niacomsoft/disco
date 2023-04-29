// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Globalization
{
    using System.Globalization;
    using System.Threading;

    /// <summary>
    ///     提供了切换本地文化区域相关的方法。
    /// </summary>
    /// <seealso cref="ILocalizationSwitcher" />
    public class LocalizationSwitcher : ILocalizationSwitcher
    {
        /// <summary>
        ///     本地文化区域变更事件。
        /// </summary>
        /// <seealso cref="CultureChangeEventHandler" />
        /// <seealso cref="CultureChangeEventArgs" />
        public event CultureChangeEventHandler CultureChange;

        /// <summary>
        ///     切换本地文化区域。
        /// </summary>
        /// <param name="culture">
        ///     文化区域信息。
        ///     <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="CultureInfo" />
        /// <seealso cref="Thread" />
        /// <seealso cref="Thread.CurrentThread" />
        /// <seealso cref="Thread.CurrentUICulture" />
        /// <seealso cref="Thread.CurrentCulture" />
        public void ChangeCulture(CultureInfo culture)
            => Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = culture;

        /// <summary>
        ///     切换本地文化区域。
        /// </summary>
        /// <param name="cultureName">
        ///     新的文化区域名称。
        /// </param>
        public virtual void ChangeCulture(string cultureName)
            => ChangeCulture(new CultureInfo(Guard.SafeGet(cultureName, LocalizationDefaults.CultureName)));

        /// <summary>
        ///     用于引发事件 <see cref="CultureChange" />。
        /// </summary>
        /// <param name="e">
        ///     <see cref="CultureChangeEventArgs" /> 类型的对象实例。
        /// </param>
        /// <seealso cref="CultureChangeEventArgs" />
        /// <seealso cref="CultureChange" />
        protected virtual void OnCultureChange(CultureChangeEventArgs e)
            => CultureChange?.Invoke(this, e);
    }
}