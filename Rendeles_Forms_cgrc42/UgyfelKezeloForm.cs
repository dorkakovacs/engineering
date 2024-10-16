using Microsoft.EntityFrameworkCore;
using Rendeles_Forms_cgrc42.Data;
using Rendeles_Forms_cgrc42.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_Forms_cgrc42
{
    public partial class UgyfelKezeloForm : Form
    {
        public UgyfelKezeloForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private RendelesDbContext _context;
        private BindingList<Ugyfel> ugyfelBindingList;

        private void UgyfelKezeloForm_Load(object sender, EventArgs e)
        {
            _context.Ugyfel.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
            dataGridView1.DataSource = ugyfelBindingSource;
        }

        private void tbSzuro_TextChanged(object sender, EventArgs e)
        {
            string filterString = tbSzuro.Text.ToLower();
            ugyfelBindingSource.DataSource = from u in ugyfelBindingList
                                             where u.Nev.ToLower().Contains(filterString) ||
                                             u.Email.ToLower().Contains(filterString) ||
                                             (u.Telefonszam != null && u.Telefonszam.Contains(filterString))
                                             orderby u.UgyfelId
                                             select u;
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            UgyfelSzerkesztesForm ugyfelSzekresztesForm = new UgyfelSzerkesztesForm();
            if (ugyfelSzekresztesForm.ShowDialog() == DialogResult.OK)
            {
                _context.Ugyfel.Add(ugyfelSzekresztesForm.SzerkesztettUgyfel);
                Mentés();
            }
        }

        void Mentés()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            Ugyfel szerkesztettUgyfel = ugyfelBindingSource.Current as Ugyfel;
            if (szerkesztettUgyfel == null)
            {
                MessageBox.Show("Nincs kiválasztott ügyfél!");
                return;
            }
            UgyfelSzerkesztesForm ugyfelSzekresztesForm = new UgyfelSzerkesztesForm(szerkesztettUgyfel);
            if (ugyfelSzekresztesForm.ShowDialog() == DialogResult.OK)
            {
                Mentés();
            }

        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            Ugyfel torlendoUgyfel = ugyfelBindingSource.Current as Ugyfel;
            if (torlendoUgyfel == null)
            {
                MessageBox.Show("Nincs kiválasztott ügyfél!");
                return;
            }
            if (MessageBox.Show("Biztosan törölni akarja az ügyfelet?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.Ugyfel.Remove(torlendoUgyfel);
                Mentés();
            }
        }
    }
}
