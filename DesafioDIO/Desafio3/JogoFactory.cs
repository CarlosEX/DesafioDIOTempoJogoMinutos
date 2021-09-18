namespace DesafioDIO
{
    public class JogoFactory
    {
        public static Jogo Create(string[] arrayTemp){
            return new Jogo(arrayTemp);
        }
    }
}