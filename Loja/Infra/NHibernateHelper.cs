using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NHibernate.Tool.hbm2ddl;
using Loja.Entidades;

namespace Loja.Infra
{
    public class NHibernateHelper
    {
        public static Configuration RecuperaConfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Usuario).Assembly);

            return cfg;
        }
        public static void GeraSchema()
        {
            Configuration cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Execute(true, true, false);
        }
    }
}
