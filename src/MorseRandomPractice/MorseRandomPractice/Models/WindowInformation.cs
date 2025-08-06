using MorseRandomPractice.WindowHelpers;

namespace MorseRandomPractice.Models;


public class WindowInformation(long windowId)
{
    public long Id { get; } = windowId;
    public string IdAsHexLeadingZero { get; } = ProcessIdHelpers.LongIdToHexLeadingZero(windowId);

    public string Title { get; set; } = "";
    public string Class { get; set; } = "";

    public WindowPosition Position { get; set; } = new();
    
    public List<WindowPosition> PreferredPositions { get; set; } = new();
}

