// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Configuration.Options.Server
{
    using Niacomsoft.Disco.Patterns;

    /// <summary>
    ///     提供了构建 <see cref="LocalizationOptions" /> 类型的对象实例相关的方法。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="IBuilder{T}" />
    /// <seealso cref="LocalizationOptions" />
    public sealed class LocalizationOptionsBuilder : IBuilder<LocalizationOptions>
    {
        private string m_culture;

        /// <summary>
        ///     构建 <see cref="LocalizationOptions" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <see cref="LocalizationOptions" /> 类型的对象实例。
        /// </returns>
        public LocalizationOptions Build()
        {
            return new LocalizationOptions
            {
                Culture = m_culture
            };
        }

        /// <summary>
        ///     设置本地化文化区域名称。
        /// </summary>
        /// <param name="culture">
        ///     文化区域名称。
        /// </param>
        /// <returns>
        ///     <see cref="LocalizationOptionsBuilder" /> 类型的对象实例。
        /// </returns>
        public LocalizationOptionsBuilder WithCulture(string culture)
        {
            m_culture = culture;
            return this;
        }
    }
}