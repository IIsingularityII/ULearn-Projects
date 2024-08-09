namespace Names;

internal static class HeatmapTask
{
    public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
    {
        string title = "Пример карты интенсивностей";
        string[] XLabels = new string[30];
        for (int i = 0; i < XLabels.Length; i++)
        {
            XLabels[i] = (i + 2).ToString();
        }
        string[] YLabels = new string[12];
        for (int i = 0; i < YLabels.Length; i++)
        {
            YLabels[i] = (i + 1).ToString();
        }
        double[,] heat = new double[30, 12];
        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                foreach (var person in names)
                {
                    if (person.BirthDate.Day == (i + 2) && person.BirthDate.Month == (j + 1))
                        heat[i, j] += 1;
                }
            }
        }
        return new HeatmapData(
            title,
            heat,
            XLabels,
            YLabels);
    }
}