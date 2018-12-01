using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingKeeperCore;

namespace KingKeeper.Controls
{
    public partial class UnitControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitControl"/> class.
        /// </summary>
        /// <param name="unit">The unit to be managed.</param>
        /// <exception cref="ArgumentNullException"><paramref name="unit"/> is <c>null</c>.</exception>
        public UnitControl(Unit unit)
        {
            InitializeComponent();

            Unit = unit ?? throw new ArgumentNullException(nameof(unit));
            //txtStrength.Text        = unit.Descriptor.Stats.Strength.BaseValue.ToString();
            //txtDexterity.Text       = unit.Descriptor.Stats.Dexterity.BaseValue.ToString();
            //txtConstitution.Text    = unit.Descriptor.Stats.Constitution.BaseValue.ToString();
            //txtIntelligence.Text    = unit.Descriptor.Stats.Intelligence.BaseValue.ToString();
            //txtWisdom.Text          = unit.Descriptor.Stats.Wisdom.BaseValue.ToString();
            //txtCharisma.Text        = unit.Descriptor.Stats.Charisma.BaseValue.ToString();
        }

        private void txtStrength_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtStrength.Text, out var value))
            {
                //Unit.Descriptor.Stats.Strength.BaseValue = value;
            }
        }

        private void txtDexterity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtDexterity.Text, out var value))
            {
                //Unit.Descriptor.Stats.Dexterity.BaseValue = value;
            }
        }

        private void txtConstitution_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtConstitution.Text, out var value))
            {
                //Unit.Descriptor.Stats.Constitution.BaseValue = value;
            }
        }

        private void txtIntelligence_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtIntelligence.Text, out var value))
            {
                //Unit.Descriptor.Stats.Intelligence.BaseValue = value;
            }
        }

        private void txtWisdom_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtWisdom.Text, out var value))
            {
                //Unit.Descriptor.Stats.Wisdom.BaseValue = value;
            }
        }

        private void txtCharisma_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCharisma.Text, out var value))
            {
                //Unit.Descriptor.Stats.Charisma.BaseValue = value;
            }
        }

        /// <summary>
        /// The <see cref="Objects.Unit"/> managed by this page.
        /// </summary>
        public Unit Unit { get; }
    }
}
