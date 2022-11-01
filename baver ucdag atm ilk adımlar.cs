// See https://aka.ms/new-console-template for more information
//atm yapımı 10.10.22
//c# ilk adım 
//para cekme a
//para yatırma
//bakiye görüntüleme
//*basıp çıkış yapma
//Hangi işlemi yapmak istiyeceği

int bakiye = 1000;

Console.WriteLine("atm'ye hoşgeldiniz");
Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
string seçim = Console.ReadLine();

    if (seçim== "1") ;
{
Console.WriteLine("Şuanki bakiye:" + bakiye);
    Console.ReadLine();
}
   if (seçim == "2") ;
{
    Console.WriteLine("çekmek istediğiniz tutarı belirtiniz");
    int çekilecek_tutar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("kalan tutar :"+(bakiye - çekilecek_tutar));
    Console.ReadLine();
}
if (seçim == "3") ;
{
    Console.WriteLine("yatırmak istediğiniz tutarı belirtiniz");
    int yatırılıcak_tutar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("yatırılan tutar :" + (bakiye + yatırılıcak_tutar));
    Console.ReadLine();
}
if (seçim == "*") ;
{
    Console.WriteLine("atm den çıkış yapılıyor");
    Console.WriteLine("atm den çıkış yapıldı başarılı günler dilerim ...");
    Console.ReadLine();
        
}
 







