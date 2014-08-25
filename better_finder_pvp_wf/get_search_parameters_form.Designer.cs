namespace search_and_metainfo
{
    partial class get_search_parameters_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.search_term_TB = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Enter comma delimited search term(s) in text box below and press the butto" +
    "n";
            // 
            // search_term_TB
            // 
            this.search_term_TB.Location = new System.Drawing.Point(12, 74);
            this.search_term_TB.Name = "search_term_TB";
            this.search_term_TB.Size = new System.Drawing.Size(290, 20);
            this.search_term_TB.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.search_btn.Location = new System.Drawing.Point(110, 100);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "To avoid this popup, enter search terms on main form before pressing \"Seach\"";
            // 
            // get_search_parameters_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_term_TB);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "get_search_parameters_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "get_search_parameters_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_term_TB;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
    }
}