// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     定义了逻辑删除状态枚举类型。
    /// </summary>
    public enum RemoveState
    {
        /// <summary>
        ///     未删除。
        /// </summary>
        NotRemove = 0,

        /// <summary>
        ///     已经被逻辑删除。
        /// </summary>
        HasRemoved = 1,

        /// <summary>
        ///     已经被逻辑删除（等同于物理删除）。
        /// </summary>
        HasDeleted = 2,

        /// <summary>
        ///     默认的。等同于 <see cref="NotRemove" />。
        /// </summary>
        /// <seealso cref="NotRemove" />
        Default = NotRemove
    }
}