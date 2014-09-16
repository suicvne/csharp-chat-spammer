namespace ChatSpammer
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
            this.controlGb = new System.Windows.Forms.GroupBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.curSpeedMs = new System.Windows.Forms.Label();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.helpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.transGroupBox = new System.Windows.Forms.GroupBox();
            this.transLabel = new System.Windows.Forms.Label();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.startSpammer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.controlGb.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.transGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // controlGb
            // 
            this.controlGb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controlGb.Controls.Add(this.button2);
            this.controlGb.Controls.Add(this.startSpammer);
            this.controlGb.Location = new System.Drawing.Point(13, 13);
            this.controlGb.Name = "controlGb";
            this.controlGb.Size = new System.Drawing.Size(296, 315);
            this.controlGb.TabIndex = 0;
            this.controlGb.TabStop = false;
            this.controlGb.Text = "Control";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsGroupBox.Controls.Add(this.curSpeedMs);
            this.settingsGroupBox.Controls.Add(this.speedTrackBar);
            this.settingsGroupBox.Controls.Add(this.label2);
            this.settingsGroupBox.Controls.Add(this.textBox2);
            this.settingsGroupBox.Controls.Add(this.textBox1);
            this.settingsGroupBox.Controls.Add(this.label1);
            this.settingsGroupBox.Location = new System.Drawing.Point(315, 13);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(296, 315);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // curSpeedMs
            // 
            this.curSpeedMs.AutoSize = true;
            this.curSpeedMs.Location = new System.Drawing.Point(13, 170);
            this.curSpeedMs.Name = "curSpeedMs";
            this.curSpeedMs.Size = new System.Drawing.Size(34, 13);
            this.curSpeedMs.TabIndex = 5;
            this.curSpeedMs.Text = "{0}ms";
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(12, 122);
            this.speedTrackBar.Maximum = 20;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(278, 45);
            this.speedTrackBar.TabIndex = 4;
            this.speedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 20);
            this.textBox2.TabIndex = 2;
            this.helpToolTip.SetToolTip(this.textBox2, "The second message");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 1;
            this.helpToolTip.SetToolTip(this.textBox1, "The first message");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Messages";
            // 
            // helpToolTip
            // 
            this.helpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // transGroupBox
            // 
            this.transGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.transGroupBox.Controls.Add(this.transLabel);
            this.transGroupBox.Controls.Add(this.opacityTrackBar);
            this.transGroupBox.Location = new System.Drawing.Point(618, 13);
            this.transGroupBox.Name = "transGroupBox";
            this.transGroupBox.Size = new System.Drawing.Size(88, 315);
            this.transGroupBox.TabIndex = 2;
            this.transGroupBox.TabStop = false;
            this.transGroupBox.Text = "Opacity";
            // 
            // transLabel
            // 
            this.transLabel.AutoSize = true;
            this.transLabel.Location = new System.Drawing.Point(27, 285);
            this.transLabel.Name = "transLabel";
            this.transLabel.Size = new System.Drawing.Size(29, 13);
            this.transLabel.TabIndex = 1;
            this.transLabel.Text = "{0}%";
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.Location = new System.Drawing.Point(21, 19);
            this.opacityTrackBar.Maximum = 16;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.opacityTrackBar.Size = new System.Drawing.Size(45, 263);
            this.opacityTrackBar.TabIndex = 0;
            this.opacityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.opacityTrackBar.Scroll += new System.EventHandler(this.opacityTrackBar_Scroll);
            this.opacityTrackBar.ValueChanged += new System.EventHandler(this.opacityTrackBar_ValueChanged);
            // 
            // startSpammer
            // 
            this.startSpammer.Location = new System.Drawing.Point(6, 131);
            this.startSpammer.Name = "startSpammer";
            this.startSpammer.Size = new System.Drawing.Size(135, 68);
            this.startSpammer.TabIndex = 0;
            this.startSpammer.Text = "Start";
            this.startSpammer.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 340);
            this.Controls.Add(this.transGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.controlGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Chat Spammer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.controlGb.ResumeLayout(false);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.transGroupBox.ResumeLayout(false);
            this.transGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlGb;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label curSpeedMs;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip helpToolTip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox transGroupBox;
        private System.Windows.Forms.Label transLabel;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startSpammer;
    }
}

