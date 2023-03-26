// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了命名信息相关的接口。
    /// </summary>
    public interface IName
    {
        /// <summary>
        ///     友好名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示友好名称。
        /// </value>
        string FriendlyName { get; set; }

        /// <summary>
        ///     名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示名称。
        /// </value>
        string Name { get; set; }
    }
}