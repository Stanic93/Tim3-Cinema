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
    class RezervacijaPropertyClass : PropertyInterface
    {
        #region Atributi
        public short rezervacijaID;
        public short kartaID;
        public string rezervacijaNaIme;
        #endregion

        #region Properties
        [PrimaryKey]
        [SqlName("RezervacijaID")]
        [DisplayName("Rezervacija ID")]
        public short RezervacijaID
        {
            get
            {
                return rezervacijaID;
            }
            set
            {
                rezervacijaID = value;
            }
        }

        [SqlName("KartaID")]
        [DisplayName("Karta ID")]
        [ForeignKey("dbo.Karta", "KartaID", "Cinema.PropertyClass.KartaPropertyClass")]
        public short KartaID
        {
            get
            {
                return kartaID;
            }
            set
            {
                kartaID = value;
            }
        }

        [SqlName("RezervacijaNaIme")]
        [DisplayName("Rezervacija na ime")]
        public string RezervacijaNaIme
        {
            get
            {
                return rezervacijaNaIme;
            }
            set
            {
                rezervacijaNaIme = value;

            }
        }
        #endregion

        #region Queries

        public string GetDeleteQuery()
        {
            return @"DELETE from dbo.Rezervacija where RezervacijaID = @RezervacijaID";
        }



        public string GetInsertQuery()
        {
            return @"INSERT into dbo.Rezervacija (KartaID, RezervacijaNaIme) values (@KartaID, @RezervacijaNaIme)";
        }

        public string GetSelectQuery()
        {
            return @"SELECT RezervacijaID, KartaID, RezervacijaNaIme from dbo.Rezervacija";
        }



        public string GetUpdateQuery()
        {
            return @"UPDATE 
                    set 
                    KartaID = @KartaID,
                    RezervacijaNaIme = @RezervacijaNaIme
                    where RezervacijaID = @RezervacijaID";
        }
        #endregion

        #region Parameters
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = rezervacijaID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KartaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = kartaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaNaIme", System.Data.SqlDbType.NVarChar);
                parameter.Value = rezervacijaNaIme;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KartaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = kartaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaNaIme", System.Data.SqlDbType.NVarChar);
                parameter.Value = rezervacijaNaIme;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaNaIme", System.Data.SqlDbType.SmallInt);
                parameter.Value = rezervacijaID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion


    }
}
