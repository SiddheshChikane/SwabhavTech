﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp.Model
{
    class Foo
    {
        [NeedToRefactor]
        public void M1()
        {

        }
        public void M2()
        {

        }
        [NeedToRefactor]
        public void M3()
        {

        }
       
        public void M4()
        {

        }
        [NeedToRefactor]
        public void M5()
        {

        } 

    }
}