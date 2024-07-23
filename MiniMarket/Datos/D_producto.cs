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
    public class D_producto
    {
        public void MostrarProducto(ref DataTable dt, string buscador)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter data = new SqlDataAdapter("mostrar_producto", ConexionSqlServer.conectar);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("@buscar", buscador);
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
        public bool InsertarProducto(L_producto parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("insertar_producto", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", parametro.descripcion);
                cmd.Parameters.AddWithValue("@id_marca", parametro.id_marca);
                cmd.Parameters.AddWithValue("@id_medida", parametro.id_medida);
                cmd.Parameters.AddWithValue("@id_categoria", parametro.id_categoria);
                cmd.Parameters.AddWithValue("@stock_minimo", parametro.stock_minimo);
                cmd.Parameters.AddWithValue("@stock_maximo", parametro.stock_maximo);
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

        public bool ActualizarProducto(L_producto parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("actualizar_producto", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", parametro.id_producto);
                cmd.Parameters.AddWithValue("@descripcion", parametro.descripcion);
                cmd.Parameters.AddWithValue("@id_marca", parametro.id_marca);
                cmd.Parameters.AddWithValue("@id_medida", parametro.id_medida);
                cmd.Parameters.AddWithValue("@id_categoria", parametro.id_categoria);
                cmd.Parameters.AddWithValue("@stock_minimo", parametro.stock_minimo);
                cmd.Parameters.AddWithValue("@stock_maximo", parametro.stock_maximo);
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

        public bool EliminarProducto(L_producto parametro)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlCommand cmd = new SqlCommand("eliminar_producto", ConexionSqlServer.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", parametro.id_producto);
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
                ConexionSqlServer.Closed();
            }
        }
        #region "Funciones Marca, Categoria, Medida a Producto"
        public void MostrarMarcayProducto(ref DataTable dtm, string buscarM)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter datam = new SqlDataAdapter("mostrar_marca_producto", ConexionSqlServer.conectar);
                datam.SelectCommand.CommandType = CommandType.StoredProcedure;
                datam.SelectCommand.Parameters.AddWithValue("@buscar", buscarM);
                datam.Fill(dtm);
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

        public void MostrarCategoriayProducto(ref DataTable dtc, string buscarC)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter datam = new SqlDataAdapter("mostrar_categoria_producto", ConexionSqlServer.conectar);
                datam.SelectCommand.CommandType = CommandType.StoredProcedure;
                datam.SelectCommand.Parameters.AddWithValue("@buscar", buscarC);
                datam.Fill(dtc);
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

        public void MostrarUnidadMedidayProducto(ref DataTable dtu, string buscarU)
        {
            try
            {
                ConexionSqlServer.Open();
                SqlDataAdapter datam = new SqlDataAdapter("mostrar_unidad_medida_producto", ConexionSqlServer.conectar);
                datam.SelectCommand.CommandType = CommandType.StoredProcedure;
                datam.SelectCommand.Parameters.AddWithValue("@buscar", buscarU);
                datam.Fill(dtu);
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
        #endregion
    }
}
