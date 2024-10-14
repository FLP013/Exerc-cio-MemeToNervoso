string Usuario, Meme;

Console.Clear();

Console.WriteLine("--- MEME TO NERVOSO ---");

Console.Write("Usuário, o que você pensa sobre mim? ");
Usuario = Console.ReadLine()!;

Meme = Usuario;

Console.WriteLine($"- E sabe o que eu penso de você?\n {Usuario.Remove(10)}... NÃO,PERA\n Tô nervoso");
