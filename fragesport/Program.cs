// string name = "Signe"; 

// string result = "6" + "4"; 

// Console.WriteLine(result); 

int pts = 0;

Console.WriteLine("Hur många katter har jag");
Console.WriteLine("a)3    b) 5    c) 2");
string firstquestion= Console.ReadLine(); 

if (firstquestion== "c")
{
    Console.WriteLine("Rätt"); 
    pts += 10; 
}
else{
    Console.WriteLine("Fel");
    pts -= 10; 
}

Console.WriteLine("Hur många år  har jag spelat fiol");
Console.WriteLine("a) 12  b) 13  c) 14"); 
string secondquestion= Console.ReadLine(); 

if (secondquestion== "b")
{
    Console.WriteLine("Rätt"); 
    pts += 10; 
}
else{
    Console.WriteLine("Fel");
    pts -= 10;  
}

Console.WriteLine("Hur många i min släkt har dött i cancer");
Console.WriteLine("a)4  b)3  c)1");
string thirdquestion= Console.ReadLine(); 

if (thirdquestion== "a")
{
    Console.WriteLine("Rätt");
    pts += 10; 
}
else{
    Console.WriteLine("Fel");
    pts -= 10; 
}

Console.WriteLine("Hur många kusiner har jag");
Console.WriteLine("a)8  b)6  c)5");
string fourtquestion= Console.ReadLine();

if(fourtquestion== "c")
{
    Console.WriteLine("Rätt");
    pts += 10; 
}
else{
    Console.WriteLine("Fel");
    pts -= 10; 
}

Console.WriteLine("hur många farbröder har jag");
Console.WriteLine("a)4  b)2  c)1");
string fiftquestion= Console.ReadLine();

if(fiftquestion== "b")
{
      Console.WriteLine("Rätt");
      pts += 10;
}
else{
    Console.WriteLine("Fel");
    pts -= 10; 
}

Console.WriteLine("Hur många lärare fick jag byta från 1-4");
Console.WriteLine("a)8  b)3  c)1"); 
string sixthquestion= Console.ReadLine();

if(sixthquestion== "a")
{
    Console.WriteLine("Rätt");
    pts += 250;
}
else{
    Console.WriteLine("Fel");
    pts -= 50; 
}

Console.WriteLine($"Grattis du fick {pts} pts");
// int hp = 100 ; 

// hp = hp -10; 
// hp -= 10; 

// hp-= 1; 

// hp+= 10; 

// Console.WriteLine($"du har {hp} hp kvar"); 

Console.ReadLine();   