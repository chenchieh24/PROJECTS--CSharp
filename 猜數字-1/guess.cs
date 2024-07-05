// 猜數字遊戲！！！(我自己做的!!)

int answer = 45;
int counting = 1;
int count_limit = 3;

System.Console.Write("請猜一個數字： ");
int guess = System.Convert.ToInt32(System.Console.ReadLine());

while (guess != answer && counting < count_limit )
{
    if (guess >= answer)
    {
        System.Console.Write("小於，再猜： ");
        guess = System.Convert.ToInt32(System.Console.ReadLine());
        counting++;
    }
    else if (guess <= answer)
    {
        System.Console.Write("大於，再猜： ");
        guess = System.Convert.ToInt32(System.Console.ReadLine());
        counting++;
    }
}

if (guess == answer && counting <= count_limit)
{
    System.Console.Write("W I N");
}
else
{
    System.Console.Write("L O S E");
}