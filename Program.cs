﻿// using System;
// using System.Windows.Forms;

// public class Program
// {
//     public static Form1 form = new Form1();
//     [STAThread]
//     static void Main(string[] args)
//     {
//         form.FormLayout();;
//         Application.Run(form);
//         // MessageBox.Show("Hello, World");
//     }
// }

using System;
using System.Windows.Forms;
using System.Threading;

namespace Engine
{
    public class Program
    {
        public static Form1 form = new Form1();
        public static bool quitting = false;
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(form);
        }
    }
}
