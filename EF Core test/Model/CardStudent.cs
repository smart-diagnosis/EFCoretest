﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class CardStudent
    {
        public int Id { get; set; }
        public Student Student { get; set; }
    }
}
