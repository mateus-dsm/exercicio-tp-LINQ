using System.Collections;
using System.ComponentModel;

public enum Tipo
{
    GOLEIRO,
    LATERAL,
    ZAGUEIRO,
    VOLANTE,
    MEIA,
    ATACANTE
}

public class Jogador
{
    public string Nome { get; set; }
    public Tipo Posicao { get; set; }

    public Jogador(string nome, Tipo posicao)
    {
        Nome = nome;
        Posicao = posicao;
    }
}

public class Time
{
    public string Nome { get; set; }
    public List<Jogador> Jogadores { get; set; }

    public Time(string nome, List<Jogador> jogadores)
    {
        Nome = nome;
        Jogadores = jogadores;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        List<Time> times = new List<Time>()
        {
            new Time("Gremio", new List<Jogador>()
            {
                new Jogador("Gabriel Granco", Tipo.GOLEIRO),
                new Jogador("Rafinha", Tipo.LATERAL),
                new Jogador("Bruno Cortez", Tipo.LATERAL),
                new Jogador("Pedro Geromel", Tipo.ZAGUEIRO),
                new Jogador("Ruan", Tipo.ZAGUEIRO),
                new Jogador("Tiago Santos", Tipo.VOLANTE),
                new Jogador("Lucas Silva", Tipo.VOLANTE),
                new Jogador("Ferreira", Tipo.MEIA),
                new Jogador("Jaminton Campaz", Tipo.MEIA),
                new Jogador("Jhonata Robert", Tipo.MEIA),
                new Jogador("Diego Souza", Tipo.ATACANTE)
            }),
            new Time("Flamengo", new List<Jogador>()
            {
                new Jogador("Hugo Souza", Tipo.GOLEIRO),
                new Jogador("Rodinel", Tipo.LATERAL),
                new Jogador("Renê", Tipo.LATERAL),
                new Jogador("Gustavo Henrique", Tipo.ZAGUEIRO),
                new Jogador("Léo Pereira", Tipo.ZAGUEIRO),
                new Jogador("Thiago Maia", Tipo.VOLANTE),
                new Jogador("João Gomes", Tipo.VOLANTE),
                new Jogador("Kenedy", Tipo.MEIA),
                new Jogador("Diego", Tipo.MEIA),
                new Jogador("Vitinho", Tipo.MEIA),
                new Jogador("Vitor Gabriel", Tipo.ATACANTE)
            })
        };

        var listasJogadores = from t in times
                        select t.Jogadores;

        List<Jogador> jogadores = new List<Jogador>();

        foreach(var elemento in listasJogadores)
            foreach(var jogador in elemento)
                jogadores.Add(jogador);

        var meias = from j in jogadores
                    where j.Posicao == Tipo.MEIA
                    select j;

        foreach (var meia in meias) Console.WriteLine(meia.Nome);
    }
}
