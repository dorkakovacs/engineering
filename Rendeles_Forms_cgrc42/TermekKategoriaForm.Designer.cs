namespace Rendeles_Forms_cgrc42
{
    partial class TermekKategoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeViewKategoriak = new TreeView();
            txtNev = new TextBox();
            txtLeiras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnTorles = new Button();
            btnMentes = new Button();
            button3 = new Button();
            btnUjTestver = new Button();
            contextMenuStripKategoria = new ContextMenuStrip(components);
            átnevezésToolStripMenuItem = new ToolStripMenuItem();
            újFőkategóriaToolStripMenuItem = new ToolStripMenuItem();
            újAlkategóriaToolStripMenuItem = new ToolStripMenuItem();
            törlésToolStripMenuItem = new ToolStripMenuItem();
            frissítésToolStripMenuItem = new ToolStripMenuItem();
            mentésXMLbeToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripKategoria.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.Location = new Point(23, 26);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(264, 398);
            treeViewKategoriak.TabIndex = 0;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
            // 
            // txtNev
            // 
            txtNev.Location = new Point(362, 55);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(651, 27);
            txtNev.TabIndex = 1;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(374, 122);
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(639, 27);
            txtLeiras.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 55);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 3;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 129);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Leírás:";
            // 
            // btnTorles
            // 
            btnTorles.Location = new Point(908, 228);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(94, 29);
            btnTorles.TabIndex = 5;
            btnTorles.Text = "Törlés";
            btnTorles.UseVisualStyleBackColor = true;
            btnTorles.Click += btnTorles_Click;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(737, 228);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(94, 29);
            btnMentes.TabIndex = 6;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            btnMentes.Click += btnMentes_Click;
            // 
            // button3
            // 
            button3.Location = new Point(518, 226);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 7;
            button3.Text = "Új gyermek kat.";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnUjTestver
            // 
            btnUjTestver.Location = new Point(332, 226);
            btnUjTestver.Name = "btnUjTestver";
            btnUjTestver.Size = new Size(140, 29);
            btnUjTestver.TabIndex = 8;
            btnUjTestver.Text = "Új testvér kat.";
            btnUjTestver.UseVisualStyleBackColor = true;
            btnUjTestver.Click += btnUjTestver_Click;
            // 
            // contextMenuStripKategoria
            // 
            contextMenuStripKategoria.ImageScalingSize = new Size(20, 20);
            contextMenuStripKategoria.Items.AddRange(new ToolStripItem[] { átnevezésToolStripMenuItem, újFőkategóriaToolStripMenuItem, újAlkategóriaToolStripMenuItem, törlésToolStripMenuItem, frissítésToolStripMenuItem, mentésXMLbeToolStripMenuItem });
            contextMenuStripKategoria.Name = "contextMenuStrip1";
            contextMenuStripKategoria.Size = new Size(183, 148);
            // 
            // átnevezésToolStripMenuItem
            // 
            átnevezésToolStripMenuItem.Name = "átnevezésToolStripMenuItem";
            átnevezésToolStripMenuItem.Size = new Size(182, 24);
            átnevezésToolStripMenuItem.Text = "Átnevezés";
            átnevezésToolStripMenuItem.Click += átnevezésToolStripMenuItem_Click;
            // 
            // újFőkategóriaToolStripMenuItem
            // 
            újFőkategóriaToolStripMenuItem.Name = "újFőkategóriaToolStripMenuItem";
            újFőkategóriaToolStripMenuItem.Size = new Size(182, 24);
            újFőkategóriaToolStripMenuItem.Text = "Új főkategória";
            újFőkategóriaToolStripMenuItem.Click += újFőkategóriaToolStripMenuItem_Click;
            // 
            // újAlkategóriaToolStripMenuItem
            // 
            újAlkategóriaToolStripMenuItem.Name = "újAlkategóriaToolStripMenuItem";
            újAlkategóriaToolStripMenuItem.Size = new Size(182, 24);
            újAlkategóriaToolStripMenuItem.Text = "Új alkategória";
            újAlkategóriaToolStripMenuItem.Click += újAlkategóriaToolStripMenuItem_Click;
            // 
            // törlésToolStripMenuItem
            // 
            törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            törlésToolStripMenuItem.Size = new Size(182, 24);
            törlésToolStripMenuItem.Text = "Törlés ";
            törlésToolStripMenuItem.Click += törlésToolStripMenuItem_Click;
            // 
            // frissítésToolStripMenuItem
            // 
            frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            frissítésToolStripMenuItem.Size = new Size(182, 24);
            frissítésToolStripMenuItem.Text = "Frissítés";
            frissítésToolStripMenuItem.Click += frissítésToolStripMenuItem_Click;
            // 
            // mentésXMLbeToolStripMenuItem
            // 
            mentésXMLbeToolStripMenuItem.Name = "mentésXMLbeToolStripMenuItem";
            mentésXMLbeToolStripMenuItem.Size = new Size(182, 24);
            mentésXMLbeToolStripMenuItem.Text = "Mentés XML-be";
            mentésXMLbeToolStripMenuItem.Click += mentésXMLbeToolStripMenuItem_Click;
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 450);
            Controls.Add(btnUjTestver);
            Controls.Add(button3);
            Controls.Add(btnMentes);
            Controls.Add(btnTorles);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLeiras);
            Controls.Add(txtNev);
            Controls.Add(treeViewKategoriak);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            Load += TermekKategoriaForm_Load;
            contextMenuStripKategoria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox txtNev;
        private TextBox txtLeiras;
        private Label label1;
        private Label label2;
        private Button btnTorles;
        private Button btnMentes;
        private Button button3;
        private Button btnUjTestver;
        private ContextMenuStrip contextMenuStripKategoria;
        private ToolStripMenuItem átnevezésToolStripMenuItem;
        private ToolStripMenuItem újFőkategóriaToolStripMenuItem;
        private ToolStripMenuItem újAlkategóriaToolStripMenuItem;
        private ToolStripMenuItem törlésToolStripMenuItem;
        private ToolStripMenuItem frissítésToolStripMenuItem;
        private ToolStripMenuItem mentésXMLbeToolStripMenuItem;
    }
}