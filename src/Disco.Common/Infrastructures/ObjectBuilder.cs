// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    /// <summary>
    ///     提供了构建 <typeparamref name="T" /> 类型的对象实例相关的基本方法。
    /// </summary>
    /// <typeparam name="T">
    ///     目标类型。
    /// </typeparam>
    /// <seealso cref="IObjectBuilder{T}" />
    public abstract class ObjectBuilder<T> : IObjectBuilder<T>
        where T : class
    {
        /// <summary>
        ///     用于初始化一个 <see cref="ObjectBuilder{T}" /> 类型的对象实例。
        /// </summary>
        protected ObjectBuilder()
        {
        }

        /// <summary>
        ///     构建 <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <returns>
        ///     <typeparamref name="T" /> 类型的对象实例。
        /// </returns>
        public abstract T Build();
    }
}