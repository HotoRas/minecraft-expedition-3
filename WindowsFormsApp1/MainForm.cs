using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private ThreeWanderers data;

        private void UpdateMemberName()
        {
            // update player name
            data.p1 = TextBoxMember1.Text;
            data.p2 = TextBoxMember2.Text;
            data.p3 = TextBoxMember3.Text;
        }
        private void UpdateDeathcounts() {
            UpdateMemberName();

            // update death count
            data.deathcount = data.deathcount_p1 + data.deathcount_p2 + data.deathcount_p3;
            data.world_death = (ushort)(data.deathcount - data.deathcount_reset * (data.world_count - 1));

            // update UI
            LabelPlayer1Death.Text = data.deathcount_p1.ToString();
            LabelPlayer2Death.Text = data.deathcount_p2.ToString();
            LabelPlayer3Death.Text = data.deathcount_p3.ToString();
            LabelTotalDeath.Text = data.deathcount.ToString();
            LabelWorldCount.Text = data.world_count.ToString();
            ProgressBarCurrentDeath.Value = (int)data.world_death;

            // update button enabler
            if (data.world_death >= data.deathcount_reset) { 
                ButtonResetWorld.Enabled = true;
                ButtonPlayer1Death.Enabled = false;
                ButtonPlayer2Death.Enabled = false;
                ButtonPlayer3Death.Enabled = false;
            } else { 
                ButtonResetWorld.Enabled = false;
                ButtonPlayer1Death.Enabled = true;
                ButtonPlayer2Death.Enabled = true;
                ButtonPlayer3Death.Enabled = true;
            }
        }

        private void UpdateProgress()
        {
            // count up progresses
            int _progress = 0;
            for (int i = 0; i < 4; i++)
            {
                if (data.progress[i]) _progress += 1;
            }
            // update UI
            ProgressBarCurProgress.Value = _progress;
        }

        private void ButtonPlayer1Death_Click(object sender, EventArgs e)
        {
            data.deathcount_p1 += 1; UpdateDeathcounts();
        }

        private void ButtonMissclick1P_Click(object sender, EventArgs e)
        {
            if (data.deathcount_p1 < 1) return;
            data.deathcount_p1 -= 1; UpdateDeathcounts();
        }

        private void ButtonPlayer2Death_Click(object sender, EventArgs e)
        {
            data.deathcount_p2 += 1; UpdateDeathcounts();
        }

        private void ButtonMissclick2P_Click(object sender, EventArgs e)
        {
            if (data.deathcount_p2 < 1) return;
            data.deathcount_p2 -= 1; UpdateDeathcounts();
        }

        private void ButtonPlayer3Death_Click(object sender, EventArgs e)
        {
            data.deathcount_p3 += 1; UpdateDeathcounts();
        }

        private void ButtonMissclick3P_Click(object sender, EventArgs e)
        {
            if (data.deathcount_p3 < 1) return;
            data.deathcount_p3 -= 1; UpdateDeathcounts();
        }

        private void ButtonIntoNeather_Click(object sender, EventArgs e)
        {
            data.progress[0] = true; UpdateProgress();
        }

        private void ButtonIntoFire_Click(object sender, EventArgs e)
        {
            data.progress[1] = true; UpdateProgress();
        }

        private void ButtonIntoEnd_Click(object sender, EventArgs e)
        {
            data.progress[2] = true; UpdateProgress();
        }

        private void ButtonGG_Click(object sender, EventArgs e)
        {
            data.progress[0] = data.progress[1] = data.progress[2] = data.progress[3] = true;
            UpdateProgress();
        }

        private void ButtonDeathLimitDec_Click(object sender, EventArgs e)
        {
            // checksum
            if (data.deathcount_reset <= ThreeWanderers.deathcount_reset_bottom)
            {
                ButtonDeathLimitDec.Enabled = false; return;
            }

            // update data
            data.deathcount_reset -= 1;
            ProgressBarCurrentDeath.Maximum = (int)data.deathcount_reset;
            LabelDeathCountToReset.Text = data.deathcount_reset.ToString();

            // update self properties
            if (data.deathcount_reset <= ThreeWanderers.deathcount_reset_bottom) ButtonDeathLimitDec.Enabled = false;
        }

        private void ButtonResetWorld_Click(object sender, EventArgs e)
        {
            // reset seq
            data.world_count += 1;
            for (int i = 0; i < 4; i++) data.progress[i] = false;
            UpdateDeathcounts(); UpdateProgress();
        }

        public MainForm()
        {
            // initialize data
            data = new ThreeWanderers
            {
                deathcount = 0,
                deathcount_reset = 3,
                deathcount_p1 = 0,
                deathcount_p2 = 0,
                deathcount_p3 = 0,
                world_count = 1,
                world_death = 0,
                progress = new bool[] { false, false, false, false, },
                p1 = "",
                p2 = "",
                p3 = ""
            };

            // load component
            InitializeComponent();

            // Initialize Labels
            LabelVersionText.Text
                = Resources.VersionA + "." + Resources.VersionB + "." + Resources.VersionC + Resources.VersionSuffix;
            LabelPlayer1Death.Text = data.deathcount_p1.ToString();
            LabelPlayer2Death.Text = data.deathcount_p2.ToString();
            LabelPlayer3Death.Text = data.deathcount_p3.ToString();
            LabelWorldCount.Text = data.world_count.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeathLimitInc_Click(object sender, EventArgs e)
        {
            data.deathcount_reset += 1;
            ProgressBarCurrentDeath.Maximum = (int)data.deathcount_reset;
            LabelDeathCountToReset.Text = data.deathcount_reset.ToString();
            if (ButtonDeathLimitDec.Enabled == false) ButtonDeathLimitDec.Enabled = true;
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sav = JsonConvert.SerializeObject(data);
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(SaveFile.FileName, sav);
                    MessageBox.Show("저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception exc)
                {
                    MessageBox.Show($"저장에 실패하였습니다.\n{exc.Message}", "저장 실패",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 불러오기LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sav = System.IO.File.ReadAllText(OpenFile.FileName);
                    data = JsonConvert.DeserializeObject<ThreeWanderers>(sav);
                    // load up all
                    ProgressBarCurrentDeath.Maximum = (int)data.deathcount_reset;

                    // update textbox first
                    TextBoxMember1.Text = data.p1;
                    TextBoxMember2.Text = data.p2;
                    TextBoxMember3.Text = data.p3;

                    UpdateDeathcounts(); UpdateProgress();
                    LabelDeathCountToReset.Text = data.deathcount_reset.ToString();

                    MessageBox.Show("로딩 성공", "로딩 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc) {
                    MessageBox.Show($"로딩에 실패하였습니다.\n{exc.Message}", "로딩 실패",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonLockPlayerName_Click(object sender, EventArgs e)
        {
            UpdateMemberName();
        }

        private void 이프로그램에대하여OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void 저작권정보CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyingForm copyright = new CopyingForm();
            copyright.Show();
        }
    }
}


public class ThreeWanderers
{
    public UInt16 deathcount_reset, world_death;
    public UInt32 world_count, deathcount_p1, deathcount_p2, deathcount_p3, deathcount;
    public const UInt16 deathcount_reset_bottom = 3;
    public bool[] progress = { false, false, false, false };

    public string p1, p2, p3;
}
