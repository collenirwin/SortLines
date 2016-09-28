﻿namespace SortLines {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.gbxSpeed = new System.Windows.Forms.GroupBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.pnlMain = new System.Windows.Forms.PictureBox();
            this.gbxStyle = new System.Windows.Forms.GroupBox();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.gbxWrites = new System.Windows.Forms.GroupBox();
            this.lblWrites = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbxType.SuspendLayout();
            this.gbxSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.gbxStyle.SuspendLayout();
            this.gbxWrites.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxType
            // 
            this.gbxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxType.Controls.Add(this.cboSort);
            this.gbxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gbxType.Location = new System.Drawing.Point(13, 318);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(109, 64);
            this.gbxType.TabIndex = 8;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Type";
            // 
            // cboSort
            // 
            this.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "Bogo",
            "Bubble",
            "Cocktail",
            "Comb",
            "Cycle",
            "Insertion",
            "Odd-Even",
            "Select",
            "Stooge",
            "Quick"});
            this.cboSort.Location = new System.Drawing.Point(6, 19);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(97, 21);
            this.cboSort.TabIndex = 1;
            // 
            // gbxSpeed
            // 
            this.gbxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSpeed.Controls.Add(this.tbSpeed);
            this.gbxSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gbxSpeed.Location = new System.Drawing.Point(225, 318);
            this.gbxSpeed.Name = "gbxSpeed";
            this.gbxSpeed.Size = new System.Drawing.Size(159, 64);
            this.gbxSpeed.TabIndex = 12;
            this.gbxSpeed.TabStop = false;
            this.gbxSpeed.Text = "Speed (100 hz)";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpeed.Location = new System.Drawing.Point(6, 13);
            this.tbSpeed.Maximum = 1000;
            this.tbSpeed.Minimum = 10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(147, 45);
            this.tbSpeed.TabIndex = 0;
            this.tbSpeed.TickFrequency = 50;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbSpeed.Value = 100;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSort.Location = new System.Drawing.Point(456, 325);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(57, 27);
            this.btnSort.TabIndex = 13;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnReset.Location = new System.Drawing.Point(456, 355);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(57, 27);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.WorkerSupportsCancellation = true;
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(13, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 300);
            this.pnlMain.TabIndex = 16;
            this.pnlMain.TabStop = false;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // gbxStyle
            // 
            this.gbxStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxStyle.Controls.Add(this.cboStyle);
            this.gbxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gbxStyle.Location = new System.Drawing.Point(128, 318);
            this.gbxStyle.Name = "gbxStyle";
            this.gbxStyle.Size = new System.Drawing.Size(91, 64);
            this.gbxStyle.TabIndex = 13;
            this.gbxStyle.TabStop = false;
            this.gbxStyle.Text = "Type";
            // 
            // cboStyle
            // 
            this.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Items.AddRange(new object[] {
            "Lines",
            "Boxes",
            "?????"});
            this.cboStyle.Location = new System.Drawing.Point(6, 19);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(79, 21);
            this.cboStyle.TabIndex = 0;
            this.cboStyle.SelectedIndexChanged += new System.EventHandler(this.Form1_ResizeEnd);
            // 
            // gbxWrites
            // 
            this.gbxWrites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxWrites.Controls.Add(this.lblWrites);
            this.gbxWrites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gbxWrites.Location = new System.Drawing.Point(390, 318);
            this.gbxWrites.Name = "gbxWrites";
            this.gbxWrites.Size = new System.Drawing.Size(60, 64);
            this.gbxWrites.TabIndex = 14;
            this.gbxWrites.TabStop = false;
            this.gbxWrites.Text = "Writes";
            // 
            // lblWrites
            // 
            this.lblWrites.Location = new System.Drawing.Point(4, 25);
            this.lblWrites.Name = "lblWrites";
            this.lblWrites.Size = new System.Drawing.Size(52, 23);
            this.lblWrites.TabIndex = 0;
            this.lblWrites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnStop.Location = new System.Drawing.Point(456, 325);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(57, 27);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(526, 392);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.gbxWrites);
            this.Controls.Add(this.gbxStyle);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.gbxSpeed);
            this.Controls.Add(this.gbxType);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.MinimumSize = new System.Drawing.Size(542, 430);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortLines";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.gbxType.ResumeLayout(false);
            this.gbxSpeed.ResumeLayout(false);
            this.gbxSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.gbxStyle.ResumeLayout(false);
            this.gbxWrites.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.GroupBox gbxSpeed;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReset;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.PictureBox pnlMain;
        private System.Windows.Forms.GroupBox gbxStyle;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.GroupBox gbxWrites;
        private System.Windows.Forms.Label lblWrites;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Button btnStop;
    }
}

