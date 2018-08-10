using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    //a.Deberá heredar de Almacenador e implementar IAlmacenable.
    //b.El método Guardar deberá insertar un archivo en la base de datos.
    //c.El método Leer recibirá el nombre de la tabla a consultar. Deberá leer y retornar todos los archivos de la base de datos.
    //d.Tanto en Leer como en Guardar capturar y relanzar las excepciones.
    //e.El método MostrarArchivos por el momento sólo deberá recorrer la lista de archivos y por cada uno simular un retardo de 5 segundos.
    //f.Agregar un constructor en el cual se deberá cargar la lista a partir de los datos guardados en la base.
    //g.Sobrecargar el operador + para agregar un archivo a la lista siempre y cuando no supere la capacidad, caso contrario lanzará una excepción con el mensaje "El disco está lleno!".
    public class DiscoElectronico: Almacenador, IAlmaceable<List<Archivo>, Archivo>
    {
      
        private  SqlCommand comando;
        private  SqlConnection conexion;

        public List<Archivo> archivosGuardados;
        
        private DiscoElectronico()
            :this(5)
        {
            this.archivosGuardados = new List<Archivo>();
           
            
        }
//f.	Agregar un constructor que reciba la capacidad y en el cual se deberá cargar la lista a partir de los datos guardados en la base.
//g.	El constructor privado inicializará la lista. Por defecto la capacidad será 5.

        public DiscoElectronico(int cap)
            :base(cap)
        {
            conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            // CREO UN OBJETO SQLCOMMAND
            comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            comando.Connection = conexion;
            //List<Archivo> lista = this.Leer("Archivo");
            archivosGuardados = this.Leer("Archivo");
            //foreach (Archivo item in archivosGuardados)
            //{
            //    archivosGuardados.Add(item);
            //}
            
            
        }

        public override void MostrarArchivos()
        {
            foreach (Archivo item in archivosGuardados)
            {
                item.ToString();
                Thread.Sleep(5000);
                DispararEvento(item);
                
            }

        }
        //bool Guardar(V elemento);
        //T Leer(String path);
        #region Insert
        public bool Guardar(Archivo elemento)
        {
            string sql = "";
            
           
                
                sql = string.Format( "INSERT INTO Archivo (nombre,contenido) VALUES('{0}','{1}')" ,elemento.Nombre, elemento.Contenido);
            
            try
            {
                comando.CommandText = sql;
                conexion.Open();
                comando.ExecuteNonQuery();                
            }
            catch (Exception e)
            {

                return false;
            }
            finally
            {
                   conexion.Close();
            }
            return true;
        }
        #endregion
        #region Select
        public List<Archivo> Leer(string path)
        {
            bool TodoOk = false;
            List<Archivo> lista = new List<Archivo>();
            Archivo p = null;
            try
            {
                string cadenaComando = string.Format("SELECT * FROM {0}", path);
                comando.CommandText = cadenaComando;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    
                        p = new Archivo(oDr["nombre"].ToString(), oDr["contenido"].ToString());
                        lista.Add(p);
                    


                }
                TodoOk = true;
                oDr.Close();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (TodoOk)
                    conexion.Close();
            }
            return lista;
        }
        #endregion
        #region Delete
        //public static bool Eliminar(Producto p, int id)
        //{

        //    string sql =string.Format ( "DELETE  FROM Productos WHERE id = {0}" , id);

        //    return EjecutarNonQuery(sql);
        //}
        #endregion
        #region Update
        //public static bool ModificarEmpresa(Producto p, int id)
        //{
        //    ProductoA pATest = null;
        //    if (p is ProductoA)
        //    {
        //        pATest = (ProductoA)p;
        //    }
        //    int idTest = id;
        //    //string sql = "UPDATE Empresas SET descripcion = '" + p.Descripcion + "', direccion = '";
        //    //sql = sql + e.Direccion + "', ganancias = " + e.Ganancias.ToString().Replace(",", ".") + " WHERE id = " + e.ID.ToString();
        //    string sql = string.Format("UPDATE Productos SET descripcion = '{0}', tipo = '{1}', diametro = {2}, material = '{3}' where id={4};",pATest.Descripcion.ToString(), 'A',pATest.Diametro, pATest.Material.ToString(), idTest);
        //    return EjecutarNonQuery(sql);
        //}
        #endregion

        private bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                conexion.Open();

                // EJECUTO EL COMMAND
                comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    conexion.Close();
            }
            return todoOk;
        }

        public static DiscoElectronico operator +(Archivo a, DiscoElectronico d)
        {

            foreach (Archivo item in d.archivosGuardados)
            {
                if (d.archivosGuardados.Contains(item))
                {
                    return d;
                }
                if (d.capacidad < 5)
                {
                    d.archivosGuardados.Add(item);
                }
                //lanzar mensaje

            }
            return d;
            
        }
        
    }
}
