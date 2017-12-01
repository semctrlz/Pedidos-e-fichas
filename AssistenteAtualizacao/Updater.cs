using GerenciadorEstoque.Code;
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

namespace AssistenteAtualizacao
{
    public partial class FrmAtualizando : Form
    {
        public FrmAtualizando()
        {
            InitializeComponent();
        }

        private void FrmAtualizando_Load(object sender, EventArgs e)
        {
            DTOCaminhos dto = new DTOCaminhos();

            DirectoryCopy(dto.Updates, Path.GetDirectoryName(Application.ExecutablePath), true);

            MessageBox.Show("Controle de estoque atualizado!");



        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            var dir = new DirectoryInfo(sourceDirName);
            var dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            var files = dir.GetFiles();

            foreach (var file in files)
            {
                try
                {
                    // Create the path to the new copy of the file.
                    var temppath = Path.Combine(destDirName, file.Name);

                    // Copy the file.
                    file.CopyTo(temppath, true);

                }
                catch { }
            }

            // If copySubDirs is true, copy the subdirectories.
            if (!copySubDirs) return;

            foreach (var subdir in dirs)
            {
                // Create the subdirectory.
                var temppath = Path.Combine(destDirName, subdir.Name);

                // Copy the subdirectories.
                DirectoryCopy(subdir.FullName, temppath, copySubDirs);
            }
        }

    }
}
