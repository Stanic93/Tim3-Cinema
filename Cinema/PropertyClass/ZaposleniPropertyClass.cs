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
    class ZaposleniPropertyClass : PropertyInterface
    {
                
        #region attribute
        private short zaposleniID;
        private string ime;
        private string prezime;
        private DateTime godiste;
        private string pozicija;
        // **** avatar ****

        #endregion

        #region properties

        [PrimaryKey]
        [SqlName("ZaposleniID")]
        [DisplayName("Zaposleni ID")]
        [LookUpKey]
        public short ZaposleniID
        {
            get
            {
                return zaposleniID;
            }
            set
            {
                zaposleniID = value;
            }
        }
        [SqlName("Ime")]
        [DisplayName("Ime")]
        [LookUpValue]
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        [SqlName("Prezime")]
        [DisplayName("Prezime")]
        [LookUpValue]
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        [SqlName("Godiste")]
        [DisplayName("Godiste")]
        [DateTime]
        public DateTime Godiste
        {
            get
            {
                return godiste; 
            }
            set
            {
                godiste = value;
            }
        }
        [SqlName("Pozicija")]
        [DisplayName("Pozicija")]
        public string Pozicija
        {
            get
            {
                return pozicija;
            }
            set
            {
                pozicija = value;
            }
        }


        #endregion

        #region queries
        public string GetDeleteQuery()
        {
            return @"Delete from dbo.Zaposleni where ZaposleniID = @ZaposleniID";
        }
        public string GetInsertQuery()
        {
            return @"INSERT into dbo.Zaposleni (Ime,Prezime,Godiste,Pozicija) values (@Ime, @Prezime, @Godiste, @Pozicija)";
        }
        public string GetSelectQuery()
        {
            return @"Select ZaposleniID,Ime,Prezime,Godiste,Pozicija from dbo.Zaposleni";
        }
        public string GetUpdateQuery()
        {
            return @"UPDATE dbo.Zaposleni
                     set 
                     Ime = @Ime,
                     Prezime = @Prezime,
                     Godiste = @Godiste,
                     Pozicija = @Pozicija
                     where ZaposleniID = @ZaposleniID";
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
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zaposleniID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Ime", System.Data.SqlDbType.NVarChar);
                parameter.Value = ime;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Prezime", System.Data.SqlDbType.NVarChar);
                parameter.Value = prezime;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Godiste", System.Data.SqlDbType.Date);
                parameter.Value = godiste;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Pozicija", System.Data.SqlDbType.NVarChar);
                parameter.Value = pozicija;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Ime", System.Data.SqlDbType.NVarChar);
                parameter.Value = ime;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Prezime", System.Data.SqlDbType.NVarChar);
                parameter.Value = prezime;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Godiste", System.Data.SqlDbType.Date);
                parameter.Value = godiste;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Pozicija", System.Data.SqlDbType.NVarChar);
                parameter.Value = pozicija;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zaposleniID;
                parameters.Add(parameter);
            }
            return parameters;
        }

       
        #endregion


    }
}
