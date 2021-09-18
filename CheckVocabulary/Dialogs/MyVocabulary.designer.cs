
namespace CheckVocabulary.Dialogs
{
    partial class MyVocabulary
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
            this.txtMeaning = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPhonetic = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEnglish = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMeaning
            // 
            this.txtMeaning.Depth = 0;
            this.txtMeaning.Hint = "Meaning in Vietnamese";
            this.txtMeaning.Location = new System.Drawing.Point(116, 149);
            this.txtMeaning.MaxLength = 32767;
            this.txtMeaning.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.PasswordChar = '\0';
            this.txtMeaning.SelectedText = "";
            this.txtMeaning.SelectionLength = 0;
            this.txtMeaning.SelectionStart = 0;
            this.txtMeaning.Size = new System.Drawing.Size(364, 23);
            this.txtMeaning.TabIndex = 2;
            this.txtMeaning.TabStop = false;
            this.txtMeaning.UseSystemPasswordChar = false;
            // 
            // txtPhonetic
            // 
            this.txtPhonetic.Depth = 0;
            this.txtPhonetic.Hint = "how to read it";
            this.txtPhonetic.Location = new System.Drawing.Point(116, 114);
            this.txtPhonetic.MaxLength = 32767;
            this.txtPhonetic.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhonetic.Name = "txtPhonetic";
            this.txtPhonetic.PasswordChar = '\0';
            this.txtPhonetic.SelectedText = "";
            this.txtPhonetic.SelectionLength = 0;
            this.txtPhonetic.SelectionStart = 0;
            this.txtPhonetic.Size = new System.Drawing.Size(364, 23);
            this.txtPhonetic.TabIndex = 1;
            this.txtPhonetic.TabStop = false;
            this.txtPhonetic.UseSystemPasswordChar = false;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Depth = 0;
            this.txtEnglish.Hint = "english word";
            this.txtEnglish.Location = new System.Drawing.Point(116, 79);
            this.txtEnglish.MaxLength = 32767;
            this.txtEnglish.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.PasswordChar = '\0';
            this.txtEnglish.SelectedText = "";
            this.txtEnglish.SelectionLength = 0;
            this.txtEnglish.SelectionStart = 0;
            this.txtEnglish.Size = new System.Drawing.Size(364, 23);
            this.txtEnglish.TabIndex = 0;
            this.txtEnglish.TabStop = false;
            this.txtEnglish.UseSystemPasswordChar = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = global::CheckVocabulary.Properties.Resources.btnOK;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(21, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(459, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(11, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 85;
            this.label9.Text = "Phonetic";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(18, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 84;
            this.label8.Text = "Meaning";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbName.Location = new System.Drawing.Point(26, 81);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 18);
            this.lbName.TabIndex = 78;
            this.lbName.Text = "English";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyVocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(504, 241);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.txtPhonetic);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyVocabulary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vocabulary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMeaning;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhonetic;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEnglish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbName;
    }
}