// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    using System;

    using Niacomsoft.Disco.Resources;

    /// <summary>
    ///     提供了运行时异常相关的辅助方法。
    /// </summary>
    public static class ExceptionHelper
    {
        /// <summary>
        ///     当 <paramref name="parameterValue" /> 等于 <c> null </c> 时，将抛出一个 <see cref="ArgumentNullException" /> 类型的异常。
        /// </summary>
        /// <param name="parameterValue">
        ///     需要校验的参数值。
        /// </param>
        /// <param name="parameterName">
        ///     参数名称。
        /// </param>
        public static void IfArgumentNull(object parameterValue, string parameterName)
        {
            if (parameterValue is null)
                throw new ArgumentNullException(parameterName, string.Format(SR.GetString("DiscoException_default_exception_message"), parameterName));
        }
    }
}