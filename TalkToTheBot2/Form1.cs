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
        // Create list with the collected data from each dll.
        private List<Tuple<MethodInfo, object, string>> infoCollectedFromDlls = new List<Tuple<MethodInfo, object, string>>();
        private object createObj;

        public Form1()
        {
            InitializeComponent();
            ReadDlls();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            textBoxConversation.Text = textBoxConversation.Text + Environment.NewLine + "You: " + textBoxTypeMessage.Text;
            CallMethods();
            textBoxTypeMessage.Clear();
        }

        private void CallMethods()
        {
            foreach (var method in infoCollectedFromDlls)
            {
                MethodInfo answerMethod = method.Item1;
                object classInstance = method.Item2;
                string classNamespace = method.Item3;
                string result = (string)answerMethod.Invoke(classInstance, new object[] { textBoxTypeMessage.Text });
                if (!string.IsNullOrEmpty(result))
                {
                    textBoxConversation.Text = textBoxConversation.Text + Environment.NewLine +
                       classNamespace + ": " + result;
                    textBoxTypeMessage.Clear();
                }
            }
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

                    // get namespace
                    string getNamespace = type.Namespace;
                    
                    if (getAnswerMethod == null)
                    {
                        continue;
                    }

                    //create instance of class
                    createObj = Activator.CreateInstance(type);

                    // Add collected data to the list.
                    infoCollectedFromDlls.Add(new Tuple<MethodInfo, object, string>(getAnswerMethod,createObj,getNamespace));
                }
            }
        }
    }
}
