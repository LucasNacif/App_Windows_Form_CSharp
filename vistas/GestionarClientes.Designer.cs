namespace numeroMayoryMenor
{
    partial class GestionarClientes
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
            listClientes = new ListBox();
            label1 = new Label();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            txtApellido = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtTarjeta = new TextBox();
            label4 = new Label();
            btnEditar = new Button();
            label5 = new Label();
            lblID = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(12, 112);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(237, 334);
            listClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 164);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 452);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(74, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(340, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(174, 452);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(340, 190);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 23);
            txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 193);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(340, 219);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(149, 23);
            txtTelefono.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 222);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono: ";
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(280, 274);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(209, 23);
            txtTarjeta.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 256);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 9;
            label4.Text = "Tarjeta de credito:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(93, 452);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 127);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 12;
            label5.Text = "Id:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(341, 127);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(341, 89);
            label6.Name = "label6";
            label6.Size = new Size(102, 22);
            label6.TabIndex = 15;
            label6.Text = "FORMULARIO";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(65, 87);
            label7.Name = "label7";
            label7.Size = new Size(137, 22);
            label7.TabIndex = 16;
            label7.Text = "LISTA DE CLIENTES";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(174, 36);
            label8.Name = "label8";
            label8.Size = new Size(170, 23);
            label8.TabIndex = 17;
            label8.Text = "GESTION DE CLIENTES";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // GestionarClientes
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(518, 485);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblID);
            Controls.Add(label5);
            Controls.Add(btnEditar);
            Controls.Add(txtTarjeta);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(listClientes);
            Name = "GestionarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE GESTION DE CLIENTES";
            Load += GestionarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Label label1;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Button btnEliminar;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtTarjeta;
        private Label label4;
        private Button btnEditar;
        private Label label5;
        private Label lblID;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}