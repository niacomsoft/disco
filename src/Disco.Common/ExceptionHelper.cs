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
                throw new ArgumentNullException(parameterName, SR.Format("DiscoException_default_exception_message", parameterName));
        }

        /// <summary>
        /// 当尝试将字符串 <paramref name="s"/> 转换成 <typeparamref name="TTarget"/> 类型值或实例时，将引发一个 <see cref="InvalidCastException"/> 类型的异常。
        /// </summary>
        /// <typeparam name="TTarget">目标类型。</typeparam>
        /// <param name="s">指定的字符串。</param>
        public static void InvalidStringParse<TTarget>(string s) 
            => throw new InvalidCastException(SR.Format("InvalidCastException_cannot_convert_string_to_type", s, typeof(TTarget).FullName));
    }
}