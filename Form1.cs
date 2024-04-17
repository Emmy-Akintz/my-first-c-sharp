using System.Windows.Forms;
using System;

public class Form1 : Form
{
    public void FormLayout()
    {
        this.Name = "Form1";
        this.Text = "Multiplication Table";
        this.Size = new System.Drawing.Size(500, 500);
        this.StartPosition = FormStartPosition.CenterScreen;
    }
}