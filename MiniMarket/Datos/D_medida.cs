using MiniMarket.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniMarket.Datos
{
    public class D_medida
    {
        public void MostrarMedia(ref DataTable data)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter dt = new SqlDataAdapter("Select * From unidades_medida", ConexionSqlServer.conectar);
                dt.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
            finally
            {
                ConexionSqlServer.Closed();
            }
        }

        public bool InsertarMedida(L_medida parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("insertar_medida", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@abreviatura", parametro.abreviatura);
                cmd.Parameters.AddWithValue("@descripcion", parametro.descripcion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionSqlServer.Closed();
            }
        }

        public bool ActualizarMedia(L_medida parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("actualizar_medida", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_medida", parametro.id_medida);
                cmd.Parameters.AddWithValue("@abreviatura", parametro.abreviatura);
                cmd.Parameters.AddWithValue("@descripcion", parametro.descripcion);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionSqlServer.Closed();
            }
        }

        public bool EliminarMarca(L_medida parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("eliminar_medida", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_medida", parametro.id_medida);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {

            }
        }
        public void BuscarMedida(ref DataTable dt, string buscar)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter data = new SqlDataAdapter("buscar_medida", ConexionSqlServer.conectar);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("@buscar", buscar);
                data.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                ConexionSqlServer.Closed();
            }
        }
    }
}
