using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;
using ImageProcessor.Imaging.Filters.Photo;

namespace MinecraftTextureManipulator
{
    public partial class Form1 : Form
    {
        public string version_path = null;
        public string save_path = Path.GetDirectoryName(Application.ExecutablePath);
        public string mcmeta_description = "Description Goes Here";
        public string mcmeta;

        public string[] flowers = new string[]
        {
            "dandelion",
            "poppy",
            "blue_orchid",
            "allium",
            "azure_bluet",
            "red_tulip",
            "orange_tulip",
            "white_tulip",
            "pink_tulip",
            "oxeye_daisy",
            "cornflower",
            "lily_of_the_valley",
            "sunflower",
            "lilac",
            "rose_bush",
            "peony"

        };

        public Form1()
        {
            InitializeComponent();
        }

        public void updateMcMeta(string text)
        {
            mcmeta_description = text;
            mcmeta = string.Format("{{\"pack\":{{\"description\":\"{0}\",\"pack_format\":5}}}}", text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            num_seed.Maximum = int.MaxValue;
            num_seed.Minimum = int.MinValue;
            textBox1.Text = mcmeta_description;
            updateMcMeta(mcmeta_description);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                version_path = fbd.SelectedPath;
                MessageBox.Show("Set MC Version/Resource Pack folder: " + version_path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (version_path != null)
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(save_path);
                var extensions = new List<string> { ".png" };
                string[] files = Directory.GetFiles(version_path, "*.*", SearchOption.AllDirectories)
                        .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();
                StreamWriter writer = File.CreateText(dirInfo.FullName + "/pack.mcmeta");
                writer.Write(mcmeta);
                writer.Close();
                foreach (string file_path in files)
                {

                    ImageFactory factory = new ImageFactory();
                    factory.Load(file_path);
                    factory.Brightness((int)num_brightness.Value);
                    if (check_onlyflower.Checked)
                    {
                        if(flowers.Contains(Path.GetFileNameWithoutExtension(file_path)))
                        {
                            factory.Saturation((int) num_saturation.Value);
                        }
                    }
                    else
                    {
                        factory.Saturation((int)num_saturation.Value);
                    }
                    factory.Contrast((int)num_contrast.Value);
                    if (check_bw.Checked)
                    {
                        factory.Filter(MatrixFilters.BlackWhite);
                    }
                    if (check_comic.Checked)
                    {
                        factory.Filter(MatrixFilters.Comic);
                    }
                    if (check_gotham.Checked)
                    {
                        factory.Filter(MatrixFilters.Gotham);
                    }
                    if (check_greyscale.Checked)
                    {
                        factory.Filter(MatrixFilters.GreyScale);
                    }
                    if (check_invert.Checked)
                    {
                        factory.Filter(MatrixFilters.Invert);
                    }
                    if (check_lomograph.Checked)
                    {
                        factory.Filter(MatrixFilters.Lomograph);
                    }
                    if (check_polaroid.Checked)
                    {
                        factory.Filter(MatrixFilters.Polaroid);
                    }    
                    if (check_sepia.Checked)
                    {
                        factory.Filter(MatrixFilters.Sepia);
                    }    
                    string save_to = dirInfo.FullName + file_path.Replace(version_path, "");
                    factory.Save(save_to);
                }
            }
            else
            {
                MessageBox.Show("Please select a path!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                save_path = fbd.SelectedPath;
                MessageBox.Show("Set save folder: " + save_path);
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            Random random;
            if (num_seed.Value == 0)
            {
                random = new Random();
            }
            else
            {
                random = new Random((int)num_seed.Value);
            }
            num_brightness.Value = random.Next(-100, 100);
            num_contrast.Value = random.Next(-100, 100);
            num_saturation.Value = random.Next(-100, 100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num_brightness.Value = 0;
            num_contrast.Value = 0;
            num_saturation.Value = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateMcMeta(textBox1.Text);
        }
    }
}
