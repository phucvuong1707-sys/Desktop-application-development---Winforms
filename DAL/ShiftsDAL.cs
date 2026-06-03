using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class ShiftsDAL
    {
        public int OpenShift(ShiftsDTO shift)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Shifts (ShiftCode,UserID,StartTime,OpeningCash,Status)
                                 VALUES (@ShiftCode,@UserID,NOW(),@OpeningCash,'Đang mở');
                                 SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, shift);
            }
        }

        public bool CloseShift(ShiftsDTO shift)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Shifts SET EndTime=NOW(), ClosingCash=@ClosingCash,
                                 ExpectedCash=@ExpectedCash, DifferenceAmount=@DifferenceAmount,
                                 DifferenceNote=@DifferenceNote, Status='Đã chốt'
                                 WHERE ShiftID=@ShiftID";
                return db.Execute(query, shift) > 0;
            }
        }

        public ShiftsDTO GetOpenShiftByUser(int userID)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.QueryFirstOrDefault<ShiftsDTO>(
                    "SELECT * FROM Shifts WHERE UserID=@userID AND Status='Đang mở'", new { userID });
            }
        }
    }
}