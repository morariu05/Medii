using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp5
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(PersonDbContext pdb = new PersonDbContext())
            {
                Person p = new Person();
                p.FirstName = textBox1.Text;
                p.LastName = textBox2.Text;

                pdb.People.Add(p);
                pdb.SaveChanges();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class PersonDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }


}
