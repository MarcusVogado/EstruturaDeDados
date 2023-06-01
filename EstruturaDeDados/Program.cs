// See https://aka.ms/new-console-template for more information



//                                ESTRUTURA DE DADOS EM C#


#region  PILHAS
Console.WriteLine("PILHAS(STACK)__________________________________________");

Stack<string> historio = new Stack<string>();
historio.Push("marcusvogado.com"); //Push Adiciona o item ou topo da pilha
historio.Push("projetos.marcusvogado.com");
historio.Push("google.com");

Console.WriteLine(historio.Peek()); // Peek imprime o elemento que está no topo da lista

var paginaAnterior = historio.Pop();// Pop Remove o elemento do topo

Console.WriteLine($"pagina atual: {historio.Peek()} pagina anterior: {paginaAnterior}");
#endregion

#region FILAS
Console.WriteLine("FILAS(QUEUE)__________________________________________");
Queue<string> filaAtendimento = new Queue<string>();

filaAtendimento.Enqueue("A-001");//Enqueue Adiciona o elemento da fila
filaAtendimento.Enqueue("A-002");
filaAtendimento.Enqueue("A-003");


Console.WriteLine($"Próximo da fila{filaAtendimento.Peek}");//Peek pega o primeiro elemento da fila mas não o remove
var atendido = filaAtendimento.Dequeue();//Dequeue Remove o primeiro da fila

Console.WriteLine($"Atendido{atendido}");
Console.WriteLine($"Próximo da fila{filaAtendimento.Peek()}");


#endregion

#region MATRIZES
Console.WriteLine("MATRIZES(ARRAYS) __________________________________________");
//unidimencional
int[] notasd1 = new int[2];

notasd1[0] = 80;
notasd1[1] = 70;
foreach (var nota in notasd1)
{
    Console.WriteLine(nota);
}
//bidimencional
int[,] notas2d = new int[3, 2];

notas2d[0, 0] = 80;//Aluno-A, PRIMEIRO BIMESTRE
notas2d[0, 1] = 90;//Aluno-A, SEGUNDO BIMESTRE 
notas2d[1, 0] = 55;//Aluno-B, PRIMEIRO BIMESTRE
notas2d[1, 1] = 60;//Aluno-B, SEGUNDO BIMESTRE
notas2d[2, 0] = 80;//Aluno C, PRIMEIRO BIMESTRE
notas2d[2, 1] = 55;//Aluno C, SEGUNDO BIMESTRE

Console.WriteLine("Notas de estudantes na MATRIZ 2D");

for (var i = 0; i < notas2d.GetLength(0); i++)
{
    Console.WriteLine($"Estudandte{i}");
    for (var j = 0; j < notas2d.GetLength(1); j++)
    {
        Console.WriteLine(notas2d[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion

#region HASHSET
Console.WriteLine("HASHSET__________________________________________");
HashSet<string> playlist = new HashSet<string>();
playlist.Add("video1");//Add para adicionar um elemento a tabela 
playlist.Add("video2");
playlist.Add("video3");
playlist.Add("video4");
playlist.Add("video4"); //Não permite duplicidades 

Console.WriteLine($"Tamnho da minha playList: {playlist.Count}");

playlist.Remove("Video2");//Remove o video 2
var contemvideo = playlist.Contains("video3");
Console.WriteLine("Contem video? " + contemvideo);
Console.WriteLine($"Tamnho da minha playList: {playlist.Count}");

#endregion

#region DICIONÁRIO 
Console.WriteLine("DICIONÁRIO(DICTIONARY)__________________________________________");
Dictionary<string, string> dicTraducao = new Dictionary<string, string>
{
    {"Confirm","Confirmar" },
    {"Cancel","Cancelar" },
    {"Home","Inicio" },
    {"Job Role","Cargo" }
};

Console.WriteLine($"Tradução de Cancel:{dicTraducao["Cancel"]}");
if (dicTraducao.TryGetValue("Cancel", out var traducao))
{
    Console.WriteLine($"Tradução de Cancel é:{traducao}");
}
else
{
    Console.WriteLine("Palavra não encontrada");
}

Dictionary<string, Dictionary<string, string>> dicTraducao2 = new Dictionary<string, Dictionary<string, string>>
{
    {"pt", new Dictionary<string, string>
    {
        {"confirm","Confirmar"},
        {"cancel","Cancelar" }
    }},
    {"en", new Dictionary<string, string>
        {
            {"confirm","Confirm"},
            {"cancel","Cancel" }
        }
    },
     {"es", new Dictionary<string, string>
        {
            {"confirm","Confirmar"},
            {"cancel","cancelar" }
      }
}
};

var linguagemSelecionada = "pt";

Console.WriteLine($"Confirm in Portuguese is: {dicTraducao2[linguagemSelecionada]["confirm"]}");

#endregion

#region LISTA LIGADA(NÓS)

Console.WriteLine("LISTA LIGADA(LINKEDLIST)__________________________________________");
LinkedList<string> playList = new LinkedList<string>();

playList.AddLast("Deus do impossível");//Adiciona sempre ao Final
playList.AddLast("A ele a glória");
playList.AddLast("Será sempre Deus");

foreach (var musica in playList)
{
    Console.WriteLine(musica);
}



Console.WriteLine("Lista____________________________________");
playList.AddFirst("Se até os Anjos Se Prostam");//Adiciona como primeiro da Lista
foreach (var musica in playList)
{
    Console.WriteLine(musica);
}
Console.WriteLine("Lista ____________________________________");
playList.Remove("A ele a glória");//Remover um item especifico da lista

foreach (var musica in playList)
{
    Console.WriteLine(musica);
}

#endregion