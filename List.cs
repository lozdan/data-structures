*
author: Daniel Lozano
*/

namespace MyDataStructures
{
    public class MyList <T> where T: IComparable<T>
    {
        private T[] numbers;
        private int len;

        public int Length
        {
            get
            {
                return len;
            }
        }

        public T[] Numbers
        {
            get
            {
                return numbers;
            }
        }

        public MyList()
        {
            this.numbers = new T[0];
            this.len = 0;
        }


        public void Add(T value)
        {
            T[] temp_numbers = numbers;
            this.numbers = new T[this.len + 1];

            this.numbers[this.len] = value;

            for (int i = 0; i < this.len; i++)
            {
                this.numbers[i] = temp_numbers[i];
            }
            this.len++;
        }

        public void Insert(T value, int index)
        {
            T[] temp_numbers = numbers;
            this.numbers = new T[this.len + 1];

            int count = 0;
            for (int i = 0; i <= this.len; i++)
            {
                if (i == index)
                {
                    this.numbers[i] = value;
                }
                else
                {
                    this.numbers[i] = temp_numbers[count];
                    count++;
                }
            }

            this.len++;
        }

        public void Remove(int index)
        {
            T[] temp_numbers = numbers;
            this.numbers = new T[this.len - 1];

            int count = 0;
            for (int i = 0; i < len - 1; i++)
            {
                if (i == index)
                {
                    count++;
                    this.numbers[i] = temp_numbers[count];
                }
                else
                    this.numbers[i] = temp_numbers[count];
                count++;
            }
            len--;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < this.len; i++)
            {
                if (this.numbers[i].CompareTo(value) == 0)
                    return true;
            }
            return false;

        }

        public void AddRange(T[] sequence)
        {
            T[] temp_numbers = this.numbers;
            this.numbers = new T[this.len + sequence.Length];
            this.len = this.len + sequence.Length;

            int j = 0;
            for (int i = 0; i < this.len; i++)
            {
                if (i < temp_numbers.Length)
                    numbers[i] = temp_numbers[i];
                else
                {
                    numbers[i] = sequence[j];
                    j++;
                }
            }
        }

        public void RemoveAll(T value)
        {
            int repeat_numbers = 0;
            for (int i = 0; i < this.len; i++)
            {
                if (this.numbers[i].CompareTo(value) == 0)
                    repeat_numbers++;
            }

            T[] temp_numbers = this.numbers;
            this.len = this.len - repeat_numbers;
            this.numbers = new T[this.len];

            int count = 0;
            for (int i = 0; i < temp_numbers.Length; i++)
            {
                if (temp_numbers[i].CompareTo(value) != 0)
                {
                    this.numbers[count] = temp_numbers[i];
                    count++;
                }
            }
        }
    }
}

