namespace CourseWork
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Saqlash tugmasi bosilganda ma'lumotlarni tekshirib
        // ular to'g'ri bo'lganda talabalar ro'yxatiga qo'shadi
        private void save_Click(object sender, EventArgs e)
        {
            var _fName = fName.Text.Trim();
            var _lName = lName.Text.Trim();
            var _groupNumber = groupNumber.Text.Trim();
            var _currentMark = currentMark.Text.Trim();
            var _middleMark = middleMark.Text.Trim();
            var _finalMark = finalMark.Text.Trim();

            if (
                _fName.Length == 0 ||
                _lName.Length == 0 ||
                _groupNumber.Length == 0 ||
                _currentMark.Length == 0 ||
                _middleMark.Length == 0 ||
                _finalMark.Length ==0
                )
            {
                errorMsg.Text = "Barcha ma'lumotlar kiritilishi lozim!!!";
            }

            else
            {
                var student = Students.Create(
                    _fName,
                    _lName,
                    _groupNumber,
                    Convert.ToInt32(_currentMark),
                    Convert.ToInt32(_middleMark),
                    Convert.ToInt32(_finalMark)
                );
                MessageBox.Show($"{student.FirstName} {student.LastName} talabalar ro'yxatiga qo'shildi!");
                Close();
            }
        }

        // Talabalar bahosini kiritish qismi faqat raqamlarni qabul qiladi
        private void currentMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
