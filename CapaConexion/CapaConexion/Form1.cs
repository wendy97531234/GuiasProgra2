﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatosLayer;
using System.Reflection;

namespace CapaConexion
{
    public partial class Form1 : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var Customers = customerRepository.ObtenerTodos();
            dataGrid.DataSource = Customers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // var filtro = Customers.FindAll( X => X.CompanyName.StartsWith(tbFiltro.Text));
            // dataGrid.DataSource = filtro;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*  DatosLayer.DataBase.ApplicationName = "Programacion 2 ejemplo";
             DatosLayer.DataBase.ConnectionTimeout = 30;

             string cadenaConexion = DatosLayer.DataBase.ConnectionString;
               var conxion = DatosLayer.DataBase.GetSqlConnection();
            */
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var cliente = customerRepository.ObtenerPorID(txtBuscar.Text);

            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Customers
            {
                CustomerID = tboxCustomerID.Text,
                CompanyName = tboxCompanyName.Text,
                ContactTitle = tboxContactTitle.Text,
                Address = tboxAddress.Text,
                City = tboxCity.Text
            };
            var resultado = 0;
            if (validarCampoNull(nuevoCliente) == false)
            {
                resultado = customerRepository.InsertarCliente(nuevoCliente);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos por favor" + resultado);
            }
            /*
            if (nuevoCliente.CustomerID == "") {
                MessageBox.Show("El Id en el usuario debe de completarse");
               return;    
            }

            if (nuevoCliente.ContactName == "")
            {
                MessageBox.Show("El nombre de usuario debe de completarse");
                return;
            }
            
            if (nuevoCliente.ContactTitle == "")
            {
                MessageBox.Show("El contacto de usuario debe de completarse");
                return;
            }
            if (nuevoCliente.Address == "")
            {
                MessageBox.Show("la direccion de usuario debe de completarse");
                return;
            }
            if (nuevoCliente.City == "")
            {
                MessageBox.Show("La ciudad de usuario debe de completarse");
                return;
            }

            */
        }
        // si encautnra un null enviara true de lo caontrario false
        public Boolean validarCampoNull(Object objeto)
        {

            foreach (PropertyInfo property in objeto.GetType().GetProperties())
            {
                object value = property.GetValue(objeto, null);
                if ((string)value == "")
                {
                    return true;
                }
            }
            return false;
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            var actualizarCliente = ObtenerNuevoCliente();
            int actualizadas = customerRepository.ActualizarCliente(actualizarCliente);
            MessageBox.Show($"Filas actualizadas = {actualizadas}");
        }

        private Customers ObtenerNuevoCliente()
        {

            var nuevoCliente = new Customers
            {
                CustomerID = tboxCustomerID.Text,
                CompanyName = tboxCompanyName.Text,
                ContactTitle = tboxContactTitle.Text,
                Address = tboxAddress.Text,
                City = tboxCity.Text
            };

            return nuevoCliente;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int elimindas = customerRepository.EliminarCliente(tboxCustomerID.Text);
            MessageBox.Show("Filas eliminadas = " + elimindas);
        }

    }
}

       