namespace pick_note_time_interval
{
    partial class MainForm
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
            richTextBox = new RichTextBox();
            numericUpDown = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxTitle = new TextBox();
            textBoxText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.BackColor = Color.White;
            richTextBox.Dock = DockStyle.Right;
            richTextBox.Location = new Point(246, 10);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new Size(222, 224);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // numericUpDown
            // 
            numericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown.Location = new Point(26, 13);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(111, 39);
            numericUpDown.TabIndex = 1;
            numericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxTitle
            // 
            textBoxTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(24, 68);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Note Title";
            textBoxTitle.Size = new Size(175, 34);
            textBoxTitle.TabIndex = 3;
            // 
            // textBoxText
            // 
            textBoxText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxText.Location = new Point(24, 119);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.PlaceholderText = "Note Text";
            textBoxText.Size = new Size(175, 112);
            textBoxText.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(textBoxText);
            Controls.Add(textBoxTitle);
            Controls.Add(numericUpDown);
            Controls.Add(richTextBox);
            Name = "MainForm";
            Padding = new Padding(10);
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox;
        private NumericUpDown numericUpDown;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxTitle;
        private TextBox textBoxText;
    }
}