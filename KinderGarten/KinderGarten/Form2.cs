using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinderGarten
{
    public partial class Form2 : Form
    {
        public static bool isNew = true;
        public static int updateId = 0;
        Child oldChild;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!isNew)
            {
                oldChild = Children.GetById(updateId);
                firstName.Text = oldChild.FirstName;
                lastName.Text = oldChild.LastName;
                responsiblePerson.Text = oldChild.ResponsiblePerson;
                age.Text = oldChild.Age;
                address.Text = oldChild.Address;
                titleText.Text = oldChild.FirstName + " " + oldChild.LastName + " ma'lumotlari";
            }
            else
            {
                titleText.Text = "Yangi bola ma'lumotlarini kiriting";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                var newChild = new Child();
                newChild.FirstName = firstName.Text;
                newChild.LastName = lastName.Text;
                newChild.ResponsiblePerson = responsiblePerson.Text;
                newChild.Age = age.Text;
                newChild.Address = address.Text;
                newChild = Children.Create(newChild);
            }
            else
            {
                oldChild.FirstName = firstName.Text;
                oldChild.LastName = lastName.Text;
                oldChild.ResponsiblePerson = responsiblePerson.Text;
                oldChild.Age = age.Text;
                oldChild.Address = address.Text;
                oldChild = Children.Update(oldChild);
            }
            isNew = true;
            ClearData();
            this.Close();
        }

        void ClearData()
        {
            firstName.Text = "";
            lastName.Text = "";
            responsiblePerson.Text = "";
            age.Text = "";
            address.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isNew = true;
            ClearData();
            this.Close();
        }
    }
}
