using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace search_and_metainfo
{
    public partial class get_search_parameters_form : Form
    {
        public get_search_parameters_form()
        {
            InitializeComponent();                        
        }

        private string return_val;

        private void search_btn_Click(object sender, EventArgs e)
        {
            return_val = search_term_TB.Text;
        }

        public string Return_Val
        {
           get { return return_val;}
        }

    }
}
