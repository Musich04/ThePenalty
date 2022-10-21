using UnityEngine;

public class IntegerGenerator
{
    private int _minValue;
    private int _maxValue;

    public IntegerGenerator(int minValue, int maxValue)
    {
        _minValue = minValue;
        _maxValue = maxValue;
    }

    public int Generate()
    {
        int value = Random.Range(_minValue, _maxValue);
        return value;
    }
}
