using DATOS.ACCESOS;
using DATOS.ENTIDADES;
using System;
using System.Drawing;
using System.Windows.Forms;
using Producto = DATOS.ENTIDADES.Producto;

namespace _2Examen
{
    public partial class FrmProductoscs : Form
    {
        public FrmProductoscs()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;

        ProductoDA productoDA = new ProductoDA();

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (string.IsNullOrEmpty(CodigoTextBox.Text))
                    {
                        errorProvider1.SetError(CodigoTextBox, "Ingrese el código");
                        CodigoTextBox.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(DescripcionTextBox.Text))
                    {
                        errorProvider1.SetError(DescripcionTextBox, "Ingrese una descripción");
                        DescripcionTextBox.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(PrecioTextBox.Text))
                    {
                        errorProvider1.SetError(PrecioTextBox, "Ingrese un precio");
                        PrecioTextBox.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(ExistenciaTextBox.Text))
                    {
                        errorProvider1.SetError(ExistenciaTextBox, "Ingrese una existencia");
                        ExistenciaTextBox.Focus();
                        return;
                    }

                    Producto producto = new Producto();
                    producto.Codigo = CodigoTextBox.Text;
                    producto.Descripcion = DescripcionTextBox.Text;
                    producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                    producto.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);
                  
                }

                catch (Exception)
                {

                }


                ProductosDataGridView.DataSource = productoDA.ListarProductos();



            }

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            ProductosDataGridView.DataSource = productoDA.ListarProductos();
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
