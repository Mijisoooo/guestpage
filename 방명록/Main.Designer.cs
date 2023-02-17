namespace 방명록
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_new = new System.Windows.Forms.Button();
            this.dgview_guestbook = new System.Windows.Forms.DataGridView();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.lbl_editdate_edit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_writer_edit = new System.Windows.Forms.Label();
            this.btn_del2 = new System.Windows.Forms.Button();
            this.btn_edit2 = new System.Windows.Forms.Button();
            this.tbox_title_edit = new System.Windows.Forms.TextBox();
            this.lbl_date_edit = new System.Windows.Forms.Label();
            this.tbox_content_edit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_detail = new System.Windows.Forms.Panel();
            this.lbl_editdate = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_writer = new System.Windows.Forms.Label();
            this.btn_del1 = new System.Windows.Forms.Button();
            this.btn_edit1 = new System.Windows.Forms.Button();
            this.lbl_inputdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_guestbook)).BeginInit();
            this.panel_edit.SuspendLayout();
            this.panel_detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 19);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(90, 39);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "새글작성";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // dgview_guestbook
            // 
            this.dgview_guestbook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview_guestbook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview_guestbook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgview_guestbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_guestbook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgview_guestbook.EnableHeadersVisualStyles = false;
            this.dgview_guestbook.Location = new System.Drawing.Point(12, 76);
            this.dgview_guestbook.Name = "dgview_guestbook";
            this.dgview_guestbook.ReadOnly = true;
            this.dgview_guestbook.RowTemplate.Height = 23;
            this.dgview_guestbook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview_guestbook.Size = new System.Drawing.Size(773, 602);
            this.dgview_guestbook.TabIndex = 1;
            this.dgview_guestbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_guestbook_CellClick);
            // 
            // panel_edit
            // 
            this.panel_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_edit.Controls.Add(this.lbl_editdate_edit);
            this.panel_edit.Controls.Add(this.label2);
            this.panel_edit.Controls.Add(this.lbl_writer_edit);
            this.panel_edit.Controls.Add(this.btn_del2);
            this.panel_edit.Controls.Add(this.btn_edit2);
            this.panel_edit.Controls.Add(this.tbox_title_edit);
            this.panel_edit.Controls.Add(this.lbl_date_edit);
            this.panel_edit.Controls.Add(this.tbox_content_edit);
            this.panel_edit.Controls.Add(this.label8);
            this.panel_edit.Controls.Add(this.label7);
            this.panel_edit.Controls.Add(this.label6);
            this.panel_edit.Controls.Add(this.label4);
            this.panel_edit.Location = new System.Drawing.Point(802, 76);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(450, 600);
            this.panel_edit.TabIndex = 2;
            // 
            // lbl_editdate_edit
            // 
            this.lbl_editdate_edit.AutoSize = true;
            this.lbl_editdate_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_editdate_edit.Location = new System.Drawing.Point(75, 120);
            this.lbl_editdate_edit.Name = "lbl_editdate_edit";
            this.lbl_editdate_edit.Size = new System.Drawing.Size(113, 12);
            this.lbl_editdate_edit.TabIndex = 25;
            this.lbl_editdate_edit.Text = "####-##-## ##:##:##";
            this.lbl_editdate_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "수정일시";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_writer_edit
            // 
            this.lbl_writer_edit.AutoSize = true;
            this.lbl_writer_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_writer_edit.Location = new System.Drawing.Point(75, 54);
            this.lbl_writer_edit.Name = "lbl_writer_edit";
            this.lbl_writer_edit.Size = new System.Drawing.Size(53, 12);
            this.lbl_writer_edit.TabIndex = 19;
            this.lbl_writer_edit.Text = "작성자명";
            this.lbl_writer_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_del2
            // 
            this.btn_del2.Location = new System.Drawing.Point(242, 545);
            this.btn_del2.Name = "btn_del2";
            this.btn_del2.Size = new System.Drawing.Size(74, 45);
            this.btn_del2.TabIndex = 18;
            this.btn_del2.Text = "삭제";
            this.btn_del2.UseVisualStyleBackColor = true;
            this.btn_del2.Click += new System.EventHandler(this.btn_del1_Click);
            // 
            // btn_edit2
            // 
            this.btn_edit2.Location = new System.Drawing.Point(152, 545);
            this.btn_edit2.Name = "btn_edit2";
            this.btn_edit2.Size = new System.Drawing.Size(74, 45);
            this.btn_edit2.TabIndex = 17;
            this.btn_edit2.Text = "수정";
            this.btn_edit2.UseVisualStyleBackColor = true;
            this.btn_edit2.Click += new System.EventHandler(this.btn_edit2_Click);
            // 
            // tbox_title_edit
            // 
            this.tbox_title_edit.Location = new System.Drawing.Point(72, 14);
            this.tbox_title_edit.Multiline = true;
            this.tbox_title_edit.Name = "tbox_title_edit";
            this.tbox_title_edit.Size = new System.Drawing.Size(361, 22);
            this.tbox_title_edit.TabIndex = 16;
            // 
            // lbl_date_edit
            // 
            this.lbl_date_edit.AutoSize = true;
            this.lbl_date_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_date_edit.Location = new System.Drawing.Point(75, 87);
            this.lbl_date_edit.Name = "lbl_date_edit";
            this.lbl_date_edit.Size = new System.Drawing.Size(113, 12);
            this.lbl_date_edit.TabIndex = 15;
            this.lbl_date_edit.Text = "####-##-## ##:##:##";
            this.lbl_date_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbox_content_edit
            // 
            this.tbox_content_edit.Location = new System.Drawing.Point(14, 176);
            this.tbox_content_edit.Multiline = true;
            this.tbox_content_edit.Name = "tbox_content_edit";
            this.tbox_content_edit.Size = new System.Drawing.Size(419, 363);
            this.tbox_content_edit.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "내용";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "작성일시";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "작성자";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "제목";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_detail
            // 
            this.panel_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_detail.Controls.Add(this.lbl_editdate);
            this.panel_detail.Controls.Add(this.label);
            this.panel_detail.Controls.Add(this.lbl_content);
            this.panel_detail.Controls.Add(this.lbl_title);
            this.panel_detail.Controls.Add(this.lbl_writer);
            this.panel_detail.Controls.Add(this.btn_del1);
            this.panel_detail.Controls.Add(this.btn_edit1);
            this.panel_detail.Controls.Add(this.lbl_inputdate);
            this.panel_detail.Controls.Add(this.label3);
            this.panel_detail.Controls.Add(this.label5);
            this.panel_detail.Controls.Add(this.label9);
            this.panel_detail.Controls.Add(this.label10);
            this.panel_detail.Location = new System.Drawing.Point(319, 76);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(450, 600);
            this.panel_detail.TabIndex = 3;
            // 
            // lbl_editdate
            // 
            this.lbl_editdate.AutoSize = true;
            this.lbl_editdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_editdate.Location = new System.Drawing.Point(75, 118);
            this.lbl_editdate.Name = "lbl_editdate";
            this.lbl_editdate.Size = new System.Drawing.Size(113, 12);
            this.lbl_editdate.TabIndex = 23;
            this.lbl_editdate.Text = "####-##-## ##:##:##";
            this.lbl_editdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 118);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 12);
            this.label.TabIndex = 22;
            this.label.Text = "수정일시";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_content.Location = new System.Drawing.Point(12, 183);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(93, 12);
            this.lbl_content.TabIndex = 21;
            this.lbl_content.Text = "글 내용 입니다. ";
            this.lbl_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_title.Location = new System.Drawing.Point(75, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(47, 12);
            this.lbl_title.TabIndex = 20;
            this.lbl_title.Text = "글제목1";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_writer
            // 
            this.lbl_writer.AutoSize = true;
            this.lbl_writer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_writer.Location = new System.Drawing.Point(75, 52);
            this.lbl_writer.Name = "lbl_writer";
            this.lbl_writer.Size = new System.Drawing.Size(47, 12);
            this.lbl_writer.TabIndex = 19;
            this.lbl_writer.Text = "작성자1";
            this.lbl_writer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_del1
            // 
            this.btn_del1.Location = new System.Drawing.Point(242, 545);
            this.btn_del1.Name = "btn_del1";
            this.btn_del1.Size = new System.Drawing.Size(74, 45);
            this.btn_del1.TabIndex = 18;
            this.btn_del1.Text = "삭제";
            this.btn_del1.UseVisualStyleBackColor = true;
            this.btn_del1.Click += new System.EventHandler(this.btn_del1_Click);
            // 
            // btn_edit1
            // 
            this.btn_edit1.Location = new System.Drawing.Point(152, 545);
            this.btn_edit1.Name = "btn_edit1";
            this.btn_edit1.Size = new System.Drawing.Size(74, 45);
            this.btn_edit1.TabIndex = 17;
            this.btn_edit1.Text = "수정";
            this.btn_edit1.UseVisualStyleBackColor = true;
            this.btn_edit1.Click += new System.EventHandler(this.btn_edit1_Click);
            // 
            // lbl_inputdate
            // 
            this.lbl_inputdate.AutoSize = true;
            this.lbl_inputdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_inputdate.Location = new System.Drawing.Point(75, 85);
            this.lbl_inputdate.Name = "lbl_inputdate";
            this.lbl_inputdate.Size = new System.Drawing.Size(113, 12);
            this.lbl_inputdate.TabIndex = 15;
            this.lbl_inputdate.Text = "####-##-## ##:##:##";
            this.lbl_inputdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "내용";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "작성일시";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "작성자";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "제목";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_detail);
            this.Controls.Add(this.panel_edit);
            this.Controls.Add(this.dgview_guestbook);
            this.Controls.Add(this.btn_new);
            this.Name = "Main";
            this.Text = "방명록";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_guestbook)).EndInit();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.panel_detail.ResumeLayout(false);
            this.panel_detail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dgview_guestbook;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Button btn_del2;
        private System.Windows.Forms.Button btn_edit2;
        private System.Windows.Forms.TextBox tbox_title_edit;
        private System.Windows.Forms.Label lbl_date_edit;
        private System.Windows.Forms.TextBox tbox_content_edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_writer_edit;
        private System.Windows.Forms.Panel panel_detail;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_writer;
        private System.Windows.Forms.Button btn_del1;
        private System.Windows.Forms.Button btn_edit1;
        private System.Windows.Forms.Label lbl_inputdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_editdate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_editdate_edit;
        private System.Windows.Forms.Label label2;
    }
}

