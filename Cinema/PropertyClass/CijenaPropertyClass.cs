﻿using Cinema.AttributeClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.PropertyClass
{
    class CijenaPropertyClass : PropertyInterface
    {

        #region attribute
        public short cijenaID;
        public decimal cijena;
        public bool vrijemePrikazivanja;
        public bool projekcija3D;
        public bool premijera;
        #endregion

        #region properties

        [MandatoryData]
        [PrimaryKey]
        [SqlName("CijenaID")]
        [DisplayName("Cijena ID")]
        [LookUpKey]
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

        [MandatoryData]
        [SqlName("Cijena")]
        [DisplayName("Cijena")]
        [LookUpValue]
        [Numeric]
        public decimal Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                cijena = value;
            }
        }

        [MandatoryData]
        [SqlName("VrijemePrikazivanjaPoslije6")]
        [DisplayName("Vecernji termin")]
        public bool VrijemePrikazivanja
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

        [MandatoryData]
        [SqlName("Projekcija3D")]
        [DisplayName("Projekcija 3D")]
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

        [MandatoryData]
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

        #endregion

        #region queries

        public string GetSelectQuery()
        {
            return @"Select CijenaID, Cijena, VrijemePrikazivanjaPoslije6, Projekcija3D, Premijera from dbo.Cijena";
        }
        public string GetDeleteQuery()
        {
            return @"Delete from dbo.Cijena where CijenaID = @CijenaID";
        }
        public string GetUpdateQuery()
        {
            return @"Update Cijena
                        set
                        Cijena = @Cijena,
                        VrijemePrikazivanjaPoslije6 = @VrijemePrikazivanja,
                        Projekcija3D = @Projekcija3D,
                        Premijera = @Premijera                        
                        where CijenaID = @CijenaID";
        }

        public string GetInsertQuery()
        {
            return @"Insert into dbo.Cijena (Cijena,VrijemePrikazivanjaPoslije6,Projekcija3D,Premijera) values (@Cijena,@VrijemePrikazivanja,@Projekcija3D,@Premijera)";
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
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@CijenaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = cijenaID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Cijena", System.Data.SqlDbType.Decimal);
                parameter.Value = cijena;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemePrikazivanja", System.Data.SqlDbType.Bit);
                parameter.Value = vrijemePrikazivanja;
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

            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Cijena", System.Data.SqlDbType.Decimal);
                parameter.Value = cijena;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemePrikazivanja", System.Data.SqlDbType.Bit);
                parameter.Value = vrijemePrikazivanja;
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
                SqlParameter parameter = new SqlParameter("@CijenaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = cijenaID;
                parameters.Add(parameter);
            }

            return parameters;

        }
        #endregion        


    }
}
