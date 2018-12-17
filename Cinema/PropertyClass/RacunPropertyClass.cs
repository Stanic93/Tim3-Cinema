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
    class RacunPropertyClass : PropertyInterface
    {
        #region Atributi
        public short racunID;
        public DateTime vrijemeIzdavanja;
        public short zaposleniID;
        public decimal ukupnaCijena;
        #endregion

        #region Properties
        [PrimaryKey]
        [SqlName("RacunID")]
        [DisplayName("Racun ID")]
        [LookUpKey]
        public short RacuniID
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
        
        [SqlName("VrijemeIzdavanja")]
        [DisplayName("Vrijeme izdavanja")]
        [LookUpValue]
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
       
        [SqlName("UkupnaCijena")]
        [DisplayName("Ukupna cijena")]
        public decimal UkupnaCijena
        {
            get
            {
                return ukupnaCijena;
            }
            set
            {
                ukupnaCijena = value;
            }
        }
        #endregion

        #region Queries
        public string GetInsertQuery()
        {
            return @"INSERT into dbo.Racun (VrijemeIzdavanja, ZaposleniID, UkupnaCijena) values (@VrijemeIzdavanja, @ZaposleniID, @UkupnaCijena)";
        }

        public string GetSelectQuery()
        {
            return @"SELECT RacunID, VrijemeIzdavanja, ZaposleniID, UkupnaCijena from dbo.Racun";
        }

        public string GetDeleteQuery()
        {
            return @"DELETE from dbo.Racun where RacunID = @RacunID";
        }
        public string GetUpdateQuery()
        {
            return @"UPDATE
                    set
                    VrijemeIzdavanja = @VrijemeIzdavanja,
                    ZaposleniID = @ZaposleniID,
                    UkupnaCijena = @UkupnaCijena
                    where RacunID =@RacunID";
        }
        #endregion

        #region Parameters

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@VrijemeIzdavanja", System.Data.SqlDbType.DateTime);
                parameter.Value = vrijemeIzdavanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zaposleniID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@UkupnaCijena", System.Data.SqlDbType.Decimal);
                parameter.Value = ukupnaCijena;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RacunID", System.Data.SqlDbType.SmallInt);
                parameter.Value = racunID;
                parameters.Add(parameter);
            }
            return parameters;
        }

         public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RacunID", System.Data.SqlDbType.SmallInt);
                parameter.Value = racunID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@VrijemeIzdavanja", System.Data.SqlDbType.DateTime);
                parameter.Value = vrijemeIzdavanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.SmallInt);
                parameter.Value = zaposleniID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@UkupnaCijena", System.Data.SqlDbType.Decimal);
                parameter.Value = ukupnaCijena;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion
    }
}
