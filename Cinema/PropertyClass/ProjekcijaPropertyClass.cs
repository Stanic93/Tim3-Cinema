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
    class ProjekcijaPropertyClass : PropertyInterface
    {
        #region attribute
        private short projekcijaID;
        private string nazivFilma;
        private short filmID;
        private DateTime datumPrvogPrikazivanja;
        private DateTime datumPosljednjegPrikazivanja;
        #endregion

        #region properties
        [MandatoryData]
        [PrimaryKey]
        [SqlName("ProjekcijaID")]
        [DisplayName("Projekcija ID")]
        [LookUpKey]
        
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
        
        [SqlName("Naziv")]
        [DisplayName("Naziv filma")]

        public string NazivFilma
        {
            get
            {
                return nazivFilma;
            }
            set
            {
                nazivFilma = value;
            }
        }

        [MandatoryData]
        [SqlName("FilmID")]
        [DisplayName("Film ID")]
        [LookUpValue]
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

        [MandatoryData]
        [SqlName("DatumPrvogPrikazivanja")]
        [DisplayName("Datum prvog prikaza")]
        [DateTime]
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

        [MandatoryData]
        [SqlName("DatumPosljednjegPrikazivanja")]
        [DisplayName("Datum posljednjeg prikaza")]
        [DateTime]
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
            return @"Select p.ProjekcijaID,p.FilmID,f.Naziv,p.DatumPrvogPrikazivanja,p.DatumPosljednjegPrikazivanja 
                FROM dbo.Projekcija p 
                JOIN dbo.Film f ON p.FilmID = f.FilmID";
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
            return @"Update dbo.Projekcija set  FilmID = @FilmID,                                               
                                                DatumPrvogPrikazivanja = @DatumPrvogPrikazivanja,                                                
                                                DatumPosljednjegPrikazivanja = @DatumPosljednjegPrikazivanja
                                        where ProjekcijaID = @ProjekcijaID
                                                ";
        }
        public string GetLookUpQuery(string ID)
        {
            throw new NotImplementedException();
        }
        public string GetSearchQuery(string rijec)
        {
            return @"Select p.ProjekcijaID,p.FilmID,f.Naziv,p.DatumPrvogPrikazivanja,p.DatumPosljednjegPrikazivanja 
                    from dbo.Projekcija p
                    join dbo.Film f on f.FilmID =p.FilmID
                    where f.Naziv like '" + rijec + "%'";
        }
        #endregion

        #region parameters
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
            {
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = projekcijaID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion
    }
}
