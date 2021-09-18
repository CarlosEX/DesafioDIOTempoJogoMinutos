# DesafioDIOTempoJogoMinutos
RESOLVEMOS! Bug: (bootcamp da everis New Talents - .NET) - Desafios avançados em C# - Desafio 3/3 - Tempo de Jogo com Minutos | Clean Code e Refactoring
Olá caro leitor,

![Superação](https://th.bing.com/th/id/R.49da4bebf0ec5efaccee30d6196a0959?rik=jviBWC3iwEtV5A&pid=ImgRaw&r=0)

Juntos, conseguimos corrigir um BUG na plataforma e ajudar os Devs a concluírem seus exercícios sem precisar fazer gambiarras. Tudo isso graças à comunidade que através de discussões, expôs o Bug, e também, ao time técnico da DIO que acatou, analisou, identificou o pedido de suporte que abri com referência nº DIOS-6501, e fez os ajustes necessários.

Essa foi mais uma vitória que nos motiva a querer sempre melhorarmos, além de nos mostrar que sozinhos não somos capazes de resolver tudo, mas trabalhando como um time, podemos conquistar objetivos muito maiores.



**Agora passa!**

![Superação](https://scontent.fcau11-1.fna.fbcdn.net/v/t39.30808-6/s851x315/242169423_579355149927183_6879047510109066776_n.jpg?_nc_cat=108&ccb=1-5&_nc_sid=730e14&_nc_ohc=XbmPwtoTq3QAX9AioTF&_nc_ht=scontent.fcau11-1.fna&oh=745ef73f579422153ac52b553ad9ba78&oe=614B0DCD)


## Vamos aos problemas!


- O BUG do exercício nº 13
- Lógica de negócio é violada no teste nº 5
- Violação do Clean Code e Refactoring


### O BUG do exercício nº 13!
![BUG](https://scontent.fcau11-1.fna.fbcdn.net/v/t39.30808-6/s600x600/242206322_579355133260518_1684181795352443225_n.jpg?_nc_cat=110&ccb=1-5&_nc_sid=730e14&_nc_ohc=0QXm7pNMlYMAX-0jPkX&_nc_ht=scontent.fcau11-1.fna&oh=7719b1c37bf65b1f4cc44f6ebbb3fa7e&oe=614B504B)

No bootcamp da everis New Talents - .NET - Desafios avançados em C# - Desafio 3/3 - Tempo de Jogo com Minutos, estávamos tendo um problema na entrega do último exercício, relacionado ao teste de número nº 13. Com isso, não era possível entregar o desafio e por mais que tentássemos modificar o código, no fim, gastamos todos os nossos corações.

Consultado o fórum e o discord, notei que havia um consenso entre a grande maioria dos devs, de que esse era um Bug do desafio, pois eu não havia visto até o momento, algum indício de alguém que conseguiu fazer passar. 

### Lógica de negócio é violada no teste nº 5
![BUG](https://scontent.fcau11-1.fna.fbcdn.net/v/t39.30808-6/p180x540/242266277_579357256593639_8348692640975057564_n.jpg?_nc_cat=111&ccb=1-5&_nc_sid=730e14&_nc_ohc=zY2gIXqcby4AX8YKWhl&_nc_ht=scontent.fcau11-1.fna&oh=03940a9552b7e26c960513e2b2c354d4&oe=6149930C)

Lendo o escopo do desafio, existe apenas uma única regra de negócio, que é a seguinte: Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

Se eu não fiz uma interpretação equivocada do enunciado: analisando o resultado do teste nº 5, “O JOGO DUROU 24 HORA(S) E 3 MINUTO(S)” esse resultado violou a regra de negócio, aceitando um valor maior (>) que 24 horas. Se eu aplicar essa validação, o teste 5 vai quebrar, devido ele esperar o resultado acima que é maior que 24 horas.

### Violação do Clean Code e Refactoring

Este não é necessariamente um problema, mas é uma motivação relacionada a estrutura e qualidade do código.

Infelizmente eu não tenho o esqueleto da versão original do exercício 3/3. Por que ele exemplifica claramente o que eu pretendo elucidar nessa parte do artigo. Porém, vou utilizar um modelo já pronto, que vai mostrar claramente os pontos que comprometem a qualidade do código, e violam as regras do Clean Code.

> Todo código é passível a ser refatorado e melhorado.

Nos desafios de código dos bootcamps, recebemos um breve escopo do desafio, com as regras de negócio e exemplos de input e output. E para ajudar mais ainda, recebemos um modelo de algoritmo com partes a serem preenchidas com a nossa solução. Isso é bom, principalmente para os Devs iniciantes, e até mesmo os Devs mais avançados, por que dá uma ideia inicial da solução.

Manter um código limpo, modular, fácil de entender, modificar e testar, é uma habilidade que devemos praticar constantemente. No começo, vamos cometer muitos erros e isso é normal, o segredo está em não desistir. Dois livros que eu recomendo a leitura, são os livros: clean code e refactoring, eles fornecem dicas imprescindíveis para tornar uma base de código limpa, profissional e elegante.

Minhas anotações de estudo no livro clean code.

Como era a última etapa de fechamento do bootcamp, e após fazer algumas dezenas de cursos, ler materiais, realizar desafios e ver centenas de linhas de códigos escritas por programadores já experientes, para mim, era quase que uma obrigação eu entregar um desafio de código naqueles padrões, tentando melhorar a sua estrutura. 


Lembra da regra de escoteiro do Clean Code?

Deixe a área do acampamento mais limpa do que como você a encontrou.
Foi então que decidi “mesmo que com limitações”, aplicar algumas técnicas de programação para melhoria de código, baseadas no Livro Clean Code e Refactoring, além de um pouquinho de SOLID e o pattern Factory.

Algumas técnicas, eu percebi que já haviam sido aplicadas pela comunidade, o que é um bom sinal, já outras, eu apliquei com base no Refactoring.
Pessoal, antes de continuar eu gostaria de deixar claro que meu código não está pronto e sempre carrego esse aprendizado de que sempre podemos melhorá-lo. Se um programador mais experiente olhar para ele, com certeza vai achar coisas erradas e o código vai ficar muito melhor após algumas refatorações.

## Algumas das técnicas utilizadas:

 - **Clean Code
   - Nomes significativos
   - Use Nomes que Revelam seu Propósito.
   - Use Nomes Pronunciáveis
   - Nomes de Métodos
   - Use nomes a partir do Domínio da Solução
   - Use nomes de Domínios do Problema
   - Teste unitário
 - **Refactoring
   - Extract Class (refactoring)
   - Extract Function (refactoring)
   - Introduce Parameter Object (refactoring)
   - Decompose Conditional (refactoring)
   - Replace Constructor with Factory Function (refactoring) = Factory (Pattern)
   - Substituir If e Else pelo operador tenário
 - **Design Pattern
   - Factory
 - **SOLID
   - DIP


Vamos ao código inicial:



            public class CodigoOriginal{
              public static void Execute() {

                 int hi, mi, hf, mf, dh, dm;
                 string[] s = Console.ReadLine().Split(' ');

                 hi = int.Parse(s[0]);
                 mi = int.Parse(s[1]);
                 hf = int.Parse(s[2]);
                 mf = int.Parse(s[3]);
                 dh = dm = 0;


                 if ((hf > hi && mf >= mi) || (hf >= hi && mf > mi)) {
                   dh = hf - hi;
                   dm = mf - mi;
                 } 
                 else if (hf == hi && mf == mi) {
                   dh = 24;
                   dm = 0;
                 } 
                 else if (hf == hi && mf < mi) {
                   dh = 23;
                   dm = mf + (60 - mi);
                 } else if (hf > hi && mf < mi) {
                   dh = hf - hi - 1;
                   dm = mf + (60 - mi);
                 }
                 else if (hf < hi && mf < mi) {
                   dh = hf + (24 - hi) - 1;
                   dm = mf + (60 - mi);
                 } else if (hf < hi && mf >= mi) {
                   dh = hf + (24 - hi);
                   dm = mf - mi;
                 }

                    Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", dh, dm);
                 Console.ReadLine();
              }
            }


Esse código além de confuso, viola regras importantes para uma boa legibilidade de código. Outro ponto, é que quando temos um código que contém muitos testes condicionais aninhados, é sinal de um "code smalls" e precisa ser feito alguma coisa a respeito.

#### Variable Names (Nomes de variáveis)

Olhando o código acima, o que faz a variável ***hi*** ? Até você parar por alguns minutos e ler o enunciado e tentar se achar nesse emaranhado de código, para depois descobrir que ela representa a ***"hora inicial"***, já se foram preciosos minutos ou horas.



#### Abbreviations (Abreviações)

Segue a mesma ideia da anterior, ao invés de hi, use horaInicial.



#### Complexidade Ciclomática

Muitos testes condicionais e "decisões" em um código, impacta de forma significativa em nossos testes unitários, pois temos que testar todas as condições.



Vamos ao código refatorado:



            Program

            A classe "cliente" Program e o Método de entrada Main.

            using System; 

            class Program{

             public static void Main()
             {

              string[] vetorTempos = Console.ReadLine().Split(' ');
              var result = JogoFactory.Create(vetorTempos).GetDuracaoJogo();

              Console.WriteLine(result);
              Console.ReadLine();

             }
            }


Veja onde o que declaramos no método main:

            var result = JogoFactory.Create(vetorTempos).GetDuracaoJogo();


#### JogoFactory 



A classe **JogoFactory** é uma Factory simples para criar instâncias da classe Jogo.

Essa classe não era necessária para o desafio, mas eu acabei criando o hábito de aplicar esse pattern simples sempre que possível. O ideal seria passar uma interface no tipo, mas para não deixar muito "purista" acebei passando a própria classe concreta Jogo.



            public class JogoFactory {
             public static Jogo Create(string[] arrayTemp){
              return new Jogo(arrayTemp);
             }
            }


#### TimeSpanCompare

Criei esse Enum, para simplificar o tipo de resultado das verificações de **TimeSpan.Compare**, já que trabalhar com os valores explicitos nas verificações, não eram muito intuitivo.

            public enum TimeSpanCompare {
             IsMenor = -1,
             IsIgual = 0,
             IsMaior = 1
            }


#### Jogo

A principio essa classe ficou grande, mas acrescentei outras regras de validação, como por exemplo as regras de negócios descritas no escopo do desafio, regras de validação dos inputs, analisando se o vetor passado é de tamanho 4 ou nulo, entre outras.

Outra coisa, é que apliquei o Extract Function e Decompose Conditional, sendo assim, fica mais simples entender um If assim:

               if (IsTemposIguais())
                SetTempoDuracaoDe24Horas();

               if (IsTempoInicialMenor())
                SetTempoInicialMenor();

               if (IsTempoInicialMaior())
                SetTempoInicialMaior();
              }


ao invés de um assim:

            if ((hf > hi && mf >= mi) || (hf >= hi && mf > mi)) {
                   dh = hf - hi;
                   dm = mf - mi;
                 } 
                 else if (hf == hi && mf == mi) {
                   dh = 24;
                   dm = 0;
                 } 
                 else if (hf == hi && mf < mi) {
                   dh = 23;
                   dm = mf + (60 - mi);
                 } else if (hf > hi && mf < mi) {
                   dh = hf - hi - 1;
                   dm = mf + (60 - mi);
                 }
                 else if (hf < hi && mf < mi) {
                   dh = hf + (24 - hi) - 1;
                   dm = mf + (60 - mi);
                 } else if (hf < hi && mf >= mi) {
                   dh = hf + (24 - hi);
                   dm = mf - mi;
                 }


Sem falar nos benefícios de facilitar a aplicação de testes unitários. Em outro desafio, eu faço uma refatoração semelhante, porém aplicando outras técnicas, mas o artigo e materiais estão no forno, veja uma prévia aqui.



            public class Jogo {

              private readonly int tempoMinimo = 1;
              private readonly int tempoMaximo = 24 * 60;

              private string[] _vetorTempos;

              public int HoraInicial { get; private set; }
              public int MinutoInicial { get; private set; }
              public int HoraFinal { get; private set; }
              public int MinutoFinal { get; private set; }
              public int DuracaoHoras { get; private set; }
              public int DuracaoMinutos { get; private set; }

              public Jogo(string[] vetorHoras) {
               ValidaEntrada(vetorHoras);
              }

              public string GetDuracaoJogo() {
               return $"O JOGO DUROU {this.DuracaoHoras} HORA(S) E {this.DuracaoMinutos} MINUTO(S)";
              }

              private void ValidaEntrada(string[] vetorHoras) {

               if (IsEntradaDeHorasValida(vetorHoras)) {

                _vetorTempos = vetorHoras;

                SetTempos();
                ValidacoesDeTempos();
               }
               else {
                SetTempoJogoInvalido();
               }
              }

              private static bool IsEntradaDeHorasValida(string[] vetorHoras) {

               int tamanhoEsperadoDoVetor = 4;

               if (vetorHoras == null)
                return false;

               if (vetorHoras.Length != tamanhoEsperadoDoVetor)
                return false;

               return true;
              }

              private void SetTempos() {
               this.HoraInicial = ValidaNumero(_vetorTempos[0]);
               this.MinutoInicial = ValidaNumero(_vetorTempos[1]);
               this.HoraFinal = ValidaNumero(_vetorTempos[2]);
               this.MinutoFinal = ValidaNumero(_vetorTempos[3]);
              }

              private static int ValidaNumero(string value) {
               try {
                bool isValid = int.TryParse(value, out int numero);
                 return isValid ? int.Parse(value) : 0;
                }
                catch (Exception) {
                 return 0;
                }
              }

              private void ValidacoesDeTempos() {

               if (IsTemposIguais())
                SetTempoDuracaoDe24Horas();

               if (IsTempoInicialMenor())
                SetTempoInicialMenor();

               if (IsTempoInicialMaior())
                SetTempoInicialMaior();

               //TODO: Validação da regra de negócio invalidade, aguardando correção do execício.  
               //ValidacoesJogo();
              }

              private void ValidacoesJogo() {

               int tempoTotalMinutos = (this.DuracaoHoras * 60) + this.DuracaoMinutos;

               if (tempoTotalMinutos < tempoMinimo)
                SetTempoJogoInvalido();

               if(tempoTotalMinutos > tempoMaximo)
                SetTempoJogoInvalido();

              }

              private bool IsTemposIguais() {
               return VerificaTempos((int)TimeSpanCompare.IsEgual);
              }
              private bool IsTempoInicialMenor() {
               return VerificaTempos((int)TimeSpanCompare.IsMenor);
              }
              private bool IsTempoInicialMaior() {
               return VerificaTempos((int)TimeSpanCompare.IsMaior);
              }

              private bool VerificaTempos(int value) {

               var hourInitial = new TimeSpan(HoraInicial, MinutoInicial, 0);
               var hourFinish = new TimeSpan(HoraFinal, MinutoFinal, 0);

               if (TimeSpan.Compare(hourInitial, hourFinish) == value)
                return true;

               return false;
              }

              private void SetDuracaoJogo(int horas, int minutos) {
               this.DuracaoHoras = horas;
               this.DuracaoMinutos = minutos;
              }

              private void SetTempoDuracaoDe24Horas() {
               SetDuracaoJogo(horas: 24, minutos: 0);
              }

              private void SetTempoInicialMenor() {

               int horas;
               int minutos;

               if(IsHoraInicialMenor() && IsMinutoInicialMaior()) {

                horas = HoraFinal - HoraInicial - 1;
                minutos = MinutoFinal + (60 - MinutoInicial);

                SetDuracaoJogo(horas, minutos);
               }

               if (IsHoraInicialMenor() && IsMinutoInicialMenorIgual() || IsHoraInicialMenorIgual() && IsMinutoInicialMenor()) {

                horas = HoraFinal - HoraInicial;
                minutos = MinutoFinal - MinutoInicial;

                SetDuracaoJogo(horas, minutos);
               }
              }

              private void SetTempoInicialMaior() {

               int horas;
               int minutos;

               if (IsHoraInicialMaior() && IsMinutoInicialMaior()) {

                horas = HoraFinal + (23 - HoraInicial);
                minutos = MinutoFinal + (60 - MinutoInicial);

                SetDuracaoJogo(horas, minutos);
               }

               if (IsHoraInicialMaior() && IsMinutoInicialMenorIgual()) {

                horas = HoraFinal + (24 - HoraInicial);
                minutos = MinutoFinal - MinutoInicial;

                SetDuracaoJogo(horas, minutos);
               }

               if (IsHorasIguais() && IsMinutoInicialMaior()) {

                horas = 23;
                minutos = MinutoFinal + (60 - MinutoInicial);

                SetDuracaoJogo(horas, minutos);
               }
              }

              private void SetTempoJogoInvalido() {
               SetDuracaoJogo(horas: 0, minutos: 0);
              }

              private bool IsHoraInicialMenorIgual() {
               return HoraInicial <= HoraFinal;
              }
              private bool IsHoraInicialMaior() {
               return HoraInicial > HoraFinal;
              }
              private bool IsHoraInicialMenor() {
                return HoraInicial < HoraFinal; ;
              }
              private bool IsHorasIguais() {
               return int.Equals(HoraInicial, HoraFinal);
              }
              private bool IsMinutoInicialMenor() {
               return MinutoInicial < MinutoFinal;
              }
              private bool IsMinutoInicialMaior() {
               return MinutoInicial > MinutoFinal;
              }
              private bool IsMinutoInicialMenorIgual() {
               return MinutoInicial <= MinutoFinal;
              }
            }


A primeira vista, parece que o código ficou mais complicado, e era melhor manter o anterior, porém caso um dia precisássemos ampliar o nosso programa, ou até mesmo modificá-lo e testá-lo, os benefícios ficariam perceptíveis.



Nesse artigo eu não vou falar o passo a passo do processo de refatoração devido o tamanho, então nos próximos eu prometo que faço desde o começo, explicando cada ação e o porque eu estou fazendo isso. Além do que esse código, não está finalizado e vai passar por outra rodada de refatoração para deixá-lo mais legivel.



Veja a próxima refatoração que fizemos em outro desafio:

C9011 - Aplicando Clean Code, Refactoring e DIP(SOLID) - Desafios avançado 1/3 de C#. (editorx.io)


Segue link do código do desafio: Digital Innovation One

Repositório no GitHub: CarlosEX/DesafioDIOTempoJogoMinutos: RESOLVEMOS! Bug: (bootcamp da everis New Talents - .NET) - Desafios avançados em C# - Desafio 3/3 - Tempo de Jogo com Minutos | Clean Code e Refactoring (github.com)



Bom pessoal, por enquanto é só,



Um forte abraço, e vamos codar!!



Atenciosamente,

Carlos Antonio.

https://carlosantoniocison.editorx.io/portifolio
