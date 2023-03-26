// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了唯一标识的接口。
    /// </summary>
    /// <typeparam name="T">
    ///     唯一标识类型。
    /// </typeparam>
    public interface IUniqueId<T>
    {
        /// <summary>
        ///     唯一标识值。
        /// </summary>
        /// <value>
        ///     设置或获取 <typeparamref name="T" /> 类型的对象实例或值，用于表示唯一标识值。
        /// </value>
        T Id { get; set; }
    }
}