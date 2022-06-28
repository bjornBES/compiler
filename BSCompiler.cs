using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compiler
{
    public class BSCompiler
    {
        public string[] S_Code;
        public Compileren compileren;
        public string[] GetCode(string codeCS)
        {
            codeCS = codeCS.Replace(':', '{');
            codeCS = codeCS.Replace('.', '*');
            S_Code = codeCS.Split(' ');
            if (compileren == null)
                compileren = new Compileren();
            return S_Code;
        }
    }
    public class Compileren
    {
        public string Compil(string[] code)
        {
            string[] FunName = new string[100];
            int FunNameIndex = 0;
            string[] ClassName = new string[100];
            int ClassNameIndex = 0;
            string[] GetName = new string[100];
            int GetNameIndex = 0;
            string Output = "";
            for (int i = 0; i < code.Length; i++)
            {
                /*
                 using System; 
                 \r\nclass Program 
                 \r\n{\r\n
                 public void Main()
                 \r\n{\r\n
                 \r\n}\r\n
                 \r\n}\r\n
 Get System 
 class Program : 
 StartF : 
 end 
 end 
                */
                int II = i + 1;
                switch (code[i])
                {
                    default:
                        for (int N = 0; N < FunNameIndex; N++)
                        {
                            if (FunName[N] + "()" == code[i])
                                Output = Output + code[i] + " ";
                        }
                        for (int N = 0; N < ClassNameIndex; N++)
                        {
                            if (ClassName[N] == code[i])
                                Output = Output + code[i] + " ";
                        }
                        for (int N = 0; N < GetNameIndex; N++)
                        {
                            if (GetName[N] == code[i])
                                Output = Output + code[i] + "; ";
                        }
                        break;
                    case "Fun":
                        Output = Output + "void ";
                        FunName[FunNameIndex] = code[II];
                        FunNameIndex++;
                        break;
                    case "class":
                        Output = Output + "class ";
                        ClassName[ClassNameIndex] = code[II];
                        ClassNameIndex++;
                        break;
                    case "{":
                        Output = Output + " \r\n{\r\n ";
                        break;
                    case "end":
                        Output = Output + " \r\n}\r\n ";
                        break;
                    case "Get":
                        Output = Output + "using";
                        if(code[II] != "System")
                        {
                            GetName[GetNameIndex] = code[II];
                            GetNameIndex++;
                        }
                        break;
                    case "System":
                        Output = Output + " System; \r\n ";
                        break;
                    case "P":
                        Output = Output + "public ";
                        break;
                    case "StartF":
                        Output = Output + "public static void Main() ";
                        break;
                }
            }
            return Output;
        }
    }
}
