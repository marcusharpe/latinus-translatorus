using System;
using System.Media;
using System.Windows.Forms;
using TranslatorNS;
using PopupsLybrary;

// Author: Marcus B
namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, EventArgs e) // exit button
        {
            DialogResult = MessageBox.Show("Would you like to spend 37 seconds while enjoing this marvelous  original composition",
                "Music break", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.Equals(DialogResult.Yes))
            {
                using (var soundPlayer = new SoundPlayer(@"music.wav"))
                {
                    soundPlayer.PlaySync();
                }
                MessageBox.Show("Thank you for listening", "Good bye box");

            }
            Close();

        }

        private void clearBTN_Click(object sender, EventArgs e) // clear button
        {
            inputTXT.Text = string.Empty;
            outputTXT.Text = string.Empty;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            pigLRadio.Checked = true;
            MessageBox.Show(Popups.DisplayPopup("so cool  ", "yeah"));

        }

        private void translateBTN_Click(object sender, EventArgs e)
        {
            if (inputTXT.Text != string.Empty)
            {
                if (pigLRadio.Checked)
                {
                    Pig_Latin_Translator latinoPig = new Pig_Latin_Translator();
                    outputTXT.Text = latinoPig.Translate(inputTXT.Text);
                    //if ("why"[2].Equals("Y"[0]) || "why"[2].Equals("y"[0])) MessageBox.Show("true");  good example of comparing char with string

                }
                else if (pigGRadio.Checked)
                {
                    Pig_Greek_Translator greekoPigus = new Pig_Greek_Translator();
                    outputTXT.Text = greekoPigus.Translate(inputTXT.Text);
                }
            }
            else
            {
                MessageBox.Show("English text cannot be empty", "Input Error",
               MessageBoxButtons.OK);

            }
        }

        private void pigGRadio_CheckedChanged(object sender, EventArgs e)
        {
            LBLOutText.Text = "Pig Greek translation:";
            outputTXT.Text = string.Empty;
        }

        private void pigLRadio_CheckedChanged(object sender, EventArgs e)
        {
            LBLOutText.Text = "Pig Latin translation:";
            outputTXT.Text = string.Empty;

        }
    }
}