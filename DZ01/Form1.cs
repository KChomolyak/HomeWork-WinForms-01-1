namespace DZ01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object Form1, EventArgs e)
        {
            int top = 11;
            int left = 11;
            foreach(Control control in Controls) 
            {
                if (control as Button != null) 
                {
                    if (left + 4 + control.Width > ClientSize.Width/3*2) 
                    {
                        top += 50;
                        left = 11;
                    }
                    control.Top = top;
                    control.Left = left;
                    left += control.Width + 4;
                }
            }
        }

        private void btNavy_Click(object sender, EventArgs e)
        {

        }
    }
}