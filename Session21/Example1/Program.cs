var state1 = new State(123, "Sombrerete", "Zacatecas");
var state2 = new State(321, "Sombrerete", "Zacatecas");
var state3 = new State(222, "Sombrerete", "Zacatecas");
var state4 = new State(543, "Sombrerete", "Zacatecas");

Console.WriteLine($"{state1}{state2}");
State[] ListState = new State[5];
ListState[0] = new State(123, "Aguascalientes", "Aguascalientes");
ListState[1] = new State(321, "Durango", "Durango");
ListState[2] = new State(222, "Chihuahua", "Chihuahua");
ListState[3] = new State(456, "Nuevo Leon", "Monterrey" );
ListState[4] = new State(461, "Yucatan", "Merida");

for(int i = 0; i <= 4; i++)
{
    Console.WriteLine(ListState[i]);
}