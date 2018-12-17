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
        private short filmID;
        private short cijenaID;
        private DateTime vrijemePrikazivanja;
        private DateTime datumPrvogPrikazivanja;
        private DateTime datumPosljednjegPrikazivanja;
        private short salaID;
        private bool projekcija3D;
        private bool premijera;
        #endregion

        #region properties
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

        [SqlName("CijenaID")]
        [DisplayName("Cijena ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Cijena", "CijenaID", "Cinema.PropertyClass.CijenaPropertyClass")]
        public short CijenaID
        {
            get
            {
                return cijenaID;
            }
            set
            {
                cijenaID = value;
            }
        }

        [SqlName("VrijemePrikazivanja")]
        [DisplayName("Vrijeme prikazivanja")]
        public DateTime VrijemePrikazivanja
        {
            get
            {
                return vrijemePrikazivanja;
            }
            set
            {
                vrijemePrikazivanja = value;
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

        [SqlName("SalaID")]
        [DisplayName("Sala ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Sala", "SalaID", "Cinema.PropertyClass.SalaPropertyClass")]
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

        [SqlName("Projekcija3D")]
        [DisplayName("Projekcija 3D")]
        public bool Projekcija3D
        {
            get
            {
                return projekcija3D;
            }
            set
            {
                projekcija3D = value;
            }
        }

        [SqlName("Premijera")]
        [DisplayName("Premijera")]
        public bool Premijera
        {
            get
            {
                return premijera;
            }
            set
            {
                premijera = value;

            }
        }

        #endregion

        #region queries
        public string GetSelectQuery()
        {
            return @"Select ProjekcijaID,FilmID,CijenaID,VrijemePrikazivanja,DatumPrvogPrikazivanja,SalaID,Projekcija3D,Premijera,DatumPosljednjegPrikazivanja from dbo.Projekcija";
        }
        public string GetDeleteQuery()
        {
            return @"Delete from dbo.Projekcija where ProjekcijaID = @ProjekcijaID";
        }
        public string GetInsertQuery()
        {
            return @"Insert into dbo.Projekcija (FilmID,CijenaID,VrijemePrikazivanja,DatumPrvogPrikazivanja,SalaID,Projekcija3D,Premijera,DatumPosljednjegPrikazivanja) values (@FilmID,@CijenaID,@VrijemePrikazivanja,@DatumPrvogPrikazivanja,@SalaID,@Projekcija3D,@DatumPosljednjegPrikazivanja)";
        }
        public string GetUpdateQuery()
        {
            return @"Update dbo>Projekcija set  FilmID = @FilmID,
                                                CijenaID = @CijenaID,
                                                VrijemePrikazivanja = @VrijemePrikazivanja,
                                                DatumPrvogPrikazivanja = @DatumPrvogPrikazivanja,
                                                SalaID = @SalaID,
                                                Projekcija3D = @Projekcija3D,
                                                Premijera = @Premijera,
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
                SqlParameter parameter = new SqlParameter("@CijenaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = cijenaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemePrikazivanja", System.Data.SqlDbType.Time);
                parameter.Value = vrijemePrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumPrvogPrikazivanja", System.Data.SqlDbType.DateTime);
                parameter.Value = datumPrvogPrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SalaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = salaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Projekcija3D", System.Data.SqlDbType.Bit);
                parameter.Value = projekcija3D;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Premijera", System.Data.SqlDbType.Bit);
                parameter.Value = premijera;
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
                SqlParameter parameter = new SqlParameter("@CijenaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = cijenaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemePrikazivanja", System.Data.SqlDbType.Time);
                parameter.Value = vrijemePrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumPrvogPrikazivanja", System.Data.SqlDbType.DateTime);
                parameter.Value = datumPrvogPrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SalaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = salaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Projekcija3D", System.Data.SqlDbType.Bit);
                parameter.Value = projekcija3D;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Premijera", System.Data.SqlDbType.Bit);
                parameter.Value = premijera;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumPosljednjegPrikazivanja", System.Data.SqlDbType.Date);
                parameter.Value = datumPosljednjegPrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = projekcija3D;
                parameters.Add(parameter);
            }
            return parameters;
        }


        #endregion

    }
}
