namespace Asm2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbChip = new System.Windows.Forms.Label();
            this.LbWat = new System.Windows.Forms.Label();
            this.lbBallNumber = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.TxtChip = new System.Windows.Forms.TextBox();
            this.TxtWat = new System.Windows.Forms.TextBox();
            this.TxtBulbn = new System.Windows.Forms.TextBox();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.CbLightType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOnC = new System.Windows.Forms.Button();
            this.BtnOffC = new System.Windows.Forms.Button();
            this.BtnChandelierInfor = new System.Windows.Forms.Button();
            this.BtnSetChandelier = new System.Windows.Forms.Button();
            this.CbSetMode = new System.Windows.Forms.ComboBox();
            this.BtnRemoveBulb = new System.Windows.Forms.Button();
            this.TxtRemovebulbC = new System.Windows.Forms.TextBox();
            this.CbSetModeLedString = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TxtSetTime = new System.Windows.Forms.TextBox();
            this.BtnSetTimeOn = new System.Windows.Forms.Button();
            this.BtnGobo = new System.Windows.Forms.Button();
            this.CbGoboName = new System.Windows.Forms.ComboBox();
            this.BtnCreateLight = new System.Windows.Forms.Button();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.PbLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChip
            // 
            this.lbChip.AutoSize = true;
            this.lbChip.Location = new System.Drawing.Point(115, 36);
            this.lbChip.Name = "lbChip";
            this.lbChip.Size = new System.Drawing.Size(57, 25);
            this.lbChip.TabIndex = 0;
            this.lbChip.Text = "Chip :";
            // 
            // LbWat
            // 
            this.LbWat.AutoSize = true;
            this.LbWat.Location = new System.Drawing.Point(85, 80);
            this.LbWat.Name = "LbWat";
            this.LbWat.Size = new System.Drawing.Size(87, 25);
            this.LbWat.TabIndex = 1;
            this.LbWat.Text = "Wattage :";
            // 
            // lbBallNumber
            // 
            this.lbBallNumber.AutoSize = true;
            this.lbBallNumber.Location = new System.Drawing.Point(414, 39);
            this.lbBallNumber.Name = "lbBallNumber";
            this.lbBallNumber.Size = new System.Drawing.Size(124, 25);
            this.lbBallNumber.TabIndex = 2;
            this.lbBallNumber.Text = "BulbNumbers:";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(436, 89);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(77, 25);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "Weight :";
            // 
            // TxtChip
            // 
            this.TxtChip.Location = new System.Drawing.Point(173, 33);
            this.TxtChip.Name = "TxtChip";
            this.TxtChip.Size = new System.Drawing.Size(140, 31);
            this.TxtChip.TabIndex = 6;
            // 
            // TxtWat
            // 
            this.TxtWat.Location = new System.Drawing.Point(173, 77);
            this.TxtWat.Name = "TxtWat";
            this.TxtWat.Size = new System.Drawing.Size(140, 31);
            this.TxtWat.TabIndex = 7;
            // 
            // TxtBulbn
            // 
            this.TxtBulbn.Location = new System.Drawing.Point(544, 33);
            this.TxtBulbn.Name = "TxtBulbn";
            this.TxtBulbn.Size = new System.Drawing.Size(136, 31);
            this.TxtBulbn.TabIndex = 8;
            // 
            // TxtWeight
            // 
            this.TxtWeight.Location = new System.Drawing.Point(544, 83);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(136, 31);
            this.TxtWeight.TabIndex = 9;
            // 
            // CbLightType
            // 
            this.CbLightType.FormattingEnabled = true;
            this.CbLightType.Location = new System.Drawing.Point(115, 130);
            this.CbLightType.Name = "CbLightType";
            this.CbLightType.Size = new System.Drawing.Size(182, 33);
            this.CbLightType.TabIndex = 10;
            this.CbLightType.SelectedIndexChanged += new System.EventHandler(this.CbLightType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Light Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnOnC
            // 
            this.BtnOnC.Location = new System.Drawing.Point(419, 203);
            this.BtnOnC.Name = "BtnOnC";
            this.BtnOnC.Size = new System.Drawing.Size(93, 43);
            this.BtnOnC.TabIndex = 15;
            this.BtnOnC.Text = "On";
            this.BtnOnC.UseVisualStyleBackColor = true;
            this.BtnOnC.Click += new System.EventHandler(this.BtnOnC_Click);
            // 
            // BtnOffC
            // 
            this.BtnOffC.Location = new System.Drawing.Point(534, 203);
            this.BtnOffC.Name = "BtnOffC";
            this.BtnOffC.Size = new System.Drawing.Size(93, 43);
            this.BtnOffC.TabIndex = 16;
            this.BtnOffC.Text = "Off";
            this.BtnOffC.UseVisualStyleBackColor = true;
            this.BtnOffC.Click += new System.EventHandler(this.BtnOffC_Click);
            // 
            // BtnChandelierInfor
            // 
            this.BtnChandelierInfor.Location = new System.Drawing.Point(646, 203);
            this.BtnChandelierInfor.Name = "BtnChandelierInfor";
            this.BtnChandelierInfor.Size = new System.Drawing.Size(127, 43);
            this.BtnChandelierInfor.TabIndex = 18;
            this.BtnChandelierInfor.Text = "Information";
            this.BtnChandelierInfor.UseVisualStyleBackColor = true;
            this.BtnChandelierInfor.Click += new System.EventHandler(this.BtnChandelierInfor_Click);
            // 
            // BtnSetChandelier
            // 
            this.BtnSetChandelier.Location = new System.Drawing.Point(431, 259);
            this.BtnSetChandelier.Name = "BtnSetChandelier";
            this.BtnSetChandelier.Size = new System.Drawing.Size(107, 43);
            this.BtnSetChandelier.TabIndex = 21;
            this.BtnSetChandelier.Text = "Set Mode:";
            this.BtnSetChandelier.UseVisualStyleBackColor = true;
            this.BtnSetChandelier.Click += new System.EventHandler(this.BtnSetChandelier_Click);
            // 
            // CbSetMode
            // 
            this.CbSetMode.FormattingEnabled = true;
            this.CbSetMode.Location = new System.Drawing.Point(564, 265);
            this.CbSetMode.Name = "CbSetMode";
            this.CbSetMode.Size = new System.Drawing.Size(182, 33);
            this.CbSetMode.TabIndex = 22;
            this.CbSetMode.SelectedIndexChanged += new System.EventHandler(this.CbSetMode_SelectedIndexChanged);
            // 
            // BtnRemoveBulb
            // 
            this.BtnRemoveBulb.Location = new System.Drawing.Point(419, 322);
            this.BtnRemoveBulb.Name = "BtnRemoveBulb";
            this.BtnRemoveBulb.Size = new System.Drawing.Size(139, 43);
            this.BtnRemoveBulb.TabIndex = 26;
            this.BtnRemoveBulb.Text = "Remove Bulb:";
            this.BtnRemoveBulb.UseVisualStyleBackColor = true;
            this.BtnRemoveBulb.Click += new System.EventHandler(this.BtnRemoveBulb_Click);
            // 
            // TxtRemovebulbC
            // 
            this.TxtRemovebulbC.Location = new System.Drawing.Point(577, 328);
            this.TxtRemovebulbC.Name = "TxtRemovebulbC";
            this.TxtRemovebulbC.Size = new System.Drawing.Size(114, 31);
            this.TxtRemovebulbC.TabIndex = 27;
            // 
            // CbSetModeLedString
            // 
            this.CbSetModeLedString.FormattingEnabled = true;
            this.CbSetModeLedString.Location = new System.Drawing.Point(564, 265);
            this.CbSetModeLedString.Name = "CbSetModeLedString";
            this.CbSetModeLedString.Size = new System.Drawing.Size(182, 33);
            this.CbSetModeLedString.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TxtSetTime
            // 
            this.TxtSetTime.Location = new System.Drawing.Point(577, 328);
            this.TxtSetTime.Name = "TxtSetTime";
            this.TxtSetTime.Size = new System.Drawing.Size(125, 31);
            this.TxtSetTime.TabIndex = 34;
            this.TxtSetTime.TextChanged += new System.EventHandler(this.TxtSetTime_TextChanged);
            // 
            // BtnSetTimeOn
            // 
            this.BtnSetTimeOn.Location = new System.Drawing.Point(419, 322);
            this.BtnSetTimeOn.Name = "BtnSetTimeOn";
            this.BtnSetTimeOn.Size = new System.Drawing.Size(139, 43);
            this.BtnSetTimeOn.TabIndex = 33;
            this.BtnSetTimeOn.Text = "Set Timer:";
            this.BtnSetTimeOn.UseVisualStyleBackColor = true;
            this.BtnSetTimeOn.Click += new System.EventHandler(this.SetTimeOn_Click);
            // 
            // BtnGobo
            // 
            this.BtnGobo.Location = new System.Drawing.Point(419, 259);
            this.BtnGobo.Name = "BtnGobo";
            this.BtnGobo.Size = new System.Drawing.Size(129, 43);
            this.BtnGobo.TabIndex = 37;
            this.BtnGobo.Text = "Create Gobo:";
            this.BtnGobo.UseVisualStyleBackColor = true;
            this.BtnGobo.Click += new System.EventHandler(this.BtnGobo_Click);
            // 
            // CbGoboName
            // 
            this.CbGoboName.FormattingEnabled = true;
            this.CbGoboName.Location = new System.Drawing.Point(564, 265);
            this.CbGoboName.Name = "CbGoboName";
            this.CbGoboName.Size = new System.Drawing.Size(182, 33);
            this.CbGoboName.TabIndex = 38;
            // 
            // BtnCreateLight
            // 
            this.BtnCreateLight.Location = new System.Drawing.Point(367, 130);
            this.BtnCreateLight.Name = "BtnCreateLight";
            this.BtnCreateLight.Size = new System.Drawing.Size(116, 43);
            this.BtnCreateLight.TabIndex = 42;
            this.BtnCreateLight.Text = "Create light";
            this.BtnCreateLight.UseVisualStyleBackColor = true;
            this.BtnCreateLight.Click += new System.EventHandler(this.BtnCreateLight_Click);
            // 
            // imgL
            // 
            this.imgL.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "COff.png");
            this.imgL.Images.SetKeyName(1, "COn1.png");
            this.imgL.Images.SetKeyName(2, "COn2.png");
            this.imgL.Images.SetKeyName(3, "COn3.png");
            this.imgL.Images.SetKeyName(4, "LSOFf.png");
            this.imgL.Images.SetKeyName(5, "LSON1.png");
            this.imgL.Images.SetKeyName(6, "LSON2.png");
            this.imgL.Images.SetKeyName(7, "LSON3.png");
            this.imgL.Images.SetKeyName(8, "SLOFF.png");
            this.imgL.Images.SetKeyName(9, "SLON.png");
            this.imgL.Images.SetKeyName(10, "SLON1.png");
            this.imgL.Images.SetKeyName(11, "SLON2.png");
            this.imgL.Images.SetKeyName(12, "SLON3.png");
            // 
            // PbLight
            // 
            this.PbLight.Location = new System.Drawing.Point(33, 185);
            this.PbLight.Name = "PbLight";
            this.PbLight.Size = new System.Drawing.Size(366, 349);
            this.PbLight.TabIndex = 43;
            this.PbLight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(866, 546);
            this.Controls.Add(this.PbLight);
            this.Controls.Add(this.BtnCreateLight);
            this.Controls.Add(this.CbGoboName);
            this.Controls.Add(this.BtnGobo);
            this.Controls.Add(this.TxtSetTime);
            this.Controls.Add(this.BtnSetTimeOn);
            this.Controls.Add(this.CbSetModeLedString);
            this.Controls.Add(this.TxtRemovebulbC);
            this.Controls.Add(this.BtnRemoveBulb);
            this.Controls.Add(this.CbSetMode);
            this.Controls.Add(this.BtnSetChandelier);
            this.Controls.Add(this.BtnChandelierInfor);
            this.Controls.Add(this.BtnOffC);
            this.Controls.Add(this.BtnOnC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbLightType);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.TxtBulbn);
            this.Controls.Add(this.TxtWat);
            this.Controls.Add(this.TxtChip);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbBallNumber);
            this.Controls.Add(this.LbWat);
            this.Controls.Add(this.lbChip);
            this.Name = "Form1";
            this.Text = "Factory ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbChip;
        private Label LbWat;
        private Label lbBallNumber;
        private Label lbWeight;
        private TextBox TxtChip;
        private TextBox TxtWat;
        private TextBox TxtBulbn;
        private TextBox TxtWeight;
        private ComboBox CbLightType;
        private Label label1;
        private Button BtnOnC;
        private Button BtnOffC;
        private Button BtnChandelierInfor;
        private Button BtnSetChandelier;
        private ComboBox CbSetMode;
        private Button BtnRemoveBulb;
        private TextBox TxtRemovebulbC;
        private ComboBox CbSetModeLedString;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private TextBox TxtSetTime;
        private Button BtnSetTimeOn;
        private Button BtnGobo;
        private ComboBox CbGoboName;
        private Button BtnCreateLight;
        private ImageList imgL;
        private PictureBox PbLight;
    }
}