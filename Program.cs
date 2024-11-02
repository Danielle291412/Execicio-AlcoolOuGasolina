Console.Clear();

Console.WriteLine("Alcool ou Gasolina?\n");

Console.Write("Determine o valor do álcool (R$):");
decimal Álcool = Convert.ToDecimal(Console.ReadLine());

Console.Write("Determine o valor da gasolina (R$):");
decimal Gasolina = Convert.ToDecimal(Console.ReadLine());

string recomendado;

double razao = RazaoÁlcoolGasolina(Álcool, Gasolina);

if (AbastecerComGasolina(razao))
{
    recomendado = "Gasolina";
}

else
{
    recomendado = "Álcool";
}


Console.WriteLine($"\nO valor do álcool corresponde a {razao:P1} do valor da gasolina.");
Console.WriteLine($"\nRecomendado: Abastecer com {recomendado.ToUpper()}.");

double RazaoÁlcoolGasolina(decimal valorÁlcool, decimal valorGasolina)
{
    return Convert.ToDouble(valorÁlcool / valorGasolina);
}

bool AbastecerComGasolina(double razao)
{
    const double MinRazaoUsoGasolina = 0.73;
    return razao >= MinRazaoUsoGasolina;
}