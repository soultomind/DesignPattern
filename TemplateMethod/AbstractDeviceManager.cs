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

        public abstract void Process();
        public void About()
        {
            // 부모 클래스가 정의한 행동
            ShowFileVersion();
        }
        public bool Connect(IntPtr handle)
        {
            if (!IsOn)
            {
                throw new InvalidOperationException("잘못된 접근입니다. 전원이 꺼져있습니다.");
            }

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
                    return ConnectHandle(handle);
                }
                else
                {
                    ShowDisplayMessage("장치에 연결 되어 있지 않습니다.");
                    return false;
                }
            }
            else
            {
                return ConnectHandle(handle);
            }
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

        protected virtual void ShowFileVersion()
        {

        }

        protected abstract bool ConnectHandle(IntPtr handle);

        protected virtual void ShowDisplayMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
