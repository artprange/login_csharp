using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arthu\Documents\csharp_login.mdf;Integrated Security=True;Connect Timeout=30");

        private void Menuform_Load(object sender, EventArgs e)
        {

        }
    }
}
