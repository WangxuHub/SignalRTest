using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRTest.MyStartup))]

namespace SignalRTest
{
    public class MyStartup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            //注册管道,使用默认的虚拟地址,根目录下的"/signalr",当然你也可以自己定义
            app.MapSignalR();
        }
    }
}
