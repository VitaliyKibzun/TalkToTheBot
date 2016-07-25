using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace TalkToTheBot2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            textBoxConversation.Text = textBoxConversation.Text + Environment.NewLine + "You: " + textBoxTypeMessage.Text;
            ReadDlls();
            textBoxTypeMessage.Clear();
        }

        private void ReadDlls()
        {
            // read all dlls
            string[] allDlls = Directory.GetFiles("..\\..\\..\\BotDlls\\", "*.dll");
            

            foreach (var dll in allDlls)
            {
                // load each dll
                Assembly asm = Assembly.LoadFrom(dll);
                Type[] types = asm.GetTypes();
                
                foreach (Type type in types)
                {
                    // continue execution only if dll is Class
                    if (!type.IsClass)
                    {
                        continue;
                    }
                    
                    // get method Answer
                    MethodInfo getAnswerMethod = type.GetMethod("Answer");
                    if (getAnswerMethod == null)
                    {
                        continue;
                    }

                    //create instance of class and execute method Answer
                    object obj = Activator.CreateInstance(type);
                    string result = (string)getAnswerMethod.Invoke(obj, new object[]{textBoxTypeMessage.Text});
                    if (!string.IsNullOrEmpty(result))
                    {
                        textBoxConversation.Text = textBoxConversation.Text + Environment.NewLine +
                            type.Namespace + ": " + result;
                        textBoxTypeMessage.Clear();
                    }
                }
            }
        }
    }
}
