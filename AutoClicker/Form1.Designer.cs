namespace AutoClicker
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSeconds = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkLeft = new System.Windows.Forms.CheckBox();
			this.chkRight = new System.Windows.Forms.CheckBox();
			this.richTxt1 = new System.Windows.Forms.RichTextBox();
			this.lblRunning = new System.Windows.Forms.Label();
			this.chkW = new System.Windows.Forms.CheckBox();
			this.chkA = new System.Windows.Forms.CheckBox();
			this.chkS = new System.Windows.Forms.CheckBox();
			this.chkD = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDuration = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "How fast should I do it?";
			// 
			// txtSeconds
			// 
			this.txtSeconds.Location = new System.Drawing.Point(14, 164);
			this.txtSeconds.Name = "txtSeconds";
			this.txtSeconds.Size = new System.Drawing.Size(34, 20);
			this.txtSeconds.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "milliseconds.";
			// 
			// chkLeft
			// 
			this.chkLeft.AutoSize = true;
			this.chkLeft.Location = new System.Drawing.Point(11, 12);
			this.chkLeft.Name = "chkLeft";
			this.chkLeft.Size = new System.Drawing.Size(69, 17);
			this.chkLeft.TabIndex = 7;
			this.chkLeft.Text = "Left-click";
			this.chkLeft.UseVisualStyleBackColor = true;
			this.chkLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkLeft_MouseClick);
			// 
			// chkRight
			// 
			this.chkRight.AutoSize = true;
			this.chkRight.Location = new System.Drawing.Point(11, 28);
			this.chkRight.Name = "chkRight";
			this.chkRight.Size = new System.Drawing.Size(76, 17);
			this.chkRight.TabIndex = 8;
			this.chkRight.Text = "Right-click";
			this.chkRight.UseVisualStyleBackColor = true;
			this.chkRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkRight_MouseClick);
			// 
			// richTxt1
			// 
			this.richTxt1.BackColor = System.Drawing.Color.White;
			this.richTxt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTxt1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTxt1.Location = new System.Drawing.Point(11, 273);
			this.richTxt1.Name = "richTxt1";
			this.richTxt1.ReadOnly = true;
			this.richTxt1.Size = new System.Drawing.Size(198, 33);
			this.richTxt1.TabIndex = 9;
			this.richTxt1.TabStop = false;
			this.richTxt1.Text = "TIP: Go into the game and CTRL+left-click anywhere to start/stop the autoclicking" +
    ".";
			this.richTxt1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTxt1_MouseClick);
			// 
			// lblRunning
			// 
			this.lblRunning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRunning.AutoSize = true;
			this.lblRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRunning.Location = new System.Drawing.Point(138, 9);
			this.lblRunning.Name = "lblRunning";
			this.lblRunning.Size = new System.Drawing.Size(66, 13);
			this.lblRunning.TabIndex = 10;
			this.lblRunning.Text = "(not running)";
			// 
			// chkW
			// 
			this.chkW.AutoSize = true;
			this.chkW.Location = new System.Drawing.Point(11, 58);
			this.chkW.Name = "chkW";
			this.chkW.Size = new System.Drawing.Size(37, 17);
			this.chkW.TabIndex = 11;
			this.chkW.Text = "W";
			this.chkW.UseVisualStyleBackColor = true;
			this.chkW.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkW_MouseClick);
			// 
			// chkA
			// 
			this.chkA.AutoSize = true;
			this.chkA.Location = new System.Drawing.Point(11, 75);
			this.chkA.Name = "chkA";
			this.chkA.Size = new System.Drawing.Size(33, 17);
			this.chkA.TabIndex = 12;
			this.chkA.Text = "A";
			this.chkA.UseVisualStyleBackColor = true;
			this.chkA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkA_MouseClick);
			// 
			// chkS
			// 
			this.chkS.AutoSize = true;
			this.chkS.Location = new System.Drawing.Point(11, 92);
			this.chkS.Name = "chkS";
			this.chkS.Size = new System.Drawing.Size(33, 17);
			this.chkS.TabIndex = 13;
			this.chkS.Text = "S";
			this.chkS.UseVisualStyleBackColor = true;
			this.chkS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkS_MouseClick);
			// 
			// chkD
			// 
			this.chkD.AutoSize = true;
			this.chkD.Location = new System.Drawing.Point(11, 110);
			this.chkD.Name = "chkD";
			this.chkD.Size = new System.Drawing.Size(34, 17);
			this.chkD.TabIndex = 14;
			this.chkD.Text = "D";
			this.chkD.UseVisualStyleBackColor = true;
			this.chkD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkD_MouseClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(52, 227);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 14);
			this.label3.TabIndex = 17;
			this.label3.Text = "milliseconds.";
			// 
			// txtDuration
			// 
			this.txtDuration.Location = new System.Drawing.Point(14, 224);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.Size = new System.Drawing.Size(34, 20);
			this.txtDuration.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Input duration:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(216, 318);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDuration);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.chkD);
			this.Controls.Add(this.chkS);
			this.Controls.Add(this.chkA);
			this.Controls.Add(this.chkW);
			this.Controls.Add(this.lblRunning);
			this.Controls.Add(this.richTxt1);
			this.Controls.Add(this.chkRight);
			this.Controls.Add(this.chkLeft);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSeconds);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "AutoClicker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSeconds;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkLeft;
		private System.Windows.Forms.CheckBox chkRight;
		private System.Windows.Forms.RichTextBox richTxt1;
		private System.Windows.Forms.Label lblRunning;
		private System.Windows.Forms.CheckBox chkW;
		private System.Windows.Forms.CheckBox chkA;
		private System.Windows.Forms.CheckBox chkS;
		private System.Windows.Forms.CheckBox chkD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDuration;
		private System.Windows.Forms.Label label4;
	}
}

