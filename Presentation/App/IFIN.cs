using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation.App
{
    public class IFIN
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Bootstrap()
        {
            _SetupSQLite();
        }

        private static void _SetupSQLite()
        {
            throw new NotImplementedException();
        }
    }
}
