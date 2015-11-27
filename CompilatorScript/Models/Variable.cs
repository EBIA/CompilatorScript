using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilatorScript
{
    using System.CodeDom;

    class Variable<T>
    {
        private string name;

        private T value;

        private readonly Type type;

        public Variable(string name, T value)
        {
            this.SetName(name);
            this.value = value;
            this.type = value.GetType();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public T Value
        {
            get
            {
                return this.value;
            }
        }

        public void SetValue(T value)
        {
            // TODO: Add some validations
            this.value = value;
        }

        public Type Type
        {
            get
            {
                return this.type;
            }
        }

        public static Variable<T> operator +(Variable<T> o1, Variable<T> o2)
        {
            var firstValue = o1.value;
            var secondValue = o2.value;

            if (firstValue.GetType() != secondValue.GetType())
            {
                throw new InvalidOperationException("Cannot use \"+\" operator between 2 different types !");
            }

            //UNDER DEVELOPMENT ! NEED TO REMOVE (dynamic) CAST !
            return (dynamic)firstValue + (dynamic)secondValue;
        } 

        public override string ToString()
        {
            return string.Format("Name - {0}\nValue - {1}\nType - {2}", this.name, this.value, this.type.Name);
        }

        private void SetName(string givenValue)
        {
            if (givenValue.Length < 1)
            {
                throw new ArgumentException("Name must consist of atleast 1 symbol !");
            }

            this.name = givenValue;
        }

    }
}
