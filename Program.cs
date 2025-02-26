// Implicit Conversion (Bilinçsiz Dönüşüm)
Console.WriteLine("******** IMPLICIT CONVERSION *********");
byte a=5;
sbyte b=30;
short c=10;

int d = a+b+c;
Console.WriteLine("d: " +d );

long h = d;
Console.WriteLine("h:" + h);
float i = h;
Console.WriteLine("i: "+i);

string str = "Patika";
char p = 'P';
object g = str + p + d;
Console.WriteLine("g: "+g);

//Explicit Conversion (Bilinçli Dönüşüm)

Console.WriteLine("******** EXPLICIT CONVERSION *********");
int x=4;
byte y = (byte)x;

Console.WriteLine($"y: "+y);

float z = 10.3f;
byte t = (byte)z;
Console.WriteLine($"t:"+t);


// ********** ToString() METODU **********

Console.WriteLine("******* ToString() METODU *******");

int testInt = 6;
string testToString = testInt.ToString();
Console.WriteLine("int Convert To String: " +testToString);

string fltConvert = 12.5f.ToString();
Console.WriteLine("float Convert To String: " + fltConvert);

// System.Convert
Console.WriteLine("****** System.Convert SINIFI ****** ");
string s1="10"; string s2 = "20";
int sayi1,sayi2;
int toplam;

sayi1 = Convert.ToInt16(s1);
sayi2 = Convert.ToInt16(s2);

toplam = sayi1 + sayi2;

Console.WriteLine($"Toplam: {toplam}");

Console.WriteLine("Convert Metodu ile string --> DateTime : " + Convert.ToDateTime("22.01.2023"));

// PARSE METODU
Console.WriteLine("****** PARSE METODU ****** ");

string metin1 = "10";
string metin2 = "20";
int rakam1;
double dob1;

rakam1 = Int32.Parse(metin1);
dob1 = Double.Parse(metin2);
Console.WriteLine($"Parse metodu ile string --> int dönüşümü : {rakam1}");
Console.WriteLine($"Parse metodu ile string --> double dönüşümü : {dob1}");

Console.WriteLine("Parse ile string --> sbyte " + sbyte.Parse("1"));
Console.WriteLine("Parse ile string --> DateTime" + DateTime.Parse("22.01.2023"));

