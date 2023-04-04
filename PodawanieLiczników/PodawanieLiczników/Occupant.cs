namespace PodawanieLiczników
{
    public class Occupant
    {
        public string nazwisko { get; private set; }
        public string imie { get; private set; }

        public float GasSum { get; private set; }
        public float WodaSum { get; private set; }
        public float PradSum { get; private set; }
        public Occupant(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.GasSum = 0;
            this.WodaSum = 0;
            this.PradSum = 0;
            
        }

        public void ChoseMedia(char media)
        {
            switch (media)
            {
                case '1':
                    Console.WriteLine("Poniżej podaj nicznik gazu:");
                    var gas = Console.ReadLine();
                    float.TryParse(gas, out float gasNumber);
                    this.GetMediaGas(gasNumber);
                    break;

                case '2':
                    Console.WriteLine("Poniżej podaj nicznik wody:");
                    var aqua = Console.ReadLine();
                    float.TryParse(aqua, out float aquaNumber);
                    this.GetMediaAqua(aquaNumber);
                    break;

                case '3':
                    Console.WriteLine("Poniżej podaj nicznik prądu:");
                    var electricity = Console.ReadLine();
                    float.TryParse(electricity, out float electricityNumber);
                    this.GetMediaPrad(electricityNumber);
                    break;
                default:
                    throw new Exception("Wybrano zły numer proszę wybrać jeden z podany: 1 2 lub 3");


            }

        }
        public void ChoseMedia(string Media)
        {
            if (char.TryParse(Media, out char mediaNumber))
            {
                this.ChoseMedia(mediaNumber);
            }
            else
            {
                throw new Exception("Podana wartość nie jest cyfrą proszę spróbować jeszcze raz");
            }
        }
        public Gas GetMediaGas(float Gas)
        {
            var WynikGazu = new Gas(Gas);
            var DaneGazu = WynikGazu.GetGasConst();
            this.GasSum = DaneGazu.GasCost;
            WynikGazu.GetGasConst();
            return WynikGazu;
        }
        public Woda GetMediaAqua(float aqua)
        {
            var WynikWody = new Woda(aqua);
            var DaneWody = WynikWody.GetMediaCost();
            this.WodaSum = DaneWody.WodaCost;
            WynikWody.GetMediaCost();
            return WynikWody;
        }

        public Prad GetMediaPrad(float electricity)
        {
            var WynikPradu = new Prad(electricity);
            var DanePradu = WynikPradu.GetMediaCost();
            this.PradSum = DanePradu.PradCost;
            WynikPradu.GetMediaCost();
            return WynikPradu;

        }
  


    }
}
