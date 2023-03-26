// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了 <typeparamref name="T" /> 类型的描述是否可用状态的接口。
    /// </summary>
    /// <typeparam name="T">
    ///     描述是否可用状态的值类型。
    /// </typeparam>
    public interface IEnabled<T>
        where T : struct
    {
        /// <summary>
        ///     是否可用。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <typeparamref name="T" /> 类型值，用于表示是否可用。
        /// </value>
        T Enabled { get; set; }
    }
}