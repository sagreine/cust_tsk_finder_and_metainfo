using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit;

namespace search_and_metainfo
{
    [ClassId("a9f68fbb-da5d-4e09-968d-7b71690b9999")]
    [Version(1.0)]
    [InputRequired(InputResourceType.None)]
    public class Program : SAS.Tasks.Toolkit.SasTask
    {
        // to make this into an exe, uncomment this Main function and comment out the rest of this class.
        // Then change the propreties output type from class library to exe. (go to project, [projectname] properties and 
        // change the dropdown item selected to windows application.
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        /*static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }*/

        public Program()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // 
            // BatchSubmit
            // 
            this.ProcsUsed = "Base";
            this.RequiresData = false;
            this.TaskCategory = "Utility";
            this.TaskDescription = "Search files in directory for string(s) and get program/line counts";
            this.TaskName = "Search and Meta Info";

        }

        public override ShowResult Show(System.Windows.Forms.IWin32Window Owner)
        {

            Form sbtForm = new Main_Search_form();
            sbtForm.Show(); 

            return ShowResult.Canceled;

        }

  
    }
}
