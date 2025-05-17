using System;
public class GraphicsSettings : ICloneable
{
    public Resolution Resolution { get; set; }
    public TextureQuality TextureQuality { get; set; }
    public DetailLevel DetailLevel { get; set; }

    public GraphicsSettings(Resolution resolution, TextureQuality textureQuality, DetailLevel detailLevel)
    {
        Resolution = resolution;
        TextureQuality = textureQuality;
        DetailLevel = detailLevel;
    }
    public object Clone()
    {
        return new GraphicsSettings(
            (Resolution)Resolution.Clone(),
            (TextureQuality)TextureQuality.Clone(),
            (DetailLevel)DetailLevel.Clone());
    }
}
public class Resolution : ICloneable
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Resolution(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public object Clone()
    {
        return new Resolution(Width, Height);
    }
}

public class TextureQuality : ICloneable
{
    public string Quality { get; set; }

    public TextureQuality(string quality)
    {
        Quality = quality;
    }

    public object Clone()
    {
        return new TextureQuality(Quality);
    }
}

public class DetailLevel : ICloneable
{
    public int Level { get; set; }

    public DetailLevel(int level)
    {
        Level = level;
    }

    public object Clone()
    {
        return new DetailLevel(Level);
    }
}
class Program
{
    static void Main()
    {
        GraphicsSettings originalSettings = new GraphicsSettings(
            new Resolution(1920, 1080),
            new TextureQuality("High"),
            new DetailLevel(3));
        GraphicsSettings clonedSettings = (GraphicsSettings)originalSettings.Clone();
        clonedSettings.Resolution.Width = 1280;
        clonedSettings.TextureQuality.Quality = "Medium";
        Console.WriteLine($"Original: {originalSettings.Resolution.Width}x{originalSettings.Resolution.Height}, Quality: {originalSettings.TextureQuality.Quality}");
        Console.WriteLine($"Clone: {clonedSettings.Resolution.Width}x{clonedSettings.Resolution.Height}, Quality: {clonedSettings.TextureQuality.Quality}");
    }
}

