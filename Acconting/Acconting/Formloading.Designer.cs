namespace Acconting
{
    partial class Formloading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formloading));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LoadingProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 60;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoadingProgressbar
            // 
            this.LoadingProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingProgressbar.animated = false;
            this.LoadingProgressbar.animationIterval = 5;
            this.LoadingProgressbar.animationSpeed = 300;
            this.LoadingProgressbar.BackColor = System.Drawing.Color.Transparent;
            this.LoadingProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadingProgressbar.BackgroundImage")));
            this.LoadingProgressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.LoadingProgressbar.ForeColor = System.Drawing.Color.Black;
            this.LoadingProgressbar.LabelVisible = true;
            this.LoadingProgressbar.LineProgressThickness = 8;
            this.LoadingProgressbar.LineThickness = 5;
            this.LoadingProgressbar.Location = new System.Drawing.Point(307, 149);
            this.LoadingProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.LoadingProgressbar.MaxValue = 100;
            this.LoadingProgressbar.Name = "LoadingProgressbar";
            this.LoadingProgressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.LoadingProgressbar.ProgressColor = System.Drawing.Color.Lime;
            this.LoadingProgressbar.Size = new System.Drawing.Size(201, 201);
            this.LoadingProgressbar.TabIndex = 17;
            this.LoadingProgressbar.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.Yellow;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(800, 31);
            this.bunifuLabel1.TabIndex = 18;
            this.bunifuLabel1.Text = "Welcome to Applicartion";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Formloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.LoadingProgressbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formloading";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formloading_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar LoadingProgressbar;
        private System.Windows.Forms.Timer timer1;
    }
}

