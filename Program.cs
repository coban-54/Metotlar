namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci geri_donus_Tipi  metot_adi(Parametre/arguman)
            //{
                //komut
            //}
            int a=2;
            int b=3;
            System.Console.WriteLine(a+b);

            int result=Topla(5,10);
            System.Console.WriteLine(result);

            Metotlar metotlar=new Metotlar();
            metotlar.EkranaYazdır(Convert.ToString(result));

            int result2=metotlar.ArttırTopla(ref a,ref b);
            System.Console.WriteLine(result2);
        }
        
            static int Topla(int deger1,int deger2)
            {
                return deger1 + deger2;
            }
    }
    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            System.Console.WriteLine(veri);
        }   
        public int  ArttırTopla(ref int deger1,ref int deger2)
        {
            deger2+=1;
            deger1+=1;
            return deger1+deger2;
        }    
    }
}