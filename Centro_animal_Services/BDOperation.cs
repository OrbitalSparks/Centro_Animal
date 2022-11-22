using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Centro_animal_Services
{
    public class BDOperation<T>
    {

 

        private string StringConeccion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\brian\\source\\repos\\Centro_Animal\\Centro_animalDB\\CADatabase\\CAnimal_DataBase.mdf;Integrated Security=True";
        public List<T> GBDOperation<T>(string SlqQuery)
        {
            List<T> lsitResuslt;
           // string sql = "SELECT IdDepart, Nombredepart FROM Departamento ORDER BY IdDepart";
            using (var connection = new SqlConnection(StringConeccion))
            {
                lsitResuslt = connection.Query<T>(SlqQuery).ToList();
            }
            return lsitResuslt;
        }

        //        public void Operationexecute( DeclaracionJurada declaracionJurada) {

        //            string sql = "INSERT INTO Declarajada (IdPersona, FechaIngreso, IdStatus, Fechacreacion) Values ( @dPersona, @FechaIngreso, @IdStatus, @Fechacreacion);";

        //            using (var connection = new SqlConnection(StringConeccion))
        //{

        //                var affectedRows = connection.Execute(sql, new { IdPersona = 1, FechaIngreso=declaracionJurada.Fecha, IdStatus=1, Fechacreacion=DateTime.Now });

        //                //Console.WriteLine(affectedRows);

        //               // var customer = connection.Query<Customer>("Select * FROM CUSTOMERS WHERE CustomerName = 'Mark'").ToList();

        //               // FiddleHelper.WriteTable(customer);
        //            }

        //        }
        public int OperationExecute(string SQLExecute, object paramsList)
        {
            int affectedRows;
            using (var connection = new SqlConnection(StringConeccion))
            {
                affectedRows = connection.Execute(SQLExecute, paramsList);
            }

            return affectedRows;
        }
        //Ejecutar INSERT, UPDATE, DELETE retornando Identity
        public int OperationExecuteWithIdentity(string SQLExecute, object paramsList)
        {
            int IdentityReturn;
            using (var connection = new SqlConnection(StringConeccion))
            {
                IdentityReturn = connection.ExecuteScalar<int>(SQLExecute, paramsList);
            }

            return IdentityReturn;
        }

    }
}
