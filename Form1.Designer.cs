namespace mod3
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
            textName = new TextBox();
            submitBtn = new Button();
            textJawaban = new TextBox();
            SuspendLayout();
            // 
            // textName
            // 
            textName.BackColor = Color.OrangeRed;
            textName.Location = new Point(31, 85);
            textName.Name = "textName";
            textName.Size = new Size(159, 23);
            textName.TabIndex = 0;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.OrangeRed;
            submitBtn.ForeColor = SystemColors.ControlLightLight;
            submitBtn.Location = new Point(208, 76);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(186, 38);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // textJawaban
            // 
            textJawaban.BackColor = Color.OrangeRed;
            textJawaban.ForeColor = SystemColors.Window;
            textJawaban.Location = new Point(42, 158);
            textJawaban.Name = "textJawaban";
            textJawaban.Size = new Size(331, 23);
            textJawaban.TabIndex = 2;
            textJawaban.TextChanged += textJawaban_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 261);
            Controls.Add(textJawaban);
            Controls.Add(submitBtn);
            Controls.Add(textName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private Button submitBtn;
        private TextBox textJawaban;
    }
}
