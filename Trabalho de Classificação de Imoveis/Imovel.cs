//criei uma classe abstrata chamada imovel
public abstract class Imovel{
//adicionei os atributos id (int),endereço (string), preco (double) e metros quadrados (double)
    public int Id { get; set; }
    public string Endereço { get; set; }
    public double Preco { get; set; }
    public double MetrosQuadrados { get; set; }
//adicionei construtor para inicializar os atributos
    public Imovel(int id, string endereco, double preco, double metrosQuadrados)
{
    this.Id = id;
    this.Endereco = endereco;
    this.Preco = preco;
    this.MetrosQuadrados = metrosQuadrados;
}
//Adicionei os dois métodos abstratas citados
public abstract void AtualizarPreco(double preco);
public abstract void VerificarImovel();
}