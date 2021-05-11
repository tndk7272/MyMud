using System;
using System.Collections.Generic;

namespace MyMud
{
    class Program
    {
        static void Main(string[] args)
        {
            // 도연님 환영합니다.
            Console.WriteLine("도연님 환영합니다.");

            // 플레이어 이름 자동랜덤 생성.
            // 1. 문자열 여러개 만들기
            // 2. 거기서 랜덤으로 지정
            List<string> names = new List<string>();
            names.Add("오도"); // 0
            names.Add("도연"); // 1
            names.Add("도도"); // 2
            names.Add("도돗"); // 3
            names.Add("또연"); // 4

            Random random = new Random();
            
            // 0부터 시작.
            int index = random.Next(names.Count);
            string playerName = names[index];

            // 플레이어 능력치를 입력받자. power, hp
            string powerString = Console.ReadLine();
            string hpString = Console.ReadLine();


            int power = int.Parse(powerString);
            int hp = int.Parse(hpString);

            Player player = new Player(playerName, power, hp);

            //Console.Read();
            //Console.ReadKey();

            // 몬스터 한마리 만들어서 때리자
            Monster monster = new Monster();
            monster.hp -= player.power;


            //
        }
    }
}
