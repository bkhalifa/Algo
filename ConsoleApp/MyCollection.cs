using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Package
    {
     
        public int Id { get; set; }
        public decimal Cost { get; set; }

    }
   

    public class MyCollection
    {

        public void GetElements()
        {
            ArrayList arrLi = new ArrayList();

            arrLi.Add(1);
            arrLi.Add(new Package { Id = 1, Cost = 12.23m });
            arrLi.Add("bilel");


        }
       
    }
}
