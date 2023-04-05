// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;

namespace Niacomsoft.Disco.Collections
{
    using System.Collections.Generic;

    /// <summary>
    ///     提供了多行的描述文本集合。密闭的，不可以从此类型派生。
    /// </summary>
    /// <seealso cref="List{T}" />
    public sealed class MultiLineDescription : List<string>
    {
        /// <summary>
        ///     初始化 <see cref="MultiLineDescription" /> 的新实例。
        /// </summary>
        public MultiLineDescription()
        {
        }

        /// <summary>
        ///     初始化 <see cref="MultiLineDescription" /> 的新实例。
        /// </summary>
        /// <param name="multiLine">
        ///     用于初始化的多行描述文本集合。
        /// </param>
        public MultiLineDescription(IEnumerable<string> multiLine) : base(multiLine)
        {
        }

        /// <summary>
        ///     初始化 <see cref="MultiLineDescription" /> 的新实例。
        /// </summary>
        /// <param name="description">
        ///     用于初始化的描述信息。
        /// </param>
        public MultiLineDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                AddRange(description.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None));
            }
        }
    }
}