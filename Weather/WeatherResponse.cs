public class CoordData
{
    public float lon { get; set; }
    public float lat { get; set; }
}

public class WeatherData
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}

public class MainData
{
    public float temp { get; set; }
    public float feels_like { get; set; }
    public float temp_min { get; set; }
    public float temp_max { get; set; }
    public int pressure { get; set; }
    public int humidity { get; set; }
}

public class WindData
{
    public float speed { get; set; }
    public int deg { get; set; }
}

public class CloudsData
{
    public int all { get; set; }
}

public class SysData
{
    public int type { get; set; }
    public int id { get; set; }
    public string country { get; set; }
    public int sunrise { get; set; }
    public int sunset { get; set; }
}

public class WeatherResponse
{
    public CoordData coord { get; set; }
    public List<WeatherData> weather { get; set; }
    public string @base { get; set; }
    public MainData main { get; set; }
    public int visibility { get; set; }
    public WindData wind { get; set; }
    public CloudsData clouds { get; set; }
    public int dt { get; set; }
    public SysData sys { get; set; }
    public int timezone { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public int cod { get; set; }
}
