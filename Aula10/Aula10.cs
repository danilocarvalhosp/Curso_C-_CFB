using System;

class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main(){

        DiasSemana ds1 = DiasSemana.Domingo;
        DiasSemana ds2 =(DiasSemana)3;

        int ds3 = (int)DiasSemana.Sexta;

        System.Console.WriteLine(ds1);
        System.Console.WriteLine(ds2);
        System.Console.WriteLine(ds3);
    }
}