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
    class RepertoarPropertyClass : PropertyInterface
    {
        #region attribute

        private short filmID;
        private string film;
        private string zanr;
        private TimeSpan duzinaTrajanja;
        private string opis;
        private string reziser;
        private bool aktivan;
        private short godina;
        #endregion

        #region properties

        [PrimaryKey]
        [SqlName("FilmID")]
        [DisplayName("Film ID")]
        [Visible]
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

        [SqlName("Film")]
        [DisplayName("Film")]
        public string Film
        {
            get
            {
                return film;
            }
            set
            {
                film = value;
            }
        }

        [SqlName("Zanr")]
        [DisplayName("Zanr")]
        public string Zanr
        {
            get
            {
                return zanr;
            }
            set
            {
                zanr = value;
            }
        }

        [SqlName("DuzinaTrajanja")]
        [DisplayName("Duzina trajanja")]
        public System.TimeSpan DuzinaTrajanja {
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
        [RichTextBox]
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
        [CheckBoxAttribute]
        [Visible]
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

        [SqlName("Godina")]
        [DisplayName("Godina")]
        [Visible]
        public short Godina
        {
            get
            {
                return godina;
            }
            set
            {
                godina = value;

            }
        }

        [SqlName("DatumPrvogPrikazivanja")]
        [DisplayName("Datum prvog prikazivanja")]
        [DateTime]
        public DateTime DatumPrvogPrikazivanja { get; set; }

        [SqlName("DatumPosljednjegPrikazivanja")]
        [DisplayName("Datum posljednjeg prikazivanja")]
        [DateTime]
        public DateTime DatumPosljednjegPrikazivanja { get; set; }

        #endregion

        #region queries
        public string GetDeleteQuery()
        {
            throw new NotImplementedException();
        }
        public string GetInsertQuery()
        {
            throw new NotImplementedException();
        }
        public string GetSelectQuery()
        {
            return @"Select FilmID,Film,Zanr,DuzinaTrajanja,Opis,Reziser,Aktivan,Godina,DatumPrvogPrikazivanja,DatumPosljednjegPrikazivanja from dbo.vRepertoar";
        }
        public string GetUpdateQuery()
        {
            throw new NotImplementedException();
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

        #region parameters
        public List<SqlParameter> GetDeleteParameters()
        {
            throw new NotImplementedException();
        }
        public List<SqlParameter> GetInsertParameters()
        {
            throw new NotImplementedException();
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            throw new NotImplementedException();
        }
        #endregion



    }
}
