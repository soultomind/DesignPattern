using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class BCorpDeviceManager : AbstractDeviceManager
    {
        public override bool IsSupportedConnectCheck
        {
            get
            {
                return false;
            }
        }

        protected override void ConnectHandle(IntPtr handle)
        {
            string text = String.Format("연결에 실패하였습니다.Handle={0}", handle);
            ShowDisplayMessage(text);
        }

        public override void Process()
        {
            ShowDisplayMessage("알수 없는 에러가 발생하였습니다.");
        }

        protected override void ShowDisplayMessage(string text)
        {
            //base.ShowDisplayMessage("=========================");
            Console.WriteLine("[{0}]={1}", GetType().Name, text);
            //base.ShowDisplayMessage("=========================");
        }

        protected override void ShowFileVersion()
        {
            Console.WriteLine("BCropLib.dll Version=1.0.0.0");
        }
    }
}
