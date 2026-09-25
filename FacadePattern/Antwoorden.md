# Opdracht #3 - Principle of Least Knowledge

## Code 1

```csharp
public float getTemp()
{
    return station.getThermometer().getTemperature();
}
```

| Does this code violate the Principle of Least Knowledge? | Yes |
|---|---|
| Waarom | `getTemperature()` wordt aangeroepen op een object dat terugkomt van `getThermometer()`. De Thermometer is geen component van House, geen parameter en wordt ook niet door de methode zelf gemaakt. House moet dus de Thermometer kennen. |

## Code 2

```csharp
public float getTemp()
{
    Thermometer thermometer = station.getThermometer();
    return GetTempHelper(thermometer);
}
public float GetTempHelper(Thermometer thermometer)
{
    return thermometer.getTemperature();
}
```

| Does this code violate the Principle of Least Knowledge? | No |
|---|---|
| Waarom | In `GetTempHelper` is de thermometer een parameter van de methode, en daar mag je methodes op aanroepen. Volgens de regels klopt het dus. Het probleem is alleen verplaatst: House is nog steeds afhankelijk van Thermometer. |
