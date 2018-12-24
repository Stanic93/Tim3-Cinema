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
    class ZanroviFilmovaPropertyClass : PropertyInterface
    {

        #region attribute

        private short zanroviID;
        private short zanrID;
        private short filmID;

        #endregion
                
        #region properties

        [PrimaryKey]
        [SqlName("ZanroviID")]
        [DisplayName("Zanrovi ID")]
        public short ZanroviID
        {
            get
            {
                return zanroviID;
            }
            set
            {
                zanroviID = value;
            }
        }

        [SqlName("ZanrID")]
        [DisplayName("Zanr ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Zanr","ZanrID","Cinema.PropertyClass.ZanrPropertyClass")]
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

        [SqlName("FilmID")]
        [DisplayName("Film ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Film", "FilmID", "Cinema.PropertyClass.FilmPropertyClass")]
        public short FilmID
        {
            get
            {
                return filmID;
            }
            set
            {
                filmID = value;
            }
        }


        #endregion

        #region queries
        public string GetDeleteQuery()
        {
            return @"Delete from ZanroviFilmova where ZanroviID = @ZanroviID";
        }
        public string GetInsertQuery()
        {
            return @"INSERT into dbo.ZanroviFilmova (ZanrID,FilmID) values (@ZanrID, @FilmID)";
        }
        public string GetSelectQuery()
        {
            return @"Select ZanroviID,ZanrID,FilmID from dbo.ZanroviFilmova";
        }
        public string GetUpdateQuery()
        {
            return @"UPDATE
                     set 
                     ZanrID = @ZanrID,
                     FilmID = @FilmID
                     where ZanroviID = @ZanroviID";
        }
        public string GetLookUpQuery(string ID)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region parameters
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZanroviID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zanroviID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZanrID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zanrID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@FilmID", System.Data.SqlDbType.SmallInt);
                parameter.Value = filmID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZanroviID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zanroviID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ZanrID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zanrID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@FilmID", System.Data.SqlDbType.SmallInt);
                parameter.Value = filmID;
                parameters.Add(parameter);
            }
            return parameters;
        }

        
        #endregion
    }
}
