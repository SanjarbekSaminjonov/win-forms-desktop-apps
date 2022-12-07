using System.Net.Http.Headers;

namespace CrossWord
{
    public partial class Form1 : Form
    {
        string[] questions = new string[]
        {
            "Savollar ro'yxati", 
            "So'z ulardan tashkil topadi", // 1-savol
            "Yozuvchining ijod mahsuli", // 2-savol
            "Xushboy suyuqlik", // 3-savol
            "100 yillik", // 4-savol
            "Mahsulotning yoki ishning yaroqlilik darajasi", // 5-savol 
        };

        string[] answers = new string[]
        {
            "H", "A", "R", "F", "A", "S", "R", "T", 
            "I", "R", "A", "S", "S", "I", "F", "A"
        };

        List<TextBox> textBoxes = new List<TextBox> { };

        public Form1()
        {
            InitializeComponent();
        }

        void bgWhite()
        {
            foreach (var textBox in textBoxes)
            {
                textBox.BackColor = Color.White;
            }
        }

        void bgFocus(byte[] indexes)
        {
            bgWhite();
            foreach (var index in indexes)
            {
                textBoxes[index].BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            }
        }

        void writeQuestion(byte index)
        {
            questionLabel.Text = questions[index];
            if (index == 1)
            {
                bgFocus(new byte[] { 0, 1, 2, 3 });
            }
            else if (index == 2)
            {
                bgFocus(new byte[] { 1, 4, 5, 6 });
            }
            else if (index == 3)
            {
                bgFocus(new byte[] { 4, 7, 8, 9 });
            }
            else if (index == 4)
            {
                bgFocus(new byte[] { 10, 11, 9 });
            }
            else if (index == 5)
            {
                bgFocus(new byte[] { 12, 13, 14, 15, 7 });
            }
        }

        void checkAnswers()
        {
            bool complated = false;

            for (var i = 0; i < answers.Length; i++)
            {
                if (textBoxes[i].Text.ToUpper() == answers[i])
                {
                    textBoxes[i].Enabled = false;
                    textBoxes[i].BorderStyle = BorderStyle.FixedSingle;
                }
                complated = complated || textBoxes[i].Enabled;
            }

            if (!complated)
            {
                MessageBox.Show("Tabriklayman!!!\n Siz barchasini to'g'ri topdigiz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxes.Add(this.textBox1);
            textBoxes.Add(this.textBox2);
            textBoxes.Add(this.textBox3);
            textBoxes.Add(this.textBox4);
            textBoxes.Add(this.textBox5);
            textBoxes.Add(this.textBox6);
            textBoxes.Add(this.textBox7);
            textBoxes.Add(this.textBox8);
            textBoxes.Add(this.textBox9);
            textBoxes.Add(this.textBox10);
            textBoxes.Add(this.textBox11);
            textBoxes.Add(this.textBox12);
            textBoxes.Add(this.textBox13);
            textBoxes.Add(this.textBox14);
            textBoxes.Add(this.textBox15);
            textBoxes.Add(this.textBox16);

            foreach (var textBox in textBoxes)
            {
                textBox.MaxLength = 1;
            }

            writeQuestion(1);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            writeQuestion(1);
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            writeQuestion(2);
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            writeQuestion(3);
        }

        private void textBox11_MouseClick(object sender, MouseEventArgs e)
        {
            writeQuestion(4);
        }

        private void textBox13_MouseClick(object sender, MouseEventArgs e)
        {
            writeQuestion(5);
        }

        private void check_Click(object sender, EventArgs e)
        {
            checkAnswers();
        }
    }
}