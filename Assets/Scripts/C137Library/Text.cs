using System;
using System.Drawing;

/*
MIT License

Copyright (c) 2022 C137#2606(https://github.com/R-C137)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace C137.Utils
{
    public class Text
    {

        /// <summary>
        /// <para>Writes text art to the console. Supports the default ASCII characters.</para>
        /// <para>TODO : Add a size parameter</para>
        /// </summary>
        /// <param name="text"></param>
        public static string GetASCIIArt(string text) // Further testing is needed
        {
            string[] textArt = new string[6];

            int i = 1;

            string fString = "";

            foreach (var character in text)
            {
                if(character == '\n')
                {
                    string _fString = "";

                    foreach (string str in textArt)
                    {
                        _fString += $"{str}\n";
                    }

                    _fString += GetASCIIArt(text.Remove(0, i));
                    return _fString;
                }
                i++;
                switch (character)
                {
                    case ' ':
                        textArt[0] += "  ";
                        textArt[1] += "  ";
                        textArt[2] += "  ";
                        textArt[3] += "  ";
                        textArt[4] += "  ";
                        textArt[5] += "  ";
                        break;

                    case '!':
                        textArt[0] += "╔╗";
                        textArt[1] += "║║";
                        textArt[2] += "║║";
                        textArt[3] += "╚╝";
                        textArt[4] += "╔╗";
                        textArt[5] += "╚╝";
                        break;

                    case '(':
                        textArt[0] += "  ╔═╗";
                        textArt[1] += " ╔╝╔╝";
                        textArt[2] += "╔╝╔╝ ";
                        textArt[3] += "╚╗╚╗ ";
                        textArt[4] += " ╚╗╚╗";
                        textArt[5] += "  ╚═╝";
                        break;

                    case ')':
                        textArt[0] += "╔═╗  ";
                        textArt[1] += "╚╗╚╗ ";
                        textArt[2] += " ╚╗╚╗";
                        textArt[3] += " ╔╝╔╝";
                        textArt[4] += "╔╝╔╝ ";
                        textArt[5] += "╚═╝  ";
                        break;

                    case '-':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "    ";
                        textArt[3] += "    ";
                        textArt[4] += "╔══╗";
                        textArt[5] += "╚══╝";
                        break;

                    case '+':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += " ╔╗ ";
                        textArt[3] += "╔╝╚╗";
                        textArt[4] += "╚╗╔╝";
                        textArt[5] += " ╚╝ ";
                        break;

                    case '=':
                        textArt[0] += "     ";
                        textArt[1] += "     ";
                        textArt[2] += "╔═══╗";
                        textArt[3] += "╚═══╝";
                        textArt[4] += "╔═══╗";
                        textArt[5] += "╚═══╝";
                        break;

                    case '\'':
                        textArt[0] += "╔╗";
                        textArt[1] += "║║";
                        textArt[2] += "╚╝";
                        textArt[3] += "  ";
                        textArt[4] += "  ";
                        textArt[5] += "  ";
                        break;

                    case 'a':
                    case 'A':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔═╗║";
                        textArt[2] += "║║ ║║";
                        textArt[3] += "║╚═╝║";
                        textArt[4] += "║╔═╗║";
                        textArt[5] += "╚╝ ╚╝";
                        break;

                    case 'b':
                        textArt[0] += "╔╗  ";
                        textArt[1] += "║║  ";
                        textArt[2] += "║╚═╗";
                        textArt[3] += "║╔╗║";
                        textArt[4] += "║╚╝║";
                        textArt[5] += "╚══╝";
                        break;
                    case 'B':
                        textArt[0] += "╔══╗ ";
                        textArt[1] += "║╔╗║ ";
                        textArt[2] += "║╚╝╚╗";
                        textArt[3] += "║╔═╗║";
                        textArt[4] += "║╚═╝║";
                        textArt[5] += "╚═══╝";
                        break;

                    case 'c':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔══╗";
                        textArt[3] += "║╔═╝";
                        textArt[4] += "║╚═╗";
                        textArt[5] += "╚══╝";
                        break;
                    case 'C':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔═╗║";
                        textArt[2] += "║║ ╚╝";
                        textArt[3] += "║║ ╔╗";
                        textArt[4] += "║╚═╝║";
                        textArt[5] += "╚═══╝";
                        break;

                    case 'd':
                        textArt[0] += "  ╔╗";
                        textArt[1] += "  ║║";
                        textArt[2] += "╔═╝║";
                        textArt[3] += "║╔╗║";
                        textArt[4] += "║╚╝║";
                        textArt[5] += "╚══╝";
                        break;
                    case 'D':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "╚╗╔╗║";
                        textArt[2] += " ║║║║";
                        textArt[3] += " ║║║║";
                        textArt[4] += "╔╝╚╝║";
                        textArt[5] += "╚═══╝";
                        break;

                    case 'e':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔══╗";
                        textArt[3] += "║║═╣";
                        textArt[4] += "║║═╣";
                        textArt[5] += "╚══╝";
                        break;
                    case 'E':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔══╝";
                        textArt[2] += "║╚══╗";
                        textArt[3] += "║╔══╝";
                        textArt[4] += "║╚══╗";
                        textArt[5] += "╚═══╝";
                        break;

                    case 'f':
                        textArt[0] += " ╔═╗";
                        textArt[1] += " ║╔╝";
                        textArt[2] += "╔╝╚╗";
                        textArt[3] += "╚╗╔╝";
                        textArt[4] += " ║║ ";
                        textArt[5] += " ╚╝ ";
                        break;
                    case 'F':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔══╝";
                        textArt[2] += "║╚══╗";
                        textArt[3] += "║╔══╝";
                        textArt[4] += "║║   ";
                        textArt[5] += "╚╝   ";
                        break;

                    case 'g':
                        textArt[0] += "╔══╗";
                        textArt[1] += "║╔╗║";
                        textArt[2] += "║╚╝║";
                        textArt[3] += "╚═╗║";
                        textArt[4] += "╔═╝║";
                        textArt[5] += "╚══╝";
                        break;
                    case 'G':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔═╗║";
                        textArt[2] += "║║ ╚╝";
                        textArt[3] += "║║╔═╗";
                        textArt[4] += "║╚╩═║";
                        textArt[5] += "╚═══╝";
                        break;

                    case 'h':
                        textArt[0] += "╔╗  ";
                        textArt[1] += "║║  ";
                        textArt[2] += "║╚═╗";
                        textArt[3] += "║╔╗║";
                        textArt[4] += "║║║║";
                        textArt[5] += "╚╝╚╝";
                        break;
                    case 'H':
                        textArt[0] += "╔╗ ╔╗";
                        textArt[1] += "║║ ║║";
                        textArt[2] += "║╚═╝║";
                        textArt[3] += "║╔═╗║";
                        textArt[4] += "║║ ║║";
                        textArt[5] += "╚╝ ╚╝";
                        break;

                    case 'i':
                        textArt[0] += "  ";
                        textArt[1] += "  ";
                        textArt[2] += "╔╗";
                        textArt[3] += "╠╣";
                        textArt[4] += "║║";
                        textArt[5] += "╚╝";
                        break;
                    case 'I':
                        textArt[0] += "╔══╗";
                        textArt[1] += "╚╣╠╝";
                        textArt[2] += " ║║ ";
                        textArt[3] += " ║║ ";
                        textArt[4] += "╔╣╠╗";
                        textArt[5] += "╚══╝";
                        break;

                    case 'j':
                        textArt[0] += " ╔╗";
                        textArt[1] += " ╚╝";
                        textArt[2] += " ╔╗";
                        textArt[3] += " ║║";
                        textArt[4] += "╔╝║";
                        textArt[5] += "╚═╝";
                        break;
                    case 'J':
                        textArt[0] += "  ╔╗";
                        textArt[1] += "  ║║";
                        textArt[2] += "  ║║";
                        textArt[3] += "╔╗║║";
                        textArt[4] += "║╚╝║";
                        textArt[5] += "╚══╝";
                        break;

                    case 'k':
                        textArt[0] += "╔╗  ";
                        textArt[1] += "║║  ";
                        textArt[2] += "║║╔╗";
                        textArt[3] += "║╚╝╝";
                        textArt[4] += "║╔╗╗";
                        textArt[5] += "╚╝╚╝";
                        break;
                    case 'K':
                        textArt[0] += "╔╗╔═╗";
                        textArt[1] += "║║║╔╝";
                        textArt[2] += "║╚╝╝ ";
                        textArt[3] += "║╔╗║ ";
                        textArt[4] += "║║║╚╗";
                        textArt[5] += "╚╝╚═╝";
                        break;

                    case 'l':
                        textArt[0] += "╔╗ ";
                        textArt[1] += "║║ ";
                        textArt[2] += "║║ ";
                        textArt[3] += "║║ ";
                        textArt[4] += "║╚╗";
                        textArt[5] += "╚═╝";
                        break;
                    case 'L':
                        textArt[0] += "╔╗   ";
                        textArt[1] += "║║   ";
                        textArt[2] += "║║   ";
                        textArt[3] += "║║ ╔╗";
                        textArt[4] += "║╚═╝║";
                        textArt[5] += "╚═══╝";
                        break;

                    case 'm':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔╗╔╗";
                        textArt[3] += "║╚╝║";
                        textArt[4] += "║║║║";
                        textArt[5] += "╚╩╩╝";
                        break;
                    case 'M':
                        textArt[0] += "╔═╗╔═╗";
                        textArt[1] += "║║╚╝║║";
                        textArt[2] += "║╔╗╔╗║";
                        textArt[3] += "║║║║║║";
                        textArt[4] += "║║║║║║";
                        textArt[5] += "╚╝╚╝╚╝";
                        break;

                    case 'n':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔═╗ ";
                        textArt[3] += "║╔╗╗";
                        textArt[4] += "║║║║";
                        textArt[5] += "╚╝╚╝";
                        break;
                    case 'N':
                        textArt[0] += "╔═╗ ╔╗";
                        textArt[1] += "║║╚╗║║";
                        textArt[2] += "║╔╗╚╝║";
                        textArt[3] += "║║╚╗║║";
                        textArt[4] += "║║ ║║║";
                        textArt[5] += "╚╝ ╚═╝";
                        break;

                    case 'o':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔══╗";
                        textArt[3] += "║╔╗║";
                        textArt[4] += "║╚╝║";
                        textArt[5] += "╚══╝";
                        break;
                    case 'O':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔═╗║";
                        textArt[2] += "║║ ║║";
                        textArt[3] += "║║ ║║";
                        textArt[4] += "║╚═╝║";
                        textArt[5] += "╚═══╝";
                        break;

                    case 'p':
                        textArt[0] += "╔══╗";
                        textArt[1] += "║╔╗║";
                        textArt[2] += "║╚╝║";
                        textArt[3] += "║╔═╝";
                        textArt[4] += "║║  ";
                        textArt[5] += "╚╝  ";
                        break;
                    case 'P':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔═╗║";
                        textArt[2] += "║╚═╝║";
                        textArt[3] += "║╔══╝";
                        textArt[4] += "║║   ";
                        textArt[5] += "╚╝   ";
                        break;

                    case 'q':
                        textArt[0] += "╔══╗";
                        textArt[1] += "║╔╗║";
                        textArt[2] += "║╚╝║";
                        textArt[3] += "╚═╗║";
                        textArt[4] += "  ║║";
                        textArt[5] += "  ╚╝";
                        break;
                    case 'Q':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔═╗║";
                        textArt[2] += "║║ ║║";
                        textArt[3] += "║╚═╝║";
                        textArt[4] += "╚══╗║";
                        textArt[5] += "   ╚╝";
                        break;

                    case 'r':
                        textArt[0] += "   ";
                        textArt[1] += "   ";
                        textArt[2] += "╔═╗";
                        textArt[3] += "║╔╝";
                        textArt[4] += "║║ ";
                        textArt[5] += "╚╝ ";
                        break;
                    case 'R':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔═╗║";
                        textArt[2] += "║╚═╝║";
                        textArt[3] += "║╔╗╔╝";
                        textArt[4] += "║║║╚╗";
                        textArt[5] += "╚╝╚═╝";
                        break;

                    case 's':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔══╗";
                        textArt[3] += "║══╣";
                        textArt[4] += "╠══║";
                        textArt[5] += "╚══╝";
                        break;
                    case 'S':
                        textArt[0] += "╔═══╗";
                        textArt[1] += "║╔═╗║";
                        textArt[2] += "║╚══╗";
                        textArt[3] += "╚══╗║";
                        textArt[4] += "║╚═╝║";
                        textArt[5] += "╚═══╝";
                        break;

                    case 't':
                        textArt[0] += " ╔╗ ";
                        textArt[1] += "╔╝╚╗";
                        textArt[2] += "╚╗╔╝";
                        textArt[3] += " ║║ ";
                        textArt[4] += " ║╚╗";
                        textArt[5] += " ╚═╝";
                        break;
                    case 'T':
                        textArt[0] += "╔════╗";
                        textArt[1] += "║╔╗╔╗║";
                        textArt[2] += "╚╝║║╚╝";
                        textArt[3] += "  ║║  ";
                        textArt[4] += "  ║║  ";
                        textArt[5] += "  ╚╝  ";
                        break;

                    case 'u':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔╗╔╗";
                        textArt[3] += "║║║║";
                        textArt[4] += "║╚╝║";
                        textArt[5] += "╚══╝";
                        break;
                    case 'U':
                        textArt[0] += "╔╗ ╔╗";
                        textArt[1] += "║║ ║║";
                        textArt[2] += "║║ ║║";
                        textArt[3] += "║║ ║║";
                        textArt[4] += "║╚═╝║";
                        textArt[5] += "╚═══╝";
                        break;

                    case 'v':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔╗╔╗";
                        textArt[3] += "║╚╝║";
                        textArt[4] += "╚╗╔╝";
                        textArt[5] += " ╚╝ ";
                        break;
                    case 'V':
                        textArt[0] += "╔╗  ╔╗";
                        textArt[1] += "║╚╗╔╝║";
                        textArt[2] += "╚╗║║╔╝";
                        textArt[3] += " ║╚╝║ ";
                        textArt[4] += " ╚╗╔╝ ";
                        textArt[5] += "  ╚╝  ";
                        break;

                    case 'w':
                        textArt[0] += "      ";
                        textArt[1] += "      ";
                        textArt[2] += "╔╗╔╗╔╗";
                        textArt[3] += "║╚╝╚╝║";
                        textArt[4] += "╚╗╔╗╔╝";
                        textArt[5] += " ╚╝╚╝ ";
                        break;
                    case 'W':
                        textArt[0] += "╔╗╔╗╔╗";
                        textArt[1] += "║║║║║║";
                        textArt[2] += "║║║║║║";
                        textArt[3] += "║╚╝╚╝║";
                        textArt[4] += "╚╗╔╗╔╝";
                        textArt[5] += " ╚╝╚╝ ";
                        break;

                    case 'x':
                        textArt[0] += "    ";
                        textArt[1] += "    ";
                        textArt[2] += "╔╗╔╗";
                        textArt[3] += "╚╬╬╝";
                        textArt[4] += "╔╬╬╗";
                        textArt[5] += "╚╝╚╝";
                        break;
                    case 'X':
                        textArt[0] += "╔═╗╔═╗";
                        textArt[1] += "╚╗╚╝╔╝";
                        textArt[2] += " ╚╗╔╝ ";
                        textArt[3] += " ╔╝╚╗ ";
                        textArt[4] += "╔╝╔╗╚╗";
                        textArt[5] += "╚═╝╚═╝";
                        break;

                    case 'y':
                        textArt[0] += "╔╗ ╔╗";
                        textArt[1] += "║║ ║║";
                        textArt[2] += "║╚═╝║";
                        textArt[3] += "╚═╗╔╝";
                        textArt[4] += "╔═╝║ ";
                        textArt[5] += "╚══╝ ";
                        break;
                    case 'Y':
                        textArt[0] += "╔╗  ╔╗";
                        textArt[1] += "║╚╗╔╝║";
                        textArt[2] += "╚╗╚╝╔╝";
                        textArt[3] += " ╚╗╔╝ ";
                        textArt[4] += "  ║║  ";
                        textArt[5] += "  ╚╝  ";
                        break;

                    case 'z':
                        textArt[0] += "     ";
                        textArt[1] += "     ";
                        textArt[2] += "╔═══╗";
                        textArt[3] += "╠══║║";
                        textArt[4] += "║║══╣";
                        textArt[5] += "╚═══╝";
                        break;
                    case 'Z':
                        textArt[0] += "╔════╗";
                        textArt[1] += "╚══╗═║";
                        textArt[2] += "  ╔╝╔╝";
                        textArt[3] += " ╔╝╔╝ ";
                        textArt[4] += "╔╝═╚═╗";
                        textArt[5] += "╚════╝";
                        break;

                    default:
                        break;
                }
            }

            foreach (string str in textArt)
            {
                fString += $"{str}\n";
            }
            return fString;
        }
    }
}
