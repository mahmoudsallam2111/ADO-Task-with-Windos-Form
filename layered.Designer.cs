namespace Disconnected_mode
{
    partial class layered
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
            this.d_G_V = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.nud_duration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_topic = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.d_G_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // d_G_V
            // 
            this.d_G_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_G_V.Location = new System.Drawing.Point(12, 12);
            this.d_G_V.Name = "d_G_V";
            this.d_G_V.RowHeadersWidth = 51;
            this.d_G_V.RowTemplate.Height = 29;
            this.d_G_V.Size = new System.Drawing.Size(392, 426);
            this.d_G_V.TabIndex = 0;
            this.d_G_V.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_G_V_CellContentClick);
            this.d_G_V.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.d_G_V_RowHeaderMouseDoubleClick);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(518, 290);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 29);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(657, 354);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(645, 290);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // nud_duration
            // 
            this.nud_duration.Location = new System.Drawing.Point(601, 127);
            this.nud_duration.Name = "nud_duration";
            this.nud_duration.Size = new System.Drawing.Size(150, 27);
            this.nud_duration.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "topic_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "course_dur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "course_name";
            // 
            // combo_topic
            // 
            this.combo_topic.FormattingEnabled = true;
            this.combo_topic.Location = new System.Drawing.Point(600, 217);
            this.combo_topic.Name = "combo_topic";
            this.combo_topic.Size = new System.Drawing.Size(151, 28);
            this.combo_topic.TabIndex = 12;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(626, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(125, 27);
            this.txt_name.TabIndex = 11;
            // 
            // layered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.nud_duration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_topic);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.d_G_V);
            this.Name = "layered";
            this.Text = "layered";
            this.Load += new System.EventHandler(this.layered_Load);
            ((System.ComponentModel.ISupportInitialize)(this.d_G_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView d_G_V;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_add;
        private NumericUpDown nud_duration;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox combo_topic;
        private TextBox txt_name;
    }
}