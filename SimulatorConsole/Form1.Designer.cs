
namespace SimulatorConsole
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startbutton = new System.Windows.Forms.Button();
            this.SetData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.conflict = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.aircraft1 = new System.Windows.Forms.PictureBox();
            this.aircraft2 = new System.Windows.Forms.PictureBox();
            this.destino2 = new System.Windows.Forms.PictureBox();
            this.departure1 = new System.Windows.Forms.PictureBox();
            this.departure2 = new System.Windows.Forms.PictureBox();
            this.destino1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aircraft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destino2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destino1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(320, 105);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(614, 75);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Advanced exercise\r\n";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAppToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.closeAppToolStripMenuItem.Text = "Close app";
            this.closeAppToolStripMenuItem.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(458, 376);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(316, 120);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start test";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetData
            // 
            this.SetData.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetData.Location = new System.Drawing.Point(458, 234);
            this.SetData.Name = "SetData";
            this.SetData.Size = new System.Drawing.Size(316, 120);
            this.SetData.TabIndex = 4;
            this.SetData.Text = "Set aircrafts data";
            this.SetData.UseVisualStyleBackColor = true;
            this.SetData.Click += new System.EventHandler(this.SetData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.conflict);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.Restart);
            this.panel1.Controls.Add(this.aircraft1);
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Controls.Add(this.aircraft2);
            this.panel1.Controls.Add(this.SetData);
            this.panel1.Controls.Add(this.startbutton);
            this.panel1.Controls.Add(this.destino2);
            this.panel1.Controls.Add(this.departure1);
            this.panel1.Controls.Add(this.departure2);
            this.panel1.Controls.Add(this.destino1);
            this.panel1.Controls.Add(this.background);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // conflict
            // 
            this.conflict.AutoSize = true;
            this.conflict.BackColor = System.Drawing.Color.Transparent;
            this.conflict.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conflict.ForeColor = System.Drawing.Color.Red;
            this.conflict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conflict.Location = new System.Drawing.Point(454, 516);
            this.conflict.Name = "conflict";
            this.conflict.Size = new System.Drawing.Size(340, 24);
            this.conflict.TabIndex = 16;
            this.conflict.Text = "There is a conflict between aircrafts";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(25, 39);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 15;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(115, 39);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 14;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // aircraft1
            // 
            this.aircraft1.BackColor = System.Drawing.Color.Transparent;
            this.aircraft1.Image = ((System.Drawing.Image)(resources.GetObject("aircraft1.Image")));
            this.aircraft1.Location = new System.Drawing.Point(1162, 330);
            this.aircraft1.Name = "aircraft1";
            this.aircraft1.Size = new System.Drawing.Size(30, 30);
            this.aircraft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aircraft1.TabIndex = 8;
            this.aircraft1.TabStop = false;
            // 
            // aircraft2
            // 
            this.aircraft2.BackColor = System.Drawing.Color.Transparent;
            this.aircraft2.Image = ((System.Drawing.Image)(resources.GetObject("aircraft2.Image")));
            this.aircraft2.Location = new System.Drawing.Point(1162, 366);
            this.aircraft2.Name = "aircraft2";
            this.aircraft2.Size = new System.Drawing.Size(30, 30);
            this.aircraft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aircraft2.TabIndex = 6;
            this.aircraft2.TabStop = false;
            // 
            // destino2
            // 
            this.destino2.BackColor = System.Drawing.Color.Transparent;
            this.destino2.Image = ((System.Drawing.Image)(resources.GetObject("destino2.Image")));
            this.destino2.Location = new System.Drawing.Point(1162, 438);
            this.destino2.Name = "destino2";
            this.destino2.Size = new System.Drawing.Size(30, 30);
            this.destino2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.destino2.TabIndex = 11;
            this.destino2.TabStop = false;
            // 
            // departure1
            // 
            this.departure1.BackColor = System.Drawing.Color.Transparent;
            this.departure1.Image = ((System.Drawing.Image)(resources.GetObject("departure1.Image")));
            this.departure1.Location = new System.Drawing.Point(1162, 474);
            this.departure1.Name = "departure1";
            this.departure1.Size = new System.Drawing.Size(30, 30);
            this.departure1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.departure1.TabIndex = 12;
            this.departure1.TabStop = false;
            // 
            // departure2
            // 
            this.departure2.BackColor = System.Drawing.Color.Transparent;
            this.departure2.Image = ((System.Drawing.Image)(resources.GetObject("departure2.Image")));
            this.departure2.Location = new System.Drawing.Point(1162, 510);
            this.departure2.Name = "departure2";
            this.departure2.Size = new System.Drawing.Size(30, 30);
            this.departure2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.departure2.TabIndex = 13;
            this.departure2.TabStop = false;
            // 
            // destino1
            // 
            this.destino1.BackColor = System.Drawing.Color.Transparent;
            this.destino1.Image = ((System.Drawing.Image)(resources.GetObject("destino1.Image")));
            this.destino1.Location = new System.Drawing.Point(1162, 402);
            this.destino1.Name = "destino1";
            this.destino1.Size = new System.Drawing.Size(30, 30);
            this.destino1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.destino1.TabIndex = 10;
            this.destino1.TabStop = false;
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1264, 681);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 7;
            this.background.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aircraft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destino2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destino1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAppToolStripMenuItem;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button SetData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox aircraft2;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox aircraft1;
        private System.Windows.Forms.PictureBox departure2;
        private System.Windows.Forms.PictureBox departure1;
        private System.Windows.Forms.PictureBox destino2;
        private System.Windows.Forms.PictureBox destino1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label conflict;
    }
}