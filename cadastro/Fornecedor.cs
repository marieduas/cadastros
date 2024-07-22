namespace cadastro;

public class Fornecedor
{
    string Nome
    int id

    string CPF/CNPJ
    int id

    string Endereço
    int id 

    int Número
    int id 

    string Cidade
    int id 

    string Estado 
    int id 

    string Pais 
    int id 

    string CEP
    int id 

    int Telefone
    int id 

    string Email
    int id 

    public void SetNome (string A)
    {
        this.Nome = A
    }
    public string GetA ()
    {
        return Nome;
    }

    public void SetCPFCNPJ (string B)
    {
        this.CPFCNPJ = B
    }
    public string GetB ()
    {
        return CPFCNPJ;
    }

    public void SetEndereço (string C)
    {
        this.Endereço = C
    }
    public string GetC ()
    {
        return Endereço;
    }

    public void SetNúmero (int D)
    {
        this.Número = D
    } 
    public int GetD ()
    {
        return Número;
    }

    public void SetCidade (string E)
    {
        this.Cidade = E
    }
    public string GetE ()
    {
        return Cidade;
    }

    public void SetEstado (string F)
    {
        this.Estado = F
    }
    public string GetF ()
    {
        return Estado;
    }

    public void SetPais (string G)
    {
        this.Pais = G
    }
    public string GetG ()
    {
        return Pais;
    }

    public void SetCEP (string H)
    {
        this.CEP = H
    }
    public string GetH ()
    {
        return CEP;
    }
}