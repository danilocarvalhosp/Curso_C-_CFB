using System;

class Aula26{
    static void Main(){
        double divid, divis, quoc, rest;
        divid = 10;
        divis = 5;
        quoc = divide(divid, divis, out rest);

        Console.WriteLine("{0}/{1}: quociente={2} e resto={3}", divid, divis, quoc, rest);
    }

    static double divide(double dividendo, double divisor, out double resto){
        double quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }

}