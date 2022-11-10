using Erisim;
Musteri m = new Musteri();
m.Id = 1;
m.Unvan = "mühendis";
m.SetKKNO("123456");
m.SetTCNO("11617674508");
m.SetTelNo("5378956321");

Console.WriteLine("KKNO: " + m.GetKKNO());
Console.WriteLine("TC" + m.GetTCNO());
Console.WriteLine("Tel No : " + m.GetTelNo());

