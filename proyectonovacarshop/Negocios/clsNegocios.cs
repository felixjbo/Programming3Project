using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_de_Datos;
using System.Data;


namespace Negocios
{
    public class clsNegocios
    {
        SqlConnection conexion = new SqlConnection();
        public string nombre, apellido, genero, estado, telefono,detalle,fact,precioss;
        AccesoDatos conn = new AccesoDatos("Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True");

        public string detalle_fact()
        {
            AccesoDatos datos = new AccesoDatos("Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True");

            fact = datos.consulta_fact();
            return fact;
        }
        public string detalle_consulta()
        {
            AccesoDatos datos = new AccesoDatos("Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True");

            detalle = datos.consulta_detalle();
            return detalle;
        }
        public double Insertar_Cliente(string p_cedula,string p_tipo, string p_nombre,
            string p_apellido, string p_genero, string p_estado,
            int p_telefono, string p_empresa)
        {
            conexion.ConnectionString = "Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True";
            
            conn.Insertar_Cliente(p_cedula, p_tipo, p_nombre, p_apellido, p_genero, p_estado, p_telefono, p_empresa);
            return 0;
        }

        private string iDENTIFICACION;

        public string IDENTIFICACION 
        { get => iDENTIFICACION;  
          set => iDENTIFICACION = value; }
        

        public void Consulta_Clientes() 
        {
            AccesoDatos datos = new AccesoDatos("Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True");
            
            nombre = datos.Consulta_Clientes(IDENTIFICACION);
            apellido = datos.SALIDAAP;
            genero = datos.SALIDAG;
            estado = datos.SALIDAEST;
            telefono = datos.SALIDAT;
        }

        static void Main(string[] args)
        {
        }

        private string marca;
        private string modelo;
        private string estilo;
        private string combustible;
        private string transmision;
        private string financiado;
        private string puertas;
        private int año;
        private string color;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Estilo { get => estilo; set => estilo = value; }
        public string Combustible { get => combustible; set => combustible = value; }
        public string Transmision { get => transmision; set => transmision = value; }
        public string Financiado { get => financiado; set => financiado = value; }
        public string Puertas { get => puertas; set => puertas = value; }
        public int Año { get => año; set => año = value; }
        public string Color { get => color; set => color = value; }
        

        public double insertar_Detalle()
        {
            conexion.ConnectionString = "Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True";
            conn.insertar_detalle(marca, modelo, estilo, combustible, transmision, financiado, puertas, año, color);


            return 0;
        }


        private string MODELO;
        private string ANO;

        
        

        public string precios() 
        {
            conexion.ConnectionString = "Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True";
            precioss = Convert.ToString(conn.precio(MODELO1,ANO1));
            return precioss;
        }

        private int numm;
        private string ID_Clientee;
        private int num_detallee;
        private string tipo_pagoe;
        private int precioe;
        private string IVAe;
        private int totale;
        private DateTime fechae;

        public int Numm { get => numm; set => numm = value; }
        public string ID_Clientee1 { get => ID_Clientee; set => ID_Clientee = value; }
        public int Num_detallee { get => num_detallee; set => num_detallee = value; }
        public string Tipo_pagoe { get => tipo_pagoe; set => tipo_pagoe = value; }
        public int Precioe { get => precioe; set => precioe = value; }
        public string IVAe1 { get => IVAe; set => IVAe = value; }
        public int Totale { get => totale; set => totale = value; }
        public string MODELO1 { get => MODELO; set => MODELO = value; }
        public string ANO1 { get => ANO; set => ANO = value; }
        public DateTime Fechae { get => fechae; set => fechae = value; }
       

        public double factura() 
        {
            conexion.ConnectionString = "Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True";
            conn.factura(Numm,ID_Clientee1,Num_detallee,Tipo_pagoe,Precioe,IVAe,Totale,Fechae);

            return 0;
        }

        private int num_detalle;
        public int Num_detalle { get => num_detalle; set => num_detalle = value; }
        public DataTable obtenerDetalle()
        {

            AccesoDatos ObjDatos = new AccesoDatos("Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True");
            DataTable dt = ObjDatos.obtenerDetalle(Num_detalle);

            return dt;


        }
    }
}
