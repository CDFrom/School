using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadGUI1
{
    public partial class MainForm : Form
    {
        string path;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Document | *.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(richTxt.Text);
                        }
                    }
                }
            }
            else
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    await sw.WriteLineAsync(richTxt.Text);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Document | *.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using(StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        path = ofd.FileName;
                        Task<string> text = sr.ReadToEndAsync();
                        richTxt.Text = text.Result;
                    }
                }
            }
        }

        int fileNumber = 1;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWindow newWindow = new NewWindow("X " + fileNumber++);
            newWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxt.SelectedText != "")
            {
                Clipboard.SetText(richTxt.SelectedText);
                richTxt.SelectedText = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxt.SelectedText != "")
            {
                Clipboard.SetText(richTxt.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTxt.Text = richTxt.Text.Insert(richTxt.SelectionStart, (Clipboard.GetText()));
            }
        }
    }
}
