using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_za_decembar.Klase
{
    public class Student
    {
        public Fax Fax { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Index { get; set; }

        public Student(Fax fax, string ime, string prezime, string index)
        {
            Fax = fax;
            Ime = ime;
            Prezime = prezime;
            Index = index;
        }

        public override string ToString()
        {
            return Ime + Prezime;
        }

        public bool sadrzi(string s)
        {
            if (Ime.ToLower().Contains(s.ToLower())) return true;
            return false;
        }
    }

    public class Fax
    {
        public string Naziv { get; set; }

        public Fax(string naziv)
        {
            Naziv = naziv;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }

    public class ListaFax
    {
        public List<Fax> listaFax;
        public int N { get { return listaFax.Count; } }

        public ListaFax()
        {
            listaFax = new List<Fax>();
        }

        public void dodajFax(string naziv)
        {
            listaFax.Add(new Fax(naziv));
        }
      
        public Fax this[int index]
        {
            get { return listaFax[index]; }
        }
    }

    public class ListaStudent
    {
        public List<Student> listaStudent;
        public int N { get { return listaStudent.Count; } }

        public ListaStudent()
        {
            listaStudent = new List<Student>();
        }

        public void dodajStudenta(Fax fax, string ime, string prezime, string index)
        {
            listaStudent.Add(new Student(fax, ime, prezime, index));
        }

        public void dodajStudenta(Student s)
        {
            listaStudent.Add(s);
        }

        public Student this[int index]
        {
            get { return listaStudent[index]; }
        }

        public ListaStudent traziPoFaxu(string s)
        {
            ListaStudent ls = new ListaStudent();
            for (int i = 0; i < ls.N; i++)
            {
                if(listaStudent[i].Fax.Naziv==s)
                {
                    ls.dodajStudenta(listaStudent[i]);
                }
            
        }
            return ls;
    }

    }
}
