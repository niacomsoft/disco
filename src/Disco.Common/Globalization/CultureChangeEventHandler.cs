// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco.Globalization
{
    /// <summary>
    ///     定义了处理文化区域变更事件的委托。
    /// </summary>
    /// <param name="sender">
    ///     触发此事件的对象实例。
    /// </param>
    /// <param name="e">
    ///     文化区域变更事件参数。
    ///     <para> <see cref="CultureChangeEventArgs" /> 类型的对象实例。 </para>
    /// </param>
    /// <seealso cref="CultureChangeEventArgs" />
    public delegate void CultureChangeEventHandler(object sender, CultureChangeEventArgs e);
}