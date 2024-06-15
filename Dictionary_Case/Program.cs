using System;


namespace Dictionary_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictionary koleksiyonunda key-value yani anahtar-deger denen 2 kavram ile karşılaşıyoruz. Dizilere eklediğimiz elemanları value, index lerini ise key olarak düşünebilirsiniz.
               Dictionary lerin elemanlarının anahtarları birbirinden farklı olmalıdır. Aynı anahtar kullanılarak 2 değer saklanamaz.
            */

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Selam");
            keyValuePairs.Add(2, "Merhaba");


        }
    }
}