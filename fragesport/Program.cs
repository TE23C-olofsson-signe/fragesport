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
    Console.WriteLine("rätt"); 
    pts += 10; 
}
else{
    Console.WriteLine("fel");
    pts -= 10;  
}

Console.WriteLine("Hur många i min släkt har dött i cancer");
Console.WriteLine("a)1  b) ");

Console.WriteLine($"Grattis du fick {pts} pts");
// int hp = 100 ; 

// hp = hp -10; 
// hp -= 10; 

// hp-= 1; 

// hp+= 10; 

// Console.WriteLine($"du har {hp} hp kvar"); 

Console.ReadLine();   