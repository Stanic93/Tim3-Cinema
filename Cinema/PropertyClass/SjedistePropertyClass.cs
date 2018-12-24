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
    class SjedistePropertyClass : PropertyInterface
    {
        #region Atributi
        private short sjedisteID;
        private short salaID;
        private short red;
        private short brojSjedista;
        private bool zauzeto;
        #endregion
       
        #region Properties
        [PrimaryKey]
        [SqlName("SjedisteID")]
        [DisplayName("Sjediste ID")]
        [LookUpKey]
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

        [SqlName("Red")]
        [DisplayName("Red")]
        public short Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }

        [SqlName("BrojSjedista")]
        [DisplayName("Broj sjedista")]
        [LookUpValue]
        public short BrojSjedista
        {
            get
            {
                return brojSjedista;
            }
            set
            {
                brojSjedista = value;
            }
        }

        [SqlName("Zauzeto")]
        [DisplayName("Zauzeto")]
        [CheckBox]
        public bool Zauzeto
        {
            get
            {
                return zauzeto;
            }
            set
            {
                zauzeto = value;
            }
        }
        #endregion

        #region Query
        public string GetDeleteQuery()
        {
            return @"DELETE from dbo.Sjediste where SjedisteID = @SjedisteID";
        }

        public string GetInsertQuery()
        {
            return @"INSERT into dbo.Sjediste (SalaID,Red,BrojSjedista,Zauzeto) values (@SalaID, @Red, @BrojSjedista, @Zauzeto)";
        }

        public string GetSelectQuery()
        {
            return @"SELECT * FROM dbo.Sjediste";
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE
                    set
                    SalaID =@SalaID,
                    Red = @Red,
                    BrojSjedista = @BrojSjedista,
                    Zauzeto = @Zauzeto where SjedisteID=@SjedisteID";
        }
        public string GetLookUpQuery(string ID)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Parameters
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@SjedisteID", System.Data.SqlDbType.SmallInt);
                parameter.Value = sjedisteID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@SalaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = salaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Red", System.Data.SqlDbType.TinyInt);
                parameter.Value = red;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@BrojSjedista", System.Data.SqlDbType.TinyInt);
                parameter.Value = brojSjedista;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Zauzeto", System.Data.SqlDbType.Bit);
                parameter.Value = zauzeto;
                parameters.Add(parameter);
            }
            return parameters;
        }
        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@SalaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = salaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Red", System.Data.SqlDbType.TinyInt);
                parameter.Value = red;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@BrojSjedista", System.Data.SqlDbType.TinyInt);
                parameter.Value = brojSjedista;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Zauzeto", System.Data.SqlDbType.Bit);
                parameter.Value = zauzeto;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SjedisteID", System.Data.SqlDbType.SmallInt);
                parameter.Value = sjedisteID;
                parameters.Add(parameter);
            }
            return parameters;
        }
        #endregion


    }
}
