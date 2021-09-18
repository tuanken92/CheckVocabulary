using CheckVocabulary.Dialogs;
using CheckVocabulary.Sources;
using ClosedXML.Excel;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckVocabulary
{
    public partial class NewWord : Form
    {
        #region Variables

        string new_word_file = MyParam.parameter.file_new_word;
        static Random random = new Random();
        static Vocabulary current_vocabulary = null;
        
        #endregion


        #region MainProgram

        public NewWord()
        {
            InitializeComponent();
            InitVariables();
            InitGui();
        }

        void InitVariables()
        {
            MyParam.parameter = SaveLoadParameter.Load_Parameter(MyParam.parameter) as MyParameter;
            MyParam.parameter.PrintInfor();
            
            
            new_word_file = MyParam.parameter.file_new_word;


            //load data
            LoadNewWord();

            random = new Random();
            
        }

        void InitGui()
        {
            //score
            numericUpDownJohn.Value = MyParam.parameter.list_player[(int)ePlayer.Player_John].score;
            numericUpDownRichard.Value = MyParam.parameter.list_player[(int)ePlayer.Player_Richard].score;
            numericUpDownLucy.Value = MyParam.parameter.list_player[(int)ePlayer.Player_Lucy].score;
            numericUpDownAnna.Value = MyParam.parameter.list_player[(int)ePlayer.Player_Anna].score;

            //setting
            txtNewWord.SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue100, Primary.LightBlue100, Primary.LightBlue100, Accent.LightBlue200, TextShade.BLACK);
            
            txtFileNewWord.Text = Path.GetFileName(MyParam.parameter.file_new_word);
            txtTimerCountdown.Text = MyParam.parameter.timer_count_down.ToString();


            //tab
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += TabControl_DrawItem;

            //Group
            groupBoxQuestion.ForeColor = SystemColors.Highlight;
            groupBoxScore.ForeColor = SystemColors.Highlight;
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle _TabBounds = tabControl.GetTabRect(e.Index);

            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;

            if (e.Index == tabControl.SelectedIndex)
            {
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text,
                            new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            SystemBrushes.FromSystemColor(SystemColors.Highlight),
                            _TabBounds, stringFlags);
            }
            else
            {
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text,
                            new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            SystemBrushes.FromSystemColor(SystemColors.Highlight),
                            _TabBounds, stringFlags);
            }
            stringFlags.Dispose();
        }

        void GetValue()
        {
            //Get score
            MyParam.parameter.list_player[(int)ePlayer.Player_John].score = (long)numericUpDownJohn.Value;
            MyParam.parameter.list_player[(int)ePlayer.Player_Richard].score = (long)numericUpDownRichard.Value;
            MyParam.parameter.list_player[(int)ePlayer.Player_Lucy].score = (long)numericUpDownLucy.Value;
            MyParam.parameter.list_player[(int)ePlayer.Player_Anna].score = (long)numericUpDownAnna.Value;

            //Get Filename
            if(!String.IsNullOrEmpty(new_word_file))
                MyParam.parameter.file_new_word = new_word_file;

            //Get timer
            int timer;
            int.TryParse(txtTimerCountdown.Text, out timer);
            MyParam.parameter.timer_count_down = timer;

        }




        #endregion

        #region My Fuction
        void LoadNewWord(string file_excel=null)
        {
            try
            {
                //Read Serial Number and Add to list
                using (var excelWorkbook = new XLWorkbook(String.IsNullOrEmpty(file_excel)?MyParam.parameter.file_new_word:file_excel))
                {
                    var nonEmptyDataRows = excelWorkbook.Worksheet(1).RowsUsed();
                    MyParam.list_vocabularies.Clear();
                    MyParam.parameter.list_index.Clear();
                    foreach (var dataRow in nonEmptyDataRows)
                    {
                        //for row number check
                        if (dataRow.RowNumber() > 1)
                        {
                            //to get column # 3's data
                            //int index_int;
                            //var index_str = dataRow.Cell(1).Value as string;
                            //bool parse_ok = int.TryParse(index_str, out index_int);
                            Vocabulary vocabulary = new Vocabulary()
                            {
                                index = dataRow.Cell(1).Value as string,// parse_ok?index_int:-1,
                                eng = dataRow.Cell(2).Value as string,
                                phonetic = dataRow.Cell(3).Value as string,
                                meaning = dataRow.Cell(4).Value as string,

                            };

                            vocabulary.Log();
                            MyParam.list_vocabularies.Add(vocabulary);

                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MyLib.ShowDlgError(exception.Message);
            }
        }

        void GetRandomValue()
        {
            if(MyParam.list_vocabularies.Count == MyParam.parameter.list_index.Count)
            {
                MyLib.ShowDlgWarning("Finished Check!");
                return;
            }
            //gen
            int index_random = random.Next(MyParam.list_vocabularies.Count);

            if (MyParam.parameter.list_index.Contains(index_random))
            {
                GetRandomValue();
                Console.WriteLine("Dupllicate!");
            }
            else
            {
                MyParam.parameter.list_index.Add(index_random);
                current_vocabulary = MyParam.list_vocabularies[index_random];
            }

                
        }
        void GenData(eTypeGen type = eTypeGen.English)
        {
            GetRandomValue();

            switch (type)
            {
                case eTypeGen.English:
                    txtNewWord.Text = current_vocabulary.eng;
                    break;

                case eTypeGen.Vietnamese:
                    txtNewWord.Text = current_vocabulary.meaning;
                    break;
            }
            //call countdown
            EnableCountdown();
        }
        void EnableCountdown()
        {
            cur_second = MyParam.parameter.timer_count_down;
            btnCountDown.Text = MyParam.parameter.timer_count_down.ToString();
            timerCountDown.Stop();
            timerCountDown.Enabled = true;
            timerCountDown.Start();
            btnCountDown.ForeColor = System.Drawing.SystemColors.Highlight;
        }

        void DisableCountdown()
        {
            timerCountDown.Stop();
            timerCountDown.Enabled = false;
            //btnCountDown.ForeColor = System.Drawing.SystemColors.Highlight;
        }

        private void NewWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (DialogYesNo dlgExit = new DialogYesNo())
            {
                if (dlgExit.ShowDialog() == DialogResult.OK)
                {
                    GetValue();
                    SaveLoadParameter.Save_Parameter(MyParam.parameter);
                    e.Cancel = false;
                }
            }

        }

        int cur_second = MyParam.parameter.timer_count_down;
        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            cur_second--;

            btnCountDown.Text = cur_second.ToString();


            if (cur_second == 0)
            {
                timerCountDown.Stop();
                timerCountDown.Enabled = false;
                btnCountDown.Text = "Time out!";
                btnCountDown.ForeColor = Color.Red;
                //MyLib.ShowDlgWarning("Time out!");
                btnCheckAnswer.PerformClick();
            }
        }
        #endregion


        #region Button click
        private void Button_Setting_Click(object sender, EventArgs e)
        {
            var name_btn = (sender as Button).Name;
            switch (name_btn)
            {
                
                case "btnChangeFile":
                    new_word_file = MyLib.OpenFileDialog(eTypeFile.File_Excel);
                    if (!String.IsNullOrEmpty(new_word_file))
                    {
                        txtFileNewWord.Text = Path.GetFileName(new_word_file);
                        LoadNewWord(new_word_file);
                    }
                    break;

                case "btnSaveConfig":
                    GetValue();
                    SaveLoadParameter.Save_Parameter(MyParam.parameter);
                    break;
                case "btnLoadConfig":
                    SaveLoadParameter.Load_Parameter(MyParam.parameter);
                    MyParam.parameter.PrintInfor();
                    break;
                case "btnClearListIndex":
                    MyParam.parameter.list_index.Clear();
                    break;
                case "btnClearScore":
                    numericUpDownJohn.Value = 0;
                    numericUpDownRichard.Value = 0;
                    numericUpDownLucy.Value = 0;
                    numericUpDownAnna.Value = 0;
                    break;
                default:
                    MyLib.ShowDlgWarning(name_btn);
                    MyParam.parameter.PrintInfor();
                    break;
            }
        }

        private void Button_Main_Click(object sender, EventArgs e)
        {
            var name_btn = (sender as Button).Name;
            switch (name_btn)
            {

                case "btnGenEnglish":
                    GenData(eTypeGen.English);
                    break;
                case "btnGenVietnamese":
                    GenData(eTypeGen.Vietnamese);
                    break;
                case "btnCheckAnswer":
                    DisableCountdown();

                    if(current_vocabulary == null)
                    {
                        MyLib.ShowDlgWarning("Empty new_word!");
                        return;
                    }
                    //show anwser dlg
                    using(MyVocabulary myVocabulary = new MyVocabulary(current_vocabulary))
                    {
                        myVocabulary.ShowDialog();
                    }
                    break;
                default:
                    MyLib.ShowDlgWarning(name_btn);
                    MyParam.parameter.PrintInfor();
                    
                    break;
            }
        }
        #endregion

        #region Hot Keys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //english
            if (keyData == (Keys.Control | Keys.Left))
            {
                btnGenEnglish.PerformClick();
                return true;
            }
            //vietnam
            if (keyData == (Keys.Control | Keys.Right))
            {
                btnGenVietnamese.PerformClick();
                return true;
            }
            //check anwser
            if (keyData == (Keys.Control | Keys.Down))
            {
                btnCheckAnswer.PerformClick();
                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion end_hot_keys
    }
}
