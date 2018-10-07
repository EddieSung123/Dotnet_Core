using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Factory
{
    public class AppConfig : IAppConfig
    {
        public DB ConnectionStrings { get; set; }
    }
    public class DB
    {
        public string NetCoreCRUD { get; set; } //ConnectionStrings name
    }
    public class Authorize
    {
        public string SecurityKey { get; set; }
    }
    public interface IAppConfig
    {
        DB ConnectionStrings { get; set; }
    }
}
