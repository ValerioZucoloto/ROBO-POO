using System;

class MainClass {
  public static void Main (string[] args) {
    Robo r1 = new Robo ("Valério", 20, 100, 100, "normal");
    Robo r2 = new Robo ("Valério", 20,100,100,"normal");

    //r1.RealizarAtaque(r2);
    //r1.RealizarAtaque(r2);
    //r1.RealizarAtaque(r2);


    Console.WriteLine(r1.GetAtaque());
    
    
    Console.WriteLine(r1.RealizarAtaque(r2));


    //Console.WriteLine(r2.GetDefesa());

    //Console.WriteLine(r1.GetAtaque());





  }
}