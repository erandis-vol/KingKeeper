using KingKeeper.Core;
using System;
using System.Windows.Forms;

namespace KingKeeper.Controls
{
    /// <summary>
    /// Represents a single tab for editing units.
    /// </summary>
    public class UnitControlTabPage : TabPage
    {
        private UnitControl unitControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitControlTabPage"/> for the specified unit.
        /// </summary>
        /// <param name="unit">The unit to be edited.</param>
        /// <exception cref="ArgumentNullException"><paramref name="unit"/> is null.</exception>
        public UnitControlTabPage(Unit unit)
            : base()
        {
            unitControl = new UnitControl(unit) {
                Dock = DockStyle.Fill
            };

            Controls.Add(unitControl);
        }

        /// <summary>
        /// Gets the unit managed by this tab.
        /// </summary>
        public Unit Unit => unitControl.Unit;
    }
}
