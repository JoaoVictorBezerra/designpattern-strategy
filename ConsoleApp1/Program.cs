



//Aritmetica calculo = new Aritmetica(); 
Geometrica calculo = new Geometrica();
Disciplina d = new Disciplina(calculo);
d.Nome = "Padroes de Desenvolvimento";
d.P1 = 7; 
d.P2 = 2;
d.calcularMedia();
Console.WriteLine("Media = {0} , Situacao = {1}", d.Media, d.Situacao);
Console.ReadKey();

interface iCalcMedia
{
    public double calculaMedia(double p1, double p2);
    public string verificaSituacao(double media);
}

public class Aritmetica : iCalcMedia
{
 
    public double calculaMedia (double p1, double p2)
    {  
        return (p1 + p2) / 2;
    }
    public string verificaSituacao(double media)
    {
        if (media >= 5) return "Aprovado";
        else return "Reprovado";
    }
}

public class Geometrica : iCalcMedia
{

    public double calculaMedia(double p1, double p2)
    {
        return Math.Sqrt(p1*p2);
    }
    public string verificaSituacao(double media)
    {
        if (media >= 7) return "Aprovado";
        else return "Reprovado";
    }
}







class Disciplina
{
    public double Media { get;set ; }
    public string Nome { get; set; }
    public double P1 { get; set; }
    public double P2 { get; set; }
    public string Situacao { get; set; }

    public iCalcMedia Calcula { get; private set; }

    public double media (double p1, double p2)
    {
        return Calcula.calculaMedia(p1, p2);
    }
    public string situacao (double situacao)
    {
        return Calcula.verificaSituacao(situacao);
    }
    public void calcularMedia ()
    {
        Media = Calcula.calculaMedia(P1, P2);
        Situacao = Calcula.verificaSituacao(Media);

    }
    public Disciplina(iCalcMedia calcMedia)
    {
        Calcula = calcMedia;
    }
}