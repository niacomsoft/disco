// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了描述是否逻辑删除的状态接口。
    /// </summary>
    /// <typeparam name="T">
    ///     描述逻辑删除状态的值类型。
    /// </typeparam>
    public interface IRemoved<T>
        where T : struct
    {
        /// <summary>
        ///     是否逻辑删除。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <typeparamref name="T" /> 类型值，用于表示是否逻辑删除。
        /// </value>
        T Removed { get; set; }
    }
}