using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace replacingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                txtInputFile.Text = dlg.FileName;

        }

        private void btnBrowseKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                txtKeyFile.Text = dlg.FileName;

        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                txtOutputFile.Text = dlg.FileName;

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                string keyFile = txtKeyFile.Text;
                string inputFile = txtInputFile.Text;
                string outputFile = txtOutputFile.Text;

                if (!File.Exists(keyFile))
                {
                    MessageBox.Show("Key-value file not found!");
                    return;
                }

                if (!File.Exists(inputFile))
                {
                    MessageBox.Show("Input file not found!");
                    return;
                }

                var map = new Dictionary<string, string>();
                foreach (var line in File.ReadAllLines(keyFile))
                {
                    if (line.Contains(":"))
                    {
                        var parts = line.Split(new[] { ':' }, 2);
                        map[parts[0].Trim()] = parts[1].Trim();
                    }
                }

                string text = File.ReadAllText(inputFile);

                text = Regex.Replace(text, @"<([^>]+)>", match =>
                {
                    string key = match.Groups[1].Value;
                    return map.ContainsKey(key) ? map[key] : match.Value;
                });

                File.WriteAllText(outputFile, text);

                MessageBox.Show("Replacement Completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
