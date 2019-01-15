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
    class TerminPropertyClass : PropertyInterface
    {
        #region attribute

        private short terminID;
        private TimeSpan vrijemePrikazivanja;
        private short salaID;
        private bool projekcija3D;
        private bool premijera;
        private DateTime datumPrikazivanja;
        private short projekcijaID;
        private short cijenaID;
        #endregion

        #region properties
        [PrimaryKey]
        [SqlName("TerminID")]
        [DisplayName("Termin ID")]
        [LookUpKey]
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
        [SqlName("VrijemePrikazivanja")]
        [DisplayName("Vrijeme prikazivanja")]
        [LookUpValue]
        [Time]
        public TimeSpan VrijemePrikazivanja
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
        [SqlName("SalaID")]
        [DisplayName("Sala ID")]
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
        [DisplayName("Projekcija3D")]
        [CheckBox]
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
        [CheckBox]
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
        [SqlName("DatumPrikazivanja")]
        [DisplayName("Datum prikazivanja")]
        [DateTime]
        public DateTime DatumPrikazivanja
        {
            get
            {
                return datumPrikazivanja;
            }
            set
            {
                datumPrikazivanja = value;
            }
        }
        [SqlName("ProjekcijaID")]
        [DisplayName("Projekcija ID")]
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
        [SqlName("CijenaID")]
        [DisplayName("Cijena ID")]
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
        
       
        #endregion

        #region queries
        public string GetDeleteQuery()
        {
            return @"Delete from dbo.Termin where TerminID = @TerminID";
        }
        public string GetInsertQuery()
        {
            return @"Insert into dbo.Termin (VrijemePrikazivanja,SalaID,Projekcija3D,Premijera,DatumPrikazivanja,ProjekcijaID,CijenaID) values
                                            (@VrijemePrikazivanja,@SalaID,@Projekcija3D,@Premijera,@DatumPrikazivanja,@ProjekcijaID,@CijenaID)";
        }
        public string GetSelectQuery()
        {
            return @"Select TerminID,VrijemePrikazivanja,SalaID,Projekcija3D,Premijera,DatumPrikazivanja,ProjekcijaID,CijenaID from dbo.Termin";
        }
        public string GetUpdateQuery()
        {
            return @"Update dbo.Termin set 
                                          VrijemePrikazivanja = @VrijemePrikazivanja,
                                          SalaID = @SalaID,
                                          Projekcija3D = @Projekcija3D,
                                          Premijera = @Premijera,
                                          DatumPrikazivanja = @DatumPrikazivanja,
                                          ProjekcijaID = @ProjekcijaID,
                                          CijenaID = @CijenaID
                                    where TerminID = @TerminID;
                                          ";
        }
        public string GetLookUpQuery(string ID)
        {
            throw new NotImplementedException();
        }
        public string GetSearchQuery(string rijec)
        {
            return @"Select TerminID,VrijemePrikazivanja,salaID,Projekcija3D,Premijera,DatumPrikazivanja,ProjekcijaID,CijenaID
                    from dbo.Termin where dbo.Termin.VrijemePrikazivanja like '" + rijec + "%'";
        }
        #endregion

        #region parameters
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@TerminID", System.Data.SqlDbType.SmallInt);
                parameter.Value = terminID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@VrijemePrikazivanja", System.Data.SqlDbType.Time);
                parameter.Value = vrijemePrikazivanja;
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
                SqlParameter parameter = new SqlParameter("@DatumPrikazivanja", System.Data.SqlDbType.DateTime);
                parameter.Value = datumPrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = projekcijaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@CijenaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = cijenaID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@TerminID", System.Data.SqlDbType.SmallInt);
                parameter.Value = terminID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemePrikazivanja", System.Data.SqlDbType.Time);
                parameter.Value = vrijemePrikazivanja;
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
                SqlParameter parameter = new SqlParameter("@DatumPrikazivanja", System.Data.SqlDbType.DateTime);
                parameter.Value = datumPrikazivanja;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = projekcijaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@CijenaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = cijenaID;
                parameters.Add(parameter);
            }
            return parameters;
        }

        
        #endregion



    }
}
