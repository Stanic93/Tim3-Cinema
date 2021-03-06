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
    class ZanrPropertyClass : PropertyInterface
    {
        #region attribute

        private short zanrID;
        private string naziv;

        #endregion

        #region properties

        [MandatoryData]
        [PrimaryKey]
        [LookUpKey]
        [SqlName("ZanrID")]
        [DisplayName("ZanrID")]
        public short ZanrID
        {
            get
            {
                return zanrID;
            }
            set
            {
                zanrID = value;
            }
        }

        [MandatoryData]
        [SqlName("Naziv")]
        [DisplayName("Naziv")]
        [LookUpValue]
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
            }
        }
        #endregion

        #region queries
        public string GetDeleteQuery()
        {
            return @"Delete from dbo.Zanr where ZanrID = @ZanrID";
        }
        public string GetInsertQuery()
        {
            return @"INSERT into dbo.Zanr (Naziv) values (@Naziv)";
        }
        public string GetSelectQuery()
        {
            return @"Select ZanrID, Naziv from dbo.Zanr";
        }
        public string GetUpdateQuery()
        {
            return @"UPDATE dbo.Zanr
                            SET
                         dbo.Zanr.Naziv =@Naziv
	                     WHERE dbo.Zanr.ZanrID=@ZanrID";
        }
        public string GetLookUpQuery(string ID)
        {
            throw new NotImplementedException();
        }
        public string GetSearchQuery(string rijec)
        {
            return @"Select ZanrID, Naziv
                    from dbo.Zanr  where dbo.Zanr.Naziv like '" + rijec + "%' ";
        }
        #endregion

        #region parametri

        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZanrID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zanrID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = naziv;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZanrID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zanrID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = naziv;
                parameters.Add(parameter);
            }
            
            return parameters;
        }

        
        #endregion


    }
}
