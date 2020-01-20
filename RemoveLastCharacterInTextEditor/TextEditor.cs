using System.Text;

namespace RemoveLastCharacterInTextEditor
{
  public class TextEditor
  {
    private readonly StringBuilder sb;
    public TextEditor()
    {
      sb = new StringBuilder();
    }

    public void Write(char word)
    {
      sb.Append(word);
    }
    public void Undo()
    {
      sb.Length--;
    }

    public override string ToString()
    {
      return sb.ToString();
    }
  }
}
