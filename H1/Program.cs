string[,] tabuleiro = new string[3, 3];
string jogadorO = "O";
string jogadorX = "X";
string jogadorAtual = jogadorX;
int linha, coluna;

bool fimDeJogo = false;
//fimDeJogo == false
while (!fimDeJogo)
{
    Console.WriteLine("Jogador Atual: " + jogadorAtual);
    Console.WriteLine("Digite a linha:");
    linha = Convert.ToInt32(Console.ReadLine()) - 1;

    Console.WriteLine("Digite a coluna:");
    coluna = Convert.ToInt32(Console.ReadLine()) - 1;

    if (tabuleiro[linha, coluna] == null)
    {
        tabuleiro[linha, coluna] = jogadorAtual;
        if (jogadorAtual == jogadorX)
            jogadorAtual = jogadorO;
    }
    else
    {
        Console.WriteLine("Posição está ocupada");
    }
    ImprimirTabuleiro();
    Console.ReadLine();
}

void ImprimirTabuleiro()
{
    for (int linhaTabuleiro = 0; linhaTabuleiro < 3; linhaTabuleiro++)
    {
        for (int colunaTabuleiro = 0; colunaTabuleiro < 3; colunaTabuleiro++)
        {
            Console.Write("" + tabuleiro[linhaTabuleiro, colunaTabuleiro] + "");
        }
        Console.WriteLine();
    }
}