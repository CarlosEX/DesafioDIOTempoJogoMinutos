namespace DesafioDIO.Desafio3
{
    public class CodigoOriginal
    {
        public static void Execute()
        {
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

            } else if (hf == hi && mf == mi) {
                dh = 24;
                dm = 0;

            } else if (hf == hi && mf < mi) {
                dh = 23;
                dm = mf + (60 - mi);

            } else if (hf > hi && mf < mi) {
                dh = hf - hi - 1;
                dm = mf + (60 - mi);

            } else if (hf < hi && mf < mi) {
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
}