using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    /*
    Created 02/15/2018
    Last Modified 05/22/2019
    Second Release 05/22/2019
    Created by Sean Davitt, Tyler Technologies NWPS Mobile Implementation Specialist
    Designed for 64bit and 32bit windows

        WIP
           ORI and FDID searchabilty in order to pull only important information
              This will speed up the procedure
              This is the desired action to be done

        NEEDS MORE TESTING
            More testing is required to make sure the file paths from one machine to another is functioning properly.
            Released to Ryan Y. so that he can provide some input.

        WORK FLOW FOR PROGRAM:
            User enters root file path for the TPSNW Software Suite I.E: C:\ or D:\ on the old server and for the new server
            User enters a preferred file path for a zipped copy of the file storage
            User enters the file path to the file storage folder on the old server
            User enters the file path for the file storage folder on the new server
            User changes the date and time to the current date and time
            User selects which actions they'd like to preform
            User Click on copy

        Update - 05/22/2019
            Optimized Code for 2018.1+ Work Flow

        Update - 07/18/2019
            Added Status Strip - Explains where in the copy process the utility is in

    */

    public partial class Form1 : Form
    {
        private XmlDocument StartupSettings = new XmlDocument();
        private string SourcePath = @"";
        private string TargetPath = @"";

        //string BackUpPath = @"";
        private ToolStripLabel ts = new ToolStripLabel();

        public string FileStorageStartPath { get; private set; }
        public string FileStorageEndPath { get; private set; }
        public string ClientPath1 { get => TargetPath; set => TargetPath = value; }
        public string SourcePath1 { get => SourcePath; set => SourcePath = value; }

        //What the form does when it initializes every time
        private void Form1_Load(object sender, EventArgs e)
        {
            InitialLoadofXML();
            statusStrip1.Items.AddRange(new ToolStripItem[] { ts });
            ts.Text = "Ready";
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Work done when Copy button is pressed
        private void Copy_Button_Click(object sender, EventArgs e)
        {
            //This will save the configuration from the client to the xml
            SaveStartupSettings();

            //This will moved the Client Settings file for the mobile client from one location to a new location.
            if (MoveClientSettingsXml.Checked == true)
            {
                ts.Text = "Moving Client Settings";
                try
                {
                    //File.Copy in this configuration will only move a file to a new location if said file does not exist in the new location.
                    //I.E: this will overwrite a file in the new location.
                    File.Copy(Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Mobile\ClientSettings.xml",
                    Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Mobile\ClientSettings.xml", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will moved the Form Administrator Client Settings file for the mobile client from one location to a new location.
            if (MoveAdminClientSettingsXml.Checked == true)
            {
                ts.Text = "Moving Mobile Admin Client Settings";
                try
                {
                    //File.Copy in this configuration will only move a file to a new location if said file does not exist in the new location.
                    //I.E: this will overwrite a file in the new location.
                    File.Copy(Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\Mobile Forms Administrator\ClientSettings.xml",
                    Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\Mobile Forms Administrator\ClientSettings.xml", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will moved the Client Security file for the mobile client from one location to a new location.
            if (MoveSecurityXml.Checked == true)
            {
                ts.Text = "Moving Mobile Security";
                try
                {
                    //File.Copy in this configuration will only move a file to a new location if said file does not exist in the new location.
                    //I.E: this will overwrite a file in the new location.
                    File.Copy(Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Mobile\Security.xml",
                    Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Mobile\Security.xml", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will moved the License Key folder and all files within from the old HOLDER to the new HOLD FOLDER.
            if (LicenseKeyMove.Checked == true)
            {
                ts.Text = "Moving License Folder";
                try
                {
                    //File.Copy in this configuration will move any and all information from one location to another.
                    //I.E: this will overwrite files/folders in the new location.
                    DirectoryCopy(Location_Copy_From.Text + @"NWS Install\License\",
                    Location_Copy_To.Text + @"NWS Install\License\", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    //File.Copy in this configuration will move any and all information from one location to another.
                    //I.E: this will overwrite files/folders in the new location.
                    File.Copy(Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\License.dat\",
                    Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\License.dat\", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    //File.Copy in this configuration will move any and all information from one location to another.
                    //I.E: this will overwrite files/folders in the new location.
                    File.Copy(Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\Mobile.dat\",
                    Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\Mobile.dat\", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will moved the Field Reporting Folder from the old HOLD Folder to the New HOLD FOLDER.
            if (MoveFRFolder.Checked == true)
            {
                ts.Text = "Moving Field Report folder";
                try
                {
                    //File.Copy in this configuration will move any and all information from one location to another.
                    //I.E: this will overwrite files/folders in the new location.
                    DirectoryCopy(Location_Copy_From.Text + @"NWS Hold\Field Reporting",
                    Location_Copy_To.Text + @"NWS Hold\Field Reporting", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will moved the the entirety of the Aegis Mobile Folder and all files within.
            //PLANNED UPGRADE -  To only move folders and files within an ORI that a user an type in the state code for
            //THIS STEP CURRENTLY TAKES THE LONGEST
            if (MoveORIs.Checked == true)
            {
                ts.Text = "Moving Mobile ORIs";
                try
                {
                    //Aegis Mobile Folder Specific location on the OLD Mobile Server
                    string StartDir = Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Mobile\";
                    //Aegis Mobile Folder Specific location on the NEW Mobile Server
                    string EndDir = Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Mobile\";
                    //Intended to search for Folders with a certain state code and then copy all files and sub folders to the new location.
                    //CURRENTLY DOES NOT FUNCTION AS INTENDED- Right now Requires a '*' and will copy all information
                    string Future = ORIStateCode.Text;

                    //Modified Versions of Async Copy to accommodate ORI/FDID Folder specifics
                    //See Async Copy Below
                    var t = Task.Run(() => AsyncCopyORIFDID(StartDir, EndDir, Future));
                    t.Wait();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will moved the the entirety of the Aegis Mobile Fire Folder and all files within.
            //PLANNED UPGRADE -  To only move folders and files within an FDID that a user an type in the state code for
            //THIS STEP CURRENTLY TAKES THE LONGEST
            if (MoveFDIDs.Checked == true)
            {
                ts.Text = "Moving Fire Mobile FDIDs";
                try
                {
                    //Aegis Mobile Folder Specific location on the OLD Mobile Server
                    string StartDir = Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Fire Mobile\";

                    //Aegis Mobile Folder Specific location on the NEW Mobile Server
                    string EndDir = Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Fire Mobile\";

                    //Intended to search for Folders with a certain state code and then copy all files and sub folders to the new location.
                    //CURRENTLY DOES NOT FUNCTION AS INTENDED- Right now Requires a '*' and will copy all information
                    string Future = FDIDStateCode.Text;

                    //Modified Versions of Async Copy to accommodate ORI/FDID Folder specifics
                    //See Async Copy Below
                    var t = Task.Run(() => AsyncCopyORIFDID(StartDir, EndDir, Future));
                    t.Wait();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will move the Pre Plans files for mobile
            if (MovePrePlan.Checked == true)
            {
                ts.Text = "Moving Mobile Pre Plans";
                try
                {
                    DirectoryCopy(Location_Copy_From.Text + @"ProgramData\New World Systems\Aegis Mobile\PrePlanSync\Client",
                        Location_Copy_To.Text + @"ProgramData\New World Systems\AegisMobile\Client", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    DirectoryCopy(Location_Copy_From.Text + @"ProgramData\New World Systems\Aegis Mobile\PrePlanSync\Server\",
                   Location_Copy_To.Text + @"ProgramData\New World Systems\Aegis Mobile\PrePlanSync\Server\", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will moved the Merge Results folder and all files within from one location to a new location.
            if (MergeResultsMove.Checked == true)
            {
                try
                {
                    ts.Text = "Moving Merge Results";
                    //File.Copy in this configuration will move any and all information from one location to another.
                    //I.E: this will overwrite files/folders in the new location.
                    DirectoryCopy(Location_Copy_From.Text + @"Program Files (x86)\New World Systems\MergeResults\",
                    Location_Copy_To.Text + @"Program Files (x86)\New World Systems\MergeResults\", true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //This will move all files within mobile file storage
            //ONLY IF DIRECTED I.E: this is not turned on by default
            if (MoveFileStorage.Checked == true)
            {
                //moves the files and folders within the Documents folder for file storage
                try
                {
                    ts.Text = "Moving Mobile File Storage";
                    string StartDir = Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\File Storage Service\Documents\";
                    string EndDir = Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\File Storage Service\Documents\";

                    //Runs the AsyncCopy function as a task to ensure it completes
                    var t = Task.Run(() => AsyncCopy(StartDir, EndDir));
                    t.Wait();
                }
                catch (IOException ex)
                {
                    Console.Write(ex.Message);
                }

                try
                {
                    string StartDir = Location_Copy_From.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\File Storage Service\Reports\";
                    string EndDir = Location_Copy_To.Text + @"Program Files (x86)\New World Systems\Aegis Mobile Server\File Storage Service\Reports\";

                    //Runs the AsyncCopy function as a task a task to ensure it completes
                    var t = Task.Run(() => AsyncCopy(StartDir, EndDir));
                    t.Wait();

                    //Message displays after all of file storage has been copied
                    ts.Text = "Completed";
                    MessageCopy();
                }
                catch (IOException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        //Copies all directories and sub folders
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            //this checks if the entered source directory exists, and if it does not then the user gets a message.
            //intended to catch bad paths (including UNC paths)
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            //This checks to see if the destination directory exists, and if the new directory does not exist it is created.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        //Copies all files from one location to another asynchronously
        public async Task AsyncCopyORIFDID(string StartDir, string EndDir, string Future)
        {
            try
            {
                foreach (string dirPath in Directory.GetDirectories(StartDir, Future, SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(StartDir, EndDir));
                    foreach (string filename in Directory.EnumerateFiles(dirPath))
                    {
                        using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                        {
                            using (FileStream DestinationStream = File.Create(filename.Replace(StartDir, EndDir)))
                            {
                                await SourceStream.CopyToAsync(DestinationStream);
                            }
                        }
                    }
                }

                foreach (string filename in Directory.EnumerateFiles(StartDir))
                {
                    using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                    {
                        using (FileStream DestinationStream = File.Create(EndDir + filename.Substring(filename.LastIndexOf('\\'))))
                        {
                            await SourceStream.CopyToAsync(DestinationStream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        //Copies all files from one location to another asynchronously
        public async Task AsyncCopy(string StartDir, string EndDir)
        {
            //this will copy all folders within the root directory, then will move all folders within the sub folders of the root directory,
            //then all files within the inner most sub folders
            //I.E: Copy Folder names within the root from old to new
            //Copy Folder contents from old to new
            try
            {
                foreach (string dirPath in Directory.GetDirectories(StartDir, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(StartDir, EndDir));
                    foreach (string filename in Directory.EnumerateFiles(dirPath))
                    {
                        using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                        {
                            using (FileStream DestinationStream = File.Create(filename.Replace(StartDir, EndDir)))
                            {
                                await SourceStream.CopyToAsync(DestinationStream);
                            }
                        }
                    }
                }

                //this will copy all files within the root directory
                foreach (string filename in Directory.EnumerateFiles(StartDir))
                {
                    using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                    {
                        using (FileStream DestinationStream = File.Create(EndDir + filename.Substring(filename.LastIndexOf('\\'))))
                        {
                            await SourceStream.CopyToAsync(DestinationStream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        //Will display a message when the Compression-Copy-Decompression is finished
        private void MessageCopy()
        {
            MessageBox.Show("Copy is complete");
        }

        //XML related information. Broken up between loading prior XML or creating a new XML with places holder information
        private void InitialLoadofXML()
        {
            //Checking if the CopyFiles.xml exists, and loading the data if it does.
            if (File.Exists("CopyFiles.xml"))
            {
                StartupSettings.Load("CopyFiles.xml");
                Location_Copy_From.Text = StartupSettings.GetElementsByTagName("SourcePath")[0].InnerText;
                Location_Copy_To.Text = StartupSettings.GetElementsByTagName("TargetPath")[0].InnerText;
            }

            //Creation of a new CopyFiles.xml if one does not already exist.
            else
            {
                SourcePath = Location_Copy_From.Text;
                TargetPath = Location_Copy_To.Text;

                //root of the XML
                XmlNode root = StartupSettings.CreateElement("root");
                StartupSettings.AppendChild(root);

                //C:\ root path OLD Server
                XmlNode Location_Copy_FromPathNode = StartupSettings.CreateElement("SourcePath");
                Location_Copy_FromPathNode.InnerText = @"\\NWPSMMSPROD\c$\";
                root.AppendChild(Location_Copy_FromPathNode);

                //C:\ root path NEW server
                XmlNode Location_Copy_ToPathNode = StartupSettings.CreateElement("TargetPath");
                Location_Copy_ToPathNode.InnerText = @"C:\";
                root.AppendChild(Location_Copy_ToPathNode);
            }
        }

        //WIP so that when the placeholder text is modified the XML maintains the modification for the continued uses.
        private void SaveStartupSettings()
        {
            StartupSettings.GetElementsByTagName("SourcePath")[0].InnerText = Location_Copy_From.Text;
            StartupSettings.GetElementsByTagName("TargetPath")[0].InnerText = Location_Copy_To.Text;

            //Save the start up settings
            StartupSettings.Save("CopyFiles.xml");
        }

        //Help Button
        private void Help_Button_Click(object sender, EventArgs e)
        {
            var Message = " Help Button .\n\n";
            Message += "1. Location you are copying from \n\n";
            Message += "    1a. Network path to the old mobile server. \n\n";
            Message += "2. Location you are copying to. \n\n";
            Message += "    2a. Drive letter of the mobile server folder on the receiving mobile server. \n\n";
            Message += "3. If you have any issues or questions please contact Me. \n\n";
            Message += "    3a. Please email me at sean.davitt@tylertech.com. \n\n";

            MessageBox.Show(Message);
        }
    }
}