
namespace compiler
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
            this.CodeBoxBS = new System.Windows.Forms.TextBox();
            this.RunCode = new System.Windows.Forms.Button();
            this.CodeBoxCS = new System.Windows.Forms.TextBox();
            this.Console = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CodeBoxBS
            // 
            this.CodeBoxBS.Location = new System.Drawing.Point(12, 12);
            this.CodeBoxBS.Multiline = true;
            this.CodeBoxBS.Name = "CodeBoxBS";
            this.CodeBoxBS.Size = new System.Drawing.Size(220, 352);
            this.CodeBoxBS.TabIndex = 0;
            this.CodeBoxBS.TextChanged += new System.EventHandler(this.CodeBoxBS_TextChanged);
            // 
            // RunCode
            // 
            this.RunCode.Location = new System.Drawing.Point(12, 360);
            this.RunCode.Name = "RunCode";
            this.RunCode.Size = new System.Drawing.Size(776, 78);
            this.RunCode.TabIndex = 1;
            this.RunCode.Text = "RunCode";
            this.RunCode.UseVisualStyleBackColor = true;
            this.RunCode.Click += new System.EventHandler(this.RunCode_Click);
            // 
            // CodeBoxCS
            // 
            this.CodeBoxCS.Location = new System.Drawing.Point(568, 12);
            this.CodeBoxCS.Multiline = true;
            this.CodeBoxCS.Name = "CodeBoxCS";
            this.CodeBoxCS.ReadOnly = true;
            this.CodeBoxCS.Size = new System.Drawing.Size(220, 352);
            this.CodeBoxCS.TabIndex = 2;
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(306, 12);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(220, 352);
            this.Console.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.CodeBoxCS);
            this.Controls.Add(this.RunCode);
            this.Controls.Add(this.CodeBoxBS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeBoxBS;
        private System.Windows.Forms.Button RunCode;
        private System.Windows.Forms.TextBox CodeBoxCS;
        private System.Windows.Forms.TextBox Console;
    }
}

