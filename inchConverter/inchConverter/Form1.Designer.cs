namespace inchConverter
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.direction = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(22, 157);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(271, 44);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Umrechnen";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "inch->cm & cm->inch converter";
            // 
            // direction
            // 
            this.direction.FormattingEnabled = true;
            this.direction.Items.AddRange(new object[] {
            "inch->cm",
            "cm->inch"});
            this.direction.Location = new System.Drawing.Point(22, 109);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(271, 23);
            this.direction.TabIndex = 2;
            this.direction.Text = "inch->cm";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(22, 71);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(271, 23);
            this.inputBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 234);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculateBtn;
        private Label label1;
        private ComboBox direction;
        private TextBox inputBox;
    }
}