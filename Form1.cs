 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global variables
        String[] files, paths;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //select songs
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //save songs
                paths = ofd.FileNames; //save paths

                //display tracks
                for(int i =0; i<files.Length; i++)
                {
                    musicListBox.Items.Add(files[i]);
                }
            }
        }

        private void musicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //play the track
            musicPlayer.URL = paths[musicListBox.SelectedIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
