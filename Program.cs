using System;
using System.Windows.Forms;

public class Program
{
    public static Form1 form = new Form1();
    [STAThread]
    static void Main(string[] args)
    {
        form.FormLayout();;
        Application.Run(form);
    }
}