namespace Faradars6
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.tryButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.changeColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.SystemColors.Window;
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(280, 89);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(100, 30);
            this.userInput.TabIndex = 1;
            // 
            // tryButton
            // 
            this.tryButton.BackColor = System.Drawing.SystemColors.Control;
            this.tryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryButton.Location = new System.Drawing.Point(263, 130);
            this.tryButton.Name = "tryButton";
            this.tryButton.Size = new System.Drawing.Size(133, 51);
            this.tryButton.TabIndex = 3;
            this.tryButton.Text = "Try";
            this.tryButton.UseVisualStyleBackColor = false;
            this.tryButton.Click += new System.EventHandler(this.TryButton_Click);
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "white",
            "cyan ",
            "peach puff",
            "default"});
            this.colorBox.Location = new System.Drawing.Point(563, 131);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(86, 21);
            this.colorBox.TabIndex = 4;
            this.colorBox.Text = "default";
            // 
            // changeColor
            // 
            this.changeColor.Location = new System.Drawing.Point(563, 158);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(86, 23);
            this.changeColor.TabIndex = 5;
            this.changeColor.Text = "Change color";
            this.changeColor.UseVisualStyleBackColor = true;
            this.changeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your guess:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(647, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "I have a number between 0 and 10 in my mind. can you guess it? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Changes everytime you restart the app!)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(661, 193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.tryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GuessingGame";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button tryButton;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

