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
    public class D_marca
    {
        public void MostrarMarca(ref DataTable data)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter dt = new SqlDataAdapter("Select * From marca", ConexionSqlServer.conectar);
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

        public bool InsertarMarca(L_marca parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("insertar_marca", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public bool EditarMarca(L_marca parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("actualizar_marca", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_marca", parametro.id_marca);
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

        public bool EliminarMarca(L_marca parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("eliminar_marca", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_marca", parametro.id_marca);
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

        public void BuscarMarca(ref DataTable dt, string buscar)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter data = new SqlDataAdapter("buscar_marca", ConexionSqlServer.conectar);
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
