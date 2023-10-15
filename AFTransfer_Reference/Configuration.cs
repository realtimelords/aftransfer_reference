using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSIsoft.AF;
using OSIsoft.AF.Asset;
using OSIsoft.AF.EventFrame;

namespace AFTransfer_Reference
{
    public partial class Configuration : Form
    {
        public Configuration(AFTransferReference transfer, bool isReadOnly)
        {
            InitializeComponent();
            var elementTemplates = transfer.Database.ElementTemplates;
            foreach (var template in elementTemplates.Where(x => 
            x.InstanceType == typeof(AFTransfer)))
            {
                Console.WriteLine(template.Name);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }
}
