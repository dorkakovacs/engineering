﻿using Rendeles_Forms_cgrc42.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_Forms_cgrc42
{
    public partial class UgyfelSzerkesztesForm : Form
    {


        public Ugyfel SzerkesztettUgyfel { get; set; }

        public UgyfelSzerkesztesForm(Ugyfel ugyfel)
        {
            InitializeComponent();
            this.SzerkesztettUgyfel = ugyfel;
            ugyfelBindingSource.DataSource = SzerkesztettUgyfel;
        }
        public UgyfelSzerkesztesForm()
        {
            InitializeComponent();
            SzerkesztettUgyfel = new Ugyfel();
            ugyfelBindingSource.DataSource = SzerkesztettUgyfel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Kérjük, javítsa a hibás mezőket!");
                return;
            }

            ugyfelBindingSource.EndEdit();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UgyfelSzerkesztesForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxNev = new Regex(@"^[\p{L} .'-]+$");

            if (!rgxNev.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "A név csak kis- és nagybetűket jeleníthet meg.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!rgxEmail.IsMatch(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Az email cím nem megfelelő formátumú.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxTelefonszam = new Regex(@"^\+36(?:20|30|31|50|70)(\d{7})$");
            if (!rgxTelefonszam.IsMatch(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "A telefonszám nem megfelelő formátumú.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
        }
    }
}
