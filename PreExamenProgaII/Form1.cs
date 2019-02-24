using PreExamenProgaII.AltoVAlyrio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreExamenProgaII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Producto> ListaProductos = new List<Producto>();

        private void button1_Click(object sender, EventArgs e)
        {
            Bodega Bodega1 = new Bodega
            {
                NumerodeBodega = "01",
                UbicacionBodega = "Zona 1",
                Departamento = "Guatemala" ,
                

            };

            Bodega Bodega2 = new Bodega
            {
                NumerodeBodega = "02",
                UbicacionBodega = "Zona 5",
                 Departamento = "Guatemala"
            };

            Bodega Bodega3 = new Bodega
            {
                NumerodeBodega = "03",
                UbicacionBodega = "Zona 18",
                 Departamento = "Guatemala"
            };

            Bodega Bodega4 = new Bodega
            {
                NumerodeBodega = "04",
                UbicacionBodega = "Zona 12",
                 Departamento = "Guatemala"
            };

            Bodega Bodega5 = new Bodega
            {
                NumerodeBodega = "05",
                UbicacionBodega = "Zona 14",
                Departamento = "Guatemala"

            };

            List<Bodega> ListaBodega = new List<Bodega>
            {
                Bodega1,
                Bodega2,
                Bodega3,
                Bodega4,
                Bodega5
            };

            var producto1 = new Producto
            {
                //Producto
                DescripciondelProducto = "Queso cheddar",
                Marca = "Suli",
                Precio = 2.50,
                Refrigerado = true,
                Fecha = DateTime.Now,
                Peso = "30 libras",
                
                //Categoria
                 ID ="123",
                 NombreCategoria = "Lacteos",

                 //Tipo de Empaque
                 TipoEmpaque  = "Caja",
                 
                 //bodega
                 Bodegas = ListaBodeg,

            };

            var producto2 = new Producto
            {

                DescripciondelProducto = "Queso crema en contenedor",
                Marca = "Dos pinos",
                Precio = 4.50,
                Refrigerado = true,
                Fecha = DateTime.Now,
                Peso = "20 libras",
                ID = "254",
                NombreCategoria = "Lacteos",
                TipoEmpaque = "Fardo de 24 unidades"
            };

            var producto3 = new Producto
            {
                DescripciondelProducto = "Crema en vaso de 8 onzas",
                Marca = "Superior",
                Precio = 8.90,
                Refrigerado = true,
                Fecha = DateTime.Now,
                Peso = "40 libras",
                ID = "477",
                NombreCategoria = "Lacteos",
                TipoEmpaque = "Fardo de 24 unidades"
            };

            var producto4 = new Producto
            {

                DescripciondelProducto = "Dip de queso sabor chipotle",
                Marca = "Superior",
                Precio = 10.90,
                Refrigerado = true,
                Fecha = DateTime.Now,
                Peso = "40 libras",
                ID = "789",
                NombreCategoria = "Lacteos",
                TipoEmpaque = "Fardo de 24 unidades"

            };

            var producto5 = new Producto
            {
                DescripciondelProducto = "Queso mozzarella",
                Marca = "San Julian",
                Precio = 12.00,
                Refrigerado = true,
                Fecha = DateTime.Now,
                Peso = "40 libras",
                ID = "587",
                NombreCategoria = "Lacteos",
                TipoEmpaque = "Fardo de 24 unidades"
            };

                 
        }
    }
}
