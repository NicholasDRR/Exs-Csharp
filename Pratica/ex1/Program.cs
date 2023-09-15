//Quando o usuário abrir o jogo deverá ser solicitado o nome do primeiro e do segundo jogador. Não será possível jogar com mais do que dois jogadores.
//
//O jogo deverá solicitar um nome para cada jogador e os nome não podem ser iguais.
//
//O jogo terá 3 rodadas, o jogador que tirar o maior número no dados na maioria das jogadas vence a partida.
//
//Em caso de empate (onde os dois tiram o mesmo número) nenhum jogador pontuará.
//
//A cada rodada a aplicação deve informar quem foi o jogador vencedor. Exemplos de mensagens:
//
//João tirou o número 2 e Maria o número 6. Maria venceu a rodada 1.
//João tirou o número 1 e Maria o número 1. Empate.
//Um placar sempre deve ser exibido até o final do jogo para que os jogadores acompanhem o resultado. Exemplo: Pontos do jogador Maria: 1 Pontos do jogador João: 0
//
//Ao final da rodada 3 a aplicação deve informar quem foi o vencedor ou se foi um empate.
//
//Opcional
//
//Fazer o controle de versionamento da sua aplicação usando git;
//Subir a aplicação para um repositório do github.

Random random = new Random();
int randomNumber = random.Next(0, 10);

int rounds = 0;
int greaterNumber = 0;
string? winner;


System.Console.Write("Player one: ");
string? playerOne = Console.ReadLine();
System.Console.Write("Player two: ");
string? playerTwo = Console.ReadLine();


if (playerOne == playerTwo)
{
    throw new ArgumentException("The name are equals");
}


do
{   
    int playerOneNumber = random.Next(0, 10);
    int playerTwoNumber = random.Next(0, 10);

    System.Console.WriteLine($"Round: {rounds + 1}\n");
    System.Console.WriteLine($"{playerOne}: {playerOneNumber}");
    System.Console.WriteLine($"{playerTwo}: {playerTwoNumber}\n");

    if (playerOneNumber > playerTwoNumber)
    {
        greaterNumber = playerOneNumber;
        winner = playerOne;
    }
    else if (playerOneNumber < playerTwoNumber)
    {
        greaterNumber = playerTwoNumber;
        winner = playerTwo;
    }
    else
    {
        System.Console.WriteLine("Draw!");
        System.Console.WriteLine($"Number: {playerOneNumber}\n");
        rounds++;
        continue;
    }

    
    System.Console.WriteLine($"Winner: {winner}");
    System.Console.WriteLine($"Number: {greaterNumber}\n");

    rounds++;

} while(rounds < 3);











  





