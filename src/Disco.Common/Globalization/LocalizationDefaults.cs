// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Globalization
{
    using System.Globalization;

    /// <summary>
    ///     提供了本地化默认值相关的方法。
    /// </summary>
    public static class LocalizationDefaults
    {
        /// <summary>
        ///     默认的文化区域名称。
        /// </summary>
        public const string CultureName = "zh-CN";

        /// <summary>
        ///     默认的文化区域信息。
        ///     <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </summary>
        /// <seealso cref="CultureInfo" />
        public static readonly CultureInfo Culture = new CultureInfo(CultureName);
    }
}