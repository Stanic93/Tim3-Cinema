using Cinema.AttributeClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.PropertyClass
{
    class SalaPropertyClass : PropertyInterface
    {
        #region Atributi    
        public short salaID;
        public short brojSale;
        #endregion

        #region Properties
        [PrimaryKey]
        [SqlName("SalaID")]
        [DisplayName("Sala ID")]
        public short SalaID
        {
            get
            {
                return salaID;
            }
            set
            {
                salaID = value;
            }
        }

        [SqlName("BrojSale")]
        [DisplayName("Broj sale")]
        public short BrojSale
        {
            get
            {
                return brojSale;
            }
            set
            {
                brojSale = value;
            }
        }
        #endregion

        #region Queries
        public string GetDeleteQuery()
        {
            return @"DELETE from dbo.Sala where SalaID = @SalaID";
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO dbo.Sala (BrojSale) values (@BrojSale)";
        }

        public string GetSelectQuery()
        {
            return @"SELECT SalaID, BrojSale from dbo.Sala";
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE
                     set 
                     BrojSale = @BrojSale
                     where SalaID = @SalaID";
        }
        #endregion

       
        #region Parameters
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@BrojSale", System.Data.SqlDbType.TinyInt);
                parameter.Value = brojSale;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@SalaID", System.Data.SqlDbType.SmallInt);
                parameter.Value =salaID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@SalaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = salaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@BrojSale", System.Data.SqlDbType.TinyInt);
                parameter.Value = brojSale;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion


        
    }
}
