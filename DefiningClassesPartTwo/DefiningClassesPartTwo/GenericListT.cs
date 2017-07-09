namespace DefiningClassesPartTwo
{
    using System;

   public class GenericList<T> where T : IComparable
    {
        private T[] generic;

        private int index;

        public GenericList(int capasity)
        {
            this.generic = new T[capasity];
            this.index = 0;
        }

        public int Count { get; set; }

        public int Index
        {
            get
            {
                return this.index;
            }
        }

        public int Capacity
        {
            get
            {
                return this.generic.Length;
            }
            set
            {
                this.Capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                this.OutOfRangeCheck(index);
                return this.generic[index];
            }
            set
            {
                this.OutOfRangeCheck(index);
                this.generic[index] = value;
            }
        }

        public void Add(T element)
        {
            this.generic[index] = element;
            this.index++;
            if (this.index == this.generic.Length)
            {
                var newGeneric = new T[this.generic.Length * 2];
                for (int i = 0; i < this.generic.Length; i++)
                {
                    newGeneric[i] = this.generic[i];
                }

                this.generic = newGeneric;
            }
        }

        public void RemoveElement(int index)
        {
            this.OutOfRangeCheck(index);
            this.index--;
            for (int i = index; i < this.index - 1; i++)
            {
                generic[i] = generic[i + 1];
            }
        }

        public void Clear()
        {
            for (int i = 0; i < this.generic.Length; i++)
            {
                this.generic[i] = default(T);
            }
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.generic.Length; i++)
            {
                if (this.generic[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public int ElementValue(T element)
        {
            for (int i = 0; i < this.generic.Length; i++)
            {
                if (this.generic[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void OutOfRangeCheck(int index)
        {
            if (index < 0 || index > this.index - 1)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
        }

        public void Check(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.DoubleSize();
            }

            this.generic[this.Count] = element;
            this.Count++;
        }

        public void DoubleSize()
        {
            var oldElements = this.generic;
            this.Capacity *= 2;
            this.generic = new T[Capacity];
            Array.Copy(oldElements, this.generic,this.Count);
        }

        public string ToString(string separator)
        {
            return string.Join(separator, this.generic);
        }

        public override string ToString()
        {
            return string.Join(", ", this.generic);
        }
        public T Min()
        {
            T min = this.generic[0];
            foreach (T element in this.generic)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.generic[0];
            foreach (T element in this.generic)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            return max;
        }
    }
}
