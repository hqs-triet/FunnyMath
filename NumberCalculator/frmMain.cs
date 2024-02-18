using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NumberCalculator
{
    public partial class frmMain : Form
    {
        MusicPlayer player = new MusicPlayer();
        public frmMain()
        {
            InitializeComponent();
        }

        private int _num1, _num2, _num3, _rs;
        private Random _rnd = new Random();

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            timer2.Stop();
            timer1.Stop();

            rdoPlusNum2.Enabled = rdoPlusNum3.Enabled = rdoMultipleNum2.Enabled = rdoBangCuuChuong.Enabled = true;
            rdoPlusMinusNum2.Enabled = rdoPlusMinusNum3.Enabled = rdoDivideNum2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            ShowNumber();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rdoGroup_CheckedChanged(null, null);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.AdjustLocation();

        }

        private void pnl1_Resize(object sender, EventArgs e)
        {
            this.AdjustLocation();
        }

        private void AdjustLocation()
        {
            pnl1.Location = new Point((this.ClientSize.Width - pnl1.Width) / 2, pnl1.Location.Y);
        }

        private void PlayBgSound()
        {
            player.Open(Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName, "AmNhac.mp3"));
            player.Play();
        }

        private void rdoGroup_CheckedChanged(object sender, EventArgs e)
        {
            minNum3.Enabled = maxNum3.Enabled = !rdoPlusNum2.Checked 
                                                && !rdoMultipleNum2.Checked 
                                                && !rdoBangCuuChuong.Checked
                                                && !rdoPlusMinusNum2.Checked
                                                && !rdoDivideNum2.Checked;
            if (rdoBangCuuChuong.Checked)
            {
                minNum1.Value = minNum2.Value = 1;
                maxNum1.Value = maxNum2.Value = 9;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.AdjustLocation();

            if(chkPlayBackground.Checked)
                this.PlayBgSound();

            timer1.Interval = (int)delayTime.Value * 1000;

            ShowNumber();
            timer1.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            rdoPlusNum2.Enabled = rdoPlusNum3.Enabled = rdoMultipleNum2.Enabled = rdoBangCuuChuong.Enabled = false;
            rdoPlusMinusNum2.Enabled = rdoPlusMinusNum3.Enabled = rdoDivideNum2.Enabled = false;
        }

        private void ShowNumber()
        {
            _num1 = _rnd.Next((int)minNum1.Value, (int)(maxNum1.Value + 1));
            _num2 = _rnd.Next((int)minNum2.Value, (int)(maxNum2.Value + 1));
            _num3 = _rnd.Next((int)minNum3.Value, (int)(maxNum3.Value + 1));
            lblNum14.Visible = false;
            lblNum13.Visible = rdoPlusNum3.Checked || rdoPlusMinusNum3.Checked;
            lblOp13.Visible = rdoPlusNum3.Checked || rdoPlusMinusNum3.Checked;
            lblOp12.Text = rdoPlusNum3.Checked ? "+" : "=";
            lblOp11.Text = rdoMultipleNum2.Checked || rdoBangCuuChuong.Checked ? "x" : "+";
            
            lblNum11.Text = _num1.ToString();
            lblNum12.Text = _num2.ToString();
            lblNum13.Text = _num3.ToString();

            if (rdoPlusNum2.Checked)
            {
                lblNum13.Tag = (_num1 + _num2).ToString();
            }
            else if(rdoPlusNum3.Checked)
            {
                lblNum14.Tag = (_num1 + _num2 + _num3).ToString();
            }
            else if (rdoMultipleNum2.Checked || rdoBangCuuChuong.Checked)
            {
                lblNum13.Tag = (_num1 * _num2).ToString();
            }
            else if(rdoPlusMinusNum2.Checked)
            {
                bool isOp1Plus = _rnd.Next(1, 3) == 1;
                lblOp11.Text = isOp1Plus ? "+" : "-";
                if(isOp1Plus)
                    lblNum13.Tag = (_num1 + _num2).ToString();
                else
                    lblNum13.Tag = (_num1 - _num2).ToString();
            }
            else if(rdoPlusMinusNum3.Checked)
            {
                bool isOp1Plus = _rnd.Next(1, 3) == 1;
                bool isOp2Plus = _rnd.Next(1, 3) == 1;
                lblOp11.Text = isOp1Plus ? "+" : "-";
                lblOp12.Text = isOp2Plus ? "+" : "-";
                if (isOp1Plus && isOp2Plus)
                    lblNum14.Tag = (_num1 + _num2 + _num3).ToString();
                else if (isOp1Plus && !isOp2Plus)
                    lblNum14.Tag = (_num1 + _num2 - _num3).ToString();
                else if (!isOp1Plus && isOp2Plus)
                    lblNum14.Tag = (_num1 - _num2 + _num3).ToString();
                else if (!isOp1Plus && !isOp2Plus)
                    lblNum14.Tag = (_num1 - _num2 - _num3).ToString();

            }
            else if(rdoDivideNum2.Checked)
            {
                while (!(_num1 > _num2 && _num1 % _num2 == 0))
                {
                    _num1 = _rnd.Next((int)minNum1.Value, (int)(maxNum1.Value + 1));
                    _num2 = _rnd.Next((int)minNum2.Value, (int)(maxNum2.Value + 1));
                }
                lblNum11.Text = _num1.ToString();
                lblNum12.Text = _num2.ToString();
                lblOp11.Text = ":";
                lblNum13.Tag = (_num1 / _num2).ToString();
            }

            pnl1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (rdoPlusNum2.Checked || rdoMultipleNum2.Checked || rdoBangCuuChuong.Checked
                || rdoPlusMinusNum2.Checked
                || rdoDivideNum2.Checked)
            {
                lblNum13.Visible = true;
                lblNum13.Text = lblNum13.Tag.ToString();
            }
            else
            {
                lblOp13.Visible = true;
                lblNum14.Visible = true;
                lblNum14.Text = lblNum14.Tag?.ToString();
            }
            timer2.Interval = (int)numTimeStartNewOps.Value * 1000;
            
            timer2.Start();
        }
    }
}
