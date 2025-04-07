
class Program
{
   
    static void MakeSnake(int rows, int colum)
    {
        int[,] array = new int[rows, colum];
        int num = 1;
        int up = 0; int down = rows-1;
        int right = colum - 1; int left = 0;

        while (up < down && left < right) {
            //вправо
            for (int i = left; i <= right; i++)
            {
                array[up,i] = num++;
            }
            up++;
            //вниз
            for (int i = up; i <= down; i++) { 
                array[i,right] = num++;
            }
            right--;
            // Влево
            if (up <= down)
            {
                for (int i = right; i >= left; --i)
                    array[down,i] = num++;
                down--;
            }

            // Вверх
            if (left <= right)
            {
                for (int i = down; i >= up; --i)
                    array[i,left] = num++;
                left++;
            }


        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colum; j++)
                Console.Write(array[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int rows = 4;
        int colum = 4;
        MakeSnake(rows, colum);
    }

}
