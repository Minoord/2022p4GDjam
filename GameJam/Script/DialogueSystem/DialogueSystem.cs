using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Game
{
    public class DialogueSystem
    {
        private int lineNumber = -1; 
        private Dictionary<string, Characters> _dialogueSpeaker = new Dictionary<string, Characters>();
        public List<string> _dialogue = new List<string>();

        public void AddDialogue(string text, Characters talkingCharachter)
        {
            _dialogueSpeaker.Add(text, talkingCharachter);
            _dialogue.Add(text);
        }

        public void AddDialogue(List<string> text, Characters talkingCharachter)
        {
            var listLength = text.Count;
            for (int i = 0; i < listLength; i++)
            {
                _dialogueSpeaker.Add(text[i], talkingCharachter);
                _dialogue.Add(text[i]);
            }
        }

        public void DeleteDialogue()
        {
            _dialogueSpeaker.Clear();
            _dialogue.Clear();
        }

        public string NextDialogue()
        {
            Console.WriteLine(_dialogue.Count + ":" + lineNumber);
            lineNumber += 1;
            if (lineNumber >= _dialogue.Count)
            {
                Console.WriteLine("canceld");
                DeleteDialogue();
                lineNumber = -1;
                return null;
            }
            return _dialogue[lineNumber];
           
        }


        public Characters GetSpeaker()
        {
            var text = _dialogue[lineNumber];
            return _dialogueSpeaker[text];
        }
    }
}
