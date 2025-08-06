namespace MorseRandomPractice;

public class MorseCharacters
{
    public static List<CharacterWithMorse> FullSet = new List<CharacterWithMorse>()
    {
        new("A", ".-"),
        new("B", "-..."),
        new("C", "-.-."),
        new("D", "-.."),
        new("E", "."),
        new("F", "..-."),
        new("G", "--."),
        new("H", "...."),
        new("I", ".."),
        new("J", ".---"),
        new("K", "-.-"),
        new("L", ".-.."),
        new("M", "--"),
        new("N", "-."),
        new("O", "---"),
        new("P", ".--."),
        new("Q", "--.-"),
        new("R", ".-."),
        new("S", "..."),
        new("T", "-"),
        new("U", "..-"),
        new("V", "...-"),
        new("W", ".--"),
        new("X", "-..-"),
        new("Y", "-.--"),
        new("Z", "--.."),
        
        new("1", ".----"),
        new("2", "..---"),
        new("3", "...--"),
        new("4", "....-"),
        new("5", "....."),
        new("6", "-...."),
        new("7", "--..."),
        new("8", "---.."),
        new("9", "----."),
        new("0", "-----"),
        
        new(".", ".-.-.-"),
        new(",", "--..--"),
        new("?", "..--.."),
        new("'", ".----."),
        new("!", "-.-.--"),
        new("/", "-..-."),
        new("(", "-.--."),
        new(")", "-.--.-"),
        new("&", ".-..."),
        new(":", "---..."),
        new(";", "-.-.-."),
        new("=", "-...-"),
        new("+", ".-.-."),
        new("-", "-....-"),
        new("_", "..--.-"),
        new("\"", ".-..-."),
        new("$", "...-..-"),
        new("@", ".--.-.")
    };
}

public class CharacterWithMorse(string english, string morse)
{
    public string English { get; } = english;
    public string Morse { get; } = morse;
}