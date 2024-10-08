/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Net
{
  using Disco.Resources;

  using System;

  /// <summary>
  ///   提供了网络通信端口号相关的方法。
  /// </summary>
  public struct Port
  {
    #region Constants

    /// <summary>
    ///   网络通信端口最大数值。
    /// </summary>
    public const int MAX_VALUE = 0xFFFF;

    /// <summary>
    ///   网络通信端口号最小数值。
    /// </summary>
    public const int MIN_VALUE = 0;

    #endregion Constants

    #region Fields

    /// <summary>
    ///   默认的 HTTP 端口号 <c> 80 </c>。
    /// </summary>
    public static readonly Port HTTP = new Port(0x50);

    /// <summary>
    ///   默认的 HTTPS 端口号 <c> 443 </c>。
    /// </summary>
    public static readonly Port HTTPS = new Port(0x1BB);

    /// <summary>
    ///   最大的网络端口号。
    /// </summary>
    public static readonly Port MaxValue = new Port(MAX_VALUE);

    /// <summary>
    ///   最小的网络端口号。
    /// </summary>
    public static readonly Port MinValue = new Port(MIN_VALUE);

    /// <summary>
    ///   默认的 MQTT 端口号 <c> 1883 </c>。
    /// </summary>
    public static readonly Port MQTT = new Port(0x75B);

    /// <summary>
    ///   默认的 MySQL 数据库端口号 <c> 3306 </c>。
    /// </summary>
    public static readonly Port MySQL = new Port(0xCEA);

    /// <summary>
    ///   默认的 PostgreSQL 端口号 <c> 5432 </c>。
    /// </summary>
    public static readonly Port PostgreSQL = new Port(0x1538);

    /// <summary>
    ///   默认的 RabbitMQ 端口号 <c> 5672 </c>。
    /// </summary>
    public static readonly Port RabbitMQ = new Port(0x1628);

    /// <summary>
    ///   默认的 Redis 端口号 <c> 6379 </c>。
    /// </summary>
    public static readonly Port Redis = new Port(0x18EB);

    /// <summary>
    ///   默认的 Microsoft SQL Server 端口号 <c> 1433 </c>。
    /// </summary>
    public static readonly Port SQLServer = new Port(0x599);

    /// <summary>
    ///   默认的 Apache Zookeeper 端口号 <c> 2181 </c>。
    /// </summary>
    public static readonly Port Zookeeper = new Port(0x885);

    #endregion Fields

    #region Constructors

    /// <summary>
    ///   初始化 <see cref="Port" /> 类型值的新实例。
    /// </summary>
    /// <param name="value">
    ///   网络通信端口号值。
    ///   <para> 网络通信端口号必须为一个 <c> 0&lt;= <paramref name="value" /> &lt;= 65535 </c> 的整型值。 </para>
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   当 <paramref name="value" /> 小于 0 或大于 65535 时，将引发此类型的异常。
    /// </exception>
    // ExceptionAdjustment: M:System.String.Format(System.String,System.Object) -T:System.FormatException
    public Port(int value)
    {
      ExceptionHelper.ThrowElse<ArgumentOutOfRangeException>(value.Between(MIN_VALUE, MAX_VALUE), nameof(Port), string.Format(Strings.ArgumentOutOfRangeException_invalid_network_port, value));
      Value = value;
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    ///   网络通信端口号。
    /// </summary>
    /// <value>
    ///   获取 <see cref="int" /> 类型的值，用于表示网络通信端口号。
    /// </value>
    public int Value { get; }

    #endregion Properties
  }
}