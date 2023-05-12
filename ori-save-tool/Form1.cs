using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ori_save_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OpenFileDialog chooseFileDialog = new OpenFileDialog();

        private void chooseInitialFileButton_Click(object sender, EventArgs e)
        {
            if (this.chooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    setInitialFile(chooseFileDialog.FileName);


     

                    // Scan directory and make sure ALL files match the pattern properly
                    foreach (string fileName in fileNames)
                    {
                        Match match = rg.Match(fileName);
                        if (!match.Success)
                        {
                            resetAllFields();
                            this.infoLabel.Text = "ALL uberstate files must match pattern '### - Name'";
                            return;
                        }
                    }

                    this.infoLabel.Text = "Press a shift button :)";

                    // Find start index
                    for (int i = 0; i < fileNames.Length; i++)
                        if (fileNames[i].Equals(fileName))
                            this.start = i;

                    if (this.start == -1)
                    {
                        resetAllFields();
                        this.infoLabel.Text = $"Could not find start index";
                        return;
                    }

                    this.shiftUpwardsButton.Enabled = true;
                    this.shiftDownwardsButton.Enabled = true;
                    this.readOnlyPathTextBox.Text = path;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }


        private bool setInitialFile(string pathToFile)
        {
            this.initialFilePath = pathToFile;

            FileInfo info = new FileInfo(pathToFile);
            if (info.DirectoryName is null)
            {
                // This should never happen, but just in case....
                resetFields();
                this.infoLabel.Text = "Error finding directory name";
                return;
            }

            this.initialFileName = info.Name;
            this.directoryPath = info.DirectoryName;
            this.fileNames = Directory.GetFiles(directory, "*.uberstate").Select(path => new FileInfo(path).Name).ToArray();

            // fileNames is sorted the same way windows explorer sorts by name
            // When you choose a file to shift up, it will shift itself up, as well as all of the files that come after it
            // (based on how you see the files are ordered in windows explorer list mode, sorted alphabetically)
            // This means that if you have file structure that looks like this:
            //   001 - YStart to Glades
            //   001 - ZStart to Glades
            // And you choose to shift ZStart to glades up, it will NOT shift YStart to glades up with it, since Z start is later
            Array.Sort(this.fileNames, new NumericComparer());

            if (!this.fileNames.Any())
            {
                resetAllFields();
                this.infoLabel.Text = "Could not find any uberstate files here";
                return;
            }


            return false;
        }

        private string initialFilePath = "";
        private string initialFileName = "";
        private string directoryPath = "";
        private string directoryFiles = "";
        private int initialFileIndex = -1;

        private void resetFields()
        {
            this.readOnlyInitialFileTextBox.Text = "";
            this.downShiftButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.upShiftButton.Enabled = false;

            //   this.readonlyReplacementFileTextBox.Text = "";
            this.replaceButton.Enabled = false;
            this.insertButton.Enabled = false;



        }

        private bool chooseInitialFile(string path)
        {
            return false;
        }
    }
}
