/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
                
            Console.WriteLine($"Введите два целых числа (A и B), где А будет возводено в натуральную степень B (B{char.ConvertFromUtf32(8800)}0):");
            Console.Write("A = ");
            string ? num_A_str = Console.ReadLine();
            Console.Write("B = ");
            string ? num_B_str = Console.ReadLine();
            bool tryText = true;

            if (num_A_str != "" && num_B_str != ""){                    //если строки непустые
                int num_A = TryInputText (num_A_str ?? "0", ref tryText);            //Проверка правильности ввода числа А
                int num_B = TryInputText (num_B_str ?? "0", ref tryText);            //Проверка правильности ввода числа В
                double res = 1;
                int b_stop = 0;
                
                if (tryText){
                    if (num_B != 0){                        
                            b_stop = (num_B > 0) ? num_B: -num_B;
                            for (int i = 0; i < b_stop; i++){
                                res *= num_A;                                
                            }
                            if (num_B < 0) res = 1/res; 

                        string kod_txt = GenKod(num_B_str ?? "0");          //генерируем строку на выдачу
                        Console.WriteLine($"Число А={num_A} в степени {num_B} равно {res} ({num_A}{kod_txt})");              
                                               
                    }
                    else Console.WriteLine("B не может быть рвно нулю по условию.");
                }
                else Console.WriteLine("Введено некорректное число. Попробуйте снова.");
            }

                        // Проверка правильности ввода числа   
            int TryInputText (string inputText, ref bool tryText){
                int try_res=0;
                if(!int.TryParse(inputText, out try_res)) tryText = false;
                return try_res;
            }

            string GenKod(string simvol){
                int [] res_kod = new int [] {8304, 185, 178, 179, 8308, 8309, 8310, 8311, 8312, 8313};
                string result = "";
                int index = 0, start = 0;
                int lenstr = simvol.Length;
                if(lenstr > 1 && simvol[0] == '-') {
                    result += char.ConvertFromUtf32(8315);
                    start = 1;
                }                
                for (int i = start; i < lenstr; i++){
                    index = Convert.ToInt16(simvol[i].ToString());
                    result += char.ConvertFromUtf32 (res_kod[index]);                    
                }                   
                return result;
            }
    }           

}
    