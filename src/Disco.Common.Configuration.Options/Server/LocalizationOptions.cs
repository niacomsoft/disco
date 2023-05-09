// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using Niacomsoft.Disco.Globalization;

    /// <summary>
    ///     提供了本地化相关的配置选项。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="ISectionOptions" />
    public sealed class LocalizationOptions : ISectionOptions
    {
        private string m_culture;

        /// <summary>
        ///     文化区域名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示文化区域名称。
        /// </value>
        public string Culture
        {
            get { return Guard.SafeGet(m_culture, LocalizationDefaults.CultureName); }
            set { m_culture = value; }
        }
    }
}