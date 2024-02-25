using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopStation
{
    public partial class ScriptTriggerForm : Form
    {
        public ScriptTriggerForm()
        {
            InitializeComponent();
        }

        public void SetFormLanguage(Language inLangManager)
        {
            if (inLangManager.Loaded() == true)
            {
                this.Text = inLangManager.SetText("TxtTriggerTitle", this.Text);
                label_S88SensorAddr.Text = inLangManager.SetText("TxtS88SensorAddr", label_S88SensorAddr.Text);
                label_Hour.Text = inLangManager.SetText("TxtClkCfgHours", label_Hour.Text);
                label_Minutes.Text = inLangManager.SetText("TxtClkCfgMinutes", label_Minutes.Text);
                label_Seconds.Text = inLangManager.SetText("TxtClkCfgSeconds", label_Seconds.Text);

                label_RunThreshold.Text = inLangManager.SetText("TxtCondItemRunning", label_RunThreshold.Text);
                label_StopThreshold.Text = inLangManager.SetText("TxtCondItemStopping", label_StopThreshold.Text);


                gBox_SpecTime.Text = inLangManager.SetText("TxtClkCfgSpecifiedTime", gBox_SpecTime.Text);
                gBox_Speed.Text = inLangManager.SetText("TxtSpeedThreshold", gBox_Speed.Text);

                gBox_Flag.Text = inLangManager.SetText("TxtCondItemFlag", gBox_Flag.Text);
                gBox_Route.Text = inLangManager.SetText("TxtCondItemRoute", gBox_Route.Text);

                labelSelectedRoute.Text = inLangManager.SetText("TxtRouteSelected", labelSelectedRoute.Text);
                labelFlagNo.Text = inLangManager.SetText("TxtScrEditFlagNo", labelFlagNo.Text);
                labelFlagVal.Text = inLangManager.SetText("TxtScrEditEquivVal", labelFlagVal.Text);
                
                
                button_Ok.Text = inLangManager.SetText("TxtOk", button_Ok.Text);
                button_Cancel.Text = inLangManager.SetText("TxtCancel", button_Cancel.Text);

            }

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {

        }

        public void SetItemEnables(int inModeIndex)
        {

            /* セット */
            switch (inModeIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    /* S88センサ関係 */
                    numUpDown_hour.Visible = false;
                    numUpDown_min.Visible = false;
                    numUpDown_sec.Visible = false;
                    gBox_Speed.Enabled = false;
                    gBox_Flag.Enabled = false;
                    gBox_Route.Enabled = false;
                    break;
                case 4:
                    /* Interval */
                    numBox_S88SensorAddr.Enabled = false;
                    gBox_Speed.Enabled = false;
                    gBox_Flag.Enabled = false;
                    gBox_Route.Enabled = false;
                    break;

                case 5:
                    /* Clock */
                    numBox_S88SensorAddr.Enabled = false;
                    gBox_Speed.Enabled = false;
                    gBox_Flag.Enabled = false;
                    gBox_Route.Enabled = false;
                    break;
                case 6:
                    /* Interval */
                    numBox_S88SensorAddr.Enabled = false;
                    gBox_Speed.Enabled = false;
                    gBox_Flag.Enabled = false;
                    gBox_Route.Enabled = false;
                    break;


                case 7:
                    //走行中
                    numBox_S88SensorAddr.Enabled = false;
                    numUpDown_hour.Enabled = false;
                    numUpDown_min.Enabled = false;
                    numUpDown_sec.Enabled = false;
                    numUpDown_StopSpeed.Enabled = false;
                    gBox_Flag.Enabled = false;
                    gBox_Route.Enabled = false;
                    break;
                case 8:
                    //停止中
                    numBox_S88SensorAddr.Enabled = false;
                    numUpDown_hour.Enabled = false;
                    numUpDown_min.Enabled = false;
                    numUpDown_sec.Enabled = false;
                    numUpDown_RunSpeed.Enabled = false;
                    gBox_Flag.Enabled = false;
                    gBox_Route.Enabled = false;
                    break;

                case 9:
                    //フラグ
                    numBox_S88SensorAddr.Enabled = false;
                    gBox_SpecTime.Enabled = false;
                    gBox_Speed.Enabled = false;
                    gBox_Route.Enabled = false;
                    break;
                case 10:
                    //ルート
                    numBox_S88SensorAddr.Enabled = false;
                    gBox_SpecTime.Enabled = false;
                    gBox_Speed.Enabled = false;
                    gBox_Flag.Enabled = false;
                    break;
                case 11:
                    //線路電源投入時
                    //return;
                    break;
            }

        }




    }
}
