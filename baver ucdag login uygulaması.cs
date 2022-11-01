//login (giriş) uygulaması
//baver ucdag login uygulaması ilk adımlar 

int hak_sayisi = 3;
while (true)
{
    Console.WriteLine("kullanıcı adını giriniz");
    string kullaniciadi = Console.ReadLine();

    Console.WriteLine("şifrenizi giriniz");
    string sifre = Console.ReadLine();


    if (kullaniciadi == "baver" && sifre == "baver1234")
    {
        Console.WriteLine("tebrikler başarılı giriş yaptınız");
        Console.ReadLine();
        break;
    }
    else
    {
        Console.WriteLine("kullanıcı adınız veya şifreniz yanlıştır !");
        if (hak_sayisi > 0)
        {
            hak_sayisi -= 1;

        }

        if (hak_sayisi == 0) ;
        {
            Console.WriteLine("lütfen tekrar deneyiniz");
        }
    }

}

Console.ReadLine();

            
            

            
        