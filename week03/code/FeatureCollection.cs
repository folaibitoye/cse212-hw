public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<string> Features { get; set; }

    // Constructor
    public FeatureCollection()
    {
        Features = new List<string>();
    }

    // Method to add a feature to the collection
    public void AddFeature(string feature)
    {
        Features.Add(feature);
    }

    // Method to get all features
    public List<string> GetFeatures()
    {
        return Features;
    }

    // Optional: Method to print all features
    public void PrintFeatures()
    {
        Console.WriteLine("Features:");
        foreach (var feature in Features)
        {
            Console.WriteLine($"- {feature}");
        }
    }
    public class Feature
    {
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public string place { get; set; }
        public double? mag { get; set; }
    }
    public List<Feature> features { get; set; }
}

