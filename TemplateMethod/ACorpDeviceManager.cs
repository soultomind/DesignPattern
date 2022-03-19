using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ACorpDeviceManager : AbstractDeviceManager, IDeviceCheckManager
    {
        public override bool IsSupportedConnectCheck
        {
            get
            {
                return true;
            }
        }
        public bool IsConnected
        {
            get { return true; }
        }

        public override void Process()
        {
            ShowDisplayMessage("요청하신 내용을 처리합니다...");
        }

        protected override bool ConnectHandle(IntPtr handle)
        {
            string text = String.Format("연결에 성공하였습니다.Handle={0}", handle);
            ShowDisplayMessage(text);
            return true;
        }


        protected override void ShowDisplayMessage(string text)
        {
            //base.ShowDisplayMessage("=========================");
            Console.WriteLine("[{0}]={1}", GetType().Name, text);
            //base.ShowDisplayMessage("=========================");
        }

        protected override void ShowFileVersion()
        {
            ShowDisplayMessage("ACropLib.dll Version=1.0.0.0");
        }
    }
}
