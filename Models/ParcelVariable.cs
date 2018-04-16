namespace ParcelCalculator.Models
{
  public class ParcelVariable
  {
    private int _length;
    private int _height;
    private int _weight;
    private int _width;
    public int GetLength()
    {
      return _length;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }
    public int GetHeight()
    {
      return _height;
    }
    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }
    public int GetWeight()
    {
      return _weight;
    }
    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }
    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }
    public int GetVolume()
    {
      return _width * _height * _length;
    }
    public int GetCost()
    {
      return GetVolume() / _weight * 2;
    }
  }
}
