/*
author: Daniel Lozano
*/

namespace MyDataStructures
{
    public class MyList
    {
        public int[] numbers;
        public int len;

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
            for(int i = 0; i <= this.len; i++)
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
    }    
}

