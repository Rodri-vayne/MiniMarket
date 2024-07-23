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
    public class D_almacen
    {
        public void MostrarAlmacen(ref DataTable data)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter dt = new SqlDataAdapter("Select * From almacenes", ConexionSqlServer.conectar);
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
        public bool InsertaAlmacen(L_almacen parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("insertar_almacen", ConexionSqlServer.conectar);
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
        public bool ActualizarAlmacen(L_almacen parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("actualizar_almacen", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_almacen", parametro.id_almacen);
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
        public bool EliminarAlmacen(L_almacen parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("delete_almacen", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_almacen", parametro.id_almacen);
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

        public void BuscarAlmacen(ref DataTable data, string buscar)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter dt = new SqlDataAdapter("buscar_almacen", ConexionSqlServer.conectar);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddWithValue("@buscar", buscar);
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
    }
}
