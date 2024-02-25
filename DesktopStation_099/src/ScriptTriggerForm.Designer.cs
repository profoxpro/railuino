namespace DesktopStation
{
    partial class ScriptTriggerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numBox_S88SensorAddr = new System.Windows.Forms.NumericUpDown();
            this.label_S88SensorAddr = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.gBox_SpecTime = new System.Windows.Forms.GroupBox();
            this.numUpDown_hour = new System.Windows.Forms.NumericUpDown();
            this.label_Hour = new System.Windows.Forms.Label();
            this.numUpDown_min = new System.Windows.Forms.NumericUpDown();
            this.label_Minutes = new System.Windows.Forms.Label();
            this.numUpDown_sec = new System.Windows.Forms.NumericUpDown();
            this.label_Seconds = new System.Windows.Forms.Label();
            this.gBox_Speed = new System.Windows.Forms.GroupBox();
            this.label_RunThreshold = new System.Windows.Forms.Label();
            this.numUpDown_RunSpeed = new System.Windows.Forms.NumericUpDown();
            this.label_StopThreshold = new System.Windows.Forms.Label();
            this.numUpDown_StopSpeed = new System.Windows.Forms.NumericUpDown();
            this.gBox_Route = new System.Windows.Forms.GroupBox();
            this.labelSelectedRoute = new System.Windows.Forms.Label();
            this.comboBox_Routes = new System.Windows.Forms.ComboBox();
            this.gBox_Flag = new System.Windows.Forms.GroupBox();
            this.labelFlagNo = new System.Windows.Forms.Label();
            this.nuUpDown_FlagNo = new System.Windows.Forms.NumericUpDown();
            this.labelFlagVal = new System.Windows.Forms.Label();
            this.nuUpDown_FlagVal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_S88SensorAddr)).BeginInit();
            this.gBox_SpecTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_sec)).BeginInit();
            this.gBox_Speed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RunSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_StopSpeed)).BeginInit();
            this.gBox_Route.SuspendLayout();
            this.gBox_Flag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDown_FlagNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDown_FlagVal)).BeginInit();
            this.SuspendLayout();
            // 
            // numBox_S88SensorAddr
            // 
            this.numBox_S88SensorAddr.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numBox_S88SensorAddr.Location = new System.Drawing.Point(212, 18);
            this.numBox_S88SensorAddr.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numBox_S88SensorAddr.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numBox_S88SensorAddr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBox_S88SensorAddr.Name = "numBox_S88SensorAddr";
            this.numBox_S88SensorAddr.Size = new System.Drawing.Size(138, 33);
            this.numBox_S88SensorAddr.TabIndex = 64;
            this.numBox_S88SensorAddr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_S88SensorAddr
            // 
            this.label_S88SensorAddr.Location = new System.Drawing.Point(17, 26);
            this.label_S88SensorAddr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_S88SensorAddr.Name = "label_S88SensorAddr";
            this.label_S88SensorAddr.Size = new System.Drawing.Size(183, 28);
            this.label_S88SensorAddr.TabIndex = 63;
            this.label_S88SensorAddr.Text = "Sensor address";
            // 
            // button_Ok
            // 
            this.button_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Ok.Location = new System.Drawing.Point(382, 406);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(125, 51);
            this.button_Ok.TabIndex = 65;
            this.button_Ok.Text = "&OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(547, 406);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(125, 51);
            this.button_Cancel.TabIndex = 66;
            this.button_Cancel.Text = "&Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // gBox_SpecTime
            // 
            this.gBox_SpecTime.Controls.Add(this.numUpDown_hour);
            this.gBox_SpecTime.Controls.Add(this.label_Hour);
            this.gBox_SpecTime.Controls.Add(this.numUpDown_min);
            this.gBox_SpecTime.Controls.Add(this.label_Minutes);
            this.gBox_SpecTime.Controls.Add(this.numUpDown_sec);
            this.gBox_SpecTime.Controls.Add(this.label_Seconds);
            this.gBox_SpecTime.Location = new System.Drawing.Point(20, 63);
            this.gBox_SpecTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gBox_SpecTime.Name = "gBox_SpecTime";
            this.gBox_SpecTime.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gBox_SpecTime.Size = new System.Drawing.Size(315, 177);
            this.gBox_SpecTime.TabIndex = 111;
            this.gBox_SpecTime.TabStop = false;
            this.gBox_SpecTime.Text = "Timing";
            // 
            // numUpDown_hour
            // 
            this.numUpDown_hour.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numUpDown_hour.Location = new System.Drawing.Point(192, 27);
            this.numUpDown_hour.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numUpDown_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numUpDown_hour.Name = "numUpDown_hour";
            this.numUpDown_hour.Size = new System.Drawing.Size(93, 35);
            this.numUpDown_hour.TabIndex = 116;
            this.numUpDown_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Hour
            // 
            this.label_Hour.Location = new System.Drawing.Point(30, 36);
            this.label_Hour.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Hour.Name = "label_Hour";
            this.label_Hour.Size = new System.Drawing.Size(108, 18);
            this.label_Hour.TabIndex = 115;
            this.label_Hour.Text = "Hours";
            // 
            // numUpDown_min
            // 
            this.numUpDown_min.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numUpDown_min.Location = new System.Drawing.Point(192, 70);
            this.numUpDown_min.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numUpDown_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDown_min.Name = "numUpDown_min";
            this.numUpDown_min.Size = new System.Drawing.Size(93, 35);
            this.numUpDown_min.TabIndex = 114;
            this.numUpDown_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Minutes
            // 
            this.label_Minutes.Location = new System.Drawing.Point(30, 80);
            this.label_Minutes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Minutes.Name = "label_Minutes";
            this.label_Minutes.Size = new System.Drawing.Size(108, 18);
            this.label_Minutes.TabIndex = 113;
            this.label_Minutes.Text = "Minutes";
            // 
            // numUpDown_sec
            // 
            this.numUpDown_sec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numUpDown_sec.Location = new System.Drawing.Point(192, 114);
            this.numUpDown_sec.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numUpDown_sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDown_sec.Name = "numUpDown_sec";
            this.numUpDown_sec.Size = new System.Drawing.Size(93, 35);
            this.numUpDown_sec.TabIndex = 112;
            this.numUpDown_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Seconds
            // 
            this.label_Seconds.Location = new System.Drawing.Point(30, 123);
            this.label_Seconds.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Seconds.Name = "label_Seconds";
            this.label_Seconds.Size = new System.Drawing.Size(108, 18);
            this.label_Seconds.TabIndex = 111;
            this.label_Seconds.Text = "Seconds";
            // 
            // gBox_Speed
            // 
            this.gBox_Speed.Controls.Add(this.label_RunThreshold);
            this.gBox_Speed.Controls.Add(this.numUpDown_RunSpeed);
            this.gBox_Speed.Controls.Add(this.label_StopThreshold);
            this.gBox_Speed.Controls.Add(this.numUpDown_StopSpeed);
            this.gBox_Speed.Location = new System.Drawing.Point(362, 63);
            this.gBox_Speed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gBox_Speed.Name = "gBox_Speed";
            this.gBox_Speed.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gBox_Speed.Size = new System.Drawing.Size(333, 177);
            this.gBox_Speed.TabIndex = 112;
            this.gBox_Speed.TabStop = false;
            this.gBox_Speed.Text = "Speed threshold";
            // 
            // label_RunThreshold
            // 
            this.label_RunThreshold.Location = new System.Drawing.Point(17, 54);
            this.label_RunThreshold.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_RunThreshold.Name = "label_RunThreshold";
            this.label_RunThreshold.Size = new System.Drawing.Size(143, 26);
            this.label_RunThreshold.TabIndex = 114;
            this.label_RunThreshold.Text = "Run threshold";
            // 
            // numUpDown_RunSpeed
            // 
            this.numUpDown_RunSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numUpDown_RunSpeed.Location = new System.Drawing.Point(185, 45);
            this.numUpDown_RunSpeed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numUpDown_RunSpeed.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numUpDown_RunSpeed.Name = "numUpDown_RunSpeed";
            this.numUpDown_RunSpeed.Size = new System.Drawing.Size(138, 35);
            this.numUpDown_RunSpeed.TabIndex = 113;
            // 
            // label_StopThreshold
            // 
            this.label_StopThreshold.Location = new System.Drawing.Point(17, 108);
            this.label_StopThreshold.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_StopThreshold.Name = "label_StopThreshold";
            this.label_StopThreshold.Size = new System.Drawing.Size(143, 26);
            this.label_StopThreshold.TabIndex = 112;
            this.label_StopThreshold.Text = "Stop threshold";
            // 
            // numUpDown_StopSpeed
            // 
            this.numUpDown_StopSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numUpDown_StopSpeed.Location = new System.Drawing.Point(185, 99);
            this.numUpDown_StopSpeed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numUpDown_StopSpeed.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numUpDown_StopSpeed.Name = "numUpDown_StopSpeed";
            this.numUpDown_StopSpeed.Size = new System.Drawing.Size(138, 35);
            this.numUpDown_StopSpeed.TabIndex = 0;
            // 
            // gBox_Route
            // 
            this.gBox_Route.Controls.Add(this.labelSelectedRoute);
            this.gBox_Route.Controls.Add(this.comboBox_Routes);
            this.gBox_Route.Location = new System.Drawing.Point(20, 249);
            this.gBox_Route.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gBox_Route.Name = "gBox_Route";
            this.gBox_Route.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gBox_Route.Size = new System.Drawing.Size(315, 141);
            this.gBox_Route.TabIndex = 113;
            this.gBox_Route.TabStop = false;
            this.gBox_Route.Text = "Route";
            // 
            // labelSelectedRoute
            // 
            this.labelSelectedRoute.Location = new System.Drawing.Point(37, 38);
            this.labelSelectedRoute.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSelectedRoute.Name = "labelSelectedRoute";
            this.labelSelectedRoute.Size = new System.Drawing.Size(168, 26);
            this.labelSelectedRoute.TabIndex = 119;
            this.labelSelectedRoute.Text = "Selected route";
            // 
            // comboBox_Routes
            // 
            this.comboBox_Routes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Routes.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_Routes.FormattingEnabled = true;
            this.comboBox_Routes.Location = new System.Drawing.Point(33, 63);
            this.comboBox_Routes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox_Routes.Name = "comboBox_Routes";
            this.comboBox_Routes.Size = new System.Drawing.Size(254, 36);
            this.comboBox_Routes.TabIndex = 5;
            // 
            // gBox_Flag
            // 
            this.gBox_Flag.Controls.Add(this.labelFlagNo);
            this.gBox_Flag.Controls.Add(this.nuUpDown_FlagNo);
            this.gBox_Flag.Controls.Add(this.labelFlagVal);
            this.gBox_Flag.Controls.Add(this.nuUpDown_FlagVal);
            this.gBox_Flag.Location = new System.Drawing.Point(362, 249);
            this.gBox_Flag.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gBox_Flag.Name = "gBox_Flag";
            this.gBox_Flag.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gBox_Flag.Size = new System.Drawing.Size(330, 141);
            this.gBox_Flag.TabIndex = 114;
            this.gBox_Flag.TabStop = false;
            this.gBox_Flag.Text = "Flag";
            // 
            // labelFlagNo
            // 
            this.labelFlagNo.Location = new System.Drawing.Point(20, 38);
            this.labelFlagNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFlagNo.Name = "labelFlagNo";
            this.labelFlagNo.Size = new System.Drawing.Size(102, 26);
            this.labelFlagNo.TabIndex = 118;
            this.labelFlagNo.Text = "Flag No";
            // 
            // nuUpDown_FlagNo
            // 
            this.nuUpDown_FlagNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nuUpDown_FlagNo.Location = new System.Drawing.Point(23, 68);
            this.nuUpDown_FlagNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nuUpDown_FlagNo.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nuUpDown_FlagNo.Name = "nuUpDown_FlagNo";
            this.nuUpDown_FlagNo.Size = new System.Drawing.Size(133, 35);
            this.nuUpDown_FlagNo.TabIndex = 117;
            // 
            // labelFlagVal
            // 
            this.labelFlagVal.Location = new System.Drawing.Point(172, 38);
            this.labelFlagVal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFlagVal.Name = "labelFlagVal";
            this.labelFlagVal.Size = new System.Drawing.Size(143, 26);
            this.labelFlagVal.TabIndex = 116;
            this.labelFlagVal.Text = "Value";
            // 
            // nuUpDown_FlagVal
            // 
            this.nuUpDown_FlagVal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nuUpDown_FlagVal.Location = new System.Drawing.Point(178, 68);
            this.nuUpDown_FlagVal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nuUpDown_FlagVal.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nuUpDown_FlagVal.Name = "nuUpDown_FlagVal";
            this.nuUpDown_FlagVal.Size = new System.Drawing.Size(128, 35);
            this.nuUpDown_FlagVal.TabIndex = 115;
            // 
            // ScriptTriggerForm
            // 
            this.AcceptButton = this.button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(712, 471);
            this.Controls.Add(this.gBox_Flag);
            this.Controls.Add(this.gBox_Route);
            this.Controls.Add(this.gBox_Speed);
            this.Controls.Add(this.gBox_SpecTime);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.numBox_S88SensorAddr);
            this.Controls.Add(this.label_S88SensorAddr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "ScriptTriggerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trigger Properties";
            ((System.ComponentModel.ISupportInitialize)(this.numBox_S88SensorAddr)).EndInit();
            this.gBox_SpecTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_sec)).EndInit();
            this.gBox_Speed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RunSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_StopSpeed)).EndInit();
            this.gBox_Route.ResumeLayout(false);
            this.gBox_Flag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDown_FlagNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDown_FlagVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_S88SensorAddr;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.NumericUpDown numUpDown_hour;
        private System.Windows.Forms.Label label_Hour;
        public System.Windows.Forms.NumericUpDown numUpDown_min;
        private System.Windows.Forms.Label label_Minutes;
        public System.Windows.Forms.NumericUpDown numUpDown_sec;
        private System.Windows.Forms.Label label_Seconds;
        public System.Windows.Forms.NumericUpDown numBox_S88SensorAddr;
        public System.Windows.Forms.GroupBox gBox_SpecTime;
        private System.Windows.Forms.Label label_RunThreshold;
        public System.Windows.Forms.NumericUpDown numUpDown_RunSpeed;
        private System.Windows.Forms.Label label_StopThreshold;
        public System.Windows.Forms.NumericUpDown numUpDown_StopSpeed;
        public System.Windows.Forms.GroupBox gBox_Speed;
        private System.Windows.Forms.Label labelSelectedRoute;
        public System.Windows.Forms.ComboBox comboBox_Routes;
        private System.Windows.Forms.Label labelFlagNo;
        public System.Windows.Forms.NumericUpDown nuUpDown_FlagNo;
        private System.Windows.Forms.Label labelFlagVal;
        public System.Windows.Forms.NumericUpDown nuUpDown_FlagVal;
        public System.Windows.Forms.GroupBox gBox_Route;
        public System.Windows.Forms.GroupBox gBox_Flag;
    }
}