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

namespace 방명록
{
    public partial class WriteNew : Form  
    {
        string connStr = "Data Source=localhost;Initial Catalog=testDB;Integrated Security=True";

        public WriteNew()
        {
            InitializeComponent();
        }


        private void btn_save_Click(object sender, EventArgs e)   // 저장 버튼 클릭
        {
            string title = tbox_title.Text;       // 제목 
            string writer = tbox_writer.Text;     // 작성자 
            string content = tbox_content.Text;   // 내용
            string inputdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");   // inputdate : 현재시간   // "yyyy-MM-dd HH:mm:ss"

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO guestbook(title, writer, content, inputdate) VALUES (@title, @writer, @content, @inputdate)", conn))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@writer", writer);
                    command.Parameters.AddWithValue("@content", content);
                    command.Parameters.AddWithValue("@inputdate", inputdate);

                    command.ExecuteNonQuery();
                }
            }

            this.Close();
            ViewRefresh();      
                               
        }

        private void btn_cancel_Click(object sender, EventArgs e)  // 취소 버튼 클릭
        {
            Close();
            ViewRefresh();   
        }



        private void ViewRefresh()
        {
            Main main_form = (Main)Application.OpenForms["Main"];
            main_form.ViewRefresh();
        }

      
    }
}
