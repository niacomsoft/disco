// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Globalization
{
    using System;
    using System.Globalization;

    /// <summary>
    ///     提供了文化区域变更事件相关的参数。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="EventArgs" />
    public sealed class CultureChangeEventArgs : EventArgs
    {
        /// <summary>
        ///     初始化 <see cref="CultureChangeEventArgs" /> 的新实例。
        /// </summary>
        /// <param name="currentCulture">
        ///     切换到的新的文化区域信息。
        /// </param>
        /// <seealso cref="CultureInfo" />
        /// <seealso cref="Guard.SafeGet{T}(T, ConstructorDelegation{T}, object[])" />
        /// <seealso cref="LocalizationDefaults" />
        /// <seealso cref="LocalizationDefaults.Culture" />
        public CultureChangeEventArgs(CultureInfo currentCulture) 
            => CurrentCulture = Guard.SafeGet(currentCulture, (args) => LocalizationDefaults.Culture);

        /// <summary>
        ///     切换到的新的文化区域信息。
        /// </summary>
        /// <value>
        ///     获取 <see cref="CultureInfo" /> 类型的对象实例，用于表示切换到的新的文化区域信息。
        /// </value>
        /// <seealso cref="CultureInfo" />
        public CultureInfo CurrentCulture { get; }
    }
}