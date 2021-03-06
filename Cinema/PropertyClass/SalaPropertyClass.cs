﻿using Cinema.AttributeClass;
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
        [MandatoryData]
        [PrimaryKey]
        [SqlName("SalaID")]
        [DisplayName("Sala ID")]
        [LookUpKey]
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

        [MandatoryData]
        [SqlName("BrojSale")]
        [DisplayName("Broj sale")]
        [LookUpValue]
        [Numeric]
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
        public string GetLookUpQuery(string ID)
        {
            throw new NotImplementedException();
        }
        public string GetSearchQuery(string rijec)
        {
            throw new NotImplementedException();
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
