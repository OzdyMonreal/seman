namespace Analizador_Lexico__Traductor_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.traducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVariables = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.DGWarnings = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGSintaxis = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LBCode = new System.Windows.Forms.Label();
            this.DGErrores = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGWarnings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSintaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.traducirToolStripMenuItem,
            this.limpiarToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.Menu.Size = new System.Drawing.Size(1907, 35);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(153, 34);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // traducirToolStripMenuItem
            // 
            this.traducirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.traducirToolStripMenuItem.Name = "traducirToolStripMenuItem";
            this.traducirToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.traducirToolStripMenuItem.Text = "Analizar";
            this.traducirToolStripMenuItem.Click += new System.EventHandler(this.traducirToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // TBCode
            // 
            this.TBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TBCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCode.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBCode.Location = new System.Drawing.Point(527, 130);
            this.TBCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBCode.Multiline = true;
            this.TBCode.Name = "TBCode";
            this.TBCode.PlaceholderText = "Escribe el código aquí. . .";
            this.TBCode.Size = new System.Drawing.Size(1011, 504);
            this.TBCode.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DGVariables);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DGWarnings);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DGSintaxis);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LBCode);
            this.panel1.Controls.Add(this.TBCode);
            this.panel1.Controls.Add(this.DGErrores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1907, 1050);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1639, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 307);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DGVariables
            // 
            this.DGVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVariables.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVariables.Location = new System.Drawing.Point(1393, 757);
            this.DGVariables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVariables.Name = "DGVariables";
            this.DGVariables.RowHeadersWidth = 62;
            this.DGVariables.RowTemplate.Height = 25;
            this.DGVariables.Size = new System.Drawing.Size(501, 258);
            this.DGVariables.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(981, 698);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Warnings";
            // 
            // DGWarnings
            // 
            this.DGWarnings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGWarnings.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGWarnings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWarnings.Location = new System.Drawing.Point(771, 757);
            this.DGWarnings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGWarnings.Name = "DGWarnings";
            this.DGWarnings.RowHeadersWidth = 62;
            this.DGWarnings.RowTemplate.Height = 25;
            this.DGWarnings.Size = new System.Drawing.Size(614, 258);
            this.DGWarnings.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(306, 698);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Errores";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(145, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Léxico";
            // 
            // DGSintaxis
            // 
            this.DGSintaxis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGSintaxis.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGSintaxis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSintaxis.Location = new System.Drawing.Point(13, 130);
            this.DGSintaxis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGSintaxis.Name = "DGSintaxis";
            this.DGSintaxis.RowHeadersWidth = 62;
            this.DGSintaxis.RowTemplate.Height = 25;
            this.DGSintaxis.Size = new System.Drawing.Size(454, 506);
            this.DGSintaxis.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1532, 698);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Variables";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBCode
            // 
            this.LBCode.AutoSize = true;
            this.LBCode.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBCode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LBCode.Location = new System.Drawing.Point(858, 58);
            this.LBCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBCode.Name = "LBCode";
            this.LBCode.Size = new System.Drawing.Size(294, 70);
            this.LBCode.TabIndex = 0;
            this.LBCode.Text = "Analizador";
            this.LBCode.Click += new System.EventHandler(this.LBCode_Click);
            // 
            // DGErrores
            // 
            this.DGErrores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGErrores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGErrores.Location = new System.Drawing.Point(13, 757);
            this.DGErrores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGErrores.Name = "DGErrores";
            this.DGErrores.RowHeadersWidth = 62;
            this.DGErrores.RowTemplate.Height = 25;
            this.DGErrores.Size = new System.Drawing.Size(750, 258);
            this.DGErrores.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1907, 1050);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizador Semántico";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGWarnings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSintaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip Menu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem1;
        private ToolStripMenuItem traducirToolStripMenuItem;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private TextBox TBCode;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private DataGridView DGErrores;
        private Label LBCode;
        private Label label2;
        private DataGridView DGSintaxis;
        private Label label4;
        private DataGridView DGWarnings;
        private DataGridView DGVariables;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}