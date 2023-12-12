namespace LAB10
{
    public partial class Form1 : Form
    {    public double Sum_Odd_Values( double a) 
        {
            double sum= 0;
            if (a % 2 == 0)
            {
                sum += a;
            }
            return sum;
        }
        Lab3 list= new Lab3();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {    
            string value = "";
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.ContainCharacter() || textBox1.Text=="")
                {
                    MessageBox.Show("EROR.EROR.EROR<This field can contain only digits>");
                    textBox1.Text = "";
                }
                else
                {
                     list.list.Add(Convert.ToDouble(textBox1.Text));

                    dataGridView1.Rows.Add(textBox1.Text);
                    dataGridView1.Columns.

                    textBox1.Text = "";
                }


            }


        }
    }
}
