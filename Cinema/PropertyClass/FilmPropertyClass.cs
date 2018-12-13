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
    class FilmPropertyClass : PropertyInterface
    {
        #region attribute
        private short filmID;
        private string naziv;
        private DateTime duzinaTrajanja;
        private string opis;
        private string reziser;
        private bool aktivan;
        #endregion

        #region properties

        [PrimaryKey]
        [SqlName("FilmID")]
        [DisplayName("Film ID")]
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

        [SqlName("Naziv")]
        [DisplayName("Naziv")]
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

        [SqlName("DuzinaTrajanja")]
        [DisplayName("Duzina trajanja")]
        public DateTime DuzinaTrajanja
        {
            get
            {
                return duzinaTrajanja;
            }
            set
            {
                duzinaTrajanja = value;
            }
        }

        [SqlName("Opis")]
        [DisplayName("Opis")]
        public string Opis
        {
            get
            {
                return opis;
            }
            set
            {
                opis = value;
            }
        }

        [SqlName("Reziser")]
        [DisplayName("Reziser")]
        public string Reziser
        {
            get
            {
                return reziser;
            }
            set
            {
                reziser = value;
            }
        }

        [SqlName("Aktivan")]
        [DisplayName("Aktivan")]
        public bool Aktivan
        {
            get
            {
                return aktivan;
            }
            set
            {
                aktivan = value;
            }
        }

        #endregion

        #region queries
        public string GetSelectQuery()
        {
            return @"Select FilmID,Naziv,DuzinaTrajanja,Opis,Reziser,Aktivan from dbo.Film";
        }
        public string GetDeleteQuery()
        {
            return @"Delete from dbo.Film where FilmID = @FilmID";
        }
        public string GetInsertQuery()
        {
            return @"Insert into dbo.Film (Naziv,DuzinaTrajanja,Opis,Reziser,Aktivan) values (@Naziv,@DuzinaTrajanja,@Opis,@Reziser,@Aktivan)";
        }
        public string GetUpdateQuery()
        {
            return @"Update dbo.Film
                        set
                        Naziv = @Naziv,
                        DuzinaTrajanja = @DuzinaTrajanja,
                        Opis = @Opis,
                        Reziser = @Reziser,                        
                        where FilmID = @FilmID";
        }
        #endregion

        #region parameters
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@FilmID", System.Data.SqlDbType.SmallInt);
                parameter.Value = filmID;
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
            {
                SqlParameter parameter = new SqlParameter("@DuzinaTrajanja", System.Data.SqlDbType.Time);
                parameter.Value = duzinaTrajanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Opis", System.Data.SqlDbType.Text);
                parameter.Value = opis;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Reziser", System.Data.SqlDbType.NVarChar);
                parameter.Value = reziser;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Aktivan", System.Data.SqlDbType.Bit);
                parameter.Value = aktivan;
                parameters.Add(parameter);
            }
            return parameters;
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = naziv;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@FilmID", System.Data.SqlDbType.SmallInt);
                parameter.Value = filmID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DuzinaTrajanja", System.Data.SqlDbType.Time);
                parameter.Value = duzinaTrajanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Opis", System.Data.SqlDbType.Text);
                parameter.Value = opis;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Reziser", System.Data.SqlDbType.NVarChar);
                parameter.Value = reziser;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Aktivan", System.Data.SqlDbType.Bit);
                parameter.Value = aktivan;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion



    }
}
