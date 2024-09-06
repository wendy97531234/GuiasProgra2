namespace CapaConexion
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(79, 381);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(134, 29);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar información";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar:";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(117, 39);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(225, 20);
            this.tbFiltro.TabIndex = 3;
            this.tbFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(35, 90);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(469, 258);
            this.dataGrid.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(515, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Customers ID";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(591, 73);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(140, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(529, 108);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(213, 27);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customers ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CompanyName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ContactTitle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "City";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(628, 158);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(140, 20);
            this.tboxCustomerID.TabIndex = 12;
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(628, 184);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(140, 20);
            this.tboxCompanyName.TabIndex = 13;
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(628, 210);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(140, 20);
            this.tboxContactTitle.TabIndex = 14;
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(628, 236);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(140, 20);
            this.tboxAddress.TabIndex = 15;
            // 
            // tboxCity
            // 
            this.tboxCity.Location = new System.Drawing.Point(628, 262);
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(140, 20);
            this.tboxCity.TabIndex = 16;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(518, 305);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(111, 27);
            this.btnInsertar.TabIndex = 17;
            this.btnInsertar.Text = "Ingresar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(666, 305);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 27);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tboxCity);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGrid);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
    }
}

