using System.Runtime.InteropServices;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace first_game
{
    internal class Program
    {
        class  Player
        {
            
            public string jobName { get; set; }
            public int hp { get; set; }
            public int atk { get; set; }
            public int def { get; set; }
            public int spd { get; set; }
            public void MyStatusInfo()
            {
                Console.WriteLine($"직업 이름 :{jobName} \n 체력  :{hp} \n 공격력:{atk} \n 방어력:{def} \n 속도  :{spd}");
            }
        }

        class MyStatus : Player
        {
            public void MyStatusInfo()
            {
                Console.WriteLine($"직업 이름 :{jobName} \n 체력  :{hp} \n 공격력:{atk} \n 방어력:{def} \n 속도  :{spd}");
            }
        }

       


        static void StartScene()
        {
            Console.Clear();
           




            Console.WriteLine(" _________________________________________________________________________________________________________");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                              텍스트 던전!                                               |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                     1.시작하기        2.내 정보        3.블러오기        4.종료                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine(" _________________________________________________________________________________________________________");


            //Console.WriteLine("");
            //Console.WriteLine("1.시작하기");
            //Console.WriteLine("2.내 정보");
            //Console.WriteLine("3.블러오기");
            //Console.WriteLine("4.종료");

            string startSelect = Console.ReadLine();
            int startNum;
            bool startBool = int.TryParse(startSelect, out startNum);
            if (startBool == true) 
            {
                if (startNum == 1) 
                {
                    jobChoice();
                }
                //아래는 미구현
                //else if (startNum == 2)
                //{
                //    
                //}
                //else if(startNum == 3)
                //{
                //    
                //}
                //else if(startNum == 4)
                //{
                //    
                //}
                else
                {
                    StartScene();
                }
            }
            else
            {
                StartScene();
            }

        }
        static void jobChoice()
        {
            Player player = new Player();
            Console.Clear();
            string jobName = "";
            int atk = 0;
            int def = 0;
            int spd = 0;
            int hp = 0;

            Console.WriteLine("직업을 선택 하세요 \b");
            Console.WriteLine();
            Console.WriteLine("1.전사\t2.궁수\t3.기사");
            string choiceNumber = Console.ReadLine();
            int jobCho;
            bool jobSelect = int.TryParse(choiceNumber, out jobCho);


            //아래 직업 선택 쪽의 코드를 최적화가 하고싶다...
            if (jobSelect == true && jobCho <= 3 && jobCho > 0)
            {
                if (jobCho == 0)
                {

                }     
                else if (jobCho == 1)
                {
                   

                    player.jobName = "전사";
                    player.hp = 45;
                    player.atk = 6;
                    player.def = 5;
                    player.spd = 4;



                    player.MyStatusInfo();
                    Console.WriteLine("정말 이 직업을 선택하겠습니까?");
                    Console.WriteLine("1.yes \t 2.no");


                    string selectNumber = Console.ReadLine();
                    int choise = int.Parse(choiceNumber);
                    bool choiceBool = int.TryParse(selectNumber, out choise);
                    if (choiceBool == true)
                    {
                        if (choise == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("직업이 확정 되었습니다");
                            player.MyStatusInfo();
                            Start();
                        }
                        else
                        {
                            jobChoice();
                        }
                    }
                    else
                    {
                        jobChoice();
                    }
                }
                else if (jobCho == 2)
                {
                    

                    player.jobName = "궁수";
                    player.atk = 4;
                    player.def = 3;
                    player.spd = 7;
                    player.hp = 30;


                    player.MyStatusInfo();
                    Console.WriteLine("정말 이 직업을 선택하겠습니까?");
                    Console.WriteLine("1.yes \t 2.no");



                    string selectNumber = Console.ReadLine();
                    int choise = int.Parse(choiceNumber);
                    bool choiceBool = int.TryParse(selectNumber, out choise);
                    if (choiceBool == true)
                    {
                        if (choise == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("직업이 확정 되었습니다");
                            player.MyStatusInfo();
                            Start();
                        }
                        else
                        {
                            jobChoice();
                        }
                    }
                    else
                    {
                        jobChoice();
                    }
                }
                else if (jobCho == 3)
                {
                    

                    player.jobName = "기사";
                    player.atk = 2;
                    player.def = 7;
                    player.spd = 3;
                    player.hp = 60;


                    player.MyStatusInfo();
                    Console.WriteLine("정말 이 직업을 선택하겠습니까?");
                    Console.WriteLine("1.yes \t 2.no");

                    string selectNumber = Console.ReadLine();
                    int choise = int.Parse(choiceNumber);
                    bool choiceBool = int.TryParse(selectNumber, out choise);
                    if (choiceBool ==  true)
                    {
                        if (choise == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("직업이 확정 되었습니다");
                            player.MyStatusInfo();
                            Start();
                            
                        }
                        else
                        {
                            jobChoice();
                        }
                    }
                    else
                    {
                        jobChoice();
                    }
                }
            }
            else
            {
                jobChoice();
            }

        }



        static void Start()
        {

            
            Console.Clear ();
            StartMap();


           
            string mapChoice = Console.ReadLine();
            int mapNum;
            bool mapBool = int.TryParse(mapChoice, out mapNum);
            //이동에 대한 코딩 구성 중...
            if (mapBool == true)
            {
                if (mapNum == 1)
                {
                    Console.Clear();
                }
                else if (mapNum == 2)
                {

                }
                else if (mapNum == 3)
                {

                }
                else if (mapNum == 4)
                {
                    Player player = new Player();
                    //Player player = new Plater; new를 쓰면 안되는데 new 말고 뭘 넣을 수 있는지 모르겠다
                    ////Console.WriteLine($"직업 이름 :{player.jobName} \n 체력  :{player.hp} \n 공격력:{player.atk} \n 방어력:{player.def} \n 속도  :{player.spd}");
                    //player.MyStatus();

                    //이 부분에서 스테이터스를 띄우고 싶습니다

                }
            }


        }


        /// <summary>
        /// 맨 처음 맵 입니다
        /// </summary>
        static void StartMap()
        {
            Console.WriteLine($" _________________________________________________________________________________________________________");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|                                       어디로 가시겠습니까?                                              |");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|                                                                                                         |");
            Console.WriteLine($"|_________________________________________________________________________________________________________|");
            Console.WriteLine($"|                   |                                                                                     |");
            Console.WriteLine($"|                   |            1. 위쪽으로  가기                  2. 오른쪽으로 가기                    |");
            Console.WriteLine($"|                   |                                                                                     |");
            Console.WriteLine($"|        나         |                                                                                     |");
            Console.WriteLine($"|                   |            3.왼쪽으로 가기                    4.장비 확인                           |");
            Console.WriteLine($"|                   |                                                                                     |");
            Console.WriteLine($" ___________________|_____________________________________________________________________________________");
        }

        /// <summary>
        /// 마을로 가면 나오는 맵입니다
        /// </summary>
        static void VilligeMap()
        {
            Console.WriteLine(" _________________________________________________________________________________________________________");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine(" _________________________________________________________________________________________________________");
        }


        /// <summary>
        /// 던전으로 가면 나오는 맵 입니다
        /// </summary>
        static void DungeontMap()
        {
            Console.WriteLine(" _________________________________________________________________________________________________________");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine(" _________________________________________________________________________________________________________");
        }


        static void Main(string[] args)
        {
            StartScene();
        }
    }
}