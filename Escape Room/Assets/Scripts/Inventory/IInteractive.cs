
/// <summary>
/// Interface for elements the player can interact with by pressing the Interact button
/// </summary>
public interface IInteractive
{
    string DisplayText { get; }
    string ObservationText { get; }
    int[] ID();
    void InteractWith(int id);
}
