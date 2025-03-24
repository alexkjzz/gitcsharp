//EtreVivant elephant = new EtreVivant(new DateTime(1958, 1, 1));
//EtreVivant souris = new EtreVivant(new DateTime(2025, 3, 3));

//Console.WriteLine($"elephant : {elephant.DateDeNaissance}");
//Console.WriteLine($"souris : {souris.DateDeNaissance}");

//Console.WriteLine($"elephant a : {elephant.GetAge()} ans");
//Console.WriteLine($"souris a : {souris.GetAge()} ans");


//int variable1 = 22;
//int variable2 = variable1;

//Console.WriteLine($"variable1 : {variable1}");
//Console.WriteLine($"variable2 : {variable2}");

//Helper.Test(variable1);

//Console.WriteLine($"variable1 : {variable1}");
//Console.WriteLine($"variable2 : {variable2}");

Employe Volodymir = new Employe("Volodymir", 2000, "Comedien");
Employe Vladimir = new Employe("Vladimir", 3000, "Clubs échangiste");


Console.WriteLine($"{Volodymir.Travail()}");
Console.WriteLine($"{Vladimir.Travail()}");

Boss Macron = new Boss("Macron", 5000, "Vielles");
Console.WriteLine($"{Volodymir.Salaire}");
Console.WriteLine($"{Macron.Travail()}");

Macron.Augmente(Volodymir);
Console.WriteLine($"{Volodymir.Salaire}");

Societe societe = new Societe("Societe");
societe.Embauche(Volodymir);
societe.Embauche(Vladimir);
societe.Embauche(Macron);

Console.WriteLine($"{societe.GetChef()}");
Console.WriteLine($"{societe.CalculSommeSalaire()}");
Console.WriteLine($"{societe.Travail()}");

Console.WriteLine(societe.Stalker());