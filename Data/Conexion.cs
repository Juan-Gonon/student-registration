using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conexion : DataConnection
    {

        public Conexion() : base("PDHN1"){}

        //public ITable<Estudiante> _Estudiante => this.GetTable<Estudiante>();

        public ITable<Estudiante> _Estudiante { get { return this.GetTable<Estudiante>(); } }


    }
}
