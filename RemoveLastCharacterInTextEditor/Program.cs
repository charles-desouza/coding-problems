using System;

namespace RemoveLastCharacterInTextEditor
{
  class Program
  {
    static void Main(string[] args)
    {
      TextEditor editor = new TextEditor();
      editor.Write('H');
      editor.Write('E');
      editor.Write('L');
      editor.Write('L');
      editor.Write('o');
      editor.Write('o');
      Console.WriteLine(editor.ToString());
      editor.Undo();
      Console.WriteLine(editor.ToString());

      Console.WriteLine();
    }
  }
}
