using System;
using System.Linq;

namespace DesafioDIO {
    class Program {
        static void Main() {
            string [] arrTemp = {"9","10","9","10"};
            var s = JogoFactory.Create(arrTemp).GetTempoPartida();
            Console.WriteLine(s);
        }

        static void DasafioHoras(){
            int horaInicial, minInicial, horaFinal, minFinal, duracaoHora, duracaoMin;
            string[] s = Console.ReadLine().Split(' ');
          
            horaInicial = int.Parse(s[0]);
            minInicial = int.Parse(s[1]);
            horaFinal = int.Parse(s[2]);
            minFinal = int.Parse(s[3]);
            duracaoHora = duracaoMin = 0;
            
            if ((horaFinal > horaInicial && minFinal >= minInicial) ||
                (horaFinal >= horaInicial && minFinal > minInicial)) {
              duracaoHora = horaFinal - horaInicial;
              duracaoMin = minFinal - minInicial;
              
            } else if (horaFinal == horaInicial && minFinal == minInicial) {
              duracaoHora = 24;
              duracaoMin = 0;
              
            } else if (horaFinal == horaInicial && minFinal < minInicial) {
              duracaoHora = 23;
              duracaoMin = minFinal + (60 - minInicial);
              
            } else if (horaFinal > horaInicial && minFinal < minInicial) {
              duracaoHora = horaFinal - horaInicial - 1;
              duracaoMin = minFinal + (60 - minInicial);
              
            } else if (horaFinal < horaInicial && minFinal < minInicial) {
              duracaoHora = horaFinal + (24 - horaInicial) - 1;
              duracaoMin = minFinal + (60 - minInicial);
              
            } else if (horaFinal < horaInicial && minFinal >= minInicial) {
              duracaoHora = horaFinal + (24 - horaInicial);
              duracaoMin = minFinal - minInicial;
            }
            
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", duracaoHora, duracaoMin);
            Console.ReadLine();
        }

        static void Desafio4(){
            
            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            int max = n.Length;
            int j;
            
            n[0] = valorLido;

            for (j= 1; j < max; j++)
            {
                n[j] = n[j-1] * 2;
            }
            
            //Console.WriteLine(string.Join("\n", n));
            
            for(int i = 0; i < max; i++){
              Console.WriteLine("N["+i+"] = " + n[i]);
            }
        }


        static void Ajuda(){

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int fim = 0;
            int option;

            do
            {
                Console.Write("Digite um código: ");
                option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        alcool += 1;
                        break;
                    case 2:
                        gasolina += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                    case 4:
                        fim = 4;
                        break;
                    default:
                        Console.WriteLine("Código inválido, informe um código válido!");
                        continue;
                }
            } while (option != fim);

            Console.WriteLine($"MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }

        
        static void Desafio3() {
            
            double a, b = 0, avg;
            int i, postive = 0;

            for (i = 0; i < 6; i++) {

                a = double.Parse(Console.ReadLine());
                
                if (a > 0) {
                    postive++;
                    b += a;
                }
            }

            avg = b / postive;

            Console.WriteLine("{0} valores positivos", postive);
            Console.WriteLine("{0}", Math.Round(avg,1)); ;
            Console.ReadLine();

        }

        static void Desafio2() {

            double A, B, C;
            double media;
            
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            media = Math.Round(((A * 2) + (B * 3) + (C * 5)) / 10, 1);

            Console.WriteLine("MEDIA = {0}", media);
            Console.ReadKey();

        }

        static void Desafio1() {

            Console.Write("Informe um número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            
            for (int i = 1; i <= n; i++) {
                
                int a1 = i;
                int a2 = i * i;
                int a3 = a2 * i;

                Console.WriteLine("{0} {1} {2}", a1, a2, a3);

                int b1 = i;
                int b2 = (i * i) + 1;
                int b3 = (b2 * i) - cont;

                Console.WriteLine("{0} {1} {2}", b1, b2, b3);
                cont++;
            }
        }
    }
}
