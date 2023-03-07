//Два списки I та U містять результати виміру струму і напруги на невідомому опорі R.Знайти наближене число R.
List<double> amperage = new List<double> () {0.8, 1, 0.6, 5};
List<double> voltage = new List<double> () {1.6, 3, 2.4, 5};
List<double> resistance = new List<double> ();
CalculateResistance();
WriteResistanceList();
void CalculateResistance()
{
    double result = 0;
    for (int i = 0; i < amperage.Count; i++)
    {
        result = voltage[i] / amperage[i];
        resistance.Add(result);
    }
}
void WriteResistanceList()
{
    Console.WriteLine("resistance list:");
    for (int i = 0; i < resistance.Count; i++)
    {
        Console.Write(resistance[i] + "\t");
    }
}
