﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppStrings
{
    /*
    Вариант 15
    1. Написать программу, которая вводит текст, состоящий из нескольких предложений, находит самое длинное слово 
    и определяет, сколько раз оно встретилось в тексте.
    2. Дан текст. Вывести все слова, предварительно удалив из них все предыдущие вхождения последней буквы.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void maxword_Click(object sender, EventArgs e)
        {
            outmaxword.Text = "";
            Stack<string> stack = new Stack<string>(); //стек, здесь буду лежать самые длинные слова
            string line = textin.Text;
            string[] words =
                line.Split(new string[] {" ", "\r\n", "\t"},
                    StringSplitOptions.RemoveEmptyEntries); //разбиваем строку на массив слов
            int maxlength = 0; //здесь будет храниться длина самого длинного слова
            for (int i = 0; i < words.Length; i++) //цикл, пробегает по массиву слов...
                if (maxlength < words[i].Length)
                    maxlength = words[i].Length; //если длина текущего слова больше запомненной - запоминаем новую длину
            for (int i = 0; i < words.Length; i++) //цикл, выбирает из массива слов, слова максимальной длины
            {
                if (words[i].Length == maxlength && !stack.Contains(words[i]))
                    stack.Push(words[i]); //если длина слова соответствует максимальной, и этого слова нет в стеке - убираем слово в стек
            }

            string[] maxwords = stack.ToArray(); //переводим стек в массив слов максимальной длины
            int count; //здесь хранится число вхождений слова в строку
            for (int i = 0; i < maxwords.Length; i++) //пробегаемся по массиву слов максимальной длины
            {
                count = 0; //обнуляем счетчик для каждого нового слова
                foreach (string x in words) //перебираем исходный массив слов
                {
                    if (x == maxwords[i])
                        ++count; //если выбранное слово, собвпадает с максимальным - наращиваем счетчик
                }
                outmaxword.Text += maxwords[i] + " встретилось в тексте " + count + " раз.";
            }
        }

        private void DeleteWord_Click(object sender, EventArgs e) // кнопка для вывода всех слов,
                                                                  // предварительно удалив из них все предыдущие вхождения последней буквы
        {
            string[] masText =  textin.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //разбиваем строку на массив слов
            char masLastWord = masText[^1].ToCharArray()[masText[^1].ToCharArray().Length - 1]; // 
            for (int i = 0; i < masText.Length; i++)
            {
                masText[i] = masText[i].Trim(masLastWord);
                delword.Text += masText[i] + " ";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textin.Clear();
            outmaxword.Clear();
            delword.Clear();
        }
    }
    /*
     string[] masText =  textin.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //разбиваем строку на массив слов
            char[] masLastWord = new char[textin.Text.Length*2]; // создаем массив для хранения последних букв в слове
            for (int i = 0; i < masText.Length; i++) 
            {
                masLastWord[i] = masText[i].ToCharArray()[masText[i].Length - 1]; // алгоритм для уравнения строчных и заглавных букв
                masLastWord[i] = masLastWord[i].ToString().ToUpper().ToCharArray()[0];
                masLastWord[masLastWord.Length - i - 1] = masLastWord[i].ToString().ToLower().ToCharArray()[0];
                if (i!=0 && i != masText.Length - 1) 
                { 
                    delword.Text += " " + String.Concat(masText[i].Split(masLastWord, StringSplitOptions.RemoveEmptyEntries));
                }
                else
                {
                    delword.Text += " " + masText[i];
                }
            }
     */
}