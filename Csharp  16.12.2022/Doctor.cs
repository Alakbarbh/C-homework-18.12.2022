﻿#region Task4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp__16._12._2022
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }

        public string GetFullDataDoctor()
        {
            return $"Name: {Name} Surname: {Surname} Address: {Address} Birthday {Birthday} ";
        }


    }

}


#endregion



