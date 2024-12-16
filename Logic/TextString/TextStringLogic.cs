using System.Text;

namespace Logic.TextString
{
    public class TextStringLogic : ITextStringLogic
    {
        public Task<string> GetTextString(string text)
        {
            string[] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(array);

            string result = string.Join(" ", array);

            return Task.FromResult(result);
        }

    }
}
