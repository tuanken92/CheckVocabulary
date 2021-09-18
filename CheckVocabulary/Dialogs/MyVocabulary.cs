using CheckVocabulary.Sources;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckVocabulary.Dialogs
{
    public partial class MyVocabulary : MaterialForm
    {
        #region Variables
        private MaterialSkinManager materialSkinManager;
        Vocabulary _myData = null;

        public Vocabulary MyData { get => _myData; set => _myData = value; }
        #endregion

        #region MainProgram
        void InitSkinManager()
        {
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

      

        public MyVocabulary(Vocabulary data)
        {
            InitializeComponent();
            InitSkinManager();
            
            MyData = data;
            
            this.Text = data.eng;

            UpdateGui(data);
        }

        #endregion

        #region Functions
        void UpdateGui(Vocabulary data)
        {
            txtEnglish.Text = data.eng;
            txtPhonetic.Text = data.phonetic;
            txtMeaning.Text = data.meaning;
        }




        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
