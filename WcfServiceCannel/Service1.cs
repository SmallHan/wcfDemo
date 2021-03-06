﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace WcfServiceCannel
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class FlyService : IFlyService
    {
        public Message Invoke(Message msg)
        {
            var body = msg.GetBody<string>();

            Console.WriteLine("body={0}", body);

            //返回一个message
            var single = Message.CreateMessage(msg.Version, msg.Headers.Action + "Response", "我已经接受到信息了");

            return single;
        }


        public string Invoke1(string msg)
        {
            return msg+DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
