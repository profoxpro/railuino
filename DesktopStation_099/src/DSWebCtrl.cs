using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace DesktopStation
{

    class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            if (request is HttpWebRequest)
            {
                (request as HttpWebRequest).KeepAlive = false;
            }
            return request;
        }
    }

    public class DSWebCtrl : IDisposable
    {
        MyWebClient WClient;
        public String ReceivedPayload;
        public int MonitorStart = 0;
        public String gReceivedTest = "";
        public int CountError = 0;
        public int ConnectError = 0;


        public DSWebCtrl(System.Net.DownloadStringCompletedEventHandler inUploadedFunc)
        {
            //文字コードを指定する
            System.Text.Encoding enc = System.Text.Encoding.GetEncoding("utf-8");


            WClient = new MyWebClient();
            //文字コードを指定する
            WClient.Encoding = enc;

            //ヘッダにContent-Typeを加える
            WClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //WClient.Headers.Add("Connnection", "Close");

            //送信完了用の関数登録
            WClient.DownloadStringCompleted += inUploadedFunc;

            ReceivedPayload = "";

        }

        public void Dispose()
        {
            WClient.CancelAsync();
            WClient.Dispose();

        }

        public string ReplaceToDSair(String inCmd)
        {
            StringBuilder sb = new StringBuilder(inCmd);

            sb.Replace("setLocoDirection", "DI");
            sb.Replace("setLocoFunction", "FN");//
            sb.Replace("setTurnout", "TO");//
            sb.Replace("setPower", "PW");//
            sb.Replace("setLocoSpeed", "SP");////
            sb.Replace("reset", "RS");//
            sb.Replace("setPing", "PG");//
            sb.Replace("getLocoConfig;", "GV");//
            sb.Replace("setLocoConfig;", "SV");//

            return sb.ToString();
        }


        public void SendWithPOST(String inIPAddress, String inCommand)
        {

            if ((inIPAddress == "") || (inCommand == ""))
            {
                return;
            }

            DateTime dtNow = DateTime.Now;
            int aMillisecond = dtNow.Millisecond;

            while( WClient.IsBusy)
            {
                if ((aMillisecond + 200) <= dtNow.Millisecond)
                {
                    WClient.CancelAsync();
                    return;
                }
            }


            //WebRequestの作成
            String aUrl = "http://" + inIPAddress + "/";

            //コマンドをDSair用に短縮変換
            String aCmd = ReplaceToDSair(inCommand);


            //POST送信する文字列を作成
            string postData = "command.cgi?op=131&ADDR=0&LEN=64&DATA=" + aCmd;

            Uri aUri = new Uri(aUrl + postData);

            var servicePoint = ServicePointManager.FindServicePoint(aUri);
            servicePoint.Expect100Continue = false;

            try
            {

                //データを送信し、また受信する
                WClient.DownloadStringAsync(aUri);
            }
            catch (WebException exc)
            {
                ConnectError++;
                Console.WriteLine(exc.Message);
            }
        }

        public String ReceiveDSairInfo(String inIPAddress)
        {

            if ((inIPAddress == "") || (MonitorStart == 0))
            {
                return "";
            }

            DateTime dtNow = DateTime.Now;
            int aMillisecond = dtNow.Millisecond;

            while (WClient.IsBusy)
            {
                if ((aMillisecond + 100) <= dtNow.Millisecond)
                {
                    WClient.CancelAsync();
                    CountError++;
                    return "";
                }
                System.Windows.Forms.Application.DoEvents();
            }

            //エラーカウンタをゼロにする
            CountError = 0;

            //WebRequestの作成
            String aUrl = "http://" + inIPAddress + "/";

            //POST送信する文字列を作成
            string postData = "command.cgi?op=130&ADDR=128&LEN=112";

            Uri aUri = new Uri(aUrl + postData);

            var servicePoint = ServicePointManager.FindServicePoint(aUri);
            servicePoint.Expect100Continue = false;

            try
            {

                //データを送信し、また受信する
                WClient.DownloadStringAsync(aUri);

            }
            catch (WebException exc)
            {
                ConnectError++;
                Console.WriteLine(exc.Message);
            }

            return "";
        }
        
    }
}
