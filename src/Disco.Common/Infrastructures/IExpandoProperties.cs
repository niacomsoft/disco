// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    using System;

    /// <summary>
    ///     定义了扩展属性的接口。
    /// </summary>
    public interface IExpandoProperties
    {
        /// <summary>
        ///     创建人姓名。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示创建人姓名。
        /// </value>
        string CreatedBy { get; set; }

        /// <summary>
        ///     创建时间。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="DateTime" /> 类型值，用于表示创建时间。
        /// </value>
        /// <seealso cref="DateTime" />
        DateTime CreatedTime { get; set; }

        /// <summary>
        ///     最后修改人姓名。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示最后修改人姓名。
        /// </value>
        string LatestModifiedBy { get; set; }

        /// <summary>
        ///     最后修改时间。
        /// </summary>
        /// <value>
        ///     设置或获取一个 <see cref="DateTime" /> 类型值，用于表示最后修改时间。
        /// </value>
        /// <seealso cref="Nullable{T}" />
        /// <seealso cref="DateTime" />
        DateTime? LatestModifiedTime { get; set; }

        /// <summary>
        ///     备注信息。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示备注信息。
        /// </value>
        string Remark { get; set; }
    }
}