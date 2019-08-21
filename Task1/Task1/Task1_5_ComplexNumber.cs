<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   class Task1_5_ComplexNumber
    {
        public double real;
        public double imaginary;
    public Task1_5_ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

        #region multiplication
        public static Task1_5_ComplexNumber operator *(Task1_5_ComplexNumber c1, Task1_5_ComplexNumber c2)
    {
            return new Task1_5_ComplexNumber(c1.real * c2.real - c1.imaginary * c2.imaginary, c1.real * c2.imaginary + c1.imaginary * c2.real);
    }
        #endregion
        #region division
        public static Task1_5_ComplexNumber operator /(Task1_5_ComplexNumber c1, Task1_5_ComplexNumber c2)
    {
            return new Task1_5_ComplexNumber((c1.real * c2.real + c1.imaginary * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary), -((c1.real * c2.imaginary - c1.imaginary * c2.real) / (c2.real * c2.real + c2.imaginary * c2.imaginary)));
    }
        #endregion
    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   class Task1_5_ComplexNumber
    {
        public double real;
        public double imaginary;
    public Task1_5_ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

        #region multiplication
        public static Task1_5_ComplexNumber operator *(Task1_5_ComplexNumber c1, Task1_5_ComplexNumber c2)
    {
            return new Task1_5_ComplexNumber(c1.real * c2.real - c1.imaginary * c2.imaginary, c1.real * c2.imaginary + c1.imaginary * c2.real);
    }
        #endregion
        #region division
        public static Task1_5_ComplexNumber operator /(Task1_5_ComplexNumber c1, Task1_5_ComplexNumber c2)
    {
            return new Task1_5_ComplexNumber((c1.real * c2.real + c1.imaginary * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary), -((c1.real * c2.imaginary - c1.imaginary * c2.real) / (c2.real * c2.real + c2.imaginary * c2.imaginary)));
    }
        #endregion
    }
}

>>>>>>> cd72095c50cb1866cdb75d3278afa06980eaee6f
