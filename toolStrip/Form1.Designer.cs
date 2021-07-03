
namespace toolStrip
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.vol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.prev = new System.Windows.Forms.Button();
            this.playpause = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.vol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.prev);
            this.panel1.Controls.Add(this.playpause);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 595);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Antek\'s\r\nmedia player";
            // 
            // vol
            // 
            this.vol.AutoSize = true;
            this.vol.Location = new System.Drawing.Point(60, 289);
            this.vol.Name = "vol";
            this.vol.Size = new System.Drawing.Size(16, 17);
            this.vol.TabIndex = 6;
            this.vol.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volmue";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 254);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 329);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.Blue;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Location = new System.Drawing.Point(16, 209);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(114, 39);
            this.prev.TabIndex = 3;
            this.prev.Text = "←";
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // playpause
            // 
            this.playpause.BackColor = System.Drawing.Color.Blue;
            this.playpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playpause.Location = new System.Drawing.Point(16, 143);
            this.playpause.Name = "playpause";
            this.playpause.Size = new System.Drawing.Size(114, 39);
            this.playpause.TabIndex = 2;
            this.playpause.Text = "►■";
            this.playpause.UseVisualStyleBackColor = false;
            this.playpause.Click += new System.EventHandler(this.playpause_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Blue;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(16, 83);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(114, 39);
            this.Next.TabIndex = 1;
            this.Next.Text = "→";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::toolStrip.Properties.Resources.normalX;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(92, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 59);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 595);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button playpause;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label vol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

