// 猜數字遊戲：1a2b (二位數版)

int secret = 32;
int[] Sall = { secret / 10, secret % 10 };
int guess;

do
{
    System.Console.Write("請輸入：");
    guess = System.Convert.ToInt32(System.Console.ReadLine());

    int[] Gall = { guess / 10, guess % 10 };

    if (guess < 10 || guess > 99)
    {
        System.Console.WriteLine("無效的數字。請輸入一個二位數的數字。");
    }
    else
    {
        if (guess != secret & (Gall[0] == Sall[0] & Gall[1] != Sall[1]))
        {
            System.Console.WriteLine("1A1C");
        }
        else if (guess != secret & (Gall[0] != Sall[0] & Gall[1] == Sall[1]))
        {
            System.Console.WriteLine("1A1C");
        }
        else if (guess != secret & (Gall[0] != Sall[0] & Gall[1] != Sall[1]) & (Gall[0] != Sall[1] & Gall[1] != Sall[0]))
        {
            System.Console.WriteLine("2C");
        }
        else if (guess != secret & (Gall[0] == Sall[1] & Gall[1] == Sall[0]))
        {
            System.Console.WriteLine("2B");
        }
        else if (guess != secret & (Gall[0] == Sall[1] & Gall[1] != Sall[0]))
        {
            System.Console.WriteLine("1B1C");
        }
        else if (guess != secret & (Gall[0] != Sall[1] & Gall[1] == Sall[0]))
        {
            System.Console.WriteLine("1B1C");
        }
        else if (Gall[0] == Sall[0] & Gall[1] == Sall[1])
        {
            System.Console.WriteLine("猜對了~!!");
        }
    }
} while (guess != secret);


