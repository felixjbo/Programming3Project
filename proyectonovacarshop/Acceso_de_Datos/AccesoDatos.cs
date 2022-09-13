using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Acceso_de_Datos
{
    
    public class AccesoDatos
    {
        public int precioU,precioo;
        public string SALIDAN, SALIDAAP, SALIDAG, SALIDAEST, SALIDAT,detalle,fact;
        public string objconex = "";
        SqlConnection conexion = new SqlConnection();
        SqlDataAdapter adaptador;
        DataTable tblDetalle;

        public AccesoDatos(string conn)
        {
            this.objconex = conn;
        }

        public int precio(string MODELO,string ANO) 
        {
            
            if (MODELO == "Montero")
            {
                precioo = 5000000;
            }
            else if (MODELO == "Lancer")
            {
                precioo = 6000000;
            }
            else if (MODELO == "Mirage")
            {
                precioo = 6000000;
            }
            else if (MODELO == "Outlander")
            {
                precioo = 8000000;
            }
            else if (MODELO == "Yaris")
            {
                precioo = 4000000;
            }
            else if (MODELO == "Corolla")
            {
                precioo = 5000000;
            }
            else if (MODELO == "Rav4")
            {
                precioo = 13000000;
            }
            else if (MODELO == "Prado")
            {
                precioo = 14000000;
            }
            else if (MODELO == "BT-50")
            {
                precioo = 7000000;
            }
            else if (MODELO == "CX-5")
            {
                precioo = 9000000;
            }
            else if (MODELO == "Civic")
            {
                precioo = 5000000;
            }
            else if (MODELO == "Crv")
            {
                precioo = 4000000;
            }
            else if (MODELO == "Fit")
            {
                precioo = 8000000;
            }
            else if (MODELO == "Pilot")
            {
                precioo = 3000000;
            }
            else if (MODELO == "Sentra")
            {
                precioo = 5000000;
            }
            else if (MODELO == "Kicks")
            {
                precioo = 4000000;
            }
            else if (MODELO == "Frontier")
            {
                precioo = 6000000;
            }
            else if (MODELO == "Qashqai")
            {
                precioo = 7000000;
            }
            else if (MODELO == "Elantra")
            {
                precioo = 4000000;
            }
            else if (MODELO == "Creta")
            {
                precioo = 9000000;
            }
            else if (MODELO == "Tucson")
            {
                precioo = 9000000;
            }
            else if (MODELO == "Accent")
            {
                precioo = 7000000;
            }
            precioo = precioo + 0;

            if (ANO == "2012") 
            {
                precioU = precioo + 500000;
            }
            else if(ANO == "2013")
            {
                precioU = precioo + 1000000;
            }
            if (ANO == "2014")
            {
                precioU = precioo + 2000000;
            }
            if (ANO == "2015")
            {
                precioU = precioo + 3000000;
            }
            if (ANO == "2016")
            {
                precioU = precioo + 4000000;
            }
            if (ANO == "2017")
            {
                precioU = precioo + 5000000;
            }
            if (ANO == "2018")
            {
                precioU = precioo + 6000000;
            }
            if (ANO == "2019")
            {
                precioU = precioo + 7000000;
            }
            if (ANO == "2020")
            {
                precioU = precioo + 8000000;
            }
            if (ANO == "2021")
            {
                precioU = precioo + 9000000;
            }
            return precioU;
        }
        public string consulta_fact() 
        {
            try
            {
                SqlConnection ObjCone = new SqlConnection(this.objconex);
                SqlCommand Comando = new SqlCommand();
                ObjCone.Open();

                Comando.Connection = ObjCone;
                string query = "Select num_fact from Factura where num_fact = (SELECT max(num_fact) FROM Factura)";
                Comando.CommandText = query;

                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    fact = reader["num_Fact"].ToString();
                }
                ObjCone.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return fact;

        }
        public string consulta_detalle() 
        {
            try
            {
                SqlConnection ObjCone = new SqlConnection(this.objconex);
                SqlCommand Comando = new SqlCommand();
                ObjCone.Open();

                Comando.Connection = ObjCone;
                string query = "Select num_detalle from Detalle_Fact where num_detalle = (SELECT max(num_detalle) FROM Detalle_Fact)"  ;
                Comando.CommandText = query;

                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    detalle = reader["num_detalle"].ToString();
                }
                ObjCone.Close();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return detalle;
        }
        public void Insertar_Cliente(string p_cedula,
                                       string p_tipo,
                                       string p_nombre,
                                       string p_apellido,
                                       string p_genero,
                                       string p_estado,
                                       int p_telefono,
                                       string p_empresa)
        {
            try
            {
                SqlConnection ObjCone = new SqlConnection(this.objconex);


                //Coneccion.ConnectionString=("");

                SqlCommand Comando = new SqlCommand();


                SqlParameter cedula = new SqlParameter("@cedula", SqlDbType.VarChar);
                cedula.Value = p_cedula;

                SqlParameter tipo = new SqlParameter("@tipo", SqlDbType.VarChar);
                tipo.Value = p_tipo;

                SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar);
                nombre.Value = p_nombre;

                SqlParameter apellido = new SqlParameter("@apellido", SqlDbType.NVarChar);
                apellido.Value = p_apellido;

                SqlParameter genero = new SqlParameter("@genero", SqlDbType.NVarChar);
                genero.Value = p_genero;

                SqlParameter estado = new SqlParameter("@estado", SqlDbType.NVarChar);
                estado.Value = p_estado;

                SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.Int);
                telefono.Value = p_telefono;

                SqlParameter empresa = new SqlParameter("@empresa", SqlDbType.NVarChar);
                empresa.Value = p_empresa;



                Comando.Parameters.Add(cedula);
                Comando.Parameters.Add(tipo);
                Comando.Parameters.Add(nombre);
                Comando.Parameters.Add(apellido);
                Comando.Parameters.Add(genero);
                Comando.Parameters.Add(estado);
                Comando.Parameters.Add(telefono);
                Comando.Parameters.Add(empresa);



                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "insertarCLIENTE";
                ObjCone.Open();
                Comando.Connection = ObjCone;
                Comando.ExecuteNonQuery();
                ObjCone.Close();
        }

            catch (SqlException e)
            {
                throw e;
            }
}
            
        public string Consulta_Clientes(string identificacion)
        {
            try
            {
                SqlConnection ObjCone = new SqlConnection(this.objconex);
                SqlCommand Comando = new SqlCommand();
                ObjCone.Open();

                Comando.Connection = ObjCone;
                string query = "select NOMBRE,APELLIDO,GENERO,ESTADO_CIVIL,TELEFONO from cliente where IDENTIFICACION ='" + identificacion + "'";
                Comando.CommandText = query;

                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    SALIDAN = reader["NOMBRE"].ToString();
                    SALIDAAP = reader["APELLIDO"].ToString();
                    SALIDAG = reader["GENERO"].ToString();
                    SALIDAEST = reader["ESTADO_CIVIL"].ToString();
                    SALIDAT = reader["TELEFONO"].ToString();
                }
                ObjCone.Close();
                return SALIDAN;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void insertar_detalle
        (string p_marca,string p_modelo, string p_estilo, string p_combustible, string p_transmision,
           string p_financiado,string p_puertas, int p_año, string p_color) 
        {
            try
            {
                SqlConnection ObjCone = new SqlConnection(this.objconex);


                SqlCommand Comando = new SqlCommand();


                SqlParameter marca = new SqlParameter("@marca", SqlDbType.VarChar);
                marca.Value = p_marca;
                SqlParameter modelo = new SqlParameter("@modelo", SqlDbType.VarChar);
                modelo.Value = p_modelo;
                SqlParameter estilo = new SqlParameter("@estilo", SqlDbType.VarChar);
                estilo.Value = p_estilo;
                SqlParameter combustible = new SqlParameter("@combustible", SqlDbType.VarChar);
                combustible.Value = p_combustible;
                SqlParameter transmision = new SqlParameter("@transmision", SqlDbType.VarChar);
                transmision.Value = p_transmision;
                SqlParameter financiado = new SqlParameter("@finaciado", SqlDbType.VarChar);
                financiado.Value = p_financiado;
                SqlParameter num_puertas = new SqlParameter("@num_puertas", SqlDbType.VarChar);
                num_puertas.Value = p_puertas;
                SqlParameter año_vehiculo = new SqlParameter("@año_vehiculo", SqlDbType.Int);
                año_vehiculo.Value = p_año;
                SqlParameter color = new SqlParameter("@color", SqlDbType.VarChar);
                color.Value = p_color;

                Comando.Parameters.Add(marca);
                Comando.Parameters.Add(modelo);
                Comando.Parameters.Add(estilo);
                Comando.Parameters.Add(combustible);
                Comando.Parameters.Add(transmision);
                Comando.Parameters.Add(financiado);
                Comando.Parameters.Add(num_puertas);
                Comando.Parameters.Add(año_vehiculo);
                Comando.Parameters.Add(color);



                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "insert_detalle";
                ObjCone.Open();
                Comando.Connection = ObjCone;
                Comando.ExecuteNonQuery();
                ObjCone.Close();
            }

            catch (SqlException e)
            {
                throw e;
            }
        }
        public void factura(int p_num,string p_ID_Cliente,int p_num_detalle, string p_tipo_pago,int p_precio,string p_IVA,int p_total,DateTime p_fecha) 
        {
            try
            {
                SqlConnection ObjCone = new SqlConnection(this.objconex);


                SqlCommand Comando = new SqlCommand();


                SqlParameter Num_fact = new SqlParameter("@Num_fact", SqlDbType.Int);
                Num_fact.Value = p_num;
                SqlParameter ID_Cliente = new SqlParameter("@ID_Cliente", SqlDbType.VarChar);
                ID_Cliente.Value = p_ID_Cliente;
                SqlParameter Num_Detalle = new SqlParameter("@Num_Detalle", SqlDbType.Int);
                Num_Detalle.Value = p_num_detalle;
                SqlParameter tipo_pago = new SqlParameter("@tipo_pago", SqlDbType.VarChar);
                tipo_pago.Value = p_tipo_pago;
                SqlParameter precio = new SqlParameter("@precio", SqlDbType.Int);
                precio.Value = p_precio;
                SqlParameter IVAA = new SqlParameter("@IVA", SqlDbType.VarChar);
                IVAA.Value = p_IVA;
                SqlParameter total = new SqlParameter("@total", SqlDbType.Int);
                total.Value = p_total;
                SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.DateTime);
                fecha.Value = p_fecha;

                Comando.Parameters.Add(Num_fact);
                Comando.Parameters.Add(ID_Cliente);
                Comando.Parameters.Add(Num_Detalle);
                Comando.Parameters.Add(tipo_pago);
                Comando.Parameters.Add(precio);
                Comando.Parameters.Add(IVAA);
                Comando.Parameters.Add(total);
                Comando.Parameters.Add(fecha);





                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "insert_factura";
                ObjCone.Open();
                Comando.Connection = ObjCone;
                Comando.ExecuteNonQuery();
                ObjCone.Close();
            }

            catch (SqlException e)
            {
                throw e;
            }


        }
        public DataTable obtenerDetalle(int Num_Deta) 
        {
            conexion.ConnectionString = "Data Source=DESKTOP-6G43AQL;Initial Catalog=VENTASAUTOSDB;Integrated Security=True";
            using (var connection = conexion)
            {
                
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "factt";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Num_Detalle", Num_Deta);
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                    return dt;
                }
            }
        }
    }
}
