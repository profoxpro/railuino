using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopStation
{
    class CommandAnalyzer
    {



        public CommandAnalyzer()
        {



        }

        public int EnterCommand(String inCommandText)
        {
            int aRet = 0;

            /*
             
             コマンド引数
             * ADD(A) 機関車追加コマンド
             * FIND(F,省略可) アドレスor名称or固有ID
             * 
             
             
             */

            if ((inCommandText == "Q") || (inCommandText == "QR"))
            {
                aRet = 1;

            }


            return aRet;
        }


    }
}
