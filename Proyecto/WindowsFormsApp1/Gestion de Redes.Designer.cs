namespace WindowsFormsApp1
{
    partial class Gestion_de_Redes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_Redes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_clasifi = new System.Windows.Forms.TextBox();
            this.txt_mant = new System.Windows.Forms.TextBox();
            this.txt_descr = new System.Windows.Forms.TextBox();
            this.txt_id_hw = new System.Windows.Forms.TextBox();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dato_hw = new System.Windows.Forms.TextBox();
            this.txt_infra = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_equipo = new System.Windows.Forms.TextBox();
            this.txt_prov_mant = new System.Windows.Forms.TextBox();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.cbo_mant = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_fecha = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ubi = new System.Windows.Forms.ComboBox();
            this.cbo_tipo_eq = new System.Windows.Forms.ComboBox();
            this.cbo_modelo = new System.Windows.Forms.ComboBox();
            this.cbo_prov_man = new System.Windows.Forms.ComboBox();
            this.cbo_marca = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.id_dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_clasifi);
            this.groupBox1.Controls.Add(this.txt_mant);
            this.groupBox1.Controls.Add(this.txt_descr);
            this.groupBox1.Controls.Add(this.txt_id_hw);
            this.groupBox1.Controls.Add(this.txt_host);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_dato_hw);
            this.groupBox1.Controls.Add(this.txt_infra);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.txt_equipo);
            this.groupBox1.Controls.Add(this.txt_prov_mant);
            this.groupBox1.Controls.Add(this.txt_ubicacion);
            this.groupBox1.Controls.Add(this.txt_modelo);
            this.groupBox1.Controls.Add(this.txt_marca);
            this.groupBox1.Controls.Add(this.cbo_mant);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbo_fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_ubi);
            this.groupBox1.Controls.Add(this.cbo_tipo_eq);
            this.groupBox1.Controls.Add(this.cbo_modelo);
            this.groupBox1.Controls.Add(this.cbo_prov_man);
            this.groupBox1.Controls.Add(this.cbo_marca);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 524);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_clasifi
            // 
            this.txt_clasifi.Location = new System.Drawing.Point(17, 26);
            this.txt_clasifi.Name = "txt_clasifi";
            this.txt_clasifi.Size = new System.Drawing.Size(8, 27);
            this.txt_clasifi.TabIndex = 39;
            this.txt_clasifi.Tag = "id_clasi_inv_pk";
            // 
            // txt_mant
            // 
            this.txt_mant.Location = new System.Drawing.Point(784, 368);
            this.txt_mant.Name = "txt_mant";
            this.txt_mant.Size = new System.Drawing.Size(8, 27);
            this.txt_mant.TabIndex = 38;
            this.txt_mant.Tag = "mant_real_por";
            // 
            // txt_descr
            // 
            this.txt_descr.Location = new System.Drawing.Point(772, 51);
            this.txt_descr.Name = "txt_descr";
            this.txt_descr.Size = new System.Drawing.Size(10, 27);
            this.txt_descr.TabIndex = 37;
            this.txt_descr.Tag = "descripcion_det";
            // 
            // txt_id_hw
            // 
            this.txt_id_hw.Location = new System.Drawing.Point(607, 38);
            this.txt_id_hw.Name = "txt_id_hw";
            this.txt_id_hw.Size = new System.Drawing.Size(10, 27);
            this.txt_id_hw.TabIndex = 28;
            this.txt_id_hw.Tag = "id_gestion_redes_pk";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(356, 41);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(245, 27);
            this.txt_host.TabIndex = 23;
            this.txt_host.Tag = "nombre_gest";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hostname:";
            // 
            // txt_dato_hw
            // 
            this.txt_dato_hw.Location = new System.Drawing.Point(788, 51);
            this.txt_dato_hw.Name = "txt_dato_hw";
            this.txt_dato_hw.Size = new System.Drawing.Size(10, 27);
            this.txt_dato_hw.TabIndex = 36;
            this.txt_dato_hw.Tag = "id_dato_hw_pk";
            // 
            // txt_infra
            // 
            this.txt_infra.Location = new System.Drawing.Point(802, 51);
            this.txt_infra.Name = "txt_infra";
            this.txt_infra.Size = new System.Drawing.Size(8, 27);
            this.txt_infra.TabIndex = 35;
            this.txt_infra.Tag = "id_infra_pk";
            this.txt_infra.Text = "1";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(778, 490);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(10, 27);
            this.txt_fecha.TabIndex = 34;
            this.txt_fecha.Tag = "fecha_inicio_garantia";
            // 
            // txt_equipo
            // 
            this.txt_equipo.Location = new System.Drawing.Point(834, 427);
            this.txt_equipo.Name = "txt_equipo";
            this.txt_equipo.Size = new System.Drawing.Size(10, 27);
            this.txt_equipo.TabIndex = 33;
            this.txt_equipo.Tag = "id_tipo_equipo_pk";
            // 
            // txt_prov_mant
            // 
            this.txt_prov_mant.Location = new System.Drawing.Point(479, 429);
            this.txt_prov_mant.Name = "txt_prov_mant";
            this.txt_prov_mant.Size = new System.Drawing.Size(10, 27);
            this.txt_prov_mant.TabIndex = 32;
            this.txt_prov_mant.Tag = "id_prov_mante_pk";
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Location = new System.Drawing.Point(370, 368);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(15, 27);
            this.txt_ubicacion.TabIndex = 31;
            this.txt_ubicacion.Tag = "id_ubicacion_pk";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(788, 313);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(8, 27);
            this.txt_modelo.TabIndex = 30;
            this.txt_modelo.Tag = "id_modelo_pk";
            this.txt_modelo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(373, 315);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(16, 27);
            this.txt_marca.TabIndex = 29;
            this.txt_marca.Tag = "id_marca_pk";
            // 
            // cbo_mant
            // 
            this.cbo_mant.DisplayMember = "mant_real_por";
            this.cbo_mant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_mant.FormattingEnabled = true;
            this.cbo_mant.Items.AddRange(new object[] {
            "Proveedor",
            "N/A"});
            this.cbo_mant.Location = new System.Drawing.Point(660, 363);
            this.cbo_mant.Name = "cbo_mant";
            this.cbo_mant.Size = new System.Drawing.Size(112, 29);
            this.cbo_mant.TabIndex = 27;
            this.cbo_mant.ValueMember = "mant_real_por";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mantenimiento Realizado Por:";
            // 
            // cbo_fecha
            // 
            this.cbo_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fecha.FormattingEnabled = true;
            this.cbo_fecha.Items.AddRange(new object[] {
            "No Aplica",
            "Aplica",
            "N/A",
            "Sin garantia"});
            this.cbo_fecha.Location = new System.Drawing.Point(299, 485);
            this.cbo_fecha.Name = "cbo_fecha";
            this.cbo_fecha.Size = new System.Drawing.Size(121, 29);
            this.cbo_fecha.TabIndex = 25;
            this.cbo_fecha.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha de inicio de garantia";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(444, 487);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ubicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Proveedor de Mantenimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marca";
            // 
            // cbo_ubi
            // 
            this.cbo_ubi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ubi.FormattingEnabled = true;
            this.cbo_ubi.Location = new System.Drawing.Point(174, 368);
            this.cbo_ubi.Name = "cbo_ubi";
            this.cbo_ubi.Size = new System.Drawing.Size(190, 29);
            this.cbo_ubi.TabIndex = 10;
            // 
            // cbo_tipo_eq
            // 
            this.cbo_tipo_eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_eq.FormattingEnabled = true;
            this.cbo_tipo_eq.Location = new System.Drawing.Point(638, 427);
            this.cbo_tipo_eq.Name = "cbo_tipo_eq";
            this.cbo_tipo_eq.Size = new System.Drawing.Size(190, 29);
            this.cbo_tipo_eq.TabIndex = 5;
            // 
            // cbo_modelo
            // 
            this.cbo_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_modelo.FormattingEnabled = true;
            this.cbo_modelo.Location = new System.Drawing.Point(582, 313);
            this.cbo_modelo.Name = "cbo_modelo";
            this.cbo_modelo.Size = new System.Drawing.Size(190, 29);
            this.cbo_modelo.TabIndex = 4;
            // 
            // cbo_prov_man
            // 
            this.cbo_prov_man.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_prov_man.FormattingEnabled = true;
            this.cbo_prov_man.Location = new System.Drawing.Point(283, 427);
            this.cbo_prov_man.Name = "cbo_prov_man";
            this.cbo_prov_man.Size = new System.Drawing.Size(190, 29);
            this.cbo_prov_man.TabIndex = 3;
            // 
            // cbo_marca
            // 
            this.cbo_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_marca.FormattingEnabled = true;
            this.cbo_marca.Location = new System.Drawing.Point(174, 313);
            this.cbo_marca.Name = "cbo_marca";
            this.cbo_marca.Size = new System.Drawing.Size(190, 29);
            this.cbo_marca.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dato,
            this.datosq,
            this.descr});
            this.dataGridView1.Location = new System.Drawing.Point(17, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_lbl
            // 
            this.txt_lbl.AutoSize = true;
            this.txt_lbl.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lbl.Location = new System.Drawing.Point(284, 9);
            this.txt_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_lbl.Name = "txt_lbl";
            this.txt_lbl.Size = new System.Drawing.Size(362, 27);
            this.txt_lbl.TabIndex = 53;
            this.txt_lbl.Text = "REDES Y TELECOMUNICACIONES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_actualizar);
            this.groupBox2.Controls.Add(this.btn_cancelar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 106);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegador";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Location = new System.Drawing.Point(17, 23);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 69);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(88, 20);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 69);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(159, 20);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 69);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Location = new System.Drawing.Point(230, 20);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 69);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(370, 20);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 69);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(299, 20);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 69);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // id_dato
            // 
            this.id_dato.HeaderText = "ID_DATO";
            this.id_dato.Name = "id_dato";
            this.id_dato.Visible = false;
            // 
            // datosq
            // 
            this.datosq.HeaderText = "DATOS ESPECIFICOS";
            this.datosq.Name = "datosq";
            this.datosq.ReadOnly = true;
            this.datosq.Width = 300;
            // 
            // descr
            // 
            this.descr.HeaderText = "DESCRIPCION";
            this.descr.Name = "descr";
            this.descr.Width = 498;
            // 
            // Gestion_de_Redes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 677);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_lbl);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Gestion_de_Redes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_de_Redes";
            this.Load += new System.EventHandler(this.Gestion_de_Redes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_ubi;
        private System.Windows.Forms.ComboBox cbo_tipo_eq;
        private System.Windows.Forms.ComboBox cbo_modelo;
        private System.Windows.Forms.ComboBox cbo_prov_man;
        private System.Windows.Forms.ComboBox cbo_marca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txt_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cbo_mant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.TextBox txt_id_hw;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_descr;
        private System.Windows.Forms.TextBox txt_dato_hw;
        private System.Windows.Forms.TextBox txt_infra;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_equipo;
        private System.Windows.Forms.TextBox txt_prov_mant;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.TextBox txt_mant;
        private System.Windows.Forms.TextBox txt_clasifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn datosq;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
    }
}