namespace Ex_Logica_Simix
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            
        }


        public string printCalc(int i) {

            if (i % 3 == 0 & i % 5 == 0)
            {
                return "Z";
            }else if(i % 3 == 0){
                return "X";
            }else if(i % 5 == 0)
            {
                return "Y";
            }
            return i.ToString();
  
        }


        private void richTextBox(object sender, EventArgs e)
        {
            for (int i = 1; i < 201; i++)
            {
                richTextBox1.AppendText(printCalc(i) + (i != 200 ? " , " : ""));

            }
        }
    }
}