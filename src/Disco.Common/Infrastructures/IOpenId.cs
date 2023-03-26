// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了开放标识的接口。
    /// </summary>
    public interface IOpenId
    {
        /// <summary>
        ///     开放标识。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示开放标识。
        /// </value>
        string OpenId { get; set; }
    }
}