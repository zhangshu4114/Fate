using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace Application_.Park_.Exercise_.Test_ {
    
    public partial class ClientForm : Form {

        public ClientForm() {
            
            InitializeComponent();
        }
        private void ClientForm_Load(object sender, EventArgs e) {
            Thread.Sleep(2500);
            this.ConnectionInitialize();

        }
        //定义回调
        private delegate void SetTextCallBack(string strValue);
        //声明
        private SetTextCallBack setCallBack;

        //定义接收服务端发送消息的回调
        private delegate void ReceiveMsgCallBack(string strMsg);
        //声明
        private ReceiveMsgCallBack receiveCallBack;

        //创建连接的Socket
        Socket socketSend;
        //创建接收客户端发送消息的线程
        Thread threadReceive;
        /**
         * 连接初始化
         */
        public void ConnectionInitialize() {
            try {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse("192.168.100.125");

                socketSend.Connect(ip, 2000);
                //实例化回调
                setCallBack = new SetTextCallBack(SetValue);
                receiveCallBack = new ReceiveMsgCallBack(SetValue);
                MessageBox.Show("初始化成功!");

                //开启一个新的线程不停的接收服务器发送消息的线程
                threadReceive = new Thread(new ThreadStart(Receive));
                
                //设置为后台线程
                threadReceive.IsBackground = true;
                threadReceive.Start();
            } catch (Exception ex) {
                MessageBox.Show("初始化失败:" + ex.ToString());
            }
        }
        /**
         * 接收服务器发送的消息
         */
        private void Receive() {
            
            while (true) {

                byte[] buffer = new byte[15];

                //实际接收到的字节数
                int r = socketSend.Receive(buffer);
                if (r == 0) {
                    break;
                } else {
                        
                }
                switch (buffer[0]) {
                    case 0xA2:
                        this.ChangeParkingLotStatus(buffer);
                        break;
                    case 0xA1:
                        
                        Action<byte[]> action = new Action<byte[]>(AppearRunLog);
                        
                        this.Invoke(action,buffer);
                        
                        break;
                    case 0xAA:
                        this.ChangeParkingLotStatus(buffer);
                        break;
                    case 0xAB:
                        this.ChangeParkingLotStatus(buffer);
                        break;
                    case 0xAC:
                        this.ChangeParkingLotStatus(buffer);
                        break;
                    case 0xAD:
                        this.ChangeParkingLotStatus(buffer);
                        break;
                    case 0xAE:
                        this.ChangeParkingLotStatus(buffer);
                        break;
                    case 0xAF:
                        this.ChangeParkingLotStatus(buffer);
                        break;
                    default:
                        break;
                }

            }
            
        }
        /**
         * 显示运行日志
         *
         */
        public void AppearRunLog(byte[] buffer) {
            Dictionary<byte, string> m = new Dictionary<byte, string>();
            
            m.Add(0x10, ":");
            m.Add(0x11, "...");
            m.Add(0x12, ",");
            m.Add(0x13, ".");

            m.Add(0xF0, "0");
            m.Add(0x01, "1");
            m.Add(0x02, "2");
            m.Add(0x03, "3");
            m.Add(0x04, "4");
            m.Add(0x05, "5");
            m.Add(0x06, "6");
            m.Add(0x07, "7");
            m.Add(0x08, "8");
            m.Add(0x09, "9");
            m.Add(0x0A, "A");
            m.Add(0x0B, "B");
            m.Add(0x0C, "C");
            m.Add(0x0D, "D");
            m.Add(0x0E, "E");
            m.Add(0x0F, "F");

            m.Add(0x20, "搬运器");
            m.Add(0x21, "出车位");
            m.Add(0x22, "车辆");
            m.Add(0x23, "存车");
            m.Add(0x24, "等候");
            m.Add(0x25, "定时器");
            m.Add(0x26, "发生");
            m.Add(0x27, "关闭");
            m.Add(0x28, "进出口");
            m.Add(0x29, "进车位");
            m.Add(0x2A, "结束");
            m.Add(0x2B, "接受");
            m.Add(0x2C, "交换位");
            m.Add(0x2D, "开始");
            m.Add(0x2E, "口");
            m.Add(0x2F, "卡号");
            m.Add(0x30, "Move");
            m.Add(0x31, "Parkln");
            m.Add(0x32, "PutCar");
            m.Add(0x33, "ParkOut");
            m.Add(0x34, "ParkExchange");
            m.Add(0x35, "取消");
            m.Add(0x36, "取车");
            m.Add(0x37, "请到");
            m.Add(0x38, "任务");
            m.Add(0x39, "驶出");
            m.Add(0x3A, "TakeCar");
            m.Add(0x3B, "完成");
            m.Add(0x3C, "Wait");
            m.Add(0x3D, "下发");
            m.Add(0x3E, "信息");
            m.Add(0x3F, "信号");
            m.Add(0x40, "已");
            m.Add(0x41, "移动");
            m.Add(0x42, "运行位");
            m.Add(0x43, "执行");
            m.Add(0x44, "直接");
            m.Add(0x45, "注册");
            m.Add(0x46, "终端");

            string msg = "";
            for (int i = 3;i <= 10 ;i++) {
                msg += m[buffer[i]];
                if (buffer[i] == 0x00) {
                    break;
                }

            }
            DateTime time = new DateTime();
            string time1 = time.Hour + ":" + time.Minute + ":" + time.Second+" ";
            
            this.RunLog.Items.Add(msg);
        }
        /**
         * 有一个组件位置是在 Form->Panel->里面 怎样定位这个组件啊 [Panel名称]RunLogPanel [组件名称]RunLog
         * 更新车位状态
         *
         */
        public void ChangeParkingLotStatus(byte[] buffer) {
            MessageBox.Show(buffer.ToString());
        }
        /**
         * 日志信息追加
         *
         */
        private void SetValue(string strValue) {
            
        }

        /**
         * 客户端给服务器发送消息
         *
         */
        public void SendMessage(byte[] msg) {
            try {
                /*string strMsg = this.txt_Msg.Text.Trim();
                byte[] buffer = new byte[2048];
                buffer = Encoding.Default.GetBytes(strMsg);*/
                int receive = socketSend.Send(msg);
            } catch (Exception ex) {
                MessageBox.Show("发送消息出错:" + ex.Message);
            }
        }
    }
}
