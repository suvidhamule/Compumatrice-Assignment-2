using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compumatrice_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // char [] sentence_array1 = new char [100];
                string sentence_array;
                List<int> word_count = new List<int>();

                Console.WriteLine("Enter String:");
                sentence_array = Console.ReadLine();
              
                if (sentence_array.Contains(","))
                {
                    string[] comma_seperate = sentence_array.Split(',');

                    foreach (var item in comma_seperate)
                    {

                        string[] array_item = item.Split(' ');


                        if (item.Contains("?"))
                        {
                            string[] question_mark_seperate = item.Split('?');

                            foreach (var item1 in question_mark_seperate)
                            {
                                string[] array_item1 = item1.Split(' ');


                                if (item1.Contains("!"))
                                {
                                    string[] exclamation_seperate = item1.Split('!');

                                    foreach (var item3 in exclamation_seperate)
                                    {
                                        string[] array_item3 = item3.Split(' ');
                                        if (array_item3.Contains(""))
                                        {
                                            word_count.Add(array_item3.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_item3.Count());
                                        }

                                    }

                                }
                                if (item1.Contains("."))
                                {
                                    string[] dot_separate = item1.Split('.');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] array_dot = dot_item.Split(' ');
                                       
                                           if(array_dot.Contains(""))
                                           {
                                              word_count.Add(array_dot.Count()-1);

                                           }
                                        else
                                           {
                                              word_count.Add(array_dot.Count());
                                           }


                                        }
                                    
                                }
                                else
                                {
                                    if (array_item1.Contains(""))
                                    {
                                        word_count.Add(array_item1.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item1.Count());
                                    }
                                }
                            }
                        }
                        else if (item.Contains("!"))
                        {
                            string[] exclamation_seperate = item.Split('!');


                            foreach (var item2 in exclamation_seperate)
                            {
                                string[] array_item2 = item2.Split(' ');
                                if (item2.Contains('?'))
                                {
                                    string[] question_mark_seperate = item2.Split('?');

                                    foreach (var item4 in question_mark_seperate)
                                    {
                                        string[] array_item4 = item4.Split(' ');
                                        if (array_item4.Contains(""))
                                        {
                                            word_count.Add(array_item4.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(array_item4.Count());
                                        }
                                    }

                                }

                                else if (item2.Contains("."))
                                {
                                    string[] dot_separate = item2.Split('.');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] array_dot = dot_item.Split(' ');

                                        if (array_dot.Contains(""))
                                        {
                                            word_count.Add(array_dot.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_dot.Count());
                                        }


                                    }

                                }
                                else
                                {
                                    if (array_item2.Contains(""))
                                    {
                                        word_count.Add(array_item2.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item2.Count());
                                    }
                                }
                            }
                        }
                            //////////

                        else if (item.Contains("."))
                        {
                            string[] exclamation_seperate = item.Split('.');


                            foreach (var item2 in exclamation_seperate)
                            {
                                string[] array_item2 = item2.Split(' ');
                                if (item2.Contains('?'))
                                {
                                    string[] question_mark_seperate = item2.Split('?');

                                    foreach (var item4 in question_mark_seperate)
                                    {
                                        string[] array_item4 = item4.Split(' ');
                                        if (array_item4.Contains(""))
                                        {
                                            word_count.Add(array_item4.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(array_item4.Count());
                                        }
                                    }

                                }

                                else if (item2.Contains("!"))
                                {
                                    string[] dot_separate = item2.Split('!');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] array_dot = dot_item.Split(' ');

                                        if (array_dot.Contains(""))
                                        {
                                            word_count.Add(array_dot.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_dot.Count());
                                        }


                                    }

                                }
                                else
                                {
                                    if (array_item2.Contains(""))
                                    {
                                        word_count.Add(array_item2.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item2.Count());
                                    }
                                }
                            }
                        }

                        
                        else
                        {
                            if (array_item.Contains(""))
                            {
                                word_count.Add(array_item.Count() - 1);
                            }
                            else
                            {
                                word_count.Add(array_item.Count());
                            }
                        }
                    }
                    Console.Write("This is final answer:" + word_count.Max());
                    Console.Read();
                }
                ///
                if (sentence_array.Contains("?"))
                {
                    string[] comma_seperate = sentence_array.Split('?');

                    foreach (var item in comma_seperate)
                    {

                        string[] array_item = item.Split(' ');


                        if (item.Contains(","))
                        {
                            string[] question_mark_seperate = item.Split(',');

                            foreach (var item1 in question_mark_seperate)
                            {
                                string[] array_item1 = item1.Split(' ');


                                if (item1.Contains("!"))
                                {
                                    string[] exclamation_seperate = item1.Split('!');

                                    foreach (var item3 in exclamation_seperate)
                                    {
                                        string[] array_item3 = item3.Split(' ');
                                        if (array_item3.Contains(""))
                                        {
                                            word_count.Add(array_item3.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_item3.Count());
                                        }

                                    }

                                }
                                else if (item1.Contains("."))
                                {
                                    string[] dot_separate = item1.Split('.');
                                    foreach (var dot_item in dot_separate)
                                    { 
                                        string [] dot_array = dot_item.Split(' ');
                                        if (dot_array.Contains(""))
                                        {
                                            word_count.Add(dot_array.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(dot_array.Count());
                                        }
                                    }
                                }
                                else
                                {
                                    if (array_item1.Contains(""))
                                    {
                                        word_count.Add(array_item1.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item1.Count());
                                    }
                                }
                            }
                        }
                        else if (item.Contains("!"))
                        {
                            string[] exclamation_seperate = item.Split('!');


                            foreach (var item2 in exclamation_seperate)
                            {
                                string[] array_item2 = item2.Split(' ');
                                if (item2.Contains(','))
                                {
                                    string[] question_mark_seperate = item2.Split(',');

                                    foreach (var item4 in question_mark_seperate)
                                    {
                                        string[] array_item4 = item4.Split(' ');
                                        if (array_item4.Contains(""))
                                        {
                                            word_count.Add(array_item4.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(array_item4.Count());
                                        }
                                    }

                                }
                                else if (item2.Contains("."))
                                { 
                                 
                                    string[] dot_separate = item2.Split('.');
                                    foreach (var dot_item in dot_separate)
                                    { 
                                        string [] dot_array = dot_item.Split(' ');
                                        if (dot_array.Contains(""))
                                        {
                                            word_count.Add(dot_array.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(dot_array.Count());
                                        }
                                    }
                                  
                                }
                                else
                                {
                                    if (array_item2.Contains(""))
                                    {
                                        word_count.Add(array_item2.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item2.Count());
                                    }
                                }
                            }
                        }/////

                        else if (item.Contains("."))
                        {
                            string[] exclamation_seperate = item.Split('.');


                            foreach (var item2 in exclamation_seperate)
                            {
                                string[] array_item2 = item2.Split(' ');
                                if (item2.Contains(','))
                                {
                                    string[] question_mark_seperate = item2.Split(',');

                                    foreach (var item4 in question_mark_seperate)
                                    {
                                        string[] array_item4 = item4.Split(' ');
                                        if (array_item4.Contains(""))
                                        {
                                            word_count.Add(array_item4.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(array_item4.Count());
                                        }
                                    }

                                }
                                else if (item2.Contains("!"))
                                {

                                    string[] dot_separate = item2.Split('!');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] dot_array = dot_item.Split(' ');
                                        if (dot_array.Contains(""))
                                        {
                                            word_count.Add(dot_array.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(dot_array.Count());
                                        }
                                    }

                                }
                                else
                                {
                                    if (array_item2.Contains(""))
                                    {
                                        word_count.Add(array_item2.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item2.Count());
                                    }
                                }
                            }
                        }/////
                        else
                        {
                            if (array_item.Contains(""))
                            {
                                word_count.Add(array_item.Count() - 1);
                            }
                            else
                            {
                                word_count.Add(array_item.Count());
                            }
                        }
                    }
                    Console.Write("This is final answer:" + word_count.Max());
                    Console.Read();
                }
                ////
                else if (sentence_array.Contains("!"))
                {
                    string[] comma_seperate = sentence_array.Split('!');

                    foreach (var item in comma_seperate)
                    {

                        string[] array_item = item.Split(' ');


                        if (item.Contains("?"))
                        {
                            string[] question_mark_seperate = item.Split('?');

                            foreach (var item1 in question_mark_seperate)
                            {
                                string[] array_item1 = item1.Split(' ');


                                if (item1.Contains(","))
                                {
                                    string[] exclamation_seperate = item1.Split(',');

                                    foreach (var item3 in exclamation_seperate)
                                    {
                                        string[] array_item3 = item3.Split(' ');
                                        if (array_item3.Contains(""))
                                        {
                                            word_count.Add(array_item3.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_item3.Count());
                                        }

                                    }

                                }
                                else if (item1.Contains("."))
                                {
                                    string[] dot_separate = item1.Split('.');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] dot_array = dot_item.Split(' ');
                                        if (dot_array.Contains(""))
                                        {
                                            word_count.Add(dot_array.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(dot_array.Count());
                                        }
                                    }
                                }
                                else
                                {
                                    if (array_item1.Contains(""))
                                    {
                                        word_count.Add(array_item1.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item1.Count());
                                    }
                                }
                            }
                        }
                        else if (item.Contains(","))
                        {
                            string[] exclamation_seperate = item.Split(',');


                            foreach (var item2 in exclamation_seperate)
                            {
                                string[] array_item2 = item2.Split(' ');
                                if (item2.Contains('?'))
                                {
                                    string[] question_mark_seperate = item2.Split('?');

                                    foreach (var item4 in question_mark_seperate)
                                    {
                                        string[] array_item4 = item4.Split(' ');
                                        if (array_item4.Contains(""))
                                        {
                                            word_count.Add(array_item4.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(array_item4.Count());
                                        }
                                    }

                                }
                                else if (item2.Contains("."))
                                {
                                    string[] dot_separate = item2.Split('.');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] dot_array = dot_item.Split(' ');
                                        if (dot_array.Contains(""))
                                        {
                                            word_count.Add(dot_array.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(dot_array.Count());
                                        }
                                    }
                                }
                                else
                                {
                                    if (array_item2.Contains(""))
                                    {
                                        word_count.Add(array_item2.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item2.Count());
                                    }
                                }
                            }
                        }////////////

                        else if (item.Contains("."))
                        {
                            string[] exclamation_seperate = item.Split('.');


                            foreach (var item2 in exclamation_seperate)
                            {
                                string[] array_item2 = item2.Split(' ');
                                if (item2.Contains('?'))
                                {
                                    string[] question_mark_seperate = item2.Split('?');

                                    foreach (var item4 in question_mark_seperate)
                                    {
                                        string[] array_item4 = item4.Split(' ');
                                        if (array_item4.Contains(""))
                                        {
                                            word_count.Add(array_item4.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(array_item4.Count());
                                        }
                                    }

                                }
                                else if (item2.Contains(","))
                                {
                                    string[] dot_separate = item2.Split(',');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] dot_array = dot_item.Split(' ');
                                        if (dot_array.Contains(""))
                                        {
                                            word_count.Add(dot_array.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(dot_array.Count());
                                        }
                                    }
                                }
                                else
                                {
                                    if (array_item2.Contains(""))
                                    {
                                        word_count.Add(array_item2.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item2.Count());
                                    }
                                }
                            }
                        }

                        else
                        {
                            if (array_item.Contains(""))
                            {
                                word_count.Add(array_item.Count() - 1);
                            }
                            else
                            {
                                word_count.Add(array_item.Count());
                            }
                        }
                    }
                  
                }
                    /*.*/
                if (sentence_array.Contains("."))
                {
                    string[] comma_seperate = sentence_array.Split('.');

                    foreach (var item in comma_seperate)
                    {

                        string[] array_item = item.Split(' ');


                        if (item.Contains("?"))
                        {
                            string[] question_mark_seperate = item.Split('?');

                            foreach (var item1 in question_mark_seperate)
                            {
                                string[] array_item1 = item1.Split(' ');


                                if (item1.Contains("!"))
                                {
                                    string[] exclamation_seperate = item1.Split('!');

                                    foreach (var item3 in exclamation_seperate)
                                    {
                                        string[] array_item3 = item3.Split(' ');
                                        if (array_item3.Contains(""))
                                        {
                                            word_count.Add(array_item3.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_item3.Count());
                                        }

                                    }

                                }
                                else if (item1.Contains(","))
                                {
                                    string[] dot_separate = item1.Split(',');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] array_dot = dot_item.Split(' ');

                                        if (array_dot.Contains(""))
                                        {
                                            word_count.Add(array_dot.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_dot.Count());
                                        }


                                    }

                                }
                                else
                                {
                                    if (array_item1.Contains(""))
                                    {
                                        word_count.Add(array_item1.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item1.Count());
                                    }
                                }
                            }
                        }
                        else if (item.Contains("!"))
                        {
                            string[] exclamation_seperate = item.Split('!');


                            foreach (var item2 in exclamation_seperate)
                            {
                                string[] array_item2 = item2.Split(' ');
                                if (item2.Contains('?'))
                                {
                                    string[] question_mark_seperate = item2.Split('?');

                                    foreach (var item4 in question_mark_seperate)
                                    {
                                        string[] array_item4 = item4.Split(' ');
                                        if (array_item4.Contains(""))
                                        {
                                            word_count.Add(array_item4.Count() - 1);
                                        }
                                        else
                                        {
                                            word_count.Add(array_item4.Count());
                                        }
                                    }

                                }

                                else if (item2.Contains(","))
                                {
                                    string[] dot_separate = item2.Split(',');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] array_dot = dot_item.Split(' ');

                                        if (array_dot.Contains(""))
                                        {
                                            word_count.Add(array_dot.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_dot.Count());
                                        }


                                    }

                                }
                                else
                                {
                                    if (array_item2.Contains(""))
                                    {
                                        word_count.Add(array_item2.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item2.Count());
                                    }
                                }
                            }
                        }
                        //////////


                        if (item.Contains(","))
                        {
                            string[] question_mark_seperate = item.Split(',');

                            foreach (var item1 in question_mark_seperate)
                            {
                                string[] array_item1 = item1.Split(' ');


                                if (item1.Contains("!"))
                                {
                                    string[] exclamation_seperate = item1.Split('!');

                                    foreach (var item3 in exclamation_seperate)
                                    {
                                        string[] array_item3 = item3.Split(' ');
                                        if (array_item3.Contains(""))
                                        {
                                            word_count.Add(array_item3.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_item3.Count());
                                        }

                                    }

                                }
                                else if (item1.Contains("?"))
                                {
                                    string[] dot_separate = item1.Split('?');
                                    foreach (var dot_item in dot_separate)
                                    {
                                        string[] array_dot = dot_item.Split(' ');

                                        if (array_dot.Contains(""))
                                        {
                                            word_count.Add(array_dot.Count() - 1);

                                        }
                                        else
                                        {
                                            word_count.Add(array_dot.Count());
                                        }


                                    }

                                }
                                else
                                {
                                    if (array_item1.Contains(""))
                                    {
                                        word_count.Add(array_item1.Count() - 1);
                                    }
                                    else
                                    {
                                        word_count.Add(array_item1.Count());
                                    }
                                }
                            }
                        }


                        else
                        {
                            if (array_item.Contains(""))
                            {
                                word_count.Add(array_item.Count() - 1);
                            }
                            else
                            {
                                word_count.Add(array_item.Count());
                            }
                        }
                    }
                    Console.Write("This is final answer:" + word_count.Max());
                    Console.Read();
                }
                    /*...*/
                else
                {
                    string[] basic_array = sentence_array.Split(' ');
                   
                   
                        
                     word_count.Add(basic_array.Count());
                    
                    Console.WriteLine("Maximum Number of words: " + word_count.Max());
                    Console.Read();
                }
               
            }
            catch(Exception ex)
            { 
                
            }

        }
    }
}
