﻿using JT808.DotNetty.Abstractions.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.DotNetty.Core.Interfaces
{
    /// <summary>
    /// JT808 Tcp会话服务
    /// </summary>
    public interface IJT808TcpSessionService
    {
        /// <summary>
        /// 获取会话集合
        /// </summary>
        /// <returns></returns>
        JT808ResultDto<List<JT808TcpSessionInfoDto>> GetAll();
        /// <summary>
        /// 通过设备终端号移除对应会话
        /// </summary>
        /// <param name="terminalPhoneNo"></param>
        /// <returns></returns>
        JT808ResultDto<bool> RemoveByTerminalPhoneNo(string terminalPhoneNo);
    }
}
