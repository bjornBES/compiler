using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compiler
{
    public partial class Form1 : Form
    {
        public string CodeFBSTCS;
        public Form1()
        {
            TapCode.Hide();
            TapDosc.Hide();
            InitializeComponent();
        }

        private void RunCode_Click(object sender, EventArgs e)
        {
            BSCompiler bSCompiler = new BSCompiler();
            bSCompiler.GetCode(CodeBoxBS.Text);
            CodeFBSTCS = bSCompiler.compileren.Compil(bSCompiler.S_Code);
            Console.Text = "";
            CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "ConpilerVersion", "v4.0" } });
            CompilerParameters parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, "Run.exe", true);
            parameters.GenerateExecutable = true;
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, CodeFBSTCS);
            if (results.Errors.HasErrors)
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.Text += error.ErrorText + "\r\n");
            else
            {
                Console.Text = "Ok";
                Process.Start(Application.StartupPath + "/" + "Run.exe");
                CodeBoxCS.Text = CodeFBSTCS;
            }
        }

        private void CodeBoxBS_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodeTap_Click(object sender, EventArgs e)
        {
            TapCode.Show();
            TapDosc.Hide();
        }

        private void DocsTap_Click(object sender, EventArgs e)
        {
            TapCode.Hide();
            TapDosc.Show();
        }
    }
}
