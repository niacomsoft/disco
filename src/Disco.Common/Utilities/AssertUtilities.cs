// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED.
//
// LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    /// <summary> 提供了断言相关的工具方法。 </summary>
    public static class AssertUtilities
    {
        /// <summary> 当 <paramref name="obj" /> 等于 <c> null </c> 时，返回 <c> true </c>；否则返回 <c> false </c>。 </summary>
        /// <param name="obj"> 需要校验的对象实例。 </param>
        /// <returns> 当 <paramref name="obj" /> 等于 <c> null </c> 时，返回 <c> true </c>；否则返回 <c> false </c>。 </returns>
        /// <seealso cref="object.ReferenceEquals(object, object)" />
        public static bool IsNull(object obj) => obj is null;

        /// <summary> 当 <paramref name="obj" /> 等于 <c> null </c> 时，返回 <c> false </c>；否则返回 <c> true </c>。 </summary>
        /// <param name="obj"> 需要校验的对象实例。 </param>
        /// <returns> 当 <paramref name="obj" /> 等于 <c> null </c> 时，返回 <c> false </c>；否则返回 <c> true </c>。 </returns>
        /// <seealso cref="AssertUtilities.IsNull(object)" />
        public static bool NotNull(object obj) => !IsNull(obj);
    }
}