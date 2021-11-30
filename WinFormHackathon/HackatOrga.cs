using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHackathon
{
    public partial class HackatOrga : Form
    {
        public HackatOrga()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // HackatOrga
            // 
            this.ClientSize = new System.Drawing.Size(598, 379);
            this.Name = "HackatOrga";
            this.Text = "HackatOrga";
            this.Load += new System.EventHandler(this.HackatOrga_Load);
            this.ResumeLayout(false);

        }

        private void HackatOrga_Load(object sender, EventArgs e)
        {

        }
    }
}
