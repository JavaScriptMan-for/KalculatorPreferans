using System;
using System.ComponentModel;
namespace CountPreferansTwo
{
  internal class Porgram
    {
        public static void Main()
        {
            //InvalidCastException
          bool four = false;
            string? q = "";
              string? name4 = "";
             string? gora4 = "";
             string? vist4 = "";
            
            System.Console.WriteLine("Приветствую Вас в калькуляторе для игры Преферанс!");

            /*names*/
            System.Console.WriteLine("Есть ли четвёртый игрок? Если есть напишите yes, если нет напишите любое другое слово");
q = Console.ReadLine();
if(q == "yes") {four = true;} else {four = false;};
            //name first player
            System.Console.WriteLine("Введите имя первого игрока");
            string? name1 = "";
            name1 = Console.ReadLine();
            System.Console.WriteLine(name1 + " - первый игрок");
            //name second player
             System.Console.WriteLine("Введите имя второго игрока");
            string? name2 = "";
            name2 = Console.ReadLine();
            System.Console.WriteLine(name2 + " - второй игрок");
            //name third player
            System.Console.WriteLine("Введите имя третьего игрока");
            string? name3 = "";
            name3 = Console.ReadLine();
            System.Console.WriteLine(name3 + " - третий игрок");
            //name fourth player
            if(four) {
               System.Console.WriteLine("Введите имя четвёртого игрока");
            name4 = Console.ReadLine();
            System.Console.WriteLine(name4 + " - четвёртый игрок");
            }

            /*gores*/
             Console.WriteLine("Запишите горы игроков");
            //first gora
            System.Console.WriteLine("Введите гору игрока " + name1);
            string? gora1 = "";
            gora1 = Console.ReadLine(); 
            System.Console.WriteLine(Convert.ToInt32(gora1) + " - гора первого игрока");
            //second gora
            System.Console.WriteLine("Введите гору игрока " + name2);
            string? gora2 = "";
            gora2 = Console.ReadLine(); 
            System.Console.WriteLine(Convert.ToInt32(gora2) + " - гора второго игрока");
            //third gora
            System.Console.WriteLine("Введите гору игрока " + name3);
            string? gora3 = "";
            gora3 = Console.ReadLine(); 
            System.Console.WriteLine(Convert.ToInt32(gora3) + " - гора третьего игрока");
            //fourth gora
            if(four) {
             System.Console.WriteLine("Введите гору игрока " + name4);
            gora4 = Console.ReadLine(); 
            System.Console.WriteLine(Convert.ToInt32(gora1) + " - гора четвёртого игрока");
            }
            /*vistes*/
            System.Console.WriteLine("Введите висты игроков");
            //first vist
            System.Console.WriteLine("Введите висты на игрока - " + name1);
            string? vist1 = "";
            vist1 = Console.ReadLine();
            System.Console.WriteLine(Convert.ToInt32(vist1) + " - висты на первого игрока");
            //second vist
              System.Console.WriteLine("Введите висты на игрока - " + name2);
            string? vist2 = "";
            vist2 = Console.ReadLine();
            System.Console.WriteLine(Convert.ToInt32(vist2) + " - висты на второго игрока");
            //third vist
              System.Console.WriteLine("Введите висты на игрока - " + name3);
            string? vist3 = "";
            vist3 = Console.ReadLine();
            System.Console.WriteLine(Convert.ToInt32(vist3) + " - висты на третьего игрока");
            //fourth
            if(four) {
                  System.Console.WriteLine("Введите висты на игрока - " + name4);
            vist4 = Console.ReadLine();
            System.Console.WriteLine(Convert.ToInt32(vist4) + " - висты на четвёртого игрока");
            }
            /*Подсчёт*/
            int minGora = 0;
                                                                     #pragma warning disable CS8601 
            string[] gores_four = [gora1, gora2, gora3, gora4];
                                                                     #pragma warning restore CS8601 
                                                                        #pragma warning disable CS8601 
            string[] gores = {gora1, gora2, gora3};
                                                                     #pragma warning restore CS8601
            if (four) {minGora = Convert.ToInt32(gores_four.Min());} else {
        minGora = Convert.ToInt32(gores.Min());
      }
int amn1 = Convert.ToInt32(gora1) - minGora;
int amn2 = Convert.ToInt32(gora2) - minGora;
int amn3 = Convert.ToInt32(gora3) - minGora;
int amn4 = 0;
Console.WriteLine(amn1 + " амнистия первого игрока");
Console.WriteLine(amn2 + " амнистия второго игрока");
Console.WriteLine(amn3 + " амнистия третьего игрока");
if(four) {amn4 = Convert.ToInt32(gora4) - minGora; System.Console.WriteLine(amn4 + " амнистия четвёртого игрока");}
int um1;
int um2;
int um3;
int um4 = 0;
if(four) {
  um1 = amn1 * 10 / 4;
  um2 = amn2 * 10 / 4;
  um3 = amn3 * 10 / 4;
  um4 = amn4 * 10 / 4;
Console.WriteLine(um1 + " - второй этап первого игрока");
Console.WriteLine(um2 + " - второй этап второго игрока");
Console.WriteLine(um3 + " - второй этап третьего игрока");
Console.WriteLine(um4 + " - второй этап четвёртого игрока");
} else {
  um1 = amn1 * 10 / 3;
  um2 = amn2 * 10 / 3;
  um3 = amn3 * 10 / 3;
Console.WriteLine(um1 + " - второй этап первого игрока");
Console.WriteLine(um2 + " - второй этап второго игрока");
Console.WriteLine(um3 + " - второй этап третьего игрока");
}
int et1;
int et2;
int et3;
int et4 = 0;
if(four) {
  et1 = um1 + Convert.ToInt32(vist1);
  et2 = um2 + Convert.ToInt32(vist2);
  et3 = um3 + Convert.ToInt32(vist3);
  et4 = um4 + Convert.ToInt32(vist4);
  System.Console.WriteLine(et1 + " - третий этап первого игрока");
  System.Console.WriteLine(et2 + " - третий этап второго игрока");
  System.Console.WriteLine(et3 + " - третий этап третьего игрока");
  System.Console.WriteLine(et4 + " - третий этап четвёртого игрока");
} else {
  et1 = um1 + Convert.ToInt32(vist1);
  et2 = um2 + Convert.ToInt32(vist2);
  et3 = um3 + Convert.ToInt32(vist3);
  System.Console.WriteLine(et1 + " - третий этап первого игрока");
  System.Console.WriteLine(et2 + " - третий этап второго игрока");
  System.Console.WriteLine(et3 + " - третий этап третьего игрока");
}
int[] underresult = {et1,et2,et3};
int[] underresult_four = {et1,et2,et3, et4};
int winner_numb = 0;
bool win1 = false;
bool win2 = false;
bool win3 = false;
bool win4 = false;
if(four) {
winner_numb = underresult_four.Min();
if(winner_numb == et1) {win1 = true;}
if(winner_numb == et2) {win2 = true;}
if(winner_numb == et3) {win3 = true;}
if(winner_numb == et4) {win4 = true;}
} else {
  winner_numb = underresult.Min();
if(winner_numb == et1) {win1 = true;}
if(winner_numb == et2) {win2 = true;}
if(winner_numb == et3) {win3 = true;}
}
if(win1) {System.Console.WriteLine(name1 + " победил!");} else
if(win2) {System.Console.WriteLine(name2 + " победил!");} else
if(win3) {System.Console.WriteLine(name3 + " победил");} else
if(win4) {System.Console.WriteLine(name4 + " победил");}
        }
    }
}
/*Начал делать 16.10.2023, закончил делать 18.10.2023. Оценка сложности 7/10. Результат - положительный*/