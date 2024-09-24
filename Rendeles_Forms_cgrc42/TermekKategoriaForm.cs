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
    public partial class TermekKategoriaForm : Form
    {
        private RendelesDbContext _context;
        private bool isNewItem = false;
        private TermekKategoria newKategoria = null!;
        public TermekKategoriaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadKategoriak();
        }
        private void LoadKategoriak()
        {
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            treeViewKategoriak.Nodes.Clear();

            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }
        }
        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }

            return node;
        }

        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is TermekKategoria selectedKategoria)
            {
                txtNev.Text = selectedKategoria.Nev;
                txtLeiras.Text = selectedKategoria.Leiras;
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (!(treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNev.Text))
            {
                MessageBox.Show("A név mező nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedKategoria.Nev = txtNev.Text;
            selectedKategoria.Leiras = txtLeiras.Text;

            try
            {
                _context.SaveChanges();
                MessageBox.Show("A változtatások sikeresen mentve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKategoriak();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUjTestver_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                newKategoria = new TermekKategoria
                {
                    SzuloKategoriaId = selectedKategoria.SzuloKategoriaId
                };
                txtNev.Clear();
                txtLeiras.Clear();
                isNewItem = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                newKategoria = new TermekKategoria
                {
                    SzuloKategoriaId = selectedKategoria.KategoriaId
                };
                txtNev.Clear();
                txtLeiras.Clear();
                isNewItem = true;
            }
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                var result = MessageBox.Show($"Biztosan törölni szeretné a(z) '{selectedKategoria.Nev}' kategóriát és annak összes alkategóriáját?",
                    "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteKategoriaAndChildren(selectedKategoria);
                        _context.SaveChanges();
                        MessageBox.Show("A kategória és alkategóriái sikeresen törölve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKategoriak();
                        txtNev.Clear();
                        txtLeiras.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a törlés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DeleteKategoriaAndChildren(TermekKategoria kategoria)
        {
            var alkategoriak = from k in _context.TermekKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                DeleteKategoriaAndChildren(gyerekKategoria);
            }

            _context.TermekKategoria.Remove(kategoria);
        }
    }
}
