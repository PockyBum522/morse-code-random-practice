using MorseRandomPractice.Models;

namespace MorseRandomPractice.Interfaces;

public interface IWindowLowLevelController
{
    WindowInformation GetActiveWindowInformation();
    WindowPosition GetWindowPositionMatchingPid(long windowPidNeedle);
}