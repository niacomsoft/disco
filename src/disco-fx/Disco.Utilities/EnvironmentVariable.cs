/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using Disco.Diagnostics;
  using Disco.Resources;

  using System;
  using System.Security;

  /// <summary>
  ///   提供了环境变量相关的基本方法。
  /// </summary>
  public class EnvironmentVariable
  {
    #region Constructors

    /// <summary>
    ///   初始化 <see cref="EnvironmentVariable" /> 类型值的新实例。
    /// </summary>
    /// <param name="variable">
    ///   环境变量名称。
    /// </param>
    /// <param name="value">
    ///   环境变量值。
    /// </param>
    /// <param name="found">
    ///   上下文中是否找到了指定名称的环境变量。
    /// </param>
    /// <param name="location">
    ///   检索到指定名称环境变量的位置。
    ///   <para> <see cref="EnvironmentVariableTarget" /> 枚举类型中的一个值。 </para>
    /// </param>
    // ExceptionAdjustment: M:System.String.Format(System.String,System.Object) -T:System.FormatException
    protected EnvironmentVariable(string variable, string value, bool found, EnvironmentVariableTarget? location)
    {
      ExceptionHelper.ThrowIf<ArgumentException>(string.IsNullOrWhiteSpace(variable), string.Format(Strings.ArgumentException_empty_or_whitespace, nameof(variable)), nameof(variable));

      Variable = variable;
      Value = value;
      NotFound = !found;
      Location = location;
    }

    /// <summary>
    ///   初始化 <see cref="EnvironmentVariable" /> 类型值的新实例。
    /// </summary>
    /// <param name="variable">
    ///   环境变量名称。
    /// </param>
    public EnvironmentVariable(string variable) : this(variable, null, false, null)
    {
    }

    /// <summary>
    ///   初始化 <see cref="EnvironmentVariable" /> 类型值的新实例。
    /// </summary>
    /// <param name="variable">
    ///   环境变量名称。
    /// </param>
    /// <param name="value">
    ///   环境变量值。
    /// </param>
    /// <param name="location">
    ///   检索到指定名称环境变量的位置。
    ///   <para> <see cref="EnvironmentVariableTarget" /> 枚举类型中的一个值。 </para>
    /// </param>
    public EnvironmentVariable(string variable, string value, EnvironmentVariableTarget location) : this(variable, value, true, location)
    {
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    ///   指定的环境变量是否有值。
    /// </summary>
    /// <value>
    ///   获取 <see cref="bool" /> 类型的值，用于表示指定的环境变量是否有值。
    ///   <para>
    ///     当 <see cref="NotFound" /> 等于 <see langword="false" /> 且 <see cref="Value" /> 不等于 <see langword="null" /> 和
    ///     <see cref="string.Empty" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    ///   </para>
    /// </value>
    public virtual bool HasValue
    {
      get
      {
        return !NotFound && !string.IsNullOrEmpty(Value);
      }
    }

    /// <summary>
    ///   最终检索到指定环境变量 <see cref="Variable" /> 的位置。
    /// </summary>
    /// <value>
    ///   获取可能为空的 <see cref="EnvironmentVariableTarget" /> 类型值，用于表示最终检索到指定环境变量 <see cref="Variable" /> 的位置。
    /// </value>
    public virtual EnvironmentVariableTarget? Location { get; }

    /// <summary>
    ///   上下文中未找到指定名称 <see cref="Variable" /> 的环境变量。
    /// </summary>
    /// <value>
    ///   获取 <see cref="bool" /> 类型的值，用于表示上下文中未找到指定名称 <see cref="Variable" /> 的环境变量。
    /// </value>
    public virtual bool NotFound { get; }

    /// <summary>
    ///   环境变量值。
    /// </summary>
    /// <value>
    ///   获取一个字符串，用于表示环境变量值。
    /// </value>
    public virtual string Value { get; }

    /// <summary>
    ///   环境变量名称。
    /// </summary>
    /// <value>
    ///   获取一个字符串，用于表示环境变量名称。
    /// </value>
    public virtual string Variable { get; }

    #endregion Properties

    #region Methods

    /// <summary>
    ///   在指定范围 <paramref name="scope" /> 获取名称为 <paramref name="variable" /> 的环境变量。
    /// </summary>
    /// <param name="variable">
    ///   环境变量名称。
    /// </param>
    /// <param name="scope">
    ///   指定的检索范围。
    ///   <para> <see cref="EnvironmentVariableTarget" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns>
    ///   <see cref="EnvironmentVariable" /> 类型的对象实例。
    /// </returns>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="SecurityException">
    ///   当调用 <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    private static EnvironmentVariable InternalGetEnvironmentVariable(string variable, EnvironmentVariableTarget scope)
    {
      var value = Environment.GetEnvironmentVariable(variable, scope);
      if (Doctor.DebugIf(string.IsNullOrEmpty(value), $"[EnvironmentVariable]: The specified location \"{scope}\" failed to retrieve an environment variable named \"{variable}\"."))
      {
        return (scope != EnvironmentVariableTarget.Machine)
          ? InternalGetEnvironmentVariable(variable, (EnvironmentVariableTarget)((int)scope + 1))
          : new EnvironmentVariable(variable);
      }
      return new EnvironmentVariable(variable, value, scope);
    }

    /// <summary>
    ///   获取名称为 <paramref name="variable" /> 的环境变量。
    /// </summary>
    /// <param name="variable">
    ///   环境变量名称。
    /// </param>
    /// <returns>
    ///   <see cref="EnvironmentVariable" /> 类型的对象实例。
    /// </returns>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="SecurityException">
    ///   当调用 <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static EnvironmentVariable GetEnvironmentVariable(string variable)
    {
      return InternalGetEnvironmentVariable(variable, EnvironmentVariableTarget.Process);
    }

    #endregion Methods
  }
}