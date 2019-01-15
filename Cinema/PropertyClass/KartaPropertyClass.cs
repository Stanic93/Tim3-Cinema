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
    class KartaPropertyClass : PropertyInterface
    {
        #region attribute

        private short kartaID;
        private short projekcijaID;
        private DateTime vrijemeIzdavanja;
        private short sjedisteID;
        private short racunID;
        private short terminID;

        #endregion

        #region properties

        [PrimaryKey]
        [SqlName("KartaID")]
        [DisplayName("Karta ID")]
        [Visible]
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
        [PrimaryKey]
        [SqlName("TerminID")]
        [DisplayName("Termin ID")]
        [ForeignKey("dbo.Termin", "TerminID", "Cinema.PropertyClass.TerminPropertyClass")]
        public short TerminID
        {
            get
            {
                return terminID;
            }
            set
            {
                terminID = value;
            }
        }

        [SqlName("RezervacijaID")]
        [DisplayName("Rezervacija ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Rezervacija", "RezervacijaID", "Cinema.PropertyClass.RezervacijaPropertyClass")]
        public short RezervacijaID {get;set;}



        [SqlName("ProjekcijaID")]
        [DisplayName("Projekcija ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Projekcija", "ProjekcijaID", "Cinema.PropertyClass.ProjekcijaPropertyClass")]
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

        [SqlName("VrijemeIzdavanja")]
        [DisplayName("Vrijeme izdavanja")]
        public DateTime VrijemeIzdavanja
        {
            get
            {
                return vrijemeIzdavanja;
            }
            set
            {
                vrijemeIzdavanja = value;
            }
        }

        [SqlName("SjedisteID")]
        [DisplayName("Sjediste ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Sjediste", "SjedisteID", "Cinema.PropertyClass.SjedistePropertyClass")]
        public short SjedisteID
        {
            get
            {
                return sjedisteID;
            }
            set
            {
                sjedisteID = value;
            }
        }

        [SqlName("RacunID")]
        [DisplayName("Racun ID")]
        [PrimaryKey]
        [ForeignKey("dbo.Racun", "RacunID", "Cinema.PropertyClass.RacunPropertyClass")]
        public short RacunID
        {
            get
            {
                return racunID;
            }
            set
            {
                racunID = value;
            }
        }


        #endregion

        #region queries
        public string GetDeleteQuery()
        {
            return @"Delete from dbo.Karta where KartaID = @KartaID";
        }
        public string GetInsertQuery()
        {
            return @"Insert into dbo.Karta (ProjekcijaID,VrijemeIzdavanja,SjedisteID,RacunID,TerminID) values (@ProjekcijaID,@VrijemeIzdavanja,@SjedisteID,@RacunID,@TerminID)";
        }
        public string GetInsertRezervacijaQuery()
        {
            return @"Insert into dbo.Karta (ProjekcijaID,VrijemeIzdavanja,SjedisteID,RezervacijaID,TerminID) values (@ProjekcijaID,@VrijemeIzdavanja,@SjedisteID,@RezervacijaID,@TerminID)";
        }
        public string GetUpdateQuery()
        {

            return @"Update dbo.Karta
                        set
                        ProjekcijaID = @ProjekcijaID,
                        VrijemeIzdavanja = @VrijemeIzdavanja,
                        SjedisteID = @SjedisteID,
                        RacunID = @RacunID
                        where KartaID = @KartaID"; 


        }
        public string GetSelectQuery()
        {
            return @"Select KartaID,ProjekcijaID,VrijemeIzdavanja,SjedisteID,RacunID from dbo.Karta";
        }
        #endregion

        #region properties
        public List<SqlParameter> GetDeleteParameters()
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KartaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = kartaID;
                parameters.Add(parameter);
            }
            return parameters;

        }

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
          
            {
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = projekcijaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemeIzdavanja", System.Data.SqlDbType.DateTime);
                parameter.Value = vrijemeIzdavanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SjedisteID", System.Data.SqlDbType.SmallInt);
                parameter.Value = sjedisteID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RacunID", System.Data.SqlDbType.SmallInt);
                parameter.Value = racunID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@TerminID", System.Data.SqlDbType.SmallInt);
                parameter.Value = terminID;
                parameters.Add(parameter);
            }
            return parameters;

        }
        public List<SqlParameter> GetInsertRezervacijaParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            {
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = projekcijaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemeIzdavanja", System.Data.SqlDbType.DateTime);
                parameter.Value = vrijemeIzdavanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SjedisteID", System.Data.SqlDbType.SmallInt);
                parameter.Value = sjedisteID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = RezervacijaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@TerminID", System.Data.SqlDbType.SmallInt);
                parameter.Value = terminID;
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
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = projekcijaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemeIzdavanja", System.Data.SqlDbType.DateTime);
                parameter.Value = vrijemeIzdavanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SjedisteID", System.Data.SqlDbType.SmallInt);
                parameter.Value = sjedisteID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RadnikID", System.Data.SqlDbType.SmallInt);
                parameter.Value = racunID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion



    }
}
