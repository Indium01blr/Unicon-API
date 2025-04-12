using System.Web;
using System.Data;
using System.ComponentModel;
using MySqlConnector;
using Microsoft.EntityFrameworkCore;

namespace Unicorn_Trade_api.Services

{
    public class DBWrapper
    {
        string connectionstring = "server=IND-CHN-LTA3807;Database=root;password=root;Integrated security=false";//ConfigurationManager.
       
        public DataTable  Getusers()
        {
            DataSet ds = new DataSet();
            DataTable dt=new DataTable();
            try
            {
                MySqlConnector.MySqlConnection objcon = new MySqlConnector.MySqlConnection(connectionstring);
                objcon.Open();
                MySqlCommand cmd = new MySqlCommand("select *from user", objcon);
                cmd.CommandType = CommandType.Text;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                
                da.Fill(ds);
               dt=ds.Tables[0];
                 
                 
            }
            catch (Exception ex)
            {
                dt=null;
            }
            return dt;
        }
        //objc
       // obj.


    }
}
