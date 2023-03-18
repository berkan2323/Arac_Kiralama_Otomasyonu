using rent_a_car.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car
{
    public partial class frmAracListesi : Form
    {
        public frmAracListesi()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        private void frmAracListesi_Load(object sender, EventArgs e)
        {
            dg_arac_listesi.DataSource = db.Arabalars.ToList();
        }
    }
}
