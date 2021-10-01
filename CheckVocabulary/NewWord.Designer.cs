
namespace CheckVocabulary
{
    partial class NewWord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWord));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxCheck = new System.Windows.Forms.GroupBox();
            this.txtWordCheck = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.numericUpDownAnna = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLucy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRichard = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJohn = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.btnGenVietnamese = new System.Windows.Forms.Button();
            this.btnGenEnglish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewWord = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.chbxEnableShow = new System.Windows.Forms.CheckBox();
            this.btnChangeFile = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnClearScore = new System.Windows.Forms.Button();
            this.btnClearListIndex = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimerCountdown = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileNewWord = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbPhoetic = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxCheck.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLucy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRichard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJohn)).BeginInit();
            this.groupBoxQuestion.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageSetting);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(80, 40);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(905, 470);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMain.Controls.Add(this.groupBoxCheck);
            this.tabPageMain.Controls.Add(this.groupBoxScore);
            this.tabPageMain.Controls.Add(this.groupBoxQuestion);
            this.tabPageMain.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPageMain.Location = new System.Drawing.Point(4, 44);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(897, 422);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            // 
            // groupBoxCheck
            // 
            this.groupBoxCheck.Controls.Add(this.lbAnswer);
            this.groupBoxCheck.Controls.Add(this.txtWordCheck);
            this.groupBoxCheck.Controls.Add(this.lbPhoetic);
            this.groupBoxCheck.Controls.Add(this.label6);
            this.groupBoxCheck.Controls.Add(this.label5);
            this.groupBoxCheck.Controls.Add(this.btnSubmit);
            this.groupBoxCheck.Location = new System.Drawing.Point(451, 6);
            this.groupBoxCheck.Name = "groupBoxCheck";
            this.groupBoxCheck.Size = new System.Drawing.Size(436, 172);
            this.groupBoxCheck.TabIndex = 3;
            this.groupBoxCheck.TabStop = false;
            this.groupBoxCheck.Text = "Check";
            // 
            // txtWordCheck
            // 
            this.txtWordCheck.Depth = 0;
            this.txtWordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordCheck.Hint = "new word";
            this.txtWordCheck.Location = new System.Drawing.Point(125, 36);
            this.txtWordCheck.MaxLength = 32767;
            this.txtWordCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtWordCheck.Name = "txtWordCheck";
            this.txtWordCheck.PasswordChar = '\0';
            this.txtWordCheck.SelectedText = "";
            this.txtWordCheck.SelectionLength = 0;
            this.txtWordCheck.SelectionStart = 0;
            this.txtWordCheck.Size = new System.Drawing.Size(185, 23);
            this.txtWordCheck.TabIndex = 0;
            this.txtWordCheck.TabStop = false;
            this.txtWordCheck.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "New word";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Image = global::CheckVocabulary.Properties.Resources.submit_64;
            this.btnSubmit.Location = new System.Drawing.Point(339, 18);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 58);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Button_Main_Click);
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.numericUpDownAnna);
            this.groupBoxScore.Controls.Add(this.numericUpDownLucy);
            this.groupBoxScore.Controls.Add(this.numericUpDownRichard);
            this.groupBoxScore.Controls.Add(this.numericUpDownJohn);
            this.groupBoxScore.Controls.Add(this.button6);
            this.groupBoxScore.Controls.Add(this.button5);
            this.groupBoxScore.Controls.Add(this.button4);
            this.groupBoxScore.Controls.Add(this.button1);
            this.groupBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxScore.Location = new System.Drawing.Point(451, 178);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(437, 240);
            this.groupBoxScore.TabIndex = 1;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "Score";
            // 
            // numericUpDownAnna
            // 
            this.numericUpDownAnna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAnna.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numericUpDownAnna.Location = new System.Drawing.Point(258, 196);
            this.numericUpDownAnna.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAnna.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownAnna.Name = "numericUpDownAnna";
            this.numericUpDownAnna.Size = new System.Drawing.Size(63, 30);
            this.numericUpDownAnna.TabIndex = 5;
            this.numericUpDownAnna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownLucy
            // 
            this.numericUpDownLucy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLucy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numericUpDownLucy.Location = new System.Drawing.Point(258, 140);
            this.numericUpDownLucy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLucy.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownLucy.Name = "numericUpDownLucy";
            this.numericUpDownLucy.Size = new System.Drawing.Size(63, 30);
            this.numericUpDownLucy.TabIndex = 5;
            this.numericUpDownLucy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownRichard
            // 
            this.numericUpDownRichard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRichard.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numericUpDownRichard.Location = new System.Drawing.Point(258, 84);
            this.numericUpDownRichard.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRichard.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownRichard.Name = "numericUpDownRichard";
            this.numericUpDownRichard.Size = new System.Drawing.Size(63, 30);
            this.numericUpDownRichard.TabIndex = 5;
            this.numericUpDownRichard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownJohn
            // 
            this.numericUpDownJohn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownJohn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numericUpDownJohn.Location = new System.Drawing.Point(258, 28);
            this.numericUpDownJohn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownJohn.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownJohn.Name = "numericUpDownJohn";
            this.numericUpDownJohn.Size = new System.Drawing.Size(63, 30);
            this.numericUpDownJohn.TabIndex = 5;
            this.numericUpDownJohn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(102, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 42);
            this.button6.TabIndex = 3;
            this.button6.Text = "Hương";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(102, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 42);
            this.button5.TabIndex = 3;
            this.button5.Text = "Thùy";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(102, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Quang";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(102, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tuấn";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.btnCountDown);
            this.groupBoxQuestion.Controls.Add(this.btnCheckAnswer);
            this.groupBoxQuestion.Controls.Add(this.btnGenVietnamese);
            this.groupBoxQuestion.Controls.Add(this.btnGenEnglish);
            this.groupBoxQuestion.Controls.Add(this.label1);
            this.groupBoxQuestion.Controls.Add(this.txtNewWord);
            this.groupBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuestion.Location = new System.Drawing.Point(8, 6);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(437, 412);
            this.groupBoxQuestion.TabIndex = 2;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Question";
            // 
            // btnCountDown
            // 
            this.btnCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountDown.Location = new System.Drawing.Point(52, 257);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(131, 116);
            this.btnCountDown.TabIndex = 4;
            this.btnCountDown.Text = "Timer";
            this.btnCountDown.UseVisualStyleBackColor = true;
            this.btnCountDown.Click += new System.EventHandler(this.Button_Main_Click);
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAnswer.FlatAppearance.BorderSize = 0;
            this.btnCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.Image = global::CheckVocabulary.Properties.Resources.questionnaire;
            this.btnCheckAnswer.Location = new System.Drawing.Point(250, 294);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(145, 42);
            this.btnCheckAnswer.TabIndex = 3;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.Button_Main_Click);
            // 
            // btnGenVietnamese
            // 
            this.btnGenVietnamese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenVietnamese.FlatAppearance.BorderSize = 0;
            this.btnGenVietnamese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenVietnamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenVietnamese.Image = global::CheckVocabulary.Properties.Resources.vietnam;
            this.btnGenVietnamese.Location = new System.Drawing.Point(250, 172);
            this.btnGenVietnamese.Name = "btnGenVietnamese";
            this.btnGenVietnamese.Size = new System.Drawing.Size(145, 42);
            this.btnGenVietnamese.TabIndex = 3;
            this.btnGenVietnamese.Text = "  Gen VNese";
            this.btnGenVietnamese.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenVietnamese.UseVisualStyleBackColor = true;
            this.btnGenVietnamese.Click += new System.EventHandler(this.Button_Main_Click);
            // 
            // btnGenEnglish
            // 
            this.btnGenEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenEnglish.FlatAppearance.BorderSize = 0;
            this.btnGenEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenEnglish.Image = global::CheckVocabulary.Properties.Resources.united_kingdom;
            this.btnGenEnglish.Location = new System.Drawing.Point(52, 172);
            this.btnGenEnglish.Name = "btnGenEnglish";
            this.btnGenEnglish.Size = new System.Drawing.Size(145, 42);
            this.btnGenEnglish.TabIndex = 3;
            this.btnGenEnglish.Text = "  Gen English";
            this.btnGenEnglish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenEnglish.UseVisualStyleBackColor = true;
            this.btnGenEnglish.Click += new System.EventHandler(this.Button_Main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "New word";
            // 
            // txtNewWord
            // 
            this.txtNewWord.Depth = 0;
            this.txtNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewWord.Hint = "new word";
            this.txtNewWord.Location = new System.Drawing.Point(125, 76);
            this.txtNewWord.MaxLength = 32767;
            this.txtNewWord.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.PasswordChar = '\0';
            this.txtNewWord.SelectedText = "";
            this.txtNewWord.SelectionLength = 0;
            this.txtNewWord.SelectionStart = 0;
            this.txtNewWord.Size = new System.Drawing.Size(270, 23);
            this.txtNewWord.TabIndex = 0;
            this.txtNewWord.TabStop = false;
            this.txtNewWord.UseSystemPasswordChar = false;
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSetting.Controls.Add(this.chbxEnableShow);
            this.tabPageSetting.Controls.Add(this.btnChangeFile);
            this.tabPageSetting.Controls.Add(this.btnLoadConfig);
            this.tabPageSetting.Controls.Add(this.btnClearScore);
            this.tabPageSetting.Controls.Add(this.btnClearListIndex);
            this.tabPageSetting.Controls.Add(this.btnSaveConfig);
            this.tabPageSetting.Controls.Add(this.label4);
            this.tabPageSetting.Controls.Add(this.label3);
            this.tabPageSetting.Controls.Add(this.txtTimerCountdown);
            this.tabPageSetting.Controls.Add(this.label2);
            this.tabPageSetting.Controls.Add(this.txtFileNewWord);
            this.tabPageSetting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPageSetting.Location = new System.Drawing.Point(4, 44);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(897, 422);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "Setting";
            // 
            // chbxEnableShow
            // 
            this.chbxEnableShow.AutoSize = true;
            this.chbxEnableShow.Location = new System.Drawing.Point(157, 109);
            this.chbxEnableShow.Name = "chbxEnableShow";
            this.chbxEnableShow.Size = new System.Drawing.Size(59, 17);
            this.chbxEnableShow.TabIndex = 94;
            this.chbxEnableShow.Text = "Enable";
            this.chbxEnableShow.UseVisualStyleBackColor = true;
            // 
            // btnChangeFile
            // 
            this.btnChangeFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnChangeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChangeFile.Image = global::CheckVocabulary.Properties.Resources.folder;
            this.btnChangeFile.Location = new System.Drawing.Point(373, 24);
            this.btnChangeFile.Name = "btnChangeFile";
            this.btnChangeFile.Size = new System.Drawing.Size(29, 23);
            this.btnChangeFile.TabIndex = 93;
            this.btnChangeFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeFile.UseVisualStyleBackColor = true;
            this.btnChangeFile.Click += new System.EventHandler(this.Button_Setting_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadConfig.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLoadConfig.FlatAppearance.BorderSize = 0;
            this.btnLoadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadConfig.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadConfig.Image = global::CheckVocabulary.Properties.Resources.update;
            this.btnLoadConfig.Location = new System.Drawing.Point(105, 135);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(92, 35);
            this.btnLoadConfig.TabIndex = 6;
            this.btnLoadConfig.Text = " Load";
            this.btnLoadConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.Button_Setting_Click);
            // 
            // btnClearScore
            // 
            this.btnClearScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearScore.FlatAppearance.BorderSize = 0;
            this.btnClearScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClearScore.Image = global::CheckVocabulary.Properties.Resources.err;
            this.btnClearScore.Location = new System.Drawing.Point(47, 292);
            this.btnClearScore.Name = "btnClearScore";
            this.btnClearScore.Size = new System.Drawing.Size(131, 35);
            this.btnClearScore.TabIndex = 7;
            this.btnClearScore.Text = " Clear Score";
            this.btnClearScore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearScore.UseVisualStyleBackColor = true;
            this.btnClearScore.Click += new System.EventHandler(this.Button_Setting_Click);
            // 
            // btnClearListIndex
            // 
            this.btnClearListIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearListIndex.FlatAppearance.BorderSize = 0;
            this.btnClearListIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearListIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearListIndex.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClearListIndex.Image = global::CheckVocabulary.Properties.Resources.err;
            this.btnClearListIndex.Location = new System.Drawing.Point(47, 251);
            this.btnClearListIndex.Name = "btnClearListIndex";
            this.btnClearListIndex.Size = new System.Drawing.Size(131, 35);
            this.btnClearListIndex.TabIndex = 7;
            this.btnClearListIndex.Text = " Clear List";
            this.btnClearListIndex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearListIndex.UseVisualStyleBackColor = true;
            this.btnClearListIndex.Click += new System.EventHandler(this.Button_Setting_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfig.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveConfig.Image = global::CheckVocabulary.Properties.Resources.save;
            this.btnSaveConfig.Location = new System.Drawing.Point(210, 135);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(92, 35);
            this.btnSaveConfig.TabIndex = 7;
            this.btnSaveConfig.Text = " Save";
            this.btnSaveConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.Button_Setting_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Show Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Timer";
            // 
            // txtTimerCountdown
            // 
            this.txtTimerCountdown.Depth = 0;
            this.txtTimerCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimerCountdown.Hint = "Timer countdown";
            this.txtTimerCountdown.Location = new System.Drawing.Point(82, 65);
            this.txtTimerCountdown.MaxLength = 32767;
            this.txtTimerCountdown.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTimerCountdown.Name = "txtTimerCountdown";
            this.txtTimerCountdown.PasswordChar = '\0';
            this.txtTimerCountdown.SelectedText = "";
            this.txtTimerCountdown.SelectionLength = 0;
            this.txtTimerCountdown.SelectionStart = 0;
            this.txtTimerCountdown.Size = new System.Drawing.Size(270, 23);
            this.txtTimerCountdown.TabIndex = 4;
            this.txtTimerCountdown.TabStop = false;
            this.txtTimerCountdown.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "File";
            // 
            // txtFileNewWord
            // 
            this.txtFileNewWord.Depth = 0;
            this.txtFileNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNewWord.Hint = "file new word";
            this.txtFileNewWord.Location = new System.Drawing.Point(82, 23);
            this.txtFileNewWord.MaxLength = 32767;
            this.txtFileNewWord.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFileNewWord.Name = "txtFileNewWord";
            this.txtFileNewWord.PasswordChar = '\0';
            this.txtFileNewWord.SelectedText = "";
            this.txtFileNewWord.SelectionLength = 0;
            this.txtFileNewWord.SelectionStart = 0;
            this.txtFileNewWord.Size = new System.Drawing.Size(270, 23);
            this.txtFileNewWord.TabIndex = 2;
            this.txtFileNewWord.TabStop = false;
            this.txtFileNewWord.UseSystemPasswordChar = false;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Answer";
            // 
            // lbPhoetic
            // 
            this.lbPhoetic.AutoSize = true;
            this.lbPhoetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoetic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbPhoetic.Location = new System.Drawing.Point(125, 92);
            this.lbPhoetic.Name = "lbPhoetic";
            this.lbPhoetic.Size = new System.Drawing.Size(24, 20);
            this.lbPhoetic.TabIndex = 1;
            this.lbPhoetic.Text = "...";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbAnswer.Location = new System.Drawing.Point(125, 127);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(24, 20);
            this.lbAnswer.TabIndex = 4;
            this.lbAnswer.Text = "...";
            // 
            // NewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 470);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Vocabulary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewWord_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxCheck.ResumeLayout(false);
            this.groupBoxCheck.PerformLayout();
            this.groupBoxScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLucy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRichard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJohn)).EndInit();
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            this.tabPageSetting.ResumeLayout(false);
            this.tabPageSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Button btnGenVietnamese;
        private System.Windows.Forms.Button btnGenEnglish;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewWord;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownJohn;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.NumericUpDown numericUpDownAnna;
        private System.Windows.Forms.NumericUpDown numericUpDownLucy;
        private System.Windows.Forms.NumericUpDown numericUpDownRichard;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.Button btnChangeFile;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTimerCountdown;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFileNewWord;
        private System.Windows.Forms.Button btnClearListIndex;
        private System.Windows.Forms.Button btnClearScore;
        private System.Windows.Forms.CheckBox chbxEnableShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxCheck;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtWordCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPhoetic;
        private System.Windows.Forms.Label lbAnswer;
    }
}

