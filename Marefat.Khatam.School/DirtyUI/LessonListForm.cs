using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirtyUI
{
    public partial class LessonListForm : Form
    {
        public LessonListForm()
        {
            InitializeComponent();
        }

        private void LessonListForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=School;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from lesson where isdeleted = 'False'";
            SqlDataReader r = cmd.ExecuteReader();
            con.Close();

        }
    }
}
