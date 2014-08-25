using System;
using System.Collections.Generic;
// Scott Greiner

// Note that search terms have white space trimmed, so you can't serach for "    dob" with the spaces. This will get converted to "dob" before.
// searching

// in the real world we'd just use the file metainfo for # of lines and programs and then regex into the file
// and return the whole line only when we found something.... Would go about 80000 times faster


// TODO:
// 1. Make highlighting thing less stupid so it is aware of what DGV it is higlighting from parameters instead of hardcoding
// 2. Instead of using split containers, just use a panel and put splits in it, so the 4 boxes can be resized as needed
// 3. Er, do it the right way using metainfo and regex so it doesn't take forever


using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit;
using SAS.Tasks.Toolkit.Controls;
using SAS.Shared;
using SAS.EG.Utilities;

namespace search_and_metainfo
{
    public partial class Main_Search_form : Form
    {
        public Main_Search_form()
        {
            InitializeComponent();

            str_status_label = status_label.Text;
            str_num_programs_label = num_programs_label.Text;
            str_tot_lines_label = tot_lines_label.Text;
            str_non_blank_lines_label = non_blank_lines_label.Text;
            str_non_blank_non_comment_label = non_blank_non_comment_label.Text;
        }
        private const string filename_default_search_extension = ".sas";

        // we want effective "default" values for these labels. So, create private strings that we will assign the initial values of the labels to
        // Then, when we want to search again, we will reset the labels to these initial values.
        private string str_status_label;
        private string str_num_programs_label;
        private string str_tot_lines_label;
        private string str_non_blank_lines_label;
        private string str_non_blank_non_comment_label;

        private void reset_labels_to_default()
        {
            status_label.Text = str_status_label;
            num_programs_label.Text = str_num_programs_label;
            tot_lines_label.Text = str_tot_lines_label;
            non_blank_lines_label.Text = str_non_blank_lines_label;
            non_blank_non_comment_label.Text = str_non_blank_non_comment_label;
        }
        // maybe have a params section (panel) and an output section (panel) and just call the recursive clear on one or the other when necessary
        private void reset_output()
        {
            reset_labels_to_default();
            total_by_searchterm_DGV.DataSource = null;
            Program_level_DGV.DataSource = null;
            every_occurence_DGV.DataSource = null;
            prog_and_log_dgv.DataSource = null;
        }

        // returns true if ready to search (has a directory in textbox 1 and search term(s) in text box2), false otherwise
        private bool get_search_params(bool need_search_terms)
        {
            if (string.IsNullOrEmpty(directory_TB.Text))
            {
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    directory_TB.Text = folderBrowserDialog1.SelectedPath;                    
                }
                else return false;
            }
            if (need_search_terms)
            {
                // If the search terms are empty, present pop-up that allows them to enter search terms. If they do, and press the button,
                // set the search term text box to the entered search term(s).
                if (string.IsNullOrEmpty(search_term_TB.Text))
                {
                    get_search_parameters_form gspf = new get_search_parameters_form();
                    DialogResult result = gspf.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        search_term_TB.Text = gspf.Return_Val;
                    }
                    else
                    {
                        status_label.Text = "Can't search without search terms. Enter comma-separated terms in upper right text box";
                        return false;
                    }
                }
            }
            return true;
        }
        // 1. [FIXED] *.sas is really *.sas* - so this would look through datasets / permanent formats as well (suprisingly well, for formats at least) - FIXED via lambda expression that limits
        //    results to those ending explicitly with the file_extionsion_cb.text. Obviously that is not ideal and the whole thing is a bit rickety
        // 2. if directory exists, return the filenames in string array. Otherwise return null
        // 3. This is obviously bad - should have exception or something, or at least fully break out why errors out.
        //    As-is, if we return null from this function
        //    we dont know if we did it because the directory is bad or because there are no .<search> items in the directory (which would cause the
        //    filenames array to be null as well)
        private string[] get_filenames(string searchWord)
        {
            string directory = directory_TB.Text;
            if (Directory.Exists(directory))
            {
                // if no extension was entered, use .sas as default
                if (string.IsNullOrEmpty(file_extension_CB.Text)) 
                { 
                    file_extension_CB.Text = filename_default_search_extension;
                }

                //string[] filenames = Directory.GetFiles(directory, "*" + file_extension_CB.Text, SearchOption.AllDirectories);
                string[] filenames = Array.FindAll(Directory.GetFiles(directory, "*" + file_extension_CB.Text, SearchOption.AllDirectories), x => x.EndsWith(file_extension_CB.Text));   
                status_label.Text = "Searching " + directory + " for lines in files containing " + searchWord + "...";
                return filenames;
            }
            else
            {                
                return null;
            }
        }

        private void search_btn_click(object sender, EventArgs e)
        {
            // in the real world we'd just use the file metainfo for # of lines and programs and then regex into the file
            // and return the whole line only when we found something.... Would go about 80000 times faster

            status_label.Text = "Searching, please wait... This label will update when finished";

            reset_output();

            if (get_search_params(true) == true)
            {                
                string[] filenames = get_filenames(search_term_TB.Text);
                if (filenames == null)
                {
                    MessageBox.Show("Directory does not exist, please try again");
                    return;
                }
                // well this is stupid - there is more than one way to get an empty array (not right now, but easily so in the future)
                else if (filenames.Count() == 0)
                {
                    status_label.Text = "Done searching, nothing found";
                    MessageBox.Show("There are no extension: '" + file_extension_CB.Text + "' files in this directory.");
                    return;
                }                
                // this is a pretty terrible way to do this, dictionary or (2D arrary <-- this one) would be better but I couldn't figure out how to 
                // do the looping part in 5 minutes so I gave up. dictionary is bad if they repeat search words on accident or something (could filter that i guess)
                
                // Dictionary<string, int> search_counts = new Dictionary<string, int>();
                string[] searchWord = search_term_TB.Text.Split(',');
                int[] searchCount = new int[searchWord.Count()];

                // variable occurences at teh variable level
                DataTable var_level_dt = new DataTable();
                var_level_dt.Columns.Add("Search Term");
                var_level_dt.Columns.Add("Occurences", typeof(Int32));

                // variable occurence at the program level (how many variables need changing in the program)
                DataTable prog_level_dt = new DataTable();
                prog_level_dt.Columns.Add("Program");
                prog_level_dt.Columns.Add("Total Changes", typeof(Int32));

                // For showing every line with an occurrence
                DataTable every_occurence = new DataTable();
                every_occurence.Columns.Add("Search_Word");
                every_occurence.Columns.Add("Program");
                every_occurence.Columns.Add("Line Number", typeof(Int32));
                every_occurence.Columns.Add("Code");

                // For checking logs are modified >= program modified datetime
                DataTable proglog = new DataTable();
                proglog.Columns.Add("Filename");
                proglog.Columns.Add("Program Modified Date", typeof(DateTime));
                proglog.Columns.Add("Log Modified Date", typeof(DateTime));
                proglog.Columns.Add("Bad_Date", typeof(bool));

                // this is a pretty terrible way to do this, dictionary would be better but I couldn't figure out how to 
                // do the looping part in 5 minutes so I gave up

                // For showing every line with an occurrence
                int total_lines = 0;
                int total_nonblank_lines = 0;
                int some_comments_removed = 0;

                ///
                /// Right now this looks at each file, at each line, then each word.
                ///
                /// Could change it to look for each word, each file, each line
                /// 
                /// This would take longer, but would return to the datagridview the search_word entries in order
                /// 
                int total_occurences = 0; ;
                foreach (string fileName in filenames)
                {
                    int tot_file_occur = 0;
                    // the first line number in the .sas programs is line 1
                    int linenum = 1;

                    // for every program, add the file modified date/time 
                    DateTime prog_mod_date = File.GetLastWriteTime(fileName);

                    // if the corresponding log exists, add the file modified date/time
                    DateTime log_mod_date = DateTime.MinValue;
                    string logname = fileName.Replace(".sas", ".log");
                    if (File.Exists(logname))
                    {
                        log_mod_date = File.GetLastWriteTime(logname);
                    }

                    // if the program modify date is > the log modify date this is bad so flag this program
                    DataRow this_prog_log = proglog.NewRow();
                    this_prog_log["Filename"] = fileName;
                    this_prog_log["Program Modified Date"] = prog_mod_date;
                    this_prog_log["Log Modified Date"] = log_mod_date;
                    this_prog_log["Bad_Date"] = log_mod_date < prog_mod_date;
                    proglog.Rows.Add(this_prog_log);

                    foreach (string line in File.ReadLines(fileName))
                    {                
                        /// Line Counts ///
                        //if this line is null or only whitespace... - check that this whitespace handles windows and UNIX whitespace
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            total_nonblank_lines++;          // global count
                            // if this non blank line does not have a start comment block or end comment block, it is more likely to not be a comment
                            // there is obviously EG utility that will tell us if this is a comment or not, so go find it or ask Ken what dll is needed
                            // to tell if the line is a comment or not and actually do this right.
                            if (!(line.Contains("/*") || line.Contains("*/")))
                            {
                                some_comments_removed++;
                            }
                        }

                        /// Search Words ///
                        // for each line in the file, check if each search word is found
                        for (int i = 0; i < searchWord.Count(); i++)
                        {
                            if (line.ToUpper().Contains(searchWord[i].ToUpper().Trim()))
                            {                                
                                searchCount[i]++; // # appearances by this variable anywhere
                                tot_file_occur++; // # appearances, any variable, this file
                                total_occurences++; // # appearances, any variable, any file

                                DataRow this_var_line = every_occurence.NewRow();
                                this_var_line["Program"] = fileName;
                                this_var_line["Search_Word"] = searchWord[i].Trim();
                                this_var_line["Line Number"] = linenum;
                                this_var_line["Code"] = line.Trim();
                                every_occurence.Rows.Add(this_var_line);
                            }
                        }
                        linenum++;
                    }
                    // add the number of lines from this program to the total lines count
                    total_lines += linenum - 1; // SAS lines start at 1, so correct that here.

                    DataRow this_prog = prog_level_dt.NewRow();
                    this_prog["Program"] = fileName;
                    this_prog["Total Changes"] = tot_file_occur;
                    prog_level_dt.Rows.Add(this_prog);
                }
                for (int i = 0; i < searchWord.Count(); i++)
                {
                    DataRow this_inst = var_level_dt.NewRow();
                    this_inst["Search Term"] = searchWord[i];
                    this_inst["Occurences"] = searchCount[i];
                    var_level_dt.Rows.Add(this_inst);
                }

                total_by_searchterm_DGV.DataSource = var_level_dt;
                Program_level_DGV.DataSource = prog_level_dt;
                every_occurence_DGV.DataSource = every_occurence;
                // update the prog-log checker datagridview
                prog_and_log_dgv.DataSource = proglog;
               
                // sort the output by search_word
                every_occurence_DGV.Sort(this.every_occurence_DGV.Columns[0], ListSortDirection.Ascending);

                keep_auto_but_allow_resize(total_by_searchterm_DGV);
                keep_auto_but_allow_resize(Program_level_DGV);
                keep_auto_but_allow_resize(every_occurence_DGV);
                keep_auto_but_allow_resize(prog_and_log_dgv);

                status_label.Text = total_occurences + " Total appearances by these variables";

                // Update Line count labels
                num_programs_label.Text +=  string.Format("{0:n0}",filenames.Count());
                tot_lines_label.Text +=  string.Format("{0:n0}",total_lines); // the total lines is really 1 high because SAS starts at line 1
                non_blank_lines_label.Text +=  string.Format("{0:n0}",total_nonblank_lines);
                non_blank_non_comment_label.Text +=  string.Format("{0:n0}",some_comments_removed);
            }
            else return;
        }

        private void remove_results_btn_Click(object sender, EventArgs e)
        {
            if (Program_level_DGV.DataSource == null)
            {
                MessageBox.Show("Need to perform a search first before you can trim down the results of that search");
            }
            else
            {
               // delete rows with this column == 0 
               DataTable temp_dt = (DataTable)Program_level_DGV.DataSource;
               var rows = temp_dt.Select("[Total Changes] = 0");
               foreach (var row in rows)
               {
                   row.Delete();
               }
               Program_level_DGV.DataSource = temp_dt;
            }
        }
        
        private void Clear_form_Click(object sender, EventArgs e)
        {
            clear_form(this);
        }

        private void clear_form(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = string.Empty;
                }
                else if (ctrl is DataGridView)
                {
                    ((DataGridView)ctrl).DataSource = null;
                    // this line may not be necessary
                    ((DataGridView)ctrl).Refresh();
                }
                // Otherwise, if this control is a container, recurse and call this clearing on this control's child controls
                else if (ctrl.HasChildren)
                {
                    clear_form(ctrl);
                }
            }
            reset_output();
        }
        
        private void keep_auto_but_allow_resize(DataGridView dgv)
        {
            // set the columns to the size we want them to be when autosized (except last column, which will fill the rest of the space)
            for (int i = 0; i < dgv.Columns.Count - 1; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            // this last column will fill the gray space (c# is smart enough so if you change order of columns, the far right column keeps property)
            dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // for each column, store the current (set above) width, change autosize off, and then set to autosize-calculated width
            for (int i = 0; i < dgv.Columns.Count - 1; i++)
            {
                int start_width = dgv.Columns[i].Width;
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns[i].Width = start_width;
            }
        }
        
        private void DataGridView_RowHighlighting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // this is rubbish. It is crazy inefficient. It looks to see if the column name is bad_date (also not a good idea).
            // Then if it is, try to parse the value in this column for each row. If that value is true, color the row red else color
            // it white. Also use sender/e instead of naming the DGV...
            if (prog_and_log_dgv.Columns[e.ColumnIndex].Name.Equals("Bad_Date"))
            {
                bool abool = false;
                if (bool.TryParse(prog_and_log_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out abool) && abool == true)
                {
                    prog_and_log_dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    prog_and_log_dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        
        private void prog_and_log_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView_RowHighlighting(sender, e);
        }
        
    }    

}
