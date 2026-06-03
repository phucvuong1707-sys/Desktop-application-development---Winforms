using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class RolesDAL
    {
        public List<RolesDTO> GetAll()
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<RolesDTO>("SELECT * FROM Roles").AsList();
            }
        }
    }
}