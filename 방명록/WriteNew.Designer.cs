namespace 방명록
{
    partial class WriteNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_new = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbox_title = new System.Windows.Forms.TextBox();
            this.tbox_writer = new System.Windows.Forms.TextBox();
            this.tbox_content = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_new.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_new
            // 
            this.panel_new.Controls.Add(this.btn_cancel);
            this.panel_new.Controls.Add(this.btn_save);
            this.panel_new.Controls.Add(this.tbox_title);
            this.panel_new.Controls.Add(this.tbox_writer);
            this.panel_new.Controls.Add(this.tbox_content);
            this.panel_new.Controls.Add(this.label8);
            this.panel_new.Controls.Add(this.label6);
            this.panel_new.Controls.Add(this.label4);
            this.panel_new.Location = new System.Drawing.Point(4, 2);
            this.panel_new.Name = "panel_new";
            this.panel_new.Size = new System.Drawing.Size(418, 511);
            this.panel_new.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(334, 476);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 30);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(251, 476);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 30);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbox_title
            // 
            this.tbox_title.Location = new System.Drawing.Point(72, 14);
            this.tbox_title.Multiline = true;
            this.tbox_title.Name = "tbox_title";
            this.tbox_title.Size = new System.Drawing.Size(336, 22);
            this.tbox_title.TabIndex = 16;
            // 
            // tbox_writer
            // 
            this.tbox_writer.Location = new System.Drawing.Point(72, 48);
            this.tbox_writer.Multiline = true;
            this.tbox_writer.Name = "tbox_writer";
            this.tbox_writer.Size = new System.Drawing.Size(336, 22);
            this.tbox_writer.TabIndex = 11;
            // 
            // tbox_content
            // 
            this.tbox_content.Location = new System.Drawing.Point(14, 113);
            this.tbox_content.Multiline = true;
            this.tbox_content.Name = "tbox_content";
            this.tbox_content.Size = new System.Drawing.Size(394, 357);
            this.tbox_content.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "내용";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // WriteNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 517);
            this.Controls.Add(this.panel_new);
            this.Name = "WriteNew";
            this.Text = "새글쓰기";
            this.panel_new.ResumeLayout(false);
            this.panel_new.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_new;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbox_title;
        private System.Windows.Forms.TextBox tbox_writer;
        private System.Windows.Forms.TextBox tbox_content;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}