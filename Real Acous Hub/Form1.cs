using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.Audits;
using Newtonsoft.Json;
using System.IO;
using cxapi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_Acous_Hub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            try
            {
                await Editor.EnsureCoreWebView2Async(null);
                Editor.CoreWebView2.Navigate(new Uri($"file:///{Directory.GetCurrentDirectory()}/Editor/index.html").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing WebView2: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Editor_Click(object sender, EventArgs e)
        {

        }

        private async void Execute_Click(object sender, EventArgs e)
        {
            string scriptToExecute = await Editor.ExecuteScriptAsync("GetText();");
            string rawScript = JsonConvert.DeserializeObject<string>(scriptToExecute);
            CoreFunctions.ExecuteScript(rawScript);
        }

        private async void Clear_Click(object sender, EventArgs e)
        {
            await Editor.ExecuteScriptAsync($"SetText(``);");
        }

        private async void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string script = File.ReadAllText(dialog.FileName);
                await Editor.CoreWebView2.ExecuteScriptAsync($"editor.setValue(`{script}`)");
            }
        }

        private async void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt",
                    DefaultExt = "lua",
                    Title = "Save Lua or Text File"
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string textToSave = await Editor.ExecuteScriptAsync("GetText();");
                    string rawText = JsonConvert.DeserializeObject<string>(textToSave);
                    File.WriteAllText(saveFileDialog1.FileName, rawText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Inject_Click(object sender, EventArgs e)
        {
            CoreFunctions.Inject();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        
        private void label2_Click_1(object sender, EventArgs e)
        {

            
        }
    }
}
