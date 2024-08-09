namespace Names;

internal static class HistogramTask
{
    public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
    {
        string title = $"Рождаемость людей с именем '{name}'";
        string[] labels = new string[31];
        for (int i = 0; i < 31; i++)
        {
            labels[i] = (i + 1).ToString();
        }
        double[] values = new double[31];
        for (int i = 0; i < 31; i++)
        {
            foreach (var person in names)
            {
                if (person.Name.Equals(name) && person.BirthDate.Day == (i + 1) && person.BirthDate.Day != 1)
                    values[i] += 1;
            }
        }
        return new HistogramData(
            title,
            labels,
            values);
    }
}