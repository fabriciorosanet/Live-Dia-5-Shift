/* LOOP WHILE

int num, resp, i;
Console.WriteLine("Digite um número para ver a tabuada: ");
num = Convert.ToInt32(Console.ReadLine());
i = 1; //inicio do contador

while (i <= 50) // repete o conteúdo do bloco enquanto i <= 10
{
    resp = num * i;
    Console.WriteLine("{0} x {1} = {2}", num.ToString(), i.ToString(), resp.ToString());
    i++; //incremento do contador
}

*/

/* 
 * LOOP FOR
 
int num, resp;
Console.Write("Digite um número para ver a tabuada: ");
num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 50; i++) // no for, o bloco é iniciado com as definições de inicio, fim e incremento do contador
{
    resp = num * i;
    Console.WriteLine("{0} x {1} = {2}", num.ToString(), i.ToString(), resp.ToString());
}

*/

/*
 * LOOP DO WHILE


int num, resp, i;
Console.Write("Digite um número para ver a tabuada: ");
num = Convert.ToInt32(Console.ReadLine());
i = 1; // inicio do contador

do // inicio do bloco de repetição
{
    resp = num * i;
    Console.WriteLine("{0} x {1} = {2}", num.ToString(), i.ToString(), resp.ToString());
    i++; //incremento do contador
}while (i <= 50);

 */
