using KingKeeper.Core;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace KingKeeper.Editors
{
    public class QuestBookEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var service = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            var qstbook = value as QuestBook;

            if (service != null && qstbook != null)
            {
                using (var dialog = new QuestBookDialog(qstbook))
                {
                    if (service.ShowDialog(dialog) == DialogResult.OK)
                    {
                        // TODO
                    }
                }
            }

            return base.EditValue(context, provider, value);
        }
    }
}
