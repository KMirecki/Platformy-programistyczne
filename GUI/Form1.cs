using Problem;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_items.BackColor = Color.White;
            textBox_seed.BackColor = Color.White;
            textBox_capacity.BackColor = Color.White;
            int parsedValue;
            string n = textBox_items.Text;
            string seed = textBox_seed.Text;
            string capacity = textBox_capacity.Text;
            bool flag1 = true, flag2 = true ,flag3 = true;
            if ((string.IsNullOrEmpty(textBox_items.Text) || !int.TryParse(textBox_items.Text, out parsedValue)))
            {
                textBox_items.BackColor = Color.Red;
                flag1 = false;

            }
            
            if ((string.IsNullOrEmpty(textBox_seed.Text) || !int.TryParse(textBox_seed.Text, out parsedValue)))
            {
                textBox_seed.BackColor = Color.Red;
                flag2 = false;
            }

            if ((string.IsNullOrEmpty(textBox_capacity.Text) || !int.TryParse(textBox_capacity.Text, out parsedValue)))
            {
                textBox_capacity.BackColor = Color.Red;
                flag3 = false;
            }
            
            if(flag1 && flag2 && flag3)
            {
                Plecak plecak = new Plecak(int.Parse(n), int.Parse(seed)); ;
                textBox_results.Text = plecak.Solve(int.Parse(capacity)).ToString();
                textBox_instance.Text = string.Join(Environment.NewLine, plecak.GenerateItems(int.Parse(n), int.Parse(seed)));
            }
            else
            {
                MessageBox.Show("Niepoprawne dane wejsciowe");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_items.BackColor = Color.White;
            textBox_seed.BackColor = Color.White;
            textBox_capacity.BackColor = Color.White;
            int parsedValue;
            string n = textBox_items.Text;
            string seed = textBox_seed.Text;
            string capacity = textBox_capacity.Text; bool flag1 = true, flag2 = true, flag3 = true;
            if ((string.IsNullOrEmpty(textBox_items.Text) || !int.TryParse(textBox_items.Text, out parsedValue)))
            {
                textBox_items.BackColor = Color.Red;
                flag1 = false;

            }

            if ((string.IsNullOrEmpty(textBox_seed.Text) || !int.TryParse(textBox_seed.Text, out parsedValue)))
            {
                textBox_seed.BackColor = Color.Red;
                flag2 = false;
            }

            if ((string.IsNullOrEmpty(textBox_capacity.Text) || !int.TryParse(textBox_capacity.Text, out parsedValue)))
            {
                textBox_capacity.BackColor = Color.Red;
                flag3 = false;
            }

            if (flag1 && flag2 && flag3)
            {
                Plecak plecak = new Plecak(int.Parse(n), int.Parse(seed)); ;
                textBox_results.Text = plecak.Solve2(int.Parse(capacity)).ToString();
                textBox_instance.Text = string.Join(Environment.NewLine, plecak.GenerateItems(int.Parse(n), int.Parse(seed)));
            }
            else
            {
                MessageBox.Show("Niepoprawne dane wejsciowe");
            }
        }
    }
}
