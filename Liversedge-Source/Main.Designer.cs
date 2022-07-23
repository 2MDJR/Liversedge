namespace Liversedge
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TextPlate = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ScriptBox = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.TopmostBox = new System.Windows.Forms.CheckBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // TextPlate
            // 
            this.TextPlate.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.TextPlate.AutoScrollMinSize = new System.Drawing.Size(256, 120);
            this.TextPlate.BackBrush = null;
            this.TextPlate.BackColor = System.Drawing.Color.Transparent;
            this.TextPlate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextPlate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TextPlate.CharHeight = 12;
            this.TextPlate.CharWidth = 7;
            this.TextPlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPlate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextPlate.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.TextPlate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextPlate.IndentBackColor = System.Drawing.SystemColors.ControlText;
            this.TextPlate.IsReplaceMode = false;
            this.TextPlate.LineNumberColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextPlate.Location = new System.Drawing.Point(7, 47);
            this.TextPlate.Name = "TextPlate";
            this.TextPlate.Paddings = new System.Windows.Forms.Padding(0);
            this.TextPlate.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TextPlate.ServiceColors = null;
            this.TextPlate.Size = new System.Drawing.Size(266, 315);
            this.TextPlate.TabIndex = 1;
            this.TextPlate.Text = resources.GetString("TextPlate.Text");
            this.TextPlate.Zoom = 100;
            this.TextPlate.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(227, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(175, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Attach";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(258, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(228, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlText;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(111, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlText;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(59, 469);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlText;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(7, 469);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Open";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ScriptBox
            // 
            this.ScriptBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ScriptBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScriptBox.FormattingEnabled = true;
            this.ScriptBox.Location = new System.Drawing.Point(7, 368);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Size = new System.Drawing.Size(214, 95);
            this.ScriptBox.TabIndex = 10;
            this.ScriptBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlText;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(227, 411);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "S.H.";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlText;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(227, 440);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Ref";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlText;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(227, 368);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 37);
            this.button10.TabIndex = 13;
            this.button10.Text = "Kill Roblox";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // TopmostBox
            // 
            this.TopmostBox.AutoSize = true;
            this.TopmostBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.TopmostBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.TopmostBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopmostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopmostBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopmostBox.Location = new System.Drawing.Point(165, 6);
            this.TopmostBox.Name = "TopmostBox";
            this.TopmostBox.Size = new System.Drawing.Size(57, 16);
            this.TopmostBox.TabIndex = 14;
            this.TopmostBox.Text = "Topmost";
            this.TopmostBox.UseVisualStyleBackColor = false;
            this.TopmostBox.CheckedChanged += new System.EventHandler(this.TopmostBox_CheckedChanged);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLabel.Location = new System.Drawing.Point(187, 28);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(71, 16);
            this.TimeLabel.TabIndex = 15;
            this.TimeLabel.Text = "00:00:00";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DateLabel.Location = new System.Drawing.Point(12, 28);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(87, 16);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "dd MM YYYY";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::Liversedge.Properties.Resources.Liversedge_TRANSPARENT;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(7, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(137, 23);
            this.button11.TabIndex = 16;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button11_MouseDown);
            this.button11.MouseEnter += new System.EventHandler(this.button11_MouseEnter);
            this.button11.MouseLeave += new System.EventHandler(this.button11_MouseLeave);
            this.button11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button11_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(285, 504);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TopmostBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ScriptBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liversedge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.TextPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FastColoredTextBoxNS.FastColoredTextBox TextPlate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox ScriptBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox TopmostBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label DateLabel;
    }
}

