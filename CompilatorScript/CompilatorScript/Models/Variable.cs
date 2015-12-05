using System;

namespace CompilatorScript
{
    public class Variable<T>
    {
        private string Name;

        private T value;

        private readonly Type type;

        private bool valueAssigned;

        public Variable(string name, T value, bool valueAssigned)
        {
            this.SetName(name);
            this.value = value;
            this.type = this.value.GetType();
            this.valueAssigned = valueAssigned;
        }

        public string GetName()
        {
            return Name;
        }

        public bool IsAssigned()
        {
            return this.valueAssigned;
        }

        public T Value
        {
            get
            {
                if (!this.valueAssigned)
                {
                    throw new ArgumentException("Variable not assigned !");
                }

                return this.value;
            }
        }

        public void SetValue(T value)
        {
            // TODO: Add some validations
            this.valueAssigned = true;
            if (value.GetType() != this.Type)
            {
                throw new FormatException();
            }

            this.value = value;
        }

        public Type Type
        {
            get
            {
                return this.type;
            }
        }

        public override string ToString()
        {
            return string.Format("Name - {0}\nValue - {1}\nType - {2}", this.GetName(), this.value, this.type.Name);
        }

        private void SetName(string givenValue)
        {
            if (givenValue.Length < 1)
            {
                throw new ArgumentException("Name must consist of atleast 1 symbol !");
            }

            this.Name = givenValue;
        }

    }
}
