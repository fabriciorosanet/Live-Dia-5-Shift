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


/* LOOP FOR
 
int num, resp;
Console.Write("Digite um número para ver a tabuada: ");
num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 500; i++) // no for, o bloco é iniciado com as definições de inicio, fim e incremento do contador
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

/* Vetores são variáveis capazes de armazenar vários dados,
   de um mesmo tipo, simultaneamente.


 exemplo de código sem vetor
double v1, v2, v3, v4, v5, total;

Console.WriteLine("Digite o valor das vendas do Vendedor 1:  ");
v1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor das vendas do Vendedor 2:  ");
v2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor das vendas do Vendedor 3:  ");
v3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor das vendas do Vendedor 4:  ");
v4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor das vendas do Vendedor 5:  ");
v5 = Convert.ToDouble(Console.ReadLine());

total = v1 + v2 + v3 + v4 + v5;

Console.WriteLine("Total das vendas: R${0}", total.ToString("0.00"));

*/

// exemplo de código com vetor

double[] v = new double[5];
double total = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o valor das vendas do Venderdor {0}: ", i.ToString());
    v[i] = Convert.ToDouble(Console.ReadLine());
    total = total + v[i];

}

Console.WriteLine("Total das vendas: R${0}", total.ToString("0.00")); 

Tesando versionamento 