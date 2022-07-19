namespace SnakeSpel2
{
    partial class startLabel
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
            this.spelTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.scoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.KlockaTimer = new System.Windows.Forms.Timer(this.components);
            this.insLabel = new System.Windows.Forms.Label();
            this.uppLabel = new System.Windows.Forms.Label();
            this.vänsterLabel = new System.Windows.Forms.Label();
            this.nerLabel = new System.Windows.Forms.Label();
            this.högerLabel = new System.Windows.Forms.Label();
            this.vgmLabel = new System.Windows.Forms.Label();
            this.matenLabel = new System.Windows.Forms.Label();
            this.redoLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spelTimer
            // 
            this.spelTimer.Enabled = true;
            this.spelTimer.Interval = 200;
            this.spelTimer.Tick += new System.EventHandler(this.SpelTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.scoreLabel,
            this.toolStripStatusLabel2,
            this.timerLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(390, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Score: ";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(16, 17);
            this.scoreLabel.Text = "0 ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(250, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel2.Text = "Tid: ";
            // 
            // timerLabel
            // 
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(34, 17);
            this.timerLabel.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tryck mellanslag för att starta!";
            // 
            // KlockaTimer
            // 
            this.KlockaTimer.Interval = 1000;
            this.KlockaTimer.Tick += new System.EventHandler(this.KlockaTimer_Tick);
            // 
            // insLabel
            // 
            this.insLabel.AutoSize = true;
            this.insLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insLabel.ForeColor = System.Drawing.Color.White;
            this.insLabel.Location = new System.Drawing.Point(21, 6);
            this.insLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insLabel.Name = "insLabel";
            this.insLabel.Size = new System.Drawing.Size(137, 26);
            this.insLabel.TabIndex = 2;
            this.insLabel.Text = "Instruktioner:";
            // 
            // uppLabel
            // 
            this.uppLabel.AutoSize = true;
            this.uppLabel.ForeColor = System.Drawing.Color.White;
            this.uppLabel.Location = new System.Drawing.Point(23, 36);
            this.uppLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uppLabel.Name = "uppLabel";
            this.uppLabel.Size = new System.Drawing.Size(73, 13);
            this.uppLabel.TabIndex = 3;
            this.uppLabel.Text = "Pil Upp = Upp";
            // 
            // vänsterLabel
            // 
            this.vänsterLabel.AutoSize = true;
            this.vänsterLabel.ForeColor = System.Drawing.Color.White;
            this.vänsterLabel.Location = new System.Drawing.Point(23, 96);
            this.vänsterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vänsterLabel.Name = "vänsterLabel";
            this.vänsterLabel.Size = new System.Drawing.Size(105, 13);
            this.vänsterLabel.TabIndex = 4;
            this.vänsterLabel.Text = "Pil Vänster = Vänster";
            // 
            // nerLabel
            // 
            this.nerLabel.AutoSize = true;
            this.nerLabel.ForeColor = System.Drawing.Color.White;
            this.nerLabel.Location = new System.Drawing.Point(23, 56);
            this.nerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nerLabel.Name = "nerLabel";
            this.nerLabel.Size = new System.Drawing.Size(67, 13);
            this.nerLabel.TabIndex = 5;
            this.nerLabel.Text = "Pil Ner = Ner";
            // 
            // högerLabel
            // 
            this.högerLabel.AutoSize = true;
            this.högerLabel.ForeColor = System.Drawing.Color.White;
            this.högerLabel.Location = new System.Drawing.Point(23, 75);
            this.högerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.högerLabel.Name = "högerLabel";
            this.högerLabel.Size = new System.Drawing.Size(91, 13);
            this.högerLabel.TabIndex = 6;
            this.högerLabel.Text = "Pil Höger = Höger";
            // 
            // vgmLabel
            // 
            this.vgmLabel.AutoSize = true;
            this.vgmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vgmLabel.ForeColor = System.Drawing.Color.White;
            this.vgmLabel.Location = new System.Drawing.Point(205, 6);
            this.vgmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vgmLabel.Name = "vgmLabel";
            this.vgmLabel.Size = new System.Drawing.Size(155, 26);
            this.vgmLabel.TabIndex = 7;
            this.vgmLabel.Text = "Vad gör man?:";
            // 
            // matenLabel
            // 
            this.matenLabel.AutoSize = true;
            this.matenLabel.ForeColor = System.Drawing.Color.White;
            this.matenLabel.Location = new System.Drawing.Point(215, 36);
            this.matenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matenLabel.Name = "matenLabel";
            this.matenLabel.Size = new System.Drawing.Size(133, 13);
            this.matenLabel.TabIndex = 8;
            this.matenLabel.Text = "Ät upp maten och bli större";
            this.matenLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // redoLabel
            // 
            this.redoLabel.AutoSize = true;
            this.redoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redoLabel.ForeColor = System.Drawing.Color.White;
            this.redoLabel.Location = new System.Drawing.Point(135, 142);
            this.redoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redoLabel.Name = "redoLabel";
            this.redoLabel.Size = new System.Drawing.Size(118, 37);
            this.redoLabel.TabIndex = 9;
            this.redoLabel.Text = "Redo?!";
            // 
            // startLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(390, 380);
            this.Controls.Add(this.redoLabel);
            this.Controls.Add(this.matenLabel);
            this.Controls.Add(this.vgmLabel);
            this.Controls.Add(this.högerLabel);
            this.Controls.Add(this.nerLabel);
            this.Controls.Add(this.vänsterLabel);
            this.Controls.Add(this.uppLabel);
            this.Controls.Add(this.insLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "startLabel";
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer spelTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer KlockaTimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel timerLabel;
        private System.Windows.Forms.Label insLabel;
        private System.Windows.Forms.Label uppLabel;
        private System.Windows.Forms.Label vänsterLabel;
        private System.Windows.Forms.Label nerLabel;
        private System.Windows.Forms.Label högerLabel;
        private System.Windows.Forms.Label vgmLabel;
        private System.Windows.Forms.Label matenLabel;
        private System.Windows.Forms.Label redoLabel;
    }
}

