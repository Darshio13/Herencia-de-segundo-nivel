using System;
class Cuadripedo  // base class (parent) 
{
    public string patas = "4";
    public void caminar()             // Vehicle method 
    {
        Console.WriteLine("Has caminado");
    }
}

class mamifero : Cuadripedo  // base class (parent) 
{
    public string ubres = "9";
    public void ordenar()             // Vehicle method 
    {
        Console.WriteLine("Tienes leche");
    }

}

class perro : mamifero // base class (parent) 
{

    public void ladrar()             // Vehicle method 
    {
        Console.WriteLine("WOF WOF");
    }

}




class Program
{
    static void Main(string[] args)
    {
        perro myObj = new perro();
        myObj.caminar();
        myObj.ladrar();
        myObj.ordenar();
    
    }
}