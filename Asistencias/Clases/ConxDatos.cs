using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Asistencias.Clases
{
    internal class ConxDatos
    {
         string cadena ="Server=127.0.0.1;Port=3308;Database=ControlAsistencia;Uid=ivancd;Pwd=cedilloSQL";
        MySqlConnection conexion;
        private void  Conectar()
        {
            try
            {
                 conexion = new MySqlConnection(cadena);
                conexion.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void Desconectar()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desconectar de la base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet ejecutar(String comando)
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public bool ejecutarComando(string comando)
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar comando:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
