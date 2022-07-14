
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CodeTap = new System.Windows.Forms.Button();
            this.DocsTap = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.TextBox();
            this.RunCode = new System.Windows.Forms.Button();
            this.CodeBoxCS = new System.Windows.Forms.TextBox();
            this.CodeBoxBS = new System.Windows.Forms.TextBox();
            this.TapCode = new System.Windows.Forms.TableLayoutPanel();
            this.TapDosc = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.TapCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CodeTap, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DocsTap, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(104, 423);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // CodeTap
            // 
            this.CodeTap.Location = new System.Drawing.Point(3, 3);
            this.CodeTap.Name = "CodeTap";
            this.CodeTap.Size = new System.Drawing.Size(98, 205);
            this.CodeTap.TabIndex = 0;
            this.CodeTap.Text = "Code";
            this.CodeTap.UseVisualStyleBackColor = true;
            this.CodeTap.Click += new System.EventHandler(this.CodeTap_Click);
            // 
            // DocsTap
            // 
            this.DocsTap.Location = new System.Drawing.Point(3, 214);
            this.DocsTap.Name = "DocsTap";
            this.DocsTap.Size = new System.Drawing.Size(98, 206);
            this.DocsTap.TabIndex = 1;
            this.DocsTap.Text = "Docs";
            this.DocsTap.UseVisualStyleBackColor = true;
            this.DocsTap.Click += new System.EventHandler(this.DocsTap_Click);
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(337, 3);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(329, 207);
            this.Console.TabIndex = 3;
            // 
            // RunCode
            // 
            this.RunCode.Location = new System.Drawing.Point(3, 216);
            this.RunCode.Name = "RunCode";
            this.RunCode.Size = new System.Drawing.Size(328, 207);
            this.RunCode.TabIndex = 1;
            this.RunCode.Text = "RunCode";
            this.RunCode.UseVisualStyleBackColor = true;
            this.RunCode.Click += new System.EventHandler(this.RunCode_Click);
            // 
            // CodeBoxCS
            // 
            this.CodeBoxCS.Location = new System.Drawing.Point(337, 216);
            this.CodeBoxCS.Multiline = true;
            this.CodeBoxCS.Name = "CodeBoxCS";
            this.CodeBoxCS.ReadOnly = true;
            this.CodeBoxCS.Size = new System.Drawing.Size(260, 114);
            this.CodeBoxCS.TabIndex = 2;
            // 
            // CodeBoxBS
            // 
            this.CodeBoxBS.Location = new System.Drawing.Point(3, 3);
            this.CodeBoxBS.Multiline = true;
            this.CodeBoxBS.Name = "CodeBoxBS";
            this.CodeBoxBS.Size = new System.Drawing.Size(328, 207);
            this.CodeBoxBS.TabIndex = 0;
            this.CodeBoxBS.TextChanged += new System.EventHandler(this.CodeBoxBS_TextChanged);
            // 
            // TapCode
            // 
            this.TapCode.ColumnCount = 2;
            this.TapCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapCode.Controls.Add(this.CodeBoxBS, 0, 0);
            this.TapCode.Controls.Add(this.CodeBoxCS, 1, 1);
            this.TapCode.Controls.Add(this.RunCode, 0, 1);
            this.TapCode.Controls.Add(this.Console, 1, 0);
            this.TapCode.Location = new System.Drawing.Point(119, 12);
            this.TapCode.Name = "TapCode";
            this.TapCode.RowCount = 2;
            this.TapCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TapCode.Size = new System.Drawing.Size(669, 426);
            this.TapCode.TabIndex = 4;
            // 
            // TapDosc
            // 
            this.TapDosc.ColumnCount = 2;
            this.TapDosc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapDosc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapDosc.Location = new System.Drawing.Point(119, 12);
            this.TapDosc.Name = "TapDosc";
            this.TapDosc.RowCount = 2;
            this.TapDosc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapDosc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapDosc.Size = new System.Drawing.Size(669, 426);
            this.TapDosc.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TapDosc);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.TapCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TapCode.ResumeLayout(false);
            this.TapCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CodeTap;
        private System.Windows.Forms.Button DocsTap;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Button RunCode;
        private System.Windows.Forms.TextBox CodeBoxCS;
        private System.Windows.Forms.TextBox CodeBoxBS;
        private System.Windows.Forms.TableLayoutPanel TapCode;
        private System.Windows.Forms.TableLayoutPanel TapDosc;
    }
}

