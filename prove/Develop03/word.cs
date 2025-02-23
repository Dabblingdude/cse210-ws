public class Word
{
    private string _text; // Stores the word itself
    private bool _isHidden; // Tracks whether the word is hidden


    // Constructor - Initializes the word and sets it as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words start as visible
    }


    // Hides the word by setting _isHidden to true
    public void Hide()
    {
        _isHidden = true;
    }


    // Reveals the word by setting _isHidden to false
    public void Show()
    {
        _isHidden = false;
    }


    // Returns whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }


    // Returns the word text, replacing it with underscores if hidden
    public string GetRenderedText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }


    // Override ToString to return the rendered word (hidden or not)
    public override string ToString()
    {
        return GetRenderedText();
    }
}