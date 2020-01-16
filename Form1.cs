using log4net;
using mncs.DbModel;
using mncs.DbSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mncs
{
    public partial class Form1 : Form
    {
        ILog log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Info("HAHA");
            using(var dbContext = new MncsDbContext())
            {
                dbContext.Programmers.Add(new Programmer {Name="1",Time=DateTime.Now });
                dbContext.SaveChanges();
            }
        }
    }
}
