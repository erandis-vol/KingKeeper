using KingKeeper.Extensions;
using KingKeeper.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // just testing things
            var test1 = new JValue(12);
            Console.WriteLine(test1);

            var test2 = JToken.FromObject(23);
            Console.WriteLine(test2);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                var save = saves[listBox1.SelectedIndex];              

                // Save Games are ZIP archives containing JSON data
                using (var archive = ZipFile.OpenRead(save.FullName))
                {
                    var header = new Header(Extract(archive, "header.json"));
                    var player = new Player(Extract(archive, "player.json"));

                    Console.WriteLine(player.MainCharacter);
                    player.MainCharacter.UniqueID = Guid.NewGuid();

                    Console.WriteLine(player.MainCharacter);

                    Console.WriteLine(player.ToString(Formatting.None));
                }
            }
        }

        string Extract(ZipArchive archive, string entryName)
        {
            var entry = archive.GetEntry(entryName);
            if (entry == null)
                return null;

            return entry.ExtractToString();
        }


    }
}
