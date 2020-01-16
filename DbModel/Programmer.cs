using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mncs.DbModel
{
    public class Programmer
    {
        [Key, Autoincrement]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? Time { get; set; }
    }
}
