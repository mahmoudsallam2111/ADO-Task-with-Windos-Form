namespace Disconnected_mode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_course = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.combo_topic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_duration = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_course
            // 
            this.dgv_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_course.Location = new System.Drawing.Point(12, 12);
            this.dgv_course.Name = "dgv_course";
            this.dgv_course.RowHeadersWidth = 51;
            this.dgv_course.RowTemplate.Height = 29;
            this.dgv_course.Size = new System.Drawing.Size(519, 412);
            this.dgv_course.TabIndex = 0;
            this.dgv_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_course_CellContentClick);
            this.dgv_course.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_course_RowHeaderMouseDoubleClick);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(663, 34);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(125, 27);
            this.txt_name.TabIndex = 1;
            // 
            // combo_topic
            // 
            this.combo_topic.FormattingEnabled = true;
            this.combo_topic.Location = new System.Drawing.Point(637, 216);
            this.combo_topic.Name = "combo_topic";
            this.combo_topic.Size = new System.Drawing.Size(151, 28);
            this.combo_topic.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "course_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "course_dur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "topic_id";
            // 
            // nud_duration
            // 
            this.nud_duration.Location = new System.Drawing.Point(638, 126);
            this.nud_duration.Name = "nud_duration";
            this.nud_duration.Size = new System.Drawing.Size(150, 27);
            this.nud_duration.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(682, 289);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(694, 353);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(555, 289);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 29);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.nud_duration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_topic);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_course);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_course;
        private TextBox txt_name;
        private ComboBox combo_topic;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nud_duration;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Button button1;
    }
}