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
            lineNumber += 1;
            if (lineNumber >= _dialogue.Count)
            {
                DeleteDialogue();
                lineNumber = -1;
                return null;
            }
            return _dialogue[lineNumber];
           
        }

        public string MenuDialogue()
        {
            lineNumber -= 2;
            var dialogue = NextDialogue();
            lineNumber += 1;
            return dialogue;

        }
        public string GetSpeaker()
        {
            if (lineNumber >= _dialogue.Count || lineNumber < 0)
            {
                DeleteDialogue();
                lineNumber = -1;
                return null;
            }
            var text = _dialogue[lineNumber];
            return "[" + _dialogueSpeaker[text].ToString() + "]";
        }
    }
}
