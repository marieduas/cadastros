namespace cadastro;

public class Cliente
{
    string Nome;
    int id;

    string CPF;
    int id;

    string Endereço;
    int id;

    string Email;
    int id;

public void SetNome (string A)
{
    this.Nome = A
}
public string GetA ()
{
    return Nome;
}

public void SetCPF (string B)
{
    this.CPF = B
}
public string GetB ()
{
    return CPF;
}

public void SetEndereço (string C)
{
    this.Endereço = C
}
public string GetC ()
{
    return Endereço;
}

public void SetEmail (string D)
{
    this.Email = D
}
public string GetD ()
{
    return Email;
}
}