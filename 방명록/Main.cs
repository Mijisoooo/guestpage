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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace 방명록
{
    public partial class Main : Form
    {
        string connStr = "Data Source=localhost;Initial Catalog=testDB;Integrated Security=True";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel_detail.Hide();
            panel_edit.Hide();
            dgview_guestbook.RowHeadersVisible = false;
            ViewRefresh();
        }

        private void btn_new_Click(object sender, EventArgs e)     // 새글작성 버튼 클릭 
        {
            WriteNew newForm = new WriteNew();
            newForm.ShowDialog();                                  
        }

        private int selectedTableno;

        private void dgview_guestbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_detail.Location = new Point(802, 76);  

            try
            {
                selectedTableno = Convert.ToInt32(dgview_guestbook.Rows[e.RowIndex].Cells["번호"].Value); 

                //if (dgview_guestbook.CurrentCell == null || dgview_guestbook.CurrentCell.Value == null)       // 내용없는 cell 클릭 시 
                //{
                //    panel_detail.Visible = false;
                //}
            }
            catch 
            {
                panel_detail.Visible = false;
                return;
            }
              
            // panel_detail, panel_edit 에 해당 row 정보 뿌리기 
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM guestbook WHERE tableno = @tableno", conn))
                {
                    command.Parameters.AddWithValue("@tableno", selectedTableno);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string title = reader["title"].ToString();
                            string writer = reader["writer"].ToString();
                            string inputdate = reader["inputdate"].ToString();
                            string editdate = reader["editdate"].ToString();
                            string content = reader["content"].ToString();

                            // panel_detail 
                            lbl_title.Text = title;
                            lbl_writer.Text = writer;
                            lbl_inputdate.Text = inputdate;
                            lbl_editdate.Text = editdate;
                            lbl_content.Text = content;

                            // panel_edit 
                            tbox_title_edit.Text = title;
                            lbl_writer_edit.Text = writer;
                            lbl_date_edit.Text = inputdate;
                            lbl_editdate_edit.Text = editdate;
                            tbox_content_edit.Text = content;
                        }
                    }
                }
            }

            if (panel_edit.Visible)
            {
                MessageBox.Show("수정을 취소합니다.");
                panel_edit.Visible = false;
            }

            panel_detail.Visible = true;

        }

        private void btn_edit1_Click(object sender, EventArgs e)    // panel_detail 에서 수정 버튼 클릭 -> panel_edit 창으로 넘어감 
        {
            panel_detail.Visible = false;
            panel_edit.Location = new Point(802, 76);
            panel_edit.Visible = true;
        }

        private void btn_edit2_Click(object sender, EventArgs e)   // panel_edit 에서 수정 버튼 클릭 
        {
            DialogResult result1 = MessageBox.Show("해당 글을 수정할까요?", "!", MessageBoxButtons.YesNo);     // 수정 전에 다시 묻기

            if (result1 == DialogResult.Yes)             // 예 클릭 -> 수정 
            {
                int tableno = selectedTableno;
                string title = tbox_title_edit.Text;
                string content = tbox_content_edit.Text;
                string editdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("UPDATE guestbook SET title = @title, content = @content, editdate = @editdate WHERE tableno = @tableno", conn))
                    {
                        command.Parameters.AddWithValue("@tableno", tableno);
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@content", content);
                        command.Parameters.AddWithValue("@editdate", editdate);
                        command.ExecuteNonQuery();
                    }
                }
            }

            else                                           // 아니오 클릭 -> 수정 취소 
            {
                int rowIndex = dgview_guestbook.CurrentCell.RowIndex;
                tbox_title_edit.Text = dgview_guestbook.Rows[rowIndex].Cells["제목"].Value.ToString();      // 제목 원래대로 돌리기
                tbox_content_edit.Text = dgview_guestbook.Rows[rowIndex].Cells["내용"].Value.ToString();    // 내용 원래대로 돌리기
            }
            panel_detail.Visible = false;
            ViewRefresh();

        }

        private void btn_del1_Click(object sender, EventArgs e)     // panel_detail, panel_edit 의 삭제 버튼 클릭 시 
        {
            DialogResult result2 = MessageBox.Show("해당 글을 삭제할까요?", "!", MessageBoxButtons.YesNo);     // 삭제 전에 다시 묻기

            if (result2 == DialogResult.Yes)            // 예 클릭 -> 삭제 처리 
            {
                int tableno = selectedTableno;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM guestbook where tableno = @tableno", conn))
                    {
                        command.Parameters.AddWithValue("@tableno", tableno);
                        command.ExecuteNonQuery();
                    }
                }
            }
            
            panel_edit.Visible = false;                 // 아니오 클릭 -> 삭제 안됨 
            ViewRefresh();
        }


        public void ViewRefresh()                       // datagridview 새로고침
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT tableno as 번호, title as 제목, writer as 작성자, content as 내용, CONVERT(CHAR(19), inputdate, 20) as 작성일시, CONVERT(CHAR(19), editdate, 20) as 수정일시 FROM guestbook", conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable guestbook_table = new DataTable();
                        adapter.Fill(guestbook_table);

                        dgview_guestbook.DataSource = guestbook_table;
                    }
                }
            }

            dgview_guestbook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;                               // dgview_guestbook에 테이블 꽉 채우기 
            dgview_guestbook.AutoResizeColumns();                                                                      // 컬럼 사이즈 변경 (제일 큰 것에 맞춰서)
            dgview_guestbook.Columns["번호"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;   // 번호 컬럼 가운데 정렬
            dgview_guestbook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;      // 헤더 가운데 정렬 

            dgview_guestbook.ClearSelection();
        }

    }
}

    

