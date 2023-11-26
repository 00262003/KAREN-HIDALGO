using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using capaENTIDAD;

namespace capaDATOS
{
    public class usario
    {
      public List<usario> listar(){

            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
             try
                {
                    string query = "select IdUSARIO, documento, nombreCompleto, correo,clave, estado from usario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr= cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.add(new usario()) { 


                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }

        }
    }
}
