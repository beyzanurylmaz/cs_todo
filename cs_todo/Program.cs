
using TodoList.Models;

string select,title,Durum;

Atp11Context db= new Atp11Context();
 int id;
 while (true)
 {
    Console.WriteLine("İşlem Seçiniz\n[0] Çıkış\n[1] Listele \n[2] Ekle \n[3] Düzenle \n[4] Sil");
    select=Console.ReadLine()!;
    switch (select) 
    {
        case "0":
        Console.WriteLine("Güle Güle...");
        Environment.Exit(0);
        break;
        
        case"1":
        Listele();
        continue;

        case "2":
        ekle();
        continue;

        case "4":
        Sil();
        continue;
        
        case "3":
        Düzenle();
        continue;


        default:
        Console.WriteLine("Lütfen 0-4 Arasında Bir Değer Giriniz");
        continue;
    }
 }
 void Listele()
{
  var todos=db.Todolists.ToList();
  Console.WriteLine("ID\tBaşlık\tAçıklama\tDurum");

  foreach (var item in todos)
  {
    Console.WriteLine($"{item.Id}\t{item.Title}\t{item.Desc}\t{item.IsComplated}");
  }
}
void ekle()
{

}
  void Sil ()
{
    
}
 void Düzenle ()
{
   
}