using ClassLibraryLightFactory;
using ClassLibraryLightFactory.FactoryMethod;
using ClassLibraryLightFactory.Light1;
using Microsoft.VisualBasic;
using System.Data;
using System.Security.AccessControl;

namespace Asm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFactories();
            Hide();
            CbSetMode.Items.Add("1");
            CbSetMode.Items.Add("2");
            CbSetMode.Items.Add("3");
            CbSetMode.SelectedIndex = 0;
            CbSetModeLedString.Items.Add("Red bright");
            CbSetModeLedString.Items.Add("Purple bright");
            CbSetModeLedString.Items.Add("Blue bright");
            CbSetModeLedString.Items.Add("Flicker");
            CbSetModeLedString.SelectedIndex = 0;
            CbGoboName.Items.Add("hearts-shape");
            CbGoboName.Items.Add("bubbles-shape");
            CbGoboName.Items.Add("stars-shape");
            CbGoboName.SelectedIndex = 0;
        }
        private void Hide()
        {
            BtnChandelierInfor.Visible = false;
            BtnGobo.Visible = false;
            BtnOnC.Visible = false;
            BtnOffC.Visible = false;
            BtnSetChandelier.Visible = false;
            BtnSetTimeOn.Visible = false;
            TxtSetTime.Visible = false;
            CbSetMode.Visible = false;
            CbSetModeLedString.Visible = false;
            CbGoboName.Visible = false;
            BtnRemoveBulb.Visible = false;
            TxtRemovebulbC.Visible = false;
            PbLight.Visible = false;
        }
        private ILightFactory currentFactory;
        private void InitializeFactories()
        {
            // Add factories to the drop-down
            CbLightType.Items.Add("Chandelier");
            CbLightType.Items.Add("LedString");
            CbLightType.Items.Add("SpotLight");
            CbLightType.SelectedIndex = 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CbLightType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbLightType.SelectedItem.ToString() == "LedString")
            {
                Hide();
                ClearData();
            }
            if(CbLightType.SelectedItem.ToString() == "SpotLight")
            {
                Hide();
                ClearData();
            }
            if (CbLightType.SelectedItem.ToString() == "Chandelier")
            {
                Hide();
                ClearData();
            }
        }
        private bool OnClick = false;
        private void BtnOnC_Click(object sender, EventArgs e)
        {
            OnClick = true;
            string selectedLightType = CbLightType.SelectedItem.ToString();
            if (selectedLightType == "Chandelier")
            {
                PbLight.Image = imgL.Images[1];
                PbLight.Visible = true;
            }
            if (selectedLightType == "LedString")
            {
                PbLight.Image = imgL.Images[5];
                PbLight.Visible = true;
            }
            if (selectedLightType == "SpotLight")
            {
                PbLight.Image = imgL.Images[9];
                PbLight.Visible = true;
            }
        }
        private void BtnOffC_Click(object sender, EventArgs e)
        {
            OnClick = false;
            if (CbLightType.SelectedItem.ToString() == "LedString")
            {
                PbLight.Image = imgL.Images[4];
                PbLight.Visible = true;
                timer1.Enabled = false;
            }
            else if (CbLightType.SelectedItem.ToString() == "Chandelier")
            {
                PbLight.Image = imgL.Images[0];
                PbLight.Visible = true;       
            }
            else if (CbLightType.SelectedItem.ToString() == "SpotLight")
            {
                PbLight.Image = imgL.Images[8];
                PbLight.Visible = true;
            }
        }
        private void BtnChandelierInfor_Click(object sender, EventArgs e)
        {
            if (currentFactory != null)
            {
                Light currentLight = currentFactory.CreateLight(
                    int.Parse(TxtChip.Text),
                    int.Parse(TxtWat.Text),
                    int.Parse(TxtBulbn.Text),
                    double.Parse(TxtWeight.Text)
                );
                string lightInformation = currentLight.DisplayInformation();
                MessageBox.Show(lightInformation, $"{CbLightType.SelectedItem} Information");
            }
            else
            {
                MessageBox.Show("Current factory is null.", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CbSetMode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnSetChandelier_Click(object sender, EventArgs e)
        {
            if (OnClick == true)
            {
                if (CbSetMode.SelectedItem.ToString() == "1" && CbLightType.SelectedItem.ToString() == "Chandelier")
                {
                    PbLight.Image = imgL.Images[1];
                    PbLight.Visible = true;
                }
                else if (CbSetMode.SelectedItem.ToString() == "2" && CbLightType.SelectedItem.ToString() == "Chandelier")
                {
                    PbLight.Image = imgL.Images[2];
                    PbLight.Visible = true;
                }
                else if (CbSetMode.SelectedItem.ToString() == "3" && CbLightType.SelectedItem.ToString() == "Chandelier")
                {
                    PbLight.Image = imgL.Images[3];
                    PbLight.Visible = true;
                }
                if (CbSetModeLedString.SelectedItem.ToString() == "Red bright" && CbLightType.SelectedItem.ToString()
                    == "LedString")
                {
                    PbLight.Image = imgL.Images[5];
                    PbLight.Visible = true;
                }
                else if (CbSetModeLedString.SelectedItem.ToString() == "Blue bright" && CbLightType.SelectedItem.ToString() 
                    == "LedString")
                {
                    PbLight.Image = imgL.Images[7];
                    PbLight.Visible = true;
                }
                else if (CbSetModeLedString.SelectedItem.ToString() == "Purple bright" && CbLightType.SelectedItem.ToString() 
                    == "LedString")
                {
                    PbLight.Image = imgL.Images[6];
                    PbLight.Visible = true;
                }
                else if (CbSetModeLedString.SelectedItem.ToString() == "Flicker" && CbLightType.SelectedItem.ToString() == "LedString")
                {
                    timer1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please,Turn on the light before using the function.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnRemoveBulb_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PbLedStringBlue_Click(object sender, EventArgs e)
        {

        }
        private int intImageNumber = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            PbLight.Image = imgL.Images[intImageNumber];
            PbLight.Visible = true;
            intImageNumber++;
            if (intImageNumber > 7)
            {
                intImageNumber = 5;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (CbLightType.SelectedItem.ToString() == "LedString") {
                PbLight.Image = imgL.Images[4];
                PbLight.Visible = true;
            }
        }

        private void SetTimeOn_Click(object sender, EventArgs e)
        {
            if (OnClick == true) 
            { 
                int time = int.Parse(TxtSetTime.Text);
                timer2.Interval = time;
                timer2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please,Turn on the light before using the function.", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtSetTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGobo_Click(object sender, EventArgs e)
        {
            if (OnClick == true) { 
                if (CbGoboName.SelectedItem.ToString() == "hearts-shape")
                {
                    PbLight.Image = imgL.Images[11];
                    PbLight.Visible = true;
                }
                else if (CbGoboName.SelectedItem.ToString() == "bubbles-shape")
                {
                    PbLight.Image = imgL.Images[12];
                    PbLight.Visible = true;
                }
                else if (CbGoboName.SelectedItem.ToString() == "stars-shape")
                {
                    PbLight.Image = imgL.Images[10];
                    PbLight.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please,Turn on the light before using the function.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearData()
        {
            TxtChip.Text = "";
            TxtBulbn.Text = "";
            TxtWat.Text = "";
            TxtWeight.Text = "";
        }
        private bool CheckDataType()
        {
            if (!int.TryParse(TxtChip.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer for Chip field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtChip.Focus();
                return false;
            }

            if (!int.TryParse(TxtWat.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer for Wat field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtWat.Focus();
                return false;
            }

            if (!int.TryParse(TxtBulbn.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer for Bulbn field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBulbn.Focus();
                return false;
            }

            if (!double.TryParse(TxtWeight.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for Weight field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtWeight.Focus();
                return false;
            }
            return true;
        }
        private void BtnCreateLight_Click(object sender, EventArgs e)
        {
            if (!CheckDataType())
            {
                return;
            }
            if (CbLightType.SelectedItem.ToString() == "Chandelier")
            {
                currentFactory = new ChandelierFactory();
                Light chandelier = currentFactory.CreateLight(
                     int.Parse(TxtChip.Text),
                     int.Parse(TxtWat.Text),
                     int.Parse(TxtBulbn.Text),
                     double.Parse(TxtWeight.Text)
                 );
                BtnOffC.Visible = true;
                BtnOnC.Visible = true;
                BtnChandelierInfor.Visible = true;
                BtnSetChandelier.Visible = true;
                CbSetMode.Visible = true;
                BtnRemoveBulb.Visible = false;
                TxtRemovebulbC.Visible = false;
                CbSetModeLedString.Visible = false;
                CbSetMode.Visible = true;
                BtnSetTimeOn.Visible = false;
                TxtSetTime.Visible = false;
                PbLight.Image = imgL.Images[0];
                PbLight.Visible = true;
            }
            else if (CbLightType.SelectedItem.ToString() == "LedString")
            {
                currentFactory = new LedStringFactory();
                Light ledString = currentFactory.CreateLight(
                    int.Parse(TxtChip.Text),
                    int.Parse(TxtWat.Text),
                    int.Parse(TxtBulbn.Text),
                    double.Parse(TxtWeight.Text)
                );
                BtnChandelierInfor.Visible = false;
                BtnSetChandelier.Visible = false;
                CbSetMode.Visible = false;
                BtnRemoveBulb.Visible = false;
                TxtRemovebulbC.Visible = false;
                BtnOnC.Visible = true;
                BtnOffC.Visible = true;
                BtnChandelierInfor.Visible = true;
                BtnSetTimeOn.Visible = true;
                TxtSetTime.Visible = true;
                CbSetModeLedString.Visible = true;
                CbSetMode.Visible = false;
                BtnSetChandelier.Visible = true;
                PbLight.Image = imgL.Images[4];
                PbLight.Visible = true;
            }
            else if (CbLightType.SelectedItem.ToString() == "SpotLight")
            {
                currentFactory = new SpotLightFactory();
                Light spotLight = currentFactory.CreateLight(
                    int.Parse(TxtChip.Text),
                    int.Parse(TxtWat.Text),
                    int.Parse(TxtBulbn.Text),
                    double.Parse(TxtWeight.Text)
                );
                BtnOffC.Visible = true;
                BtnOnC.Visible = true;
                CbSetModeLedString.Visible = false;
                BtnSetTimeOn.Visible = false;
                TxtSetTime.Visible = false;
                BtnChandelierInfor.Visible = true;
                BtnSetChandelier.Visible = false;
                CbSetMode.Visible = false;
                BtnRemoveBulb.Visible = false;
                TxtRemovebulbC.Visible = false;
                BtnGobo.Visible = true;
                CbGoboName.Visible = true;
                PbLight.Image = imgL.Images[8];
                PbLight.Visible = true;
            }
        }
    }
}