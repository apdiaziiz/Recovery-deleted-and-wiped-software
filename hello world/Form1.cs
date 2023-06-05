using System;
//using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Shell32; //Reference Microsoft Shell Controls And Automation on the COM tab.
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.FileIO;
//using System.Runtime.InteropServices;
//using System.Linq;
using MaterialSkin.Controls;
using MaterialSkin;
//using EaseUS.DataRecoverySDK;
//using RecuvaSharp;

namespace hello_world
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        enum RecycleFlags : int
        {
            SHRB_NOCONFIRMATION = 0x00000001,
            SHRB_NOPROGRESSUI = 0x00000001,
            SHRB_NOSOUND = 0x00000004,
        }

        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        private Shell Shl;
        private const long ssfBITBUCKET = 10;
        private const int recycleNAME = 0;
        private const int recyclePATH = 1;

        private void Delete(string Item)
        {
            FileSystem.DeleteFile(Item, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            //Gives the most control of dialogs.
        }

        private bool Restore(string Item)
        {
            Shl = new Shell();
            Folder Recycler = Shl.NameSpace(10);
            for (int i = 0; i < Recycler.Items().Count; i++)
            {
                FolderItem FI = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(FI, 0);
                if (Path.GetExtension(FileName) == "") FileName += Path.GetExtension(FI.Path);
                //Necessary for systems with hidden file extensions.
                string FilePath = Recycler.GetDetailsOf(FI, 1);
                if (Item == Path.Combine(FilePath, FileName))
                {
                    DoVerb(FI, "ESTORE");
                    return true;
                }
            }
            return false;
        }

        private bool DoVerb(FolderItem Item, string Verb)
        {
            foreach (FolderItemVerb FIVerb in Item.Verbs())
            {
                if (FIVerb.Name.ToUpper().Contains(Verb.ToUpper()))
                {
                    FIVerb.DoIt();
                    return true;
                }
            }
            return false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Clear the combo box
            mtCbx.Items.Clear();

            // Get the list of disk drives and add their names to the combo box
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady && drive.DriveType == DriveType.Fixed)
                {
                    mtCbx.Items.Add(drive.Name);
                }
            }
        }

        private void eraseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to delete all the contents in the recycle pin", "Recycle Bin", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                    MessageBox.Show("The recycle bin has been successfully cleaned !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The recycle bin couldn't be recycled " + ex.Message);
                }
            }
        }

        private void recoveryBtn_Click(object sender, EventArgs e)
        {
            
        }

    }
}
