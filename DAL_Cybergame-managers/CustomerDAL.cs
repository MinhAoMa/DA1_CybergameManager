using DAL_Cybergame_managers.helper;
using DAL_Cybergame_managers.interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers
{

    public class CustomerDAL : ICustomerDAL
    {
        private const string PARM_CUSTOMERID = "@idCustomer";
        private const string PARM_CUSTOMERNAME = "@nameCustomer";
        private const string PARM_ACCOUNTCUS = "@accountCus";
        private const string PARM_PASSCUS = "@passwordCus";
        private const string PARM_MONEYCUS = "@moneyCus";
        private const string PARM_TIMELEFTCUS = "@timeLeftCus";
        private const string PARM_TOTALTIMECUS = "@totalTime";
        private const string PARM_STATUS = "@status";


        public int Insert(int idCustomer, string nameCustomer, string accountCus, string passwordCus, decimal moneyCus, TimeSpan timeLeftCus)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CUSTOMERID,SqlDbType.Int),
                new SqlParameter(PARM_CUSTOMERNAME,SqlDbType.NVarChar,120),
                new SqlParameter(PARM_ACCOUNTCUS,SqlDbType.VarChar,30),
                new SqlParameter(PARM_PASSCUS,SqlDbType.VarChar,30),
                new SqlParameter(PARM_MONEYCUS,SqlDbType.Decimal),
                new SqlParameter(PARM_TIMELEFTCUS,SqlDbType.Time),
                new SqlParameter(PARM_TOTALTIMECUS,SqlDbType.Time),
                new SqlParameter(PARM_STATUS,SqlDbType.Bit)

            };
            parm[0].Value = idCustomer;
            parm[1].Value = nameCustomer;
            parm[2].Value = accountCus;
            parm[3].Value = passwordCus;
            parm[4].Value = moneyCus;
            parm[5].Value = timeLeftCus;
            parm[6].Value = new TimeSpan(0);
            parm[7].Value = false;
            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "ThanhVien_ins", parm);
        }

        public int Update(int idCustomer, string nameCustomer, string accountCus, string passwordCus, decimal moneyCus, TimeSpan timeLeftCus, TimeSpan totalTime)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CUSTOMERID,SqlDbType.Int),
                new SqlParameter(PARM_CUSTOMERNAME,SqlDbType.NVarChar,120),
                new SqlParameter(PARM_ACCOUNTCUS,SqlDbType.VarChar,30),
                new SqlParameter(PARM_PASSCUS,SqlDbType.VarChar,30),
                new SqlParameter(PARM_MONEYCUS,SqlDbType.Decimal),
                new SqlParameter(PARM_TIMELEFTCUS,SqlDbType.Time),
                new SqlParameter(PARM_TOTALTIMECUS,SqlDbType.Time),
                new SqlParameter(PARM_STATUS,SqlDbType.Bit)
            };
            parm[0].Value = idCustomer;
            parm[1].Value = nameCustomer;
            parm[2].Value = accountCus;
            parm[3].Value = passwordCus;
            parm[4].Value = moneyCus;
            parm[5].Value = timeLeftCus;
            parm[6].Value = new TimeSpan(0);
            parm[7].Value = false;
            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "ThanhVien_UPDT", parm);
        }
        public int UpdateMoney( int idCustomer, string nameCustomer, decimal moneyCus,TimeSpan timeLeftCus) {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CUSTOMERID,SqlDbType.Int),
                new SqlParameter(PARM_CUSTOMERNAME,SqlDbType.NVarChar,120),
                new SqlParameter(PARM_MONEYCUS,SqlDbType.Decimal),
                new SqlParameter(PARM_TIMELEFTCUS,SqlDbType.Time),
               

            };

            parm[0].Value = idCustomer;
            parm[1].Value = nameCustomer;
            parm[2].Value = moneyCus;
            parm[3].Value = timeLeftCus;

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "ThanhVien_UPDT_money", parm);
        }
        public int Delete(int idCustomer)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CUSTOMERID,SqlDbType.Int)
            };
            parm[0].Value = idCustomer;

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "ThanhVien_Del", parm);
        }
        public int checkMember_ID(int idCustomer)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CUSTOMERID,SqlDbType.Int)
            };
            parm[0].Value = idCustomer;
            return (int)Sqlhelper.ExecuteScalar(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "tbl_ThanhVien_Check_ID", parm);
        }
        

        public DataTable getAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "ThanhVien_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("idThanhVien", typeof(int));
            table.Columns.Add("Ten", typeof(string));
            table.Columns.Add("TaiKhoan", typeof(string));
            table.Columns.Add("MatKhau", typeof(string));
            table.Columns.Add("SoTien", typeof(decimal));
            table.Columns.Add("TGConLai", typeof(TimeSpan));
            table.Columns.Add("TongTGChoi", typeof(TimeSpan));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["idThanhVien"].ToString()), dra["Ten"].ToString(), dra["TaiKhoan"].ToString(), dra["MatKhau"].ToString(), decimal.Parse(dra["SoTien"].ToString()), TimeSpan.Parse(dra["TGConLai"].ToString()), TimeSpan.Parse(dra["TongTGChoi"].ToString()));
            }
            dra.Dispose();
            return table;
        }
        public DataTable getMember_ID(int idCustomer)
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "ThanhVien_Sel_ID", null);
            DataTable table = new DataTable();
            table.Columns.Add("idThanhVien", typeof(int));
            table.Columns.Add("Ten", typeof(string));
            table.Columns.Add("TaiKhoan", typeof(string));
            table.Columns.Add("MatKhau", typeof(string));
            table.Columns.Add("SoTien", typeof(decimal));
            table.Columns.Add("TGConLai", typeof(TimeSpan));
            table.Columns.Add("TongTGChoi", typeof(TimeSpan));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["idThanhVien"].ToString()), dra["Ten"].ToString(), dra["TaiKhoan"].ToString(), dra["MatKhau"].ToString(), decimal.Parse(dra["SoTien"].ToString()), TimeSpan.Parse(dra["TGConLai"].ToString()), TimeSpan.Parse(dra["TongTGChoi"].ToString()));
            }
            dra.Dispose();
            return table;
        }

       
    }
}
