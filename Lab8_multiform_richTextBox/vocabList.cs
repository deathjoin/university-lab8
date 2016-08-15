using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_multiform_richTextBox
{
    public class vocabList
    {
        public vocabList next = null;
        public vocabList prev = null;
        public vocabList head = null;
        public vocabList tail = null;
        public string word;

        public vocabList(string s = "") {
            if (s != "") {
                this.word = s;
                this.head = this;
                this.tail = this;
            }
        }

        public int getLength() {
            vocabList cur = this.head;
            int n = 0;
            while (cur != null) {
                n++;
                cur = cur.next;
            }
            return n;
        }

        public string getString() {
            vocabList cur = this.head.next;
            string s = this.head.word;
            while (cur != null) {
                s += ' ' + cur.word;
                cur = cur.next;
            }
            return s;
        }

        private void addNewWord(string s) {
            vocabList toAdd = new vocabList(s);

            if (this.head == null) {
                toAdd.head = toAdd;
                this.head = toAdd;
                this.tail = toAdd;
            } else {
                vocabList cur = this.head;
                while (cur != null && cur.word != toAdd.word) {
                    cur = cur.next;
                }

                // if new word is unique, add it to vocab
                if(cur == null) {
                    cur = this.head;
                    bool rightPlace = false;

                    while ((cur != null) && !rightPlace) {
                        rightPlace = true;

                        // lol, lets count words weight O_O
                        double n = 100000,
                               toAddWeight = 0,
                               curWeight = 0;

                        for (int i = 0; i < toAdd.word.Length; i++) {
                            toAddWeight += (int)toAdd.word[i] * n;
                            n /= 1000;
                        }

                        n = 100000;
                        for (int i = 0; i < cur.word.Length; i++) {
                            curWeight += (int)cur.word[i] * n;
                            n /= 1000;
                        }

                        if (toAddWeight > curWeight) {
                                cur = cur.next;
                                rightPlace = false;
                        }
                    }

                    if (cur == this.head) { // Add to head
                        toAdd.head = toAdd;
                        toAdd.next = this.head;
                        toAdd.next.prev = toAdd;
                        toAdd.tail = this.tail;
                        this.head = toAdd;
                    } else if (cur == null) { // Add to END
                        toAdd.head = this.head;
                        toAdd.tail = toAdd;
                        toAdd.prev = this.tail;
                        toAdd.prev.next = toAdd;
                        this.tail = toAdd;
                    } else { // Add to cur place, before cur
                        cur.prev.next = toAdd;
                        toAdd.prev = cur.prev;
                        toAdd.next = cur;
                        cur.prev = toAdd;
                        toAdd.head = this.head;
                        toAdd.tail = this.tail;
                    }
                }

            }
        }

        public void update(string s) {
            // empty current list
            this.head = null;
            this.next = null;
            this.prev = null;
            this.tail = null;

            string[] words = s.Split(new Char [] {'.', ',', ' ', ':', ';', '!', '?', '(', ')', '\r', '\n', '\t'});

            foreach (string word in words) {
                if (word != "")
                    this.addNewWord(word);
            }
        }
    }
}
