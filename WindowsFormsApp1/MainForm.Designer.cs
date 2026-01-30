namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxMember1 = new System.Windows.Forms.TextBox();
            this.TextBoxMember2 = new System.Windows.Forms.TextBox();
            this.TextBoxMember3 = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이프로그램에대하여OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저작권정보CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPlayer1Death = new System.Windows.Forms.Label();
            this.LabelPlayer2Death = new System.Windows.Forms.Label();
            this.LabelPlayer3Death = new System.Windows.Forms.Label();
            this.ButtonPlayer1Death = new System.Windows.Forms.Button();
            this.ButtonPlayer2Death = new System.Windows.Forms.Button();
            this.ButtonPlayer3Death = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelVersionText = new System.Windows.Forms.Label();
            this.ButtonLockPlayerName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonResetWorld = new System.Windows.Forms.Button();
            this.ButtonDeathLimitDec = new System.Windows.Forms.Button();
            this.ButtonGG = new System.Windows.Forms.Button();
            this.ButtonIntoEnd = new System.Windows.Forms.Button();
            this.ButtonIntoFire = new System.Windows.Forms.Button();
            this.ButtonIntoNeather = new System.Windows.Forms.Button();
            this.ButtonDeathLimitInc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelDeathCountToReset = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelTotalDeath = new System.Windows.Forms.Label();
            this.LabelWorldCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ProgressBarCurrentDeath = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.ProgressBarCurProgress = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ButtonMissclick1P = new System.Windows.Forms.Button();
            this.ButtonMissclick2P = new System.Windows.Forms.Button();
            this.ButtonMissclick3P = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxMember1
            // 
            this.TextBoxMember1.Location = new System.Drawing.Point(42, 346);
            this.TextBoxMember1.Name = "TextBoxMember1";
            this.TextBoxMember1.Size = new System.Drawing.Size(100, 21);
            this.TextBoxMember1.TabIndex = 0;
            // 
            // TextBoxMember2
            // 
            this.TextBoxMember2.Location = new System.Drawing.Point(239, 346);
            this.TextBoxMember2.Name = "TextBoxMember2";
            this.TextBoxMember2.Size = new System.Drawing.Size(100, 21);
            this.TextBoxMember2.TabIndex = 1;
            // 
            // TextBoxMember3
            // 
            this.TextBoxMember3.Location = new System.Drawing.Point(431, 346);
            this.TextBoxMember3.Name = "TextBoxMember3";
            this.TextBoxMember3.Size = new System.Drawing.Size(100, 21);
            this.TextBoxMember3.TabIndex = 2;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장SToolStripMenuItem,
            this.불러오기LToolStripMenuItem,
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.파일FToolStripMenuItem.Text = "파일 (&F)";
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.저장SToolStripMenuItem.Text = "저장 (&S)...";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 불러오기LToolStripMenuItem
            // 
            this.불러오기LToolStripMenuItem.Name = "불러오기LToolStripMenuItem";
            this.불러오기LToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.불러오기LToolStripMenuItem.Text = "불러오기 (&L)...";
            this.불러오기LToolStripMenuItem.Click += new System.EventHandler(this.불러오기LToolStripMenuItem_Click);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.종료XToolStripMenuItem.Text = "종료 (&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이프로그램에대하여OToolStripMenuItem,
            this.저작권정보CToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.도움말HToolStripMenuItem.Text = "도움말 (&H)";
            // 
            // 이프로그램에대하여OToolStripMenuItem
            // 
            this.이프로그램에대하여OToolStripMenuItem.Name = "이프로그램에대하여OToolStripMenuItem";
            this.이프로그램에대하여OToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.이프로그램에대하여OToolStripMenuItem.Text = "이 프로그램에 대하여 (&O)";
            this.이프로그램에대하여OToolStripMenuItem.Click += new System.EventHandler(this.이프로그램에대하여OToolStripMenuItem_Click);
            // 
            // 저작권정보CToolStripMenuItem
            // 
            this.저작권정보CToolStripMenuItem.Name = "저작권정보CToolStripMenuItem";
            this.저작권정보CToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.저작권정보CToolStripMenuItem.Text = "저작권 정보 (&C)";
            this.저작권정보CToolStripMenuItem.Click += new System.EventHandler(this.저작권정보CToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "사망:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "사망:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "사망:";
            // 
            // LabelPlayer1Death
            // 
            this.LabelPlayer1Death.AutoSize = true;
            this.LabelPlayer1Death.Location = new System.Drawing.Point(79, 317);
            this.LabelPlayer1Death.Name = "LabelPlayer1Death";
            this.LabelPlayer1Death.Size = new System.Drawing.Size(11, 12);
            this.LabelPlayer1Death.TabIndex = 5;
            this.LabelPlayer1Death.Text = "0";
            // 
            // LabelPlayer2Death
            // 
            this.LabelPlayer2Death.AutoSize = true;
            this.LabelPlayer2Death.Location = new System.Drawing.Point(276, 317);
            this.LabelPlayer2Death.Name = "LabelPlayer2Death";
            this.LabelPlayer2Death.Size = new System.Drawing.Size(11, 12);
            this.LabelPlayer2Death.TabIndex = 5;
            this.LabelPlayer2Death.Text = "0";
            // 
            // LabelPlayer3Death
            // 
            this.LabelPlayer3Death.AutoSize = true;
            this.LabelPlayer3Death.Location = new System.Drawing.Point(468, 317);
            this.LabelPlayer3Death.Name = "LabelPlayer3Death";
            this.LabelPlayer3Death.Size = new System.Drawing.Size(11, 12);
            this.LabelPlayer3Death.TabIndex = 5;
            this.LabelPlayer3Death.Text = "0";
            // 
            // ButtonPlayer1Death
            // 
            this.ButtonPlayer1Death.Location = new System.Drawing.Point(42, 373);
            this.ButtonPlayer1Death.Name = "ButtonPlayer1Death";
            this.ButtonPlayer1Death.Size = new System.Drawing.Size(100, 23);
            this.ButtonPlayer1Death.TabIndex = 6;
            this.ButtonPlayer1Death.Text = "사망하다 &1P";
            this.ButtonPlayer1Death.UseVisualStyleBackColor = true;
            this.ButtonPlayer1Death.Click += new System.EventHandler(this.ButtonPlayer1Death_Click);
            // 
            // ButtonPlayer2Death
            // 
            this.ButtonPlayer2Death.Location = new System.Drawing.Point(239, 373);
            this.ButtonPlayer2Death.Name = "ButtonPlayer2Death";
            this.ButtonPlayer2Death.Size = new System.Drawing.Size(100, 23);
            this.ButtonPlayer2Death.TabIndex = 6;
            this.ButtonPlayer2Death.Text = "사망하다 &2P";
            this.ButtonPlayer2Death.UseVisualStyleBackColor = true;
            this.ButtonPlayer2Death.Click += new System.EventHandler(this.ButtonPlayer2Death_Click);
            // 
            // ButtonPlayer3Death
            // 
            this.ButtonPlayer3Death.Location = new System.Drawing.Point(431, 373);
            this.ButtonPlayer3Death.Name = "ButtonPlayer3Death";
            this.ButtonPlayer3Death.Size = new System.Drawing.Size(100, 23);
            this.ButtonPlayer3Death.TabIndex = 6;
            this.ButtonPlayer3Death.Text = "사망하다 &3P";
            this.ButtonPlayer3Death.UseVisualStyleBackColor = true;
            this.ButtonPlayer3Death.Click += new System.EventHandler(this.ButtonPlayer3Death_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(40, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Minecraft";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(212, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "하드코어 런";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(407, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 45);
            this.label6.TabIndex = 7;
            this.label6.Text = "3 원정대";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(40, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 45);
            this.label7.TabIndex = 7;
            this.label7.Text = "범인";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(122, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 45);
            this.label8.TabIndex = 7;
            this.label8.Text = "추적기";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(244, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "version";
            // 
            // LabelVersionText
            // 
            this.LabelVersionText.AutoSize = true;
            this.LabelVersionText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersionText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelVersionText.Location = new System.Drawing.Point(341, 94);
            this.LabelVersionText.Name = "LabelVersionText";
            this.LabelVersionText.Size = new System.Drawing.Size(134, 32);
            this.LabelVersionText.TabIndex = 7;
            this.LabelVersionText.Text = "versionText";
            // 
            // ButtonLockPlayerName
            // 
            this.ButtonLockPlayerName.Location = new System.Drawing.Point(8, 295);
            this.ButtonLockPlayerName.Name = "ButtonLockPlayerName";
            this.ButtonLockPlayerName.Size = new System.Drawing.Size(186, 23);
            this.ButtonLockPlayerName.TabIndex = 8;
            this.ButtonLockPlayerName.Text = "이름 따로 저장 (&A)";
            this.ButtonLockPlayerName.UseVisualStyleBackColor = true;
            this.ButtonLockPlayerName.Click += new System.EventHandler(this.ButtonLockPlayerName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonResetWorld);
            this.groupBox1.Controls.Add(this.ButtonDeathLimitDec);
            this.groupBox1.Controls.Add(this.ButtonGG);
            this.groupBox1.Controls.Add(this.ButtonIntoEnd);
            this.groupBox1.Controls.Add(this.ButtonIntoFire);
            this.groupBox1.Controls.Add(this.ButtonIntoNeather);
            this.groupBox1.Controls.Add(this.ButtonDeathLimitInc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LabelDeathCountToReset);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ButtonLockPlayerName);
            this.groupBox1.Location = new System.Drawing.Point(588, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 376);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "전체 컨트롤";
            // 
            // ButtonResetWorld
            // 
            this.ButtonResetWorld.Enabled = false;
            this.ButtonResetWorld.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonResetWorld.Location = new System.Drawing.Point(55, 93);
            this.ButtonResetWorld.Name = "ButtonResetWorld";
            this.ButtonResetWorld.Size = new System.Drawing.Size(99, 44);
            this.ButtonResetWorld.TabIndex = 10;
            this.ButtonResetWorld.Text = "&Re?";
            this.ButtonResetWorld.UseVisualStyleBackColor = true;
            this.ButtonResetWorld.Click += new System.EventHandler(this.ButtonResetWorld_Click);
            // 
            // ButtonDeathLimitDec
            // 
            this.ButtonDeathLimitDec.Location = new System.Drawing.Point(119, 54);
            this.ButtonDeathLimitDec.Name = "ButtonDeathLimitDec";
            this.ButtonDeathLimitDec.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeathLimitDec.TabIndex = 10;
            this.ButtonDeathLimitDec.Text = "감소 (&D)";
            this.ButtonDeathLimitDec.UseVisualStyleBackColor = true;
            this.ButtonDeathLimitDec.Click += new System.EventHandler(this.ButtonDeathLimitDec_Click);
            // 
            // ButtonGG
            // 
            this.ButtonGG.Location = new System.Drawing.Point(6, 246);
            this.ButtonGG.Name = "ButtonGG";
            this.ButtonGG.Size = new System.Drawing.Size(188, 23);
            this.ButtonGG.TabIndex = 10;
            this.ButtonGG.Text = "수고하셨습니다! (&G)";
            this.ButtonGG.UseVisualStyleBackColor = true;
            this.ButtonGG.Click += new System.EventHandler(this.ButtonGG_Click);
            // 
            // ButtonIntoEnd
            // 
            this.ButtonIntoEnd.Location = new System.Drawing.Point(6, 217);
            this.ButtonIntoEnd.Name = "ButtonIntoEnd";
            this.ButtonIntoEnd.Size = new System.Drawing.Size(188, 23);
            this.ButtonIntoEnd.TabIndex = 10;
            this.ButtonIntoEnd.Text = "진행: 끝이야? (&E)";
            this.ButtonIntoEnd.UseVisualStyleBackColor = true;
            this.ButtonIntoEnd.Click += new System.EventHandler(this.ButtonIntoEnd_Click);
            // 
            // ButtonIntoFire
            // 
            this.ButtonIntoFire.Location = new System.Drawing.Point(6, 188);
            this.ButtonIntoFire.Name = "ButtonIntoFire";
            this.ButtonIntoFire.Size = new System.Drawing.Size(188, 23);
            this.ButtonIntoFire.TabIndex = 10;
            this.ButtonIntoFire.Text = "진행: 포화 속으로 (&T)";
            this.ButtonIntoFire.UseVisualStyleBackColor = true;
            this.ButtonIntoFire.Click += new System.EventHandler(this.ButtonIntoFire_Click);
            // 
            // ButtonIntoNeather
            // 
            this.ButtonIntoNeather.Location = new System.Drawing.Point(6, 159);
            this.ButtonIntoNeather.Name = "ButtonIntoNeather";
            this.ButtonIntoNeather.Size = new System.Drawing.Size(188, 23);
            this.ButtonIntoNeather.TabIndex = 10;
            this.ButtonIntoNeather.Text = "진행: 네더(지옥) 진입 (&N)";
            this.ButtonIntoNeather.UseVisualStyleBackColor = true;
            this.ButtonIntoNeather.Click += new System.EventHandler(this.ButtonIntoNeather_Click);
            // 
            // ButtonDeathLimitInc
            // 
            this.ButtonDeathLimitInc.Location = new System.Drawing.Point(6, 54);
            this.ButtonDeathLimitInc.Name = "ButtonDeathLimitInc";
            this.ButtonDeathLimitInc.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeathLimitInc.TabIndex = 10;
            this.ButtonDeathLimitInc.Text = "증가 (&I)";
            this.ButtonDeathLimitInc.UseVisualStyleBackColor = true;
            this.ButtonDeathLimitInc.Click += new System.EventHandler(this.ButtonDeathLimitInc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "회 사망";
            // 
            // LabelDeathCountToReset
            // 
            this.LabelDeathCountToReset.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelDeathCountToReset.Location = new System.Drawing.Point(6, 35);
            this.LabelDeathCountToReset.Name = "LabelDeathCountToReset";
            this.LabelDeathCountToReset.Size = new System.Drawing.Size(140, 12);
            this.LabelDeathCountToReset.TabIndex = 9;
            this.LabelDeathCountToReset.Text = "3";
            this.LabelDeathCountToReset.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "리셋 조건: 매 지구당";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(40, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 45);
            this.label12.TabIndex = 7;
            this.label12.Text = "총 사망 횟수:";
            // 
            // LabelTotalDeath
            // 
            this.LabelTotalDeath.AutoSize = true;
            this.LabelTotalDeath.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalDeath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTotalDeath.Location = new System.Drawing.Point(253, 189);
            this.LabelTotalDeath.Name = "LabelTotalDeath";
            this.LabelTotalDeath.Size = new System.Drawing.Size(38, 45);
            this.LabelTotalDeath.TabIndex = 7;
            this.LabelTotalDeath.Text = "0";
            // 
            // LabelWorldCount
            // 
            this.LabelWorldCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelWorldCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWorldCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelWorldCount.Location = new System.Drawing.Point(52, 234);
            this.LabelWorldCount.Name = "LabelWorldCount";
            this.LabelWorldCount.Size = new System.Drawing.Size(325, 45);
            this.LabelWorldCount.TabIndex = 7;
            this.LabelWorldCount.Text = "0";
            this.LabelWorldCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(374, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 45);
            this.label13.TabIndex = 7;
            this.label13.Text = "번째 지구";
            // 
            // ProgressBarCurrentDeath
            // 
            this.ProgressBarCurrentDeath.Location = new System.Drawing.Point(371, 144);
            this.ProgressBarCurrentDeath.Maximum = 3;
            this.ProgressBarCurrentDeath.Name = "ProgressBarCurrentDeath";
            this.ProgressBarCurrentDeath.Size = new System.Drawing.Size(169, 17);
            this.ProgressBarCurrentDeath.Step = 1;
            this.ProgressBarCurrentDeath.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(40, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 45);
            this.label14.TabIndex = 7;
            this.label14.Text = "이번 지구 진행도";
            // 
            // ProgressBarCurProgress
            // 
            this.ProgressBarCurProgress.Location = new System.Drawing.Point(371, 167);
            this.ProgressBarCurProgress.Maximum = 4;
            this.ProgressBarCurProgress.Name = "ProgressBarCurProgress";
            this.ProgressBarCurProgress.Size = new System.Drawing.Size(169, 19);
            this.ProgressBarCurProgress.Step = 1;
            this.ProgressBarCurProgress.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(326, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "사망";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(310, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "런 진행";
            // 
            // ButtonMissclick1P
            // 
            this.ButtonMissclick1P.Location = new System.Drawing.Point(42, 402);
            this.ButtonMissclick1P.Name = "ButtonMissclick1P";
            this.ButtonMissclick1P.Size = new System.Drawing.Size(100, 23);
            this.ButtonMissclick1P.TabIndex = 6;
            this.ButtonMissclick1P.Text = "그건 틀렸어";
            this.ButtonMissclick1P.UseVisualStyleBackColor = true;
            this.ButtonMissclick1P.Click += new System.EventHandler(this.ButtonMissclick1P_Click);
            // 
            // ButtonMissclick2P
            // 
            this.ButtonMissclick2P.Location = new System.Drawing.Point(239, 402);
            this.ButtonMissclick2P.Name = "ButtonMissclick2P";
            this.ButtonMissclick2P.Size = new System.Drawing.Size(100, 23);
            this.ButtonMissclick2P.TabIndex = 6;
            this.ButtonMissclick2P.Text = "그건 틀렸어";
            this.ButtonMissclick2P.UseVisualStyleBackColor = true;
            this.ButtonMissclick2P.Click += new System.EventHandler(this.ButtonMissclick2P_Click);
            // 
            // ButtonMissclick3P
            // 
            this.ButtonMissclick3P.Location = new System.Drawing.Point(431, 402);
            this.ButtonMissclick3P.Name = "ButtonMissclick3P";
            this.ButtonMissclick3P.Size = new System.Drawing.Size(100, 23);
            this.ButtonMissclick3P.TabIndex = 6;
            this.ButtonMissclick3P.Text = "그건 틀렸어";
            this.ButtonMissclick3P.UseVisualStyleBackColor = true;
            this.ButtonMissclick3P.Click += new System.EventHandler(this.ButtonMissclick3P_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "3wanderers.json";
            this.OpenFile.Filter = "세이브 데이터|*.json";
            this.OpenFile.InitialDirectory = "%UserProfile%\\Documents";
            // 
            // SaveFile
            // 
            this.SaveFile.FileName = "3wanderers.json";
            this.SaveFile.Filter = "세이브 데이터|*.json";
            this.SaveFile.InitialDirectory = "%UserProfile%\\Documents";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgressBarCurProgress);
            this.Controls.Add(this.ProgressBarCurrentDeath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LabelVersionText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LabelWorldCount);
            this.Controls.Add(this.LabelTotalDeath);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonPlayer3Death);
            this.Controls.Add(this.ButtonPlayer2Death);
            this.Controls.Add(this.ButtonMissclick3P);
            this.Controls.Add(this.ButtonMissclick2P);
            this.Controls.Add(this.ButtonMissclick1P);
            this.Controls.Add(this.ButtonPlayer1Death);
            this.Controls.Add(this.LabelPlayer3Death);
            this.Controls.Add(this.LabelPlayer2Death);
            this.Controls.Add(this.LabelPlayer1Death);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxMember3);
            this.Controls.Add(this.TextBoxMember2);
            this.Controls.Add(this.TextBoxMember1);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "하코런 3원정대 범인찾기";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxMember1;
        private System.Windows.Forms.TextBox TextBoxMember2;
        private System.Windows.Forms.TextBox TextBoxMember3;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPlayer1Death;
        private System.Windows.Forms.Label LabelPlayer2Death;
        private System.Windows.Forms.Label LabelPlayer3Death;
        private System.Windows.Forms.Button ButtonPlayer1Death;
        private System.Windows.Forms.Button ButtonPlayer2Death;
        private System.Windows.Forms.Button ButtonPlayer3Death;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelVersionText;
        private System.Windows.Forms.Button ButtonLockPlayerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonDeathLimitDec;
        private System.Windows.Forms.Button ButtonDeathLimitInc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelDeathCountToReset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ButtonResetWorld;
        private System.Windows.Forms.Label LabelTotalDeath;
        private System.Windows.Forms.Label LabelWorldCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar ProgressBarCurrentDeath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar ProgressBarCurProgress;
        private System.Windows.Forms.Button ButtonGG;
        private System.Windows.Forms.Button ButtonIntoEnd;
        private System.Windows.Forms.Button ButtonIntoFire;
        private System.Windows.Forms.Button ButtonIntoNeather;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ButtonMissclick1P;
        private System.Windows.Forms.Button ButtonMissclick2P;
        private System.Windows.Forms.Button ButtonMissclick3P;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이프로그램에대하여OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저작권정보CToolStripMenuItem;
    }
}

