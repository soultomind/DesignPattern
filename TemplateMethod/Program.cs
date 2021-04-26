using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DesignPattern TemplateMethod Pattern");

            DeviceManager deviceManager = null;

            deviceManager = new ACorpDeviceManager();
            deviceManager.On();
            deviceManager.Connect((IntPtr)1010);
            deviceManager.Process();
            deviceManager.Off();

            deviceManager = new BCorpDeviceManager();
            deviceManager.On();
            deviceManager.Connect((IntPtr)2020);
            deviceManager.Process();
            deviceManager.Off();
        }
    }

    interface IDeviceCheckManager
    {
        bool IsConnected();
    }

    abstract class DeviceManager
    {
        public bool IsOn { get; set; }
        public abstract bool IsSupportedConnectCheck { get; }
        public abstract void ConnectHandle(IntPtr handle);
        public abstract void Process();
        public void Connect(IntPtr handle)
        {
            if (IsSupportedConnectCheck)
            {
                ShowDisplayMessage("장치 연결 체크를 지원하는 장치입니다.");
                if ((this as IDeviceCheckManager).IsConnected())
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

        public void On()
        {
            if (!IsOn)
            {
                IsOn = true;
                ShowDisplayMessage(GetType().Name + " 전원 On");
            }
        }

        public void Off()
        {
            if (IsOn)
            {
                ShowDisplayMessage(GetType().Name + "전원 Off");
                IsOn = false;
            }
        }

        protected void ShowDisplayMessage(string text)
        {
            Console.WriteLine("알림={0}", text);
        }
    }

    class ACorpDeviceManager : DeviceManager, IDeviceCheckManager
    {
        public override bool IsSupportedConnectCheck
        {
            get
            {
                return true;
            }
        }
        public bool IsConnected()
        {
            return true;
        }

        public override void ConnectHandle(IntPtr handle)
        {
            string text = String.Format("연결에 성공하였습니다.Handle={0}", handle);
            ShowDisplayMessage(text);
        }
        

        public override void Process()
        {
            ShowDisplayMessage("요청하신 내용을 처리합니다...");
        }
    }

    class BCorpDeviceManager : DeviceManager
    {
        public override bool IsSupportedConnectCheck
        {
            get
            {
                return false;
            }
        }
        

        public override void ConnectHandle(IntPtr handle)
        {
            string text = String.Format("연결에 실패하였습니다.Handle={0}", handle);
            ShowDisplayMessage(text);
        }

        public override void Process()
        {
            ShowDisplayMessage("알수 없는 에러가 발생하였습니다.");
        }
    }
}