using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilatorScript.Models
{
    class Array<T>
    {
        private Variable<T>[] arrayList;

        private bool isAssigned;

        public Array(int lenght, bool isAssigned)
        {
            this.arrayList = new Variable<T>[lenght];
            this.isAssigned = isAssigned;
        }

        public Variable<T>[] GetArray()
        {
            if (!this.isAssigned)
            {
                throw new InvalidOperationException("Array not set!");
            }

            return this.arrayList;
        }

        public void SetArray(int lenght)
        {
            this.isAssigned = true;
            this.arrayList = new Variable<T>[lenght];
        }

        public void SetElementAt(Variable<T> element, int index)
        {
            this.arrayList[index] = element;
        }

        public Variable<T> GetElementAt(int index)
        {
            return this.arrayList[index];
        }
    }
}
