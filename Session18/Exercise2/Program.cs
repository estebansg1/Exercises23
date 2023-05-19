using System;
using System.Text.RegularExpressions;


Console.Write("Ingresa una CURP o RFC: ");
string input = Console.ReadLine();

if (EsCURPValida(input))
{
    Console.WriteLine("Es una CURP válida.");
}
else if (EsRFCValido(input))
{
    Console.WriteLine("Es un RFC válido.");
}
else
{
    Console.WriteLine("No es una CURP ni un RFC válido.");
}

static bool EsCURPValida(string input)
{
    string patronCURP = @"^[A-Z]{4}\d{6}[HM]{1}(AS|BC|BS|CC|CH|CL|CM|CS|DF|DG|GR|GT|HG|JC|MC|MN|MS|NE|NL|NT|OC|PL|QR|QT|SL|SP|SR|TC|TL|TS|VZ|YN|ZS){1}[B-DF-HJ-NP-TV-Z]{3}[A-Z0-9]{1}\d{1}$";
    return Regex.IsMatch(input, patronCURP);
}

static bool EsRFCValido(string input)
{
    string patronRFC = @"^[A-Z]{4}\d{6}([A-Z0-9]{3})?$";
    return Regex.IsMatch(input, patronRFC);
}