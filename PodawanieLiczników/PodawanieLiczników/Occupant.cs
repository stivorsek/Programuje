namespace PodawanieLiczników
{
    public class Occupant
    {
        public string nazwisko { get; private set; }
        public string imie { get; private set; }

        public float gasCost { get; private set; }
        public float watterCost { get; private set; }
        public float electricityCost { get; private set; }
        public Occupant(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.gasCost = 0;
            this.watterCost = 0;
            this.electricityCost = 0;
            
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
                    this.GetMediaWatter(aquaNumber);
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
        public void ChoseMedia(string media)
        {
            if (char.TryParse(media, out char mediaNumber))
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
            var newReadingGas = new Gas(Gas);
            var newGasCalculate = newReadingGas.GetGasConst();
            this.gasCost = newGasCalculate.gasCost;
            return newReadingGas;
        }
        public Watter GetMediaWatter(float watter)
        {
            var newReadingWatter = new Watter(watter);
            var newWatterCalculate = newReadingWatter.GetAquaCost();
            this.watterCost = newWatterCalculate.watterCost;
            return newReadingWatter;
        }

        public Electricity GetMediaPrad(float electricity)
        {
            var newReadingElectricity = new Electricity(electricity);
            var newElectricityCalculate = newReadingElectricity.GetElectricityCost();
            this.electricityCost = newElectricityCalculate.pradCost;
            return newReadingElectricity;

        }
  


    }
}
