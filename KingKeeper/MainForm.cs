using KingKeeper.Controls;
using KingKeeper.Core;
using KingKeeper.Extensions;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace KingKeeper
{
    public partial class MainForm : Form
    {
        private FileInfo saveGame = null;

        private Save header = null;
        private Player player = null;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!FindInstallation())
            {
                MessageBox.Show(
                    "Could not find Pathfinder: Kingmaker." + Environment.NewLine + "If this is a bug, please report it.",
                    "KingKeeper",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
                return;
            }

            if (!FindSaveGames())
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

        private bool FindInstallation()
        {
            return Directory.Exists(Program.GetInstallationDirectory());
        }

        private bool FindSaveGames()
        {
            return Directory.Exists(Program.GetSavedGamesDirectory());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenDialog { Text = "Open Saved Game..." })
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    Open(dialog.SelectedSaveGame);

                    txtHeaderName.Text = header.Name;
                    txtHeaderGameName.Text = header.GameName;
                    txtHeaderDescription.Text = header.Description;
                    
                    txtPlayerMoney.Text = player.Money.ToString();

                    //tabControlUnits.TabPages.Clear();
                    //foreach (var unit in party.EntityData.Where(x => !x.IsReference))
                    //{
                    //    var name = unit.Descriptor.CustomName;
                    //    if (name == string.Empty)
                    //        name = "???"; // TODO

                    //    var page = new TabPage(name);
                    //    page.Controls.Add(new UnitControl(unit));

                    //    tabControlUnits.TabPages.Add(page);
                    //}

                    //tabControlUnits.TabPages.Add(new TabPage("Test"));
                    

                    saveGame = dialog.SelectedSaveGame;

                    Text = $"KingKeeper - {header.Name} [{saveGame.Name}]";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Failed to load {dialog.SelectedSaveGame.Name}:\n\n{ex}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveGame == null)
                return;

            try
            {
                Save(saveGame);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to save {saveGame.Name}:\n\n{ex}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveGame == null)
                return;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Prompt user to save any changes.
            Close();
        }

        private void Backup(FileInfo file)
        {
            var backup = new FileInfo(file.FullName + ".bak");

            if (backup.Exists)
            {
                backup.Delete();
            }

            file.CopyTo(backup.FullName);
        }

        private void Open(FileInfo file)
        {
            // Create a backup of the file
            Backup(file);

            // Save games are ZIP archives
            using (var archive = ZipFile.OpenRead(file.FullName))
            {
                T Extract<T>(string entryName)
                {
                    var entry = archive.GetEntry(entryName);
                    if (entry == null)
                        throw new Exception($"Save does not contain \"{entryName}\".");

                    return entry.ExtractToObject<T>();
                }

                //header = new Header(Extract("header.json"));
                //player = new Player(Extract("player.json"));
                //party = new Party(Extract("party.json"));

                header = Extract<Save>("header.json");
                player = Extract<Player>("player.json");
            }
        }

        private void Save(FileInfo file)
        {
            //using (var archive = ZipFile.Open(file.FullName, ZipArchiveMode.Update))
            //{
            //    archive.ReplaceEntryFromString(player.ToString(Formatting.None), "player.json");
            //}

            throw new NotImplementedException();
        }

        private void txtPlayerMoney_TextChanged(object sender, EventArgs e)
        {
            if (saveGame != null && int.TryParse(txtPlayerMoney.Text, out var money))
            {
                player.Money = money;
            }
        }
    }
}
