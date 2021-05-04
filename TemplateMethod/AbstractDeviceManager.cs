using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class AbstractDeviceManager
    {
        public bool IsOn { get; set; }
        public abstract bool IsSupportedConnectCheck { get; }
        public void About()
        {
            // 부모 클래스가 정의한 행동
            ShowFileVersion();
        }
        public void Connect(IntPtr handle)
        {
            if (IsSupportedConnectCheck)
            {
                if (!(this is IDeviceCheckManager))
                {
                    throw new InvalidOperationException("잘못된 접근입니다.");
                }

                ShowDisplayMessage("장치 연결 체크를 지원하는 장치입니다.");
                if ((this as IDeviceCheckManager).IsConnected)
                {
                    ShowDisplayMessage("장치에 연결 되어 있습니다.");
                    ConnectHandle(handle);
                }
                else
                {
                    ShowDisplayMessage("장치에 연결 되어 있지 않습니다.");
                }
            }
            else
            {
                ConnectHandle(handle);
            }
        }
        protected abstract void ConnectHandle(IntPtr handle);
        public abstract void Process();

        protected virtual void ShowFileVersion()
        {

        }

        public void On()
        {
            if (!IsOn)
            {
                IsOn = true;
                ShowDisplayMessage("전원 On");
            }
        }

        public void Off()
        {
            if (IsOn)
            {
                ShowDisplayMessage("전원 Off");
                IsOn = false;
            }
        }

        protected virtual void ShowDisplayMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
