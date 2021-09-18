using System;
using System.Linq;

namespace DesafioDIO
{
    public class Jogo
    {
        private readonly int tempMinMinute = 1;
        private readonly int tempMaxHour = 24;
        private readonly TimeSpan tempInitial;
        private readonly TimeSpan tempFinish;
        private int HourInitial { get; set; }
        private int MinuteInitial { get; set; }
        private int HourFinish { get; set; }
        private int MinuteFinish { get; set; }
        private int HoraTotal { get; set; }
        private int MinutoTotal { get; set; }
        private string[] inputTemp { get; set; }

        public Jogo(string[] arrayTemp)
        {
            SetTemps();
            ValidadeTemp();
        }
        

#region Métodos de atulizações (Set)

        private void SetTemps()
        {
            this.HourInitial = int.Parse(inputTemp[0]);
            this.MinuteInitial = int.Parse(inputTemp[1]);
            this.HourFinish = int.Parse(inputTemp[2]);
            this.MinuteFinish = int.Parse(inputTemp[3]);
        }

        private void SetTempo(int horas, int minutos){
            this.HoraTotal = horas;
            this.MinutoTotal = minutos;
        }

        private void SetTempoJogoComDuracaoDe24Horas()
        {
            SetTempo(24, 0);
        }
        private void SetTempoJogoInvalido(){
            SetTempo(0, 0);
        }

        private void SetTempoJogoComTempoFinalMaiorQueTempoInicial()
        {
            var horas = HourFinish - HourInitial;
            var minutos = MinuteFinish - MinuteInitial;
            SetTempo(horas, minutos);
        }
        
#endregion

#region Metódos de validações (Is)
        
        private bool IsInputTempValid(){

            int tamanhoEsperadoDoVetor = 4;

            if(inputTemp.Length != tamanhoEsperadoDoVetor)
                return false;
            
            if(inputTemp == null)
                return false;
            
            int conteNulos = (from x in inputTemp where x == null select x).Count();

            if(conteNulos < 1)
                return false;

            return true;
        }

        private void ValidadeTemp()
        {
            if (IsTempoFinalMaiorQueTempoInicial())
                SetTempoJogoComTempoFinalMaiorQueTempoInicial();

            if (IsHorasIguaisComMinutosIguais())
                SetTempoJogoComDuracaoDe24Horas();

            if(IsInputTempValid())
                SetTempoJogoInvalido();

        }

        private bool IsTempoInicialIgual(){
            return true;
        }
        private bool IsTempoInicialMaior(){
            return true;
        }
        private bool IsTempoInicialMenor(){
            return true;
        }

        private bool IsJogoValidate(){
            return true;
        }

        private bool Is23Horas(){

            return false;
        }

        private bool VerificaTempos(int value){

            var tempInitial = new TimeSpan(HourInitial, MinuteInitial, 0);
            var tempFinish = new TimeSpan(HourFinish, MinuteFinish, 0);

            if (TimeSpan.Compare(tempFinish, tempInitial) == value)
                return true;

            return false;

        }

        private bool IsTemposIguais(){
            return VerificaTempos((int)TimeSpanCompare.IsEqual);
        }

        private bool IsTempoFinalMaiorQueTempoInicial()
        {
            return VerificaTempos((int)TimeSpanCompare.IsBigger);
        }

        private bool IsTempoFinalMenorQueTempoInicial()
        {
            return VerificaTempos((int)TimeSpanCompare.IsMinor);
        }

        private bool IsHorasIguaisComMinutosIguaisd()
        {
            if (int.Equals(HourInitial, HourFinish))
                return true;
            return false;
        }

        private bool IsHoraFinalMenorQueHoraInicial()
        {
            if (HourFinish < HourInitial)
                return true;
            return false;
        }

        private bool IsHorasIguaisComMinutosIguais()
        {
            var hourInitial = new TimeSpan(HourInitial, MinuteInitial, 0);
            var hourFinish = new TimeSpan(HourFinish, MinuteFinish, 0);

            if (TimeSpan.Compare(hourInitial, hourFinish) == (int)TimeSpanCompare.IsEqual)
                return true;

            return false;
        }
#endregion
        
        public string GetTempoPartida()
        {
            return $"O JOGO DUROU {this.HoraTotal} HORA(S) E {this.MinutoTotal} MINUTO(S)";
        }
    }
}