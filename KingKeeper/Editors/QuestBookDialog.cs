using KingKeeper.Core;
using KingKeeper.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KingKeeper.Editors
{
    public partial class QuestBookDialog : Form
    {
        private List<Quest> quests;

        public QuestBookDialog(QuestBook questBook)
        {
            InitializeComponent();

            // Copy quests from the QuestBook
            quests = new List<Quest>(questBook.PersistentQuests);

            // Prepare the list view
            // TODO: We should look into a way to query quest names.
            listView1.Items.AddRange(quests.Select(x => new ListViewItem(x.Blueprint.ToString())).ToArray());
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listView1.FirstSelectedIndex();
            if (index >= 0)
            {
                propertyGrid1.SelectedObject = quests[index];
            }
            else
            {
                propertyGrid1.SelectedObject = null;
            }
        }

        public IReadOnlyList<Quest> Quests => quests.AsReadOnly();
    }
}
