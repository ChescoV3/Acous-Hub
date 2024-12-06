namespace Real_Acous_Hub
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Editor = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Execute = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Clear = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Inject = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.AllowExternalDrop = true;
            this.Editor.BackColor = System.Drawing.Color.Gainsboro;
            this.Editor.CreationProperties = null;
            this.Editor.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Editor.Location = new System.Drawing.Point(73, 75);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(527, 272);
            this.Editor.TabIndex = 0;
            this.Editor.ZoomFactor = 1D;
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BorderThickness = 1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton1.Location = new System.Drawing.Point(12, 222);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(45, 46);
            this.guna2CircleButton1.TabIndex = 1;
            this.guna2CircleButton1.Text = "📁";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.Transparent;
            this.Execute.BorderThickness = 1;
            this.Execute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Execute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Execute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Execute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Execute.FillColor = System.Drawing.Color.White;
            this.Execute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Execute.ForeColor = System.Drawing.Color.Black;
            this.Execute.Location = new System.Drawing.Point(12, 96);
            this.Execute.Name = "Execute";
            this.Execute.PressedColor = System.Drawing.Color.Transparent;
            this.Execute.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Execute.Size = new System.Drawing.Size(45, 46);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "➤";
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Transparent;
            this.Clear.BorderThickness = 1;
            this.Clear.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Clear.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clear.FillColor = System.Drawing.Color.Transparent;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(12, 160);
            this.Clear.Name = "Clear";
            this.Clear.PressedColor = System.Drawing.Color.White;
            this.Clear.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Clear.Size = new System.Drawing.Size(45, 46);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "🧹";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Inject
            // 
            this.Inject.BackColor = System.Drawing.Color.Transparent;
            this.Inject.BorderThickness = 1;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.FillColor = System.Drawing.Color.Transparent;
            this.Inject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Inject.ForeColor = System.Drawing.Color.Black;
            this.Inject.Location = new System.Drawing.Point(116, 353);
            this.Inject.Name = "Inject";
            this.Inject.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Inject.Size = new System.Drawing.Size(45, 46);
            this.Inject.TabIndex = 4;
            this.Inject.Text = "🔗";
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.BorderThickness = 1;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton2.Location = new System.Drawing.Point(12, 285);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(45, 46);
            this.guna2CircleButton2.TabIndex = 5;
            this.guna2CircleButton2.Text = "💾";
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(-4, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Acous Hub";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2CircleButton5
            // 
            this.guna2CircleButton5.BackColor = System.Drawing.Color.LightGray;
            this.guna2CircleButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton5.FillColor = System.Drawing.Color.Silver;
            this.guna2CircleButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton5.Location = new System.Drawing.Point(593, 12);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.Size = new System.Drawing.Size(34, 34);
            this.guna2CircleButton5.TabIndex = 10;
            this.guna2CircleButton5.Text = "-";
            this.guna2CircleButton5.Click += new System.EventHandler(this.guna2CircleButton5_Click);
            // 
            // guna2CircleButton6
            // 
            this.guna2CircleButton6.BackColor = System.Drawing.Color.LightGray;
            this.guna2CircleButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2CircleButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton6.FillColor = System.Drawing.Color.Silver;
            this.guna2CircleButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton6.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton6.Location = new System.Drawing.Point(629, 12);
            this.guna2CircleButton6.Name = "guna2CircleButton6";
            this.guna2CircleButton6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2CircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton6.Size = new System.Drawing.Size(33, 34);
            this.guna2CircleButton6.TabIndex = 11;
            this.guna2CircleButton6.Text = "X";
            this.guna2CircleButton6.Click += new System.EventHandler(this.guna2CircleButton6_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label2.Location = new System.Drawing.Point(167, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 55);
            this.label2.TabIndex = 12;
            this.label2.Text = "Made by Chesco";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2CircleButton6);
            this.Controls.Add(this.guna2CircleButton5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.Editor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Editor;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton Execute;
        private Guna.UI2.WinForms.Guna2CircleButton Clear;
        private Guna.UI2.WinForms.Guna2CircleButton Inject;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton6;
        private System.Windows.Forms.Label label2;
    }
}

