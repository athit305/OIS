using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.Common.DTO
{
    public class DATABASE_INFO
    {
        public string DATASOURCE { get; set; }
        public string DATABASENAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }

        public string ConnectionString
        {
            get
            {
                string strConn = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};", this.DATASOURCE, this.DATABASENAME, this.USERNAME, this.PASSWORD);
                if (strConn == String.Empty)
                    throw new ApplicationException("Database can't generate ConnectionString");
                return strConn;
            }
        }
        public string DatabaseString
        {
            get
            {
                if (this.USERNAME != null && this.DATASOURCE != null && this.USERNAME + this.DATASOURCE != string.Empty)
                {
                    string strDB = string.Format("{0}@{1}", this.USERNAME, this.DATASOURCE);
                    return strDB;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
