using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC
{
    public class student
    {
        private int id;
        private string name;

        public student(int id, string name)
        {
            setid(id);
            setName(name);
              
        }
        public student()
        {
        }

        public void setName(string _namee) { 
           name = _namee;
        }

        public string GetName()
        {
            return name;
        }


        public void setid(int _id)
        {
            id =  _id;
        }

        public int Getid()
        {
            return id;
        }


        public override string ToString()
        {
            return $"name :: {name} , id :: {id}";
        }
    }
}
