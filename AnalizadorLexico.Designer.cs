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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Menu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem1 = new ToolStripMenuItem();
            traducirToolStripMenuItem = new ToolStripMenuItem();
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            TBCode = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            DGVariables = new DataGridView();
            label3 = new Label();
            DGWarnings = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            DGSintaxis = new DataGridView();
            label2 = new Label();
            LBCode = new Label();
            DGErrores = new DataGridView();
            imageList1 = new ImageList(components);
            Menu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVariables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGWarnings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGSintaxis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGErrores).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(243, 243, 243);
            Menu.ImageScalingSize = new Size(24, 24);
            Menu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, traducirToolStripMenuItem, limpiarToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(9, 3, 0, 3);
            Menu.Size = new Size(1907, 35);
            Menu.TabIndex = 2;
            Menu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem1 });
            archivoToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem1
            // 
            abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            abrirToolStripMenuItem1.Size = new Size(153, 34);
            abrirToolStripMenuItem1.Text = "Abrir";
            abrirToolStripMenuItem1.Click += abrirToolStripMenuItem1_Click;
            // 
            // traducirToolStripMenuItem
            // 
            traducirToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            traducirToolStripMenuItem.Name = "traducirToolStripMenuItem";
            traducirToolStripMenuItem.Size = new Size(90, 29);
            traducirToolStripMenuItem.Text = "Analizar";
            traducirToolStripMenuItem.Click += traducirToolStripMenuItem_Click;
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.Size = new Size(86, 29);
            limpiarToolStripMenuItem.Text = "Limpiar";
            limpiarToolStripMenuItem.Click += limpiarToolStripMenuItem_Click;
            // 
            // TBCode
            // 
            TBCode.BackColor = Color.FromArgb(243, 243, 243);
            TBCode.BorderStyle = BorderStyle.None;
            TBCode.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TBCode.Location = new Point(527, 130);
            TBCode.Margin = new Padding(4, 5, 4, 5);
            TBCode.Multiline = true;
            TBCode.Name = "TBCode";
            TBCode.PlaceholderText = "Escribe el código aquí. . .";
            TBCode.Size = new Size(1011, 504);
            TBCode.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 53, 76);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(DGVariables);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DGWarnings);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DGSintaxis);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LBCode);
            panel1.Controls.Add(TBCode);
            panel1.Controls.Add(DGErrores);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1907, 1050);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1639, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 307);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // DGVariables
            // 
            DGVariables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGVariables.BackgroundColor = Color.Gainsboro;
            DGVariables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVariables.Location = new Point(1393, 757);
            DGVariables.Margin = new Padding(4, 5, 4, 5);
            DGVariables.Name = "DGVariables";
            DGVariables.RowHeadersWidth = 62;
            DGVariables.RowTemplate.Height = 25;
            DGVariables.Size = new Size(501, 258);
            DGVariables.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(981, 698);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 54);
            label3.TabIndex = 0;
            label3.Text = "Semántico";
            // 
            // DGWarnings
            // 
            DGWarnings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGWarnings.BackgroundColor = Color.Gainsboro;
            DGWarnings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWarnings.Location = new Point(771, 757);
            DGWarnings.Margin = new Padding(4, 5, 4, 5);
            DGWarnings.Name = "DGWarnings";
            DGWarnings.RowHeadersWidth = 62;
            DGWarnings.RowTemplate.Height = 25;
            DGWarnings.Size = new Size(614, 258);
            DGWarnings.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(306, 698);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(199, 54);
            label4.TabIndex = 0;
            label4.Text = "Sintáctico";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(145, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 54);
            label1.TabIndex = 0;
            label1.Text = "Léxico";
            // 
            // DGSintaxis
            // 
            DGSintaxis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGSintaxis.BackgroundColor = Color.Gainsboro;
            DGSintaxis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGSintaxis.Location = new Point(13, 130);
            DGSintaxis.Margin = new Padding(4, 5, 4, 5);
            DGSintaxis.Name = "DGSintaxis";
            DGSintaxis.RowHeadersWidth = 62;
            DGSintaxis.RowTemplate.Height = 25;
            DGSintaxis.Size = new Size(454, 506);
            DGSintaxis.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(1532, 698);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 54);
            label2.TabIndex = 0;
            label2.Text = "Variables";
            label2.Click += label2_Click;
            // 
            // LBCode
            // 
            LBCode.AutoSize = true;
            LBCode.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            LBCode.ForeColor = SystemColors.Desktop;
            LBCode.Location = new Point(858, 58);
            LBCode.Margin = new Padding(4, 0, 4, 0);
            LBCode.Name = "LBCode";
            LBCode.Size = new Size(294, 70);
            LBCode.TabIndex = 0;
            LBCode.Text = "Analizador";
            LBCode.Click += LBCode_Click;
            // 
            // DGErrores
            // 
            DGErrores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGErrores.BackgroundColor = Color.Gainsboro;
            DGErrores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGErrores.Location = new Point(13, 757);
            DGErrores.Margin = new Padding(4, 5, 4, 5);
            DGErrores.Name = "DGErrores";
            DGErrores.RowHeadersWidth = 62;
            DGErrores.RowTemplate.Height = 25;
            DGErrores.Size = new Size(750, 258);
            DGErrores.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1907, 1050);
            Controls.Add(Menu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Menu;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analizador Semántico";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVariables).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGWarnings).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGSintaxis).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGErrores).EndInit();
            ResumeLayout(false);
            PerformLayout();
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