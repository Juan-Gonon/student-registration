namespace Estudiantes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox gbMenu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgMenu2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblNid = new System.Windows.Forms.Label();
            this.txtBoxNid = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            gbMenu = new System.Windows.Forms.GroupBox();
            gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bgMenu2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            gbMenu.BackColor = System.Drawing.Color.Transparent;
            gbMenu.Controls.Add(this.pictureBox1);
            gbMenu.Controls.Add(this.label1);
            gbMenu.Cursor = System.Windows.Forms.Cursors.Default;
            gbMenu.Dock = System.Windows.Forms.DockStyle.Top;
            gbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbMenu.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gbMenu.ForeColor = System.Drawing.Color.White;
            gbMenu.Location = new System.Drawing.Point(0, 0);
            gbMenu.Margin = new System.Windows.Forms.Padding(0);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new System.Drawing.Size(736, 80);
            gbMenu.TabIndex = 0;
            gbMenu.TabStop = false;
            gbMenu.Text = "Menu";
            gbMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.gbMenu_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estudiantes.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(38, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistama de Estudiantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bgMenu2
            // 
            this.bgMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bgMenu2.BackColor = System.Drawing.Color.Transparent;
            this.bgMenu2.Controls.Add(this.btnDelete);
            this.bgMenu2.Controls.Add(this.btnCancel);
            this.bgMenu2.Controls.Add(this.btnEnviar);
            this.bgMenu2.Controls.Add(this.flowLayoutPanel4);
            this.bgMenu2.Controls.Add(this.flowLayoutPanel3);
            this.bgMenu2.Controls.Add(this.flowLayoutPanel2);
            this.bgMenu2.Controls.Add(this.flowLayoutPanel1);
            this.bgMenu2.Controls.Add(this.lblEmail);
            this.bgMenu2.Controls.Add(this.txtBoxEmail);
            this.bgMenu2.Controls.Add(this.lblNombre);
            this.bgMenu2.Controls.Add(this.txtBoxNombre);
            this.bgMenu2.Controls.Add(this.lblApellido);
            this.bgMenu2.Controls.Add(this.txtBoxApellido);
            this.bgMenu2.Controls.Add(this.lblNid);
            this.bgMenu2.Controls.Add(this.txtBoxNid);
            this.bgMenu2.Controls.Add(this.groupBox3);
            this.bgMenu2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgMenu2.ForeColor = System.Drawing.Color.White;
            this.bgMenu2.Location = new System.Drawing.Point(12, 173);
            this.bgMenu2.Name = "bgMenu2";
            this.bgMenu2.Size = new System.Drawing.Size(312, 506);
            this.bgMenu2.TabIndex = 1;
            this.bgMenu2.TabStop = false;
            this.bgMenu2.Text = "Informacion del Estudiante";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::Estudiantes.Properties.Resources.trash;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(173, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(218, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BackgroundImage = global::Estudiantes.Properties.Resources.save;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(259, 425);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(35, 35);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(57, 369);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(240, 2);
            this.flowLayoutPanel4.TabIndex = 12;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(189, 317);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(109, 2);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(57, 317);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(109, 2);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(57, 259);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 2);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 330);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmail.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.ForeColor = System.Drawing.Color.White;
            this.txtBoxEmail.Location = new System.Drawing.Point(56, 351);
            this.txtBoxEmail.Multiline = true;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(242, 20);
            this.txtBoxEmail.TabIndex = 4;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.txtBoxEmail_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 278);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.ForeColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(57, 299);
            this.txtBoxNombre.Multiline = true;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(110, 20);
            this.txtBoxNombre.TabIndex = 2;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            this.txtBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNombre_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(170, 278);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(80, 18);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.BackColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxApellido.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellido.ForeColor = System.Drawing.Color.White;
            this.txtBoxApellido.Location = new System.Drawing.Point(188, 299);
            this.txtBoxApellido.Multiline = true;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(110, 20);
            this.txtBoxApellido.TabIndex = 3;
            this.txtBoxApellido.TextChanged += new System.EventHandler(this.txtBoxApellido_TextChanged);
            this.txtBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxApellido_KeyPress);
            // 
            // lblNid
            // 
            this.lblNid.AutoSize = true;
            this.lblNid.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNid.Location = new System.Drawing.Point(18, 220);
            this.lblNid.Name = "lblNid";
            this.lblNid.Size = new System.Drawing.Size(40, 18);
            this.lblNid.TabIndex = 2;
            this.lblNid.Text = "Nid:";
            // 
            // txtBoxNid
            // 
            this.txtBoxNid.BackColor = System.Drawing.Color.Purple;
            this.txtBoxNid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNid.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNid.ForeColor = System.Drawing.Color.White;
            this.txtBoxNid.Location = new System.Drawing.Point(56, 241);
            this.txtBoxNid.Multiline = true;
            this.txtBoxNid.Name = "txtBoxNid";
            this.txtBoxNid.Size = new System.Drawing.Size(110, 20);
            this.txtBoxNid.TabIndex = 1;
            this.txtBoxNid.TextChanged += new System.EventHandler(this.txtBoxNid_TextChanged);
            this.txtBoxNid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNid_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBoxImage);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(63, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // picBoxImage
            // 
            this.picBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxImage.Image = global::Estudiantes.Properties.Resources.image;
            this.picBoxImage.Location = new System.Drawing.Point(63, 31);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(48, 48);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxImage.TabIndex = 0;
            this.picBoxImage.TabStop = false;
            this.picBoxImage.Click += new System.EventHandler(this.picBoxImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numPage);
            this.groupBox1.Controls.Add(this.lblPage);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.dataTable);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(330, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 506);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de estudiantes";
            // 
            // numPage
            // 
            this.numPage.BackColor = System.Drawing.Color.DarkMagenta;
            this.numPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numPage.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPage.ForeColor = System.Drawing.Color.White;
            this.numPage.Location = new System.Drawing.Point(6, 434);
            this.numPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(62, 19);
            this.numPage.TabIndex = 13;
            this.numPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPage.ValueChanged += new System.EventHandler(this.numPage_ValueChanged);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(165, 390);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(56, 18);
            this.lblPage.TabIndex = 12;
            this.lblPage.Text = "Página";
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.BackgroundImage = global::Estudiantes.Properties.Resources.forward_right;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(239, 425);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(35, 35);
            this.btnLast.TabIndex = 11;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Estudiantes.Properties.Resources.arrow_right_21093;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(198, 425);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 10;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImage = global::Estudiantes.Properties.Resources.arrow_left_21094;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(157, 425);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 35);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.BackgroundImage = global::Estudiantes.Properties.Resources.forward_left;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(116, 425);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(35, 35);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dataTable
            // 
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataTable.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.GridColor = System.Drawing.Color.Chocolate;
            this.dataTable.Location = new System.Drawing.Point(20, 68);
            this.dataTable.Name = "dataTable";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dataTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(354, 303);
            this.dataTable.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estudiantes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(407, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 2);
            this.panel1.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(407, 17);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(314, 23);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Estudiantes.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bgMenu2);
            this.Controls.Add(gbMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systema de estudiante";
            gbMenu.ResumeLayout(false);
            gbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bgMenu2.ResumeLayout(false);
            this.bgMenu2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox bgMenu2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblNid;
        private System.Windows.Forms.TextBox txtBoxNid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.NumericUpDown numPage;
    }
}

