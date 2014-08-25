namespace search_and_metainfo
{
    partial class Main_Search_form
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
            this.Directory_label = new System.Windows.Forms.Label();
            this.directory_TB = new System.Windows.Forms.TextBox();
            this.Search_term_label = new System.Windows.Forms.Label();
            this.search_term_TB = new System.Windows.Forms.TextBox();
            this.status_label = new System.Windows.Forms.Label();
            this.every_occurence_DGV = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.Program_level_DGV = new System.Windows.Forms.DataGridView();
            this.file_extension_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.total_by_searchterm_DGV = new System.Windows.Forms.DataGridView();
            this.remove_results_btn = new System.Windows.Forms.Button();
            this.Clear_form = new System.Windows.Forms.Button();
            this.num_programs_label = new System.Windows.Forms.Label();
            this.tot_lines_label = new System.Windows.Forms.Label();
            this.non_blank_lines_label = new System.Windows.Forms.Label();
            this.non_blank_non_comment_label = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.prog_and_log_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.every_occurence_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program_level_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.total_by_searchterm_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prog_and_log_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Directory_label
            // 
            this.Directory_label.AutoSize = true;
            this.Directory_label.Location = new System.Drawing.Point(25, 11);
            this.Directory_label.Name = "Directory_label";
            this.Directory_label.Size = new System.Drawing.Size(317, 13);
            this.Directory_label.TabIndex = 0;
            this.Directory_label.Text = "Enter the directory you want to search below (or just press search)";
            // 
            // directory_TB
            // 
            this.directory_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.directory_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.directory_TB.Location = new System.Drawing.Point(28, 43);
            this.directory_TB.Name = "directory_TB";
            this.directory_TB.Size = new System.Drawing.Size(599, 20);
            this.directory_TB.TabIndex = 1;
            // 
            // Search_term_label
            // 
            this.Search_term_label.AutoSize = true;
            this.Search_term_label.Location = new System.Drawing.Point(655, 11);
            this.Search_term_label.Name = "Search_term_label";
            this.Search_term_label.Size = new System.Drawing.Size(368, 26);
            this.Search_term_label.TabIndex = 3;
            this.Search_term_label.Text = "Enter the comma-delimited item(s) you wish to search for below\r\n(note, trimming a" +
    "nd capitalization happens, so \"   ABC\" is the same as \"abc\")";
            // 
            // search_term_TB
            // 
            this.search_term_TB.Location = new System.Drawing.Point(658, 43);
            this.search_term_TB.Name = "search_term_TB";
            this.search_term_TB.Size = new System.Drawing.Size(286, 20);
            this.search_term_TB.TabIndex = 4;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(12, 156);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(590, 25);
            this.status_label.TabIndex = 5;
            this.status_label.Text = "This label tells you what is happening as you do things";
            // 
            // every_occurence_DGV
            // 
            this.every_occurence_DGV.AllowUserToAddRows = false;
            this.every_occurence_DGV.AllowUserToOrderColumns = true;
            this.every_occurence_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.every_occurence_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.every_occurence_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.every_occurence_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.every_occurence_DGV.Location = new System.Drawing.Point(0, 0);
            this.every_occurence_DGV.Name = "every_occurence_DGV";
            this.every_occurence_DGV.Size = new System.Drawing.Size(1069, 195);
            this.every_occurence_DGV.TabIndex = 6;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(28, 76);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(71, 26);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_btn_click);
            // 
            // Program_level_DGV
            // 
            this.Program_level_DGV.AllowUserToAddRows = false;
            this.Program_level_DGV.AllowUserToOrderColumns = true;
            this.Program_level_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Program_level_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Program_level_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Program_level_DGV.Location = new System.Drawing.Point(0, 0);
            this.Program_level_DGV.Name = "Program_level_DGV";
            this.Program_level_DGV.Size = new System.Drawing.Size(826, 211);
            this.Program_level_DGV.TabIndex = 8;
            // 
            // file_extension_CB
            // 
            this.file_extension_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.file_extension_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.file_extension_CB.FormattingEnabled = true;
            this.file_extension_CB.Items.AddRange(new object[] {
            ".sas",
            ".log",
            ".lst",
            ".txt"});
            this.file_extension_CB.Location = new System.Drawing.Point(658, 81);
            this.file_extension_CB.Name = "file_extension_CB";
            this.file_extension_CB.Size = new System.Drawing.Size(121, 21);
            this.file_extension_CB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(280, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter File extension to search for. Default is .sas. The search will look in all " +
    "files with this file extension (and only files with this extension)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 184);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Program_level_DGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.total_by_searchterm_DGV);
            this.splitContainer1.Size = new System.Drawing.Size(1069, 211);
            this.splitContainer1.SplitterDistance = 826;
            this.splitContainer1.TabIndex = 11;
            // 
            // total_by_searchterm_DGV
            // 
            this.total_by_searchterm_DGV.AllowUserToAddRows = false;
            this.total_by_searchterm_DGV.AllowUserToOrderColumns = true;
            this.total_by_searchterm_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.total_by_searchterm_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.total_by_searchterm_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_by_searchterm_DGV.Location = new System.Drawing.Point(0, 0);
            this.total_by_searchterm_DGV.Name = "total_by_searchterm_DGV";
            this.total_by_searchterm_DGV.Size = new System.Drawing.Size(239, 211);
            this.total_by_searchterm_DGV.TabIndex = 0;
            // 
            // remove_results_btn
            // 
            this.remove_results_btn.Location = new System.Drawing.Point(28, 130);
            this.remove_results_btn.Name = "remove_results_btn";
            this.remove_results_btn.Size = new System.Drawing.Size(222, 23);
            this.remove_results_btn.TabIndex = 12;
            this.remove_results_btn.Text = "Remove results below with no search terms";
            this.remove_results_btn.UseVisualStyleBackColor = true;
            this.remove_results_btn.Click += new System.EventHandler(this.remove_results_btn_Click);
            // 
            // Clear_form
            // 
            this.Clear_form.Location = new System.Drawing.Point(256, 130);
            this.Clear_form.Name = "Clear_form";
            this.Clear_form.Size = new System.Drawing.Size(86, 23);
            this.Clear_form.TabIndex = 13;
            this.Clear_form.Text = "Clear Form";
            this.Clear_form.UseVisualStyleBackColor = true;
            this.Clear_form.Click += new System.EventHandler(this.Clear_form_Click);
            // 
            // num_programs_label
            // 
            this.num_programs_label.AutoSize = true;
            this.num_programs_label.Location = new System.Drawing.Point(796, 76);
            this.num_programs_label.Name = "num_programs_label";
            this.num_programs_label.Size = new System.Drawing.Size(109, 13);
            this.num_programs_label.TabIndex = 14;
            this.num_programs_label.Text = "Number of Programs: ";
            // 
            // tot_lines_label
            // 
            this.tot_lines_label.AutoSize = true;
            this.tot_lines_label.Location = new System.Drawing.Point(796, 89);
            this.tot_lines_label.Name = "tot_lines_label";
            this.tot_lines_label.Size = new System.Drawing.Size(111, 13);
            this.tot_lines_label.TabIndex = 15;
            this.tot_lines_label.Text = "Total number of lines: ";
            // 
            // non_blank_lines_label
            // 
            this.non_blank_lines_label.AutoSize = true;
            this.non_blank_lines_label.Location = new System.Drawing.Point(796, 102);
            this.non_blank_lines_label.Name = "non_blank_lines_label";
            this.non_blank_lines_label.Size = new System.Drawing.Size(86, 13);
            this.non_blank_lines_label.TabIndex = 16;
            this.non_blank_lines_label.Text = "Non-blank lines: ";
            // 
            // non_blank_non_comment_label
            // 
            this.non_blank_non_comment_label.AutoSize = true;
            this.non_blank_non_comment_label.Location = new System.Drawing.Point(796, 115);
            this.non_blank_non_comment_label.Name = "non_blank_non_comment_label";
            this.non_blank_non_comment_label.Size = new System.Drawing.Size(185, 13);
            this.non_blank_non_comment_label.TabIndex = 17;
            this.non_blank_non_comment_label.Text = "Non-blank, non-comment block lines: ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(12, 401);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.every_occurence_DGV);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.prog_and_log_dgv);
            this.splitContainer2.Size = new System.Drawing.Size(1069, 391);
            this.splitContainer2.SplitterDistance = 195;
            this.splitContainer2.TabIndex = 19;
            // 
            // prog_and_log_dgv
            // 
            this.prog_and_log_dgv.AllowUserToAddRows = false;
            this.prog_and_log_dgv.AllowUserToOrderColumns = true;
            this.prog_and_log_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.prog_and_log_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.prog_and_log_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prog_and_log_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prog_and_log_dgv.Location = new System.Drawing.Point(0, 0);
            this.prog_and_log_dgv.Name = "prog_and_log_dgv";
            this.prog_and_log_dgv.Size = new System.Drawing.Size(1069, 192);
            this.prog_and_log_dgv.TabIndex = 7;
            this.prog_and_log_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.prog_and_log_dgv_CellFormatting);
            // 
            // Main_Search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 804);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.non_blank_non_comment_label);
            this.Controls.Add(this.non_blank_lines_label);
            this.Controls.Add(this.tot_lines_label);
            this.Controls.Add(this.num_programs_label);
            this.Controls.Add(this.Clear_form);
            this.Controls.Add(this.remove_results_btn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.file_extension_CB);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.search_term_TB);
            this.Controls.Add(this.Search_term_label);
            this.Controls.Add(this.directory_TB);
            this.Controls.Add(this.Directory_label);
            this.Name = "Main_Search_form";
            this.Text = "Enter Search Terms";
            ((System.ComponentModel.ISupportInitialize)(this.every_occurence_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program_level_DGV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.total_by_searchterm_DGV)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prog_and_log_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Directory_label;
        private System.Windows.Forms.TextBox directory_TB;
        private System.Windows.Forms.Label Search_term_label;
        private System.Windows.Forms.TextBox search_term_TB;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.DataGridView every_occurence_DGV;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView Program_level_DGV;
        private System.Windows.Forms.ComboBox file_extension_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView total_by_searchterm_DGV;
        private System.Windows.Forms.Button remove_results_btn;
        private System.Windows.Forms.Button Clear_form;
        private System.Windows.Forms.Label num_programs_label;
        private System.Windows.Forms.Label tot_lines_label;
        private System.Windows.Forms.Label non_blank_lines_label;
        private System.Windows.Forms.Label non_blank_non_comment_label;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView prog_and_log_dgv;
    }
}

