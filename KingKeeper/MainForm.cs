using KingKeeper.Extensions;
using KingKeeper.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingKeeper
{
    public partial class MainForm : Form
    {
        private FileInfo[] saves = null;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (FindSaveGames())
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(saves.Select(x => x.Name).ToArray());
            }
            else
            {
                MessageBox.Show(
                    "Could not find any saved games." + Environment.NewLine + "If this is a bug, please report it.",
                    "KingKeeper",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
                return;
            }

            base.OnLoad(e);
        }

        private bool FindSaveGames()
        {
            var files = Directory.EnumerateFiles(Program.GetSavedGamesDirectory(), "*.zks");
            if (files.Any())
            {
                saves = files.Select(x => new FileInfo(x)).ToArray();
                return true;
            }

            return false;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                var save = saves[listBox1.SelectedIndex];              

                // Save Games are ZIP archives containing JSON data
                using (var archive = ZipFile.OpenRead(save.FullName))
                {
                    var player = Extract<Player>(archive, "player.json");
                    if (player == null)
                        throw new FileNotFoundException("Could not find \"player.json\".");


                }

            }



        }

        T Extract<T>(ZipArchive archive, string entryName)
        {
            var entry = archive.GetEntry(entryName);
            if (entry == null)
                return default(T);

            return JsonConvert.DeserializeObject<T>(entry.ExtractToString());
        }
    }
}
