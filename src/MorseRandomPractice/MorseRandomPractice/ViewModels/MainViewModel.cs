using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MorseRandomPractice.ViewModels;

// This is just for window selection gui. Most of the window size/position actual logic is in App.axaml.cs
public partial class MainViewModel(ILogger? loggerApplication = null) : ObservableObject
{
    [ObservableProperty] private string _englishCharacterSetText;
    [ObservableProperty] private string _morseCharacterSetText;

    private List<string> _hiddenMorseLines = [];
    private int _revealedLinesCount = 0;
    
    [RelayCommand]
    private void whenViewLoaded(object? plot)
    {
        if (loggerApplication is null)
        {
            loggerApplication?.Error("In WhenViewLoaded() for MainViewModel, loggerApplication is null");
            
            throw new NullReferenceException();
        }
    }

    [RelayCommand]
    private void NextSet()
    {
        MorseCharacterSetText = "";
        _hiddenMorseLines.Clear();
        
        var random = new Random();

        var newEnglishLinesText = "";
        
        for (var i = 0; i < 5; i++)
        {
            var randomIndex = random.Next(MorseCharacters.FullSet.Count);
            
            newEnglishLinesText += MorseCharacters.FullSet[randomIndex].English;
            newEnglishLinesText += Environment.NewLine;
            
            _hiddenMorseLines.Add(MorseCharacters.FullSet[randomIndex].Morse);
        }
        
        EnglishCharacterSetText = newEnglishLinesText;
        
        MorseCharacterSetText = "";
        _revealedLinesCount = 0;
    }
    
    [RelayCommand]
    private void RevealNextLine()
    {
        if (_revealedLinesCount > 4) return;
        
        MorseCharacterSetText += _hiddenMorseLines[_revealedLinesCount];
        MorseCharacterSetText += Environment.NewLine;
        
        _revealedLinesCount++;
    }
}

