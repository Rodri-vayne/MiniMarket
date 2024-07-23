using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiniMarket.Logica;

namespace MiniMarket.Datos
{
    public class D_categoria
    {
        public void MostrarCategoria(ref DataTable data)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter dt = new SqlDataAdapter("Select * From categoria", ConexionSqlServer.conectar);
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
        
        public bool InsertarCategoria(L_categoria parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("insertar_categoria", ConexionSqlServer.conectar);
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

        public bool EditarCategoria(L_categoria parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("actualizar_categoria", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_categoria", parametro.id_categoria);
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

        public bool EliminarCategoria(L_categoria parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("eliminar_categoria", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_categoria", parametro.id_categoria);
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

        public void BuscarCategoria(ref DataTable dt, string buscar)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter data = new SqlDataAdapter("buscar_categoria", ConexionSqlServer.conectar);
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
