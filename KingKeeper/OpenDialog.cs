using KingKeeper.Core;
using KingKeeper.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace KingKeeper
{
    public partial class OpenDialog : Form
    {
        private class SaveGame : IDisposable
        {
            public SaveGame(FileInfo file)
            {
                File = file;

                using (var archive = ZipFile.OpenRead(file.FullName))
                {
                    Image = archive.GetEntry("header.png").ExtractToImage();

                    var header = archive.GetEntry("header.json").ExtractToObject<Save>();
                    Name = header.Name;
                    Description = header.Description;
                }
            }

            ~SaveGame()
            {
                Dispose(false);
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            private void Dispose(bool disposing)
            {
                if (disposing)
                {
                    Image?.Dispose();
                }
            }

            public FileInfo File { get; }

            public Image Image { get; }

            public string Name { get; }

            public string Description { get; }
        }

        private List<SaveGame> saveGames;
        private SaveGame selected;

        public OpenDialog()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            saveGames = new List<SaveGame>(Directory.EnumerateFiles(Program.GetSavedGamesDirectory(), "*.zks").Select(x => new SaveGame(new FileInfo(x))));

            foreach (var saveGame in saveGames)
            {
                listView1.Items.Add(new ListViewItem {
                    Text = saveGame.Name,
                    Tag = saveGame
                });
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            base.OnLoad(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            for (int i = 0; i < saveGames.Count; i++)
            {
                saveGames[i]?.Dispose();
                saveGames[i] = null;
            }

            base.OnClosed(e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listView1.FirstSelectedItem();
            var selectedGame = selectedItem?.Tag as SaveGame;

            if (selectedItem != null && selectedGame != null)
            {
                pictureBox1.Image = selectedGame.Image;
                richTextBox1.Text = selectedGame.Description;

                selected = selectedGame;
                button1.Enabled = true;
            }
            else
            {
                selected = null;
                button1.Enabled = false;
            }
        }

        /// <summary>
        /// Gets the selected save game.
        /// </summary>
        public FileInfo SelectedSaveGame => selected != null ? selected.File : null;
    }
}
