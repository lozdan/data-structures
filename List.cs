*
author: Daniel Lozano
*/

namespace MyDataStructures
{
    public class MyList
    {
        private int[] numbers;
        private int len;

        public int Length
        {
            get
            {
                return len;
            }
        }

        public int[] Numbers
        {
            get
            {
                return numbers;
            }
        }

        public MyList()
        {
            this.numbers = new int[0];
            this.len = 0;
        }


        public void Add(int value)
        {
            int[] temp_numbers = numbers;
            this.numbers = new int[this.len + 1];

            this.numbers[this.len] = value;

            for (int i = 0; i < this.len; i++)
            {
                this.numbers[i] = temp_numbers[i];
            }
            this.len++;
        }

        public void Insert(int value, int index)
        {
            int[] temp_numbers = numbers;
            this.numbers = new int[this.len + 1];

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
            int[] temp_numbers = numbers;
            this.numbers = new int[this.len - 1];

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

        public bool Contains(int value)
        {
            bool exist = false;
            for (int i = 0; i < this.len && exist is false; i++)
            {
                if (this.numbers[i] == value)
                    exist = true;
            }
            return exist;
        }

        public void AddRange(int[] sequence)
        {
            int[] temp_numbers = this.numbers;
            this.numbers = new int[this.len + sequence.Length];
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

        public void RemoveAll(int value)
        {
            int repeat_numbers = 0;
            for(int i = 0; i < this.len; i++)
            {
                if (this.numbers[i] == value)
                    repeat_numbers++;
            }

            int[] temp_numbers = this.numbers;
            this.len = this.len - repeat_numbers;
            this.numbers = new int[this.len];

            int count = 0;
            for(int i = 0; i < temp_numbers.Length; i++)
            {
                if (temp_numbers[i] != value)
                {
                    this.numbers[count] = temp_numbers[i];
                    count++;
                }
            }
        }
    }
}

