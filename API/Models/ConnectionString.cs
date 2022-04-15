using API.Models.Interfaces;
namespace API.Models
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString(){
            string server="ik1eybdutgxsm0lo.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database="n698lceswqmtisj5";
            string port="3306";
            string userName="c8b8lto77b8nx2jx";
            string passWord="zvzh6nger2cbgep0";

            cs = $@"server = {server}; user={userName}; database = {database}; port={port};password={passWord};";
        }
    }
}