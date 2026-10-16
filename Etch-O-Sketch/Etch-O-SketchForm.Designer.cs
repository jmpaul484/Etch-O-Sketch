namespace Etch_O_Sketch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            selectColorToolStripMenuItem = new ToolStripMenuItem();
            drawToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            PictureBox = new PictureBox();
            DrawWaveformsButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            PictureBoxToolTip = new ToolTip(components);
            ColorComboBox = new ComboBox();
            SelectColorButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(953, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "F&ile";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectColorToolStripMenuItem, drawToolStripMenuItem, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "E&dit";
            // 
            // selectColorToolStripMenuItem
            // 
            selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            selectColorToolStripMenuItem.Size = new Size(250, 34);
            selectColorToolStripMenuItem.Text = "Select Color";
            // 
            // drawToolStripMenuItem
            // 
            drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            drawToolStripMenuItem.Size = new Size(250, 34);
            drawToolStripMenuItem.Text = "Draw Waveforms";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(250, 34);
            clearToolStripMenuItem.Text = "Clear";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "H&elp";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            // 
            // PictureBox
            // 
            PictureBox.BackColor = Color.White;
            PictureBox.Location = new Point(12, 36);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(929, 402);
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            // 
            // DrawWaveformsButton
            // 
            DrawWaveformsButton.Location = new Point(179, 444);
            DrawWaveformsButton.Name = "DrawWaveformsButton";
            DrawWaveformsButton.Size = new Size(161, 61);
            DrawWaveformsButton.TabIndex = 3;
            DrawWaveformsButton.Text = "D&raw Waveforms";
            DrawWaveformsButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(346, 444);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(161, 61);
            ClearButton.TabIndex = 4;
            ClearButton.Tag = "";
            ClearButton.Text = "C&lear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(780, 444);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(161, 61);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ColorComboBox
            // 
            ColorComboBox.ForeColor = SystemColors.MenuText;
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Location = new Point(592, 459);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(182, 33);
            ColorComboBox.TabIndex = 6;
            ColorComboBox.Visible = false;
            // 
            // SelectColorButton
            // 
            SelectColorButton.Location = new Point(12, 444);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(161, 61);
            SelectColorButton.TabIndex = 7;
            SelectColorButton.Text = "S&elect Color";
            SelectColorButton.UseVisualStyleBackColor = true;
            SelectColorButton.Click += this.SelectColorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 517);
            Controls.Add(SelectColorButton);
            Controls.Add(ColorComboBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DrawWaveformsButton);
            Controls.Add(PictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem selectColorToolStripMenuItem;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox PictureBox;
        private Button DrawWaveformsButton;
        private Button ClearButton;
        private Button ExitButton;
        private ToolTip PictureBoxToolTip;
        private ComboBox ColorComboBox;
        private Button SelectColorButton;
    }
}
