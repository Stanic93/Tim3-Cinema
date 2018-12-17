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
    class ProjekcijaPropertyClass : PropertyInterface
    {
        #region attribute
        private short projekcijaID;
        private short filmID;
        private DateTime datumPrvogPrikazivanja;
        private DateTime datumPosljednjegPrikazivanja;
        #endregion

        #region properties
        [PrimaryKey]
        [SqlName("ProjekcijaID")]
        [DisplayName("Projekcija ID")]
        public short ProjekcijaID
        {
            get
            {
                return projekcijaID;
            }
            set
            {
                projekcijaID = value;
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

        [SqlName("DatumPrvogPrikazivanja")]
        [DisplayName("Datum prvog prikazivanja")]
        public DateTime DatumPrvogPrikazivanja
        {
            get
            {
                return datumPrvogPrikazivanja;
            }
            set
            {
                datumPrvogPrikazivanja = value;
            }
        }

        [SqlName("DatumPosljednjegPrikazivanja")]
        [DisplayName("Datum posljednjeg prikazivanja")]
        public DateTime DatumPosljednjegPrikazivanja
        {
            get
            {
                return datumPosljednjegPrikazivanja;
            }
            set
            {
                datumPosljednjegPrikazivanja = value;
            }
        }        

        #endregion

        #region queries
        public string GetSelectQuery()
        {
            return @"Select ProjekcijaID,FilmID,DatumPrvogPrikazivanja,DatumPosljednjegPrikazivanja from dbo.Projekcija";
        }
        public string GetDeleteQuery()
        {
            return @"Delete from dbo.Projekcija where ProjekcijaID = @ProjekcijaID";
        }
        public string GetInsertQuery()
        {
            return @"Insert into dbo.Projekcija (FilmID,DatumPrvogPrikazivanja,DatumPosljednjegPrikazivanja) values (@FilmID,@DatumPrvogPrikazivanja,@DatumPosljednjegPrikazivanja)";
        }
        public string GetUpdateQuery()
        {
            return @"Update dbo>Projekcija set  FilmID = @FilmID,                                               
                                                DatumPrvogPrikazivanja = @DatumPrvogPrikazivanja,                                                
                                                DatumPosljednjegPrikazivanja = @DatumPosljednjegPrikazivanja
                                        where ProjekcijaID = @ProjekcijaID
                                                ";
        }
        #endregion

        #region properties
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = projekcijaID;
                parameters.Add(parameter);
            }
            return parameters;
        }   

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@FilmID", System.Data.SqlDbType.SmallInt);
                parameter.Value = filmID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumPrvogPrikazivanja", System.Data.SqlDbType.DateTime);
                parameter.Value = datumPrvogPrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumPosljednjegPrikazivanja", System.Data.SqlDbType.Date);
                parameter.Value = datumPosljednjegPrikazivanja;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@FilmID", System.Data.SqlDbType.SmallInt);
                parameter.Value = filmID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumPrvogPrikazivanja", System.Data.SqlDbType.DateTime);
                parameter.Value = datumPrvogPrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumPosljednjegPrikazivanja", System.Data.SqlDbType.Date);
                parameter.Value = datumPosljednjegPrikazivanja;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion
    }
}
