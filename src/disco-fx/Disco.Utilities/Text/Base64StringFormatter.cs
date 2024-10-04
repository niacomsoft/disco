/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Text
{
  using System;

  /// <summary>
  ///   提供了 <c> BASE64 </c> 字符串格式化相关的方法。密闭的，不可以从此类型派生。
  /// </summary>
  public sealed class Base64StringFormatter : IBase64StringEncoder, IBase64StringDecoder
  {
    #region Fields

    /// <summary>
    ///   <c> BASE-64 </c> 解码器。
    /// </summary>
    public static readonly Lazy<IBase64StringDecoder> Decoder = new Lazy<IBase64StringDecoder>(() => new Base64StringFormatter(), true);

    /// <summary>
    ///   <c> BASE-64 </c> 编码器。
    /// </summary>
    public static readonly Lazy<IBase64StringEncoder> Encoder = new Lazy<IBase64StringEncoder>(() => new Base64StringFormatter(), true);

    #endregion Fields

    #region Methods

    /// <inheritdoc />
    /// <exception cref="FormatException">
    ///   当调用 <see cref="Convert.FromBase64String(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public byte[] FromBase64String(string base64Str)
    {
      return Convert.FromBase64String(base64Str);
    }

    /// <inheritdoc />
    /// <exception cref="OverflowException">
    ///   当访问 <c> <paramref name="input" />.Length </c> 属性时，可能引发此类型的异常。
    /// </exception>
    public string ToBase64String(byte[] input, int start = 0, int? length = null, Base64FormattingOptions options = Base64FormattingOptions.None)
    {
      if (input.HasItems())
      {
        return Convert.ToBase64String(input, start, length.DefaultIf(input.Length), options);
      }
      return null;
    }

    #endregion Methods
  }
}