using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai07 : Form
    {
        // Danh sách các phần mở rộng của file văn bản có thể xem trước
        private readonly string[] textExtensions = { ".txt", ".cs", ".xml", ".json", ".log", ".html", ".css", ".js", ".config" };
        // Danh sách các phần mở rộng của file ảnh có thể xem trước
        private readonly string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
        public Lab02_Bai07()
        {
            InitializeComponent();
        }
        private void Lab02_Bai07_Load(object sender, EventArgs e)
        {
            PopulateDrives();
        }
        private void PopulateDrives()
        {
            directoryTreeView.Nodes.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode driveNode = new TreeNode(drive.Name);
                    driveNode.Tag = drive.RootDirectory.FullName;
                    driveNode.Nodes.Add("dummy");
                    directoryTreeView.Nodes.Add(driveNode);
                }
            }
        }

        private void directoryTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Nodes.Count == 1 && selectedNode.Nodes[0].Text == "dummy")
            {
                selectedNode.Nodes.Clear();
                string path = selectedNode.Tag.ToString();
                PopulateDirectory(selectedNode, path);
            }
        }

        private void PopulateDirectory(TreeNode parentNode, string path)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (string dir in directories)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    TreeNode dirNode = new TreeNode(di.Name);
                    dirNode.Tag = dir;
                    dirNode.Nodes.Add("dummy");
                    parentNode.Nodes.Add(dirNode);
                }

                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    TreeNode fileNode = new TreeNode(fi.Name);
                    fileNode.Tag = file;
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException) {  }
        }

        private void directoryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            imagePreviewBox.Visible = false;
            fileContentTextBox.Visible = false;
            imagePreviewBox.Image = null;
            fileContentTextBox.Text = "";

            string path = e.Node.Tag?.ToString();

            if (string.IsNullOrEmpty(path) || Directory.Exists(path))
            {
                return;
            }

            string extension = Path.GetExtension(path).ToLower();

            if (imageExtensions.Contains(extension))
            {
                try
                {
                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        imagePreviewBox.Image = Image.FromStream(stream);
                        imagePreviewBox.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image: {ex.Message}");
                }
            }
            else if (textExtensions.Contains(extension))
            {
                try
                {
                    fileContentTextBox.Text = File.ReadAllText(path);
                    fileContentTextBox.Visible = true; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading text file: {ex.Message}");
                }
            }
        }
    }
}
