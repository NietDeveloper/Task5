
// 1. Vaqt kalkulyatori:
System.Console.Write("Daqiqani kiriting:");
int minute = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Hour:{minute/60}:{minute%60}");
// 2. Yosh toifasini aniqlash:
System.Console.Write("Yoshingizni kiriting:");
int age = Convert.ToInt32(Console.ReadLine());
if(age>=0)
{
if(age>=0 && age <= 12)
{
    System.Console.WriteLine("Bola");    
}
else if(age >= 13 && age <= 19)
{
    System.Console.WriteLine("O\'smir");
}
else if(age >= 20 && age <=59)
{
    System.Console.WriteLine("Kattalar");
}
else
{
    System.Console.WriteLine("Katta");
}
}
else
{
    System.Console.WriteLine("You have entered an incorrect age.Please try again.");
}
// 3. O'rtacha ballni hisoblash:
System.Console.Write("Birinchi fan bo'yicha ball:");
int lesson1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ikkinchi fan bo'yicha ball:");
int lesson2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Uchunchi fan bo'yicha ball:");
int lesson3 = Convert.ToInt32(Console.ReadLine());
int intermediate = (lesson1+lesson2+lesson3)/3;
string yakuniyBall = (intermediate >= 80 && intermediate <= 100 )?"A\'lo"
                    :(intermediate >= 60 && intermediate <= 79)? "Yaxshi"
                    :(intermediate >= 40 && intermediate <= 59)? "Qoniqarli":"Qoniqarsiz!";
System.Console.WriteLine(yakuniyBall);                    
// 4. "Raqamni toping" o'yini:
var rand = new Random();
int secretNumber = rand.Next(1, 100);
System.Console.Write("Sirli sonni kiriting:");
int myNumber =0;
System.Console.WriteLine("1 dan 100 gacha bolgan sonni topishga harakat qiling!");
while(secretNumber != myNumber)
{
    System.Console.Write("Taxmin sonni kiriting:");
    if(int.TryParse(Console.ReadLine(), out myNumber))
    {
        string hind = (secretNumber > myNumber)
                    ?"Sirli raqam kattaroq!"
                    : (myNumber>secretNumber)
                        ?"Sirli raqam kichikroq!"
                        :"Tabriklayman siz sonni toptingiz!";
    System.Console.WriteLine(hind);
    }
    else
    {
        System.Console.WriteLine("Tog'ri son kiriting!");
    }
    
};