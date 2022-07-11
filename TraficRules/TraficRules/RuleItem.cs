using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficRules
{
    public partial class RuleItem : UserControl
    {
        public RuleItem()
        {
            InitializeComponent();
        }


        private Image _image;
        private string _imgAlt;

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; image.Image = value; }
        }

        [Category("Custom Props")]
        public string ImgAlt
        {
            get { return _imgAlt; }
            set { _imgAlt = value; imgAlt.Text = value; }
        }
    }
}
