#region hesap makinesi
//int n1, n2, res ,deg = 0;
//Console.WriteLine("__________________Hesap makinesi______________");
//Console.Write("ilk değeri giriniz = "); n1 = int.Parse(Console.ReadLine());
//Console.Write("ikinci değeri giriniz = "); n2 = int.Parse(Console.ReadLine());
//Console.WriteLine("1 = toplama");
//Console.WriteLine("2 = çıkarma");
//Console.WriteLine("3 = çarpma");
//Console.WriteLine("4 = bölme");
//Console.WriteLine("0 = exit");
//Console.Write("yapmak istediğiniz işlemi seçiniz = "); deg = byte.Parse(Console.ReadLine());
//if (deg == 1)
//{
//    res = n1 + n2;
//    Console.WriteLine("sonucunuz = " + res);
//}
//else if(deg == 2)
//{
//    res = n1 - n2;
//    Console.WriteLine("sonucunuz = " + res);
//}
//else if (deg == 3)
//{
//    res = n1 * n2;
//    Console.WriteLine("sonucunuz = " + res);
//}
//else if (deg == 4)
//{
//    res = n1 / n2;
//    Console.WriteLine("sonucunuz = " + res);
//}
//else if(deg > 4 | deg < 0)
//{
//    Console.WriteLine("hatalı işlem seçtiniz");
//}
//else
//{
//    Console.WriteLine("exit");
//}
#endregion

#region baklava

int n = 5;

for (int i = 1; i <= n; i = i + 1)
{
    for(int j = n - 1; j > 0; j = j -1)
    {
        Console.Write(" ");
    }

    for(int k = 1; k <= 2 * i - 1; k = k + 1)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.Read();
#endregion