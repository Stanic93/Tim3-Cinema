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
    class LoginPropertyClass : PropertyInterface
    {

        #region Atributi
        public short loginID;
        public short zaposleniID;
        public string korisnickoIme;
        public string lozinka;
        public string radnoMjesto;
        #endregion

        #region Properties
        [PrimaryKey]
        [SqlName("LoginID")]
        [DisplayName("Login ID")]
        public short LoginID
        {
            get
            {
                return loginID;
            }
            set
            {
                loginID = value;
            }
        }

        [SqlName("ZaposleniID")]
        [DisplayName("Zaposleni ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Zaposleni", "ZaposleniID", "Cinema.PropertyClass.ZaposleniPropertyClass")]
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

        [SqlName("KorisnickoIme")]
        [DisplayName("Korisnicko ime")]
        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }
            set
            {
                korisnickoIme = value;
            }
        }

        [SqlName("Lozinka")]
        [DisplayName("Lozinka")]
        public string Lozinka
        {
            get
            {
                return lozinka;
            }
            set
            {
                lozinka = value;
            }
        }

        [SqlName("RadnoMjesto")]
        [DisplayName("Radno mjesto")]
        public string RadnoMjesto
        {
            get
            {
                return radnoMjesto;
            }
            set
            {
                radnoMjesto = value;
            }
        }
        #endregion

        #region Queries
        public string GetDeleteQuery()
        {
            return @"DELETE from dbo.Login where LoginID=@LoginID";
        }

        public string GetInsertQuery()
        {
            return @"INSERT into dbo.Login (ZaposleniID, KorisnickoIme, Lozinka, RadnoMjesto) values (@ZaposleniID, @KorisnickoIme,@Lozinka,@RadnoMjesto)";
        }

        public string GetSelectQuery()
        {
            return @"SELECT LoginID, ZaposleniID, KorisnickoIme, Lozinka, RadnoMjesto from dbo.Login";
        }

       
        public string GetUpdateQuery()
        {
            return @"UPDATE dbo.Login
                    set
                    ZaposleniID=@ZaposleniID,
                    KorisnickoIme=@KorisnickoIme,
                    Lozinka=@Lozinka,
                    RadnoMjesto=@RadnoMjesto
                    where LoginID=@LoginID";
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
                    SqlParameter parameter = new SqlParameter("@LoginID", System.Data.SqlDbType.SmallInt);
                    parameter.Value = loginID;
                    parameters.Add(parameter);
                }
                return parameters;
        }
        
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zaposleniID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@KorisnickoIme", System.Data.SqlDbType.NVarChar);
                parameter.Value = korisnickoIme;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Lozinka", System.Data.SqlDbType.NVarChar);
                parameter.Value = lozinka;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RadnoMjesto", System.Data.SqlDbType.NVarChar);
                parameter.Value = radnoMjesto;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zaposleniID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@KorisnickoIme", System.Data.SqlDbType.NVarChar);
                parameter.Value = korisnickoIme;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Lozinka", System.Data.SqlDbType.NVarChar);
                parameter.Value = lozinka;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RadnoMjesto", System.Data.SqlDbType.NVarChar);
                parameter.Value = radnoMjesto;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@LoginID", System.Data.SqlDbType.SmallInt);
                parameter.Value = loginID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion



        
    }
}
