/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Text
{
  using System;
  using System.Text;

  /// <summary>
  ///   提供了默认文本编码相关的静态 <see langword="static" /> 方法。
  /// </summary>
  public static class DefaultEncodingProvider
  {
    #region Constructors

    /// <summary>
    ///   初始化 <see cref="DefaultEncodingProvider" /> 静态 <see langword="static" /> 类的新实例。
    /// </summary>
    static DefaultEncodingProvider()
    {
      Provider = new Lazy<Encoding>(() => Encoding.UTF8, true);
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    ///   默认的文本编码器。
    /// </summary>
    /// <value>
    ///   设置或获取 <see cref="Lazy{T}" /> 类型的对象实例，用于表示默认的文本编码器。
    /// </value>
    private static Lazy<Encoding> Provider { get; set; }

    /// <summary>
    ///   默认的编码程序。
    /// </summary>
    /// <value>
    ///   获取 <see cref="Encoding" /> 类型的对象实例，用于表示默认的文本编码器。
    /// </value>
    public static Encoding DefaultEncoding => Provider.Value;

    #endregion Properties

    #region Methods

    /// <summary>
    ///   设置默认的文本编码程序。
    /// </summary>
    /// <param name="provider">
    ///   <see cref="Func{TResult}" /> 类型的方法委托。
    /// </param>
    public static void SetDefaultEncoding(Func<Encoding> provider)
    {
      provider.IfNull(nameof(provider));
      Provider = new Lazy<Encoding>(provider, true);
    }

    #endregion Methods
  }
}