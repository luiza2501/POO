//criei uma classe abstrata chamada imovel
public abstract class Imovel{
//adicionei os atributos id (int),endereço (string), preco (double) e metros quadrados (double)
    public int id { get; set; }
    public string endereco { get; set; }
    public double preco { get; set; }
    public double metrosQuadrados { get; set; }
//adicionei construtor para inicializar os atributos
    public Imovel(int id, string endereco, double preco, double metrosQuadrados)
{
    this.id = id;
    this.endereco = endereco;
    this.preco = preco;
    this.metrosQuadrados = metrosQuadrados;
}
//Adicionei os dois métodos abstratas citados
public abstract void AtualizarPreco(double preco);
public abstract void VerificarImovel();
}