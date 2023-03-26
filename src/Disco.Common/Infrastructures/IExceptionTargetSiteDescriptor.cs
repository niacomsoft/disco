// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    using System.Reflection;

    /// <summary>
    ///     定义了抛出异常的方法信息的接口。
    /// </summary>
    public interface IExceptionTargetSiteDescriptor
    {
        /// <summary>
        ///     引发异常的方法名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示引发异常的方法名称。
        /// </value>
        string Name { get; set; }

        /// <summary>
        ///     包含程序集、命名空间的引发异常的类型完全限定名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示包含程序集、命名空间的引发异常的类型完全限定名称。
        /// </value>
        string QualifiedTypeName { get; set; }

        /// <summary>
        ///     引发异常的方法信息。
        /// </summary>
        /// <value>
        ///     设置或获取 <see cref="MethodBase" /> 类型的对象实例，用于表示引发异常的方法信息。
        /// </value>
        /// <seealso cref="MethodBase" />
        MethodBase Source { get; set; }

        /// <summary>
        ///     引发异常的类型名称。
        /// </summary>
        /// <value>
        ///     设置或获取一个字符串，用于表示引发异常的类型名称。
        /// </value>
        string TypeName { get; set; }
    }
}