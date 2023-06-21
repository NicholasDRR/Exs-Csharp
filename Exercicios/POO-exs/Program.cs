//1- Uma classe derivada pode interromper a herança virtual declarando um override como :
//( ) inherits ( ) extends ( ) private ( ) not inheritable (x) sealed

//2- Qual das palavras-chave a seguir é usada para alterar os dados e o comportamento de
//uma classe base substituindo um membro de uma classe base por um novo membro
//derivado ?
//(x) new ( ) base ( ) overloads ( ) override ( ) overridable


//3- Qual das seguintes afirmações está correta?
//A( ) Os métodos estáticos podem ser um método virtual. 
//B( ) Os métodos abstratos não podem ser um método virtual.
//C( ) É obrigatório substituir um método virtual. 
//D(x) Ao substituir um método virtual, os nomes e as assinaturas do método de substituição devem ser os
//mesmos do método virtual que está sendo substituído.
//E( ) Podemos substituir métodos virtuais e não virtuais.



//Qual o resultado da execução do código acima
//considerando as classes A e B.
//Onde B herda da classe A


// 2

//Qual o resultado da execução do código acima
//considerando as classes A e B, onde B herda da classe A

//A
//B


//Quais dos seguintes requisitos são necessários para o polimorfismo em tempo de execução?
//1- O método base substituído deve ser virtual ou abstract
//2- Tanto o método override quanto o método virtual devem ter o mesmo modificador de nível
//de acesso.
//3- Uma declaração override pode alterar a acessibilidade do método virtual.
//4- Uma propriedade abstrata herdada não pode ser substituída em uma classe derivada.
//5- Um método abstrato é implicitamente um método virtual.
//( ) 1 e 3 (x) 1, 2, e 5 ( ) 2, 3 e 4 ( ) somente 4

//1

//Crie um programa que implemente uma interface IVeiculo com dois métodos, um para Dirigir
//do tipo void e outro para Abastecer do tipo bool que possui um parâmetro do tipo int com a
//quantidade de gasolina a abastecer.(defina isso como uma propriedade)
//Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a
//quantidade inicial de gasolina do carro e implemente os métodos Dirigir e Abastecer do carro.
//O método Dirigir deve exibir na tela ”Dirigindo o carro..”, se a gasolina for maior que 0, caso
//contrário deve exibir “Sem gasolina...”, e o método Abastecer deve aumentar a gasolina do
//carro e retornar true.
//Para testar, crie um objeto do tipo Carro com 0 de gasolina inicial e solicite ao usuário a
//informação de uma quantidade de gasolina para abastecer via teclado e por fim execute o
//método Dirigir do carro.


//Car car = new(0);
//System.Console.Write("Quantity to Supply: ");
//var quantity = Convert.ToInt32(Console.ReadLine());
//
//if (car.Supply(quantity))
//{
//    car.Drive();
//}
//
//
//
//interface IVehicle
//{
//    void Drive();
//    bool Supply(int quantity);
//}
//public class Car : IVehicle
//{
//
//    int Gasoline;
//
//    public Car(int gasoline)
//    {
//        Gasoline = gasoline;               
//    }
//
//    public void Drive()
//    {
//        if (Gasoline > 0)
//        {
//            System.Console.WriteLine("Driving the car...");
//        }
//        else
//        {
//            System.Console.WriteLine("No gasoline!");
//        }
//    }
//
//    public bool Supply(int quantity)
//    {
//        Gasoline += quantity;
//        return true;
//    }
//
//
//}

//2

//Crie um programa para gerenciar um álbum de fotos usando os coceitos da programação
//orientada a objetos.
//Para começar, crie uma classe chamada LivroFotos com um atributo privado numPaginas do
//tipo int. Defina também um método público GetNumeroPaginas que retornará o número de
//páginas do álbum de fotos
//O construtor padrão deverá criar um álbum com 16 páginas a classe deve possuir um
//construtor adicional, com o qual podemos especificar o número de páginas que queremos
//no álbum. Crie também uma classe SuperLivroFotos cujo construtor criará um álbum com
//64 páginas.
//Por fim, execute as seguintes ações:
//- Criar um álbum de fotos padrão e exibir o número de páginas
//- Criar um álbum de fotos com 24 páginas e exibir o número de páginas
//- Criar um álbum de fotos grande e exibir o número de páginas


//PhotosBook photosBook = new();
//System.Console.WriteLine(photosBook.GetPageNum());
//
//
//PhotosBook photosBook2 = new(24);
//System.Console.WriteLine(photosBook2.GetPageNum());
//
//SuperPhotoBook photosBook3 = new();
//System.Console.WriteLine(photosBook3.GetPageNum());
//
//
//public class PhotosBook
//{
//    protected int PageNum;
//
//    public PhotosBook()
//    {
//        PageNum = 16;
//    }
//    public PhotosBook(int pageNum)
//    {
//        PageNum = pageNum;
//    }
//
//    public int GetPageNum()
//    {
//        return PageNum;
//    }
//
//}
//
//
//public class SuperPhotoBook : PhotosBook
//{
//
//    public SuperPhotoBook()
//    {
//        PageNum = 64;        
//    }
//}


//3


//  Crie um programa que solicite ao usuário três nomes de pessoas e os armazene em
//  uma matriz de objetos do tipo Pessoa. Haverá duas pessoas do tipo Aluno e uma
//  pessoa do tipo Professor.
//  Para isso, crie uma classe Pessoa que possua uma propriedade Nome do tipo string, um
//  construtor que receba o nome como parâmetro e sobrescreva o método ToString().
//  Então crie mais duas classes que herdam da classe Pessoa, elas serão chamadas de
//  Aluno e Professor. A classe Aluno possui um método Estudar que escreve pelo console
//  que o aluno está estudando. A classe Professor terá um método Explicar que grava no
//  console que o professor está explicando.
//  Lembre-se de também criar dois construtores nas classes filhas que chamam o
//  construtor pai da classe Pessoa.
//  Termine o programa lendo as pessoas (o professor e os alunos) e execute os métodos
//  Explicar e Estudar.



Student joao = new Person("João");
System.Console.WriteLine(joao.ToString());









public class Person
{
    protected string Name { get; set; }

    public Person (string name)
    {
        Name = name;
    }

    public override string ToString ()
    {
        return $"Hello, my name is {Name}!";
    }

}

public class Student : Person
{

    public Student(string name) : base (name)
    {
        Name = name;
    }
    
    public void Studying()
    {
        System.Console.WriteLine("Studying...");
    }
public class Teacher : Person
{

    public Teacher(string name) : base (name)
    {
        Name = name;
    }
    
    public void Explain()
    {
        System.Console.WriteLine("Explaining...");
    }
}
















