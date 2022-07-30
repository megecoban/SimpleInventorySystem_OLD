public interface IInventoryItem
{
    public void Use();
    public void Examine();
    public void DecreaseAmount(int decreaseVal = 1);
    public void DecreaseDurability(int decreaseVal = 1);
    public void IncreaseAmount(int increaseVal = 1);
    public void IncreaseDurability(int increaseVal = 1);
}
