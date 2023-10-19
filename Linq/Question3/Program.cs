using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {

        static public List<TraineeDetails> details;
        static public List<TraineeDetails> traineeDetails;
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class

            TraineeData traineeData = new TraineeData();
            details = traineeData.GetTraineeDetails();

            LinqExercise();
                       bool check = true;
            while (check)
            {
                 System.Console.WriteLine("Enter Yes to continue No to exit");
                 string value = Console.ReadLine().ToUpper();

                if (value.Equals("YES"))
                {
                    LinqExercise();
                }
                else
                {
                    check = false;
                }
            }
        }
        public static void LinqExercise()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("\t\t\t\t\t|----------------Enter the options-----------------|");
            System.Console.WriteLine("1.Press 1 to Show the list of Trainee Id");
            System.Console.WriteLine("Press 2 to Show the first 3 Trainee Id using Take");
            System.Console.WriteLine("Press 3 to show the last 2 Trainee Id using Skip");
            System.Console.WriteLine("Press 4 to show the count of Trainee");
            System.Console.WriteLine("Press 5 to show the Trainee Name who are all passed out 2019 or later");
            System.Console.WriteLine("Press 6 to show the Trainee Id and Trainee Name by alphabetic order of the trainee name.");
            System.Console.WriteLine("Press 7 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark");
            System.Console.WriteLine("Press 8 to show the unique passed out year using distinct");
            System.Console.WriteLine("Press 9 to show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message");
            System.Console.WriteLine("Press 10 to show the first Trainee Id and Trainee Name");
            System.Console.WriteLine("Press 11 to show the last Trainee Id and Trainee Name");
            System.Console.WriteLine("Press 12 to print the total score of each trainee");
            System.Console.WriteLine("Press 13 to show the maximum total score");
            System.Console.WriteLine("Press 14 to show the minimum total score");
            System.Console.WriteLine("Press 15 to show the average of total score");
            System.Console.WriteLine("Press 16 to show true or false if any one has the more than 40 score using any()");
            System.Console.WriteLine("press 17 to show true of false if all of them has the more than 20 using all()");
            System.Console.WriteLine("Press 18 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.");
            Console.ResetColor();
            int subMenuVal;
            int.TryParse(Console.ReadLine(), out subMenuVal);
            switch (subMenuVal)
            {
                case 1:
                    {
                        listofTraineeId();
                        break;
                    }
                case 2:
                    {
                        First3TraineeIdusingTake();
                        break;
                    }
                case 3:
                    {
                        Last3(); break;
                    }
                case 4:
                    {
                        CoutnOfTrainee();
                        break;
                    }
                case 5:
                    {
                        PassedOut2019();
                        break;
                    }
                case 6:
                    {
                        AlphabeticOrderOfTheTraineeName();
                        break;
                    }
                case 7:
                    {
                        MoreThanSeven(); break;
                    }
                case 8:
                    {
                        PassedOutYear();
                        break;
                    }
                case 9:
                    {
                        TotalScore();
                        break;
                    }
                case 10:
                    {
                        FirstTrainee();
                        break;
                    }
                case 11:
                    {
                        LastTraniee();
                        break;
                    }
                case 12:
                    {
                        TotalScoreOfEachTrainee();
                        break;
                    }
                case 13:
                    {
                        maximum();
                        break;
                    }
                case 14:
                    {
                        minimum();
                        break;
                    }
                case 15:
                    {
                        average();
                        break;
                    }
                case 16:
                    {
                        MoreThan40(); break;
                    }
                case 17:
                    {
                        MoreThan20();
                        break;
                    }
                case 18:
                    {
                        ShowDetails();
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Enter valid number");
                        break;
                    }
            }

        }
        public static void listofTraineeId()
        {
            TraineeData traineeData = new TraineeData();
            System.Console.WriteLine("Show the list of traniee Id");
            var tranieeId = from val in details
                            select val.TraineeId;
            foreach (var item in tranieeId)
            {
                System.Console.WriteLine(item);
            }
        }
        public static void First3TraineeIdusingTake()
        {
            var item = (from val in details
                        select val).Take(3);
            foreach (var data in item)
            {
                System.Console.WriteLine($"{data.TraineeId}");
            }
        }
        public static void Last3()
        {
            var item = (from val in details
                        select val).SkipLast(2);
            foreach (var data in item)
            {
                System.Console.WriteLine($"{data.TraineeId}");
            }
        }
        public static void CoutnOfTrainee()
        {
            int item = (from val in details

                        select val).Count();
            System.Console.WriteLine(item);
        }
        public static void PassedOut2019()
        {
            var item = from s in details where s.YearPassedOut >= 2019 select s;
            foreach (var val in item)
            {
                System.Console.WriteLine($"DOB : {val.DOJ} ID:{val.TraineeId}");
            }
        }
        public static void AlphabeticOrderOfTheTraineeName()
        {
            var sortedNames = from val in details orderby val.TraineeName ascending select val;
            foreach (var item in sortedNames)
            {
                System.Console.WriteLine($"ID:{item.TraineeId} Name :{item.TraineeName}");
            }
        }
        public static void MoreThanSeven()
        {
            var item = from val in details
                       from score in val.ScoreDetails
                       where score.Mark > 4
                       select new { val.TraineeId, val.TraineeName, score.ExerciseName, score.Mark };
            foreach (var val in item)
            {
                System.Console.WriteLine($"ID:{val.TraineeId} Name :{val.TraineeName} Exercise : {val.ExerciseName} mark : {val.Mark}");
            }
        }
        public static void PassedOutYear()
        {
            var data = (from item in details
                        select item.YearPassedOut).Distinct();
            foreach (var item in data)
            {
                System.Console.WriteLine($"{item}");
            }
        }
        public static void TotalScore()
        {
            System.Console.WriteLine("Enter ID");
            string traineeID = Console.ReadLine();
            int data1 = 0;
            bool cheak = true;
            foreach (var item in details)
            {
                if (traineeID.Equals(item.TraineeId))
                {
                    data1 = (from item1 in details
                             where item1.TraineeId == traineeID
                             from item2 in item1.ScoreDetails
                             select item2.Mark).Sum();
                    cheak = false;
                    break;
                }
            }
            if (cheak)
            {
                System.Console.WriteLine("Invalid ID");
            }
            System.Console.WriteLine(data1);

        }
        public static void FirstTrainee()
        {
            var item = (from val in details select val).Take(1);
            foreach (var val in item)
            {
                System.Console.WriteLine($"Name : {val.TraineeName} ID:{val.TraineeId}");
            }
        }
        public static void LastTraniee()
        {
            var item = (from val in details select val).TakeLast(1);
            foreach (var val in item)
            {
                System.Console.WriteLine($"Name : {val.TraineeName} ID:{val.TraineeId}");
            }

        }
        public static void TotalScoreOfEachTrainee()
        {
            var data1 = from item1 in details
                        select new
                        {
                            item1,
                            TotalScore = (from item2 in item1.ScoreDetails
                                          select item2.Mark).Sum()
                        };
            foreach (var item in data1)
            {
                System.Console.WriteLine($"{item.TotalScore}\t{item.item1.TraineeId}");
            }

        }
        public static void maximum()
        {
            var data1 = from item1 in details
                        select new
                        {
                            item1,
                            V = (from item2 in item1.ScoreDetails
                                 select item2.Mark).Sum()
                        }; ;



            System.Console.WriteLine($"{data1.Max()}");

        }
        public static void minimum()
        {
            var data1 = from item1 in details
                        select
                          (from item2 in item1.ScoreDetails
                           select item2.Mark).Sum();

            System.Console.WriteLine($"{data1.Min()}");
        }
        public static void average()
        {
            var data1 = from item1 in details
                        select
                          (from item2 in item1.ScoreDetails
                           select item2.Mark).Sum();

            System.Console.WriteLine($"{data1.Average()}");
        }
        public static void MoreThan40()
        {
            var data1 = from item1 in details
                        select new
                        {
                            item1,
                            V = (from item2 in item1.ScoreDetails
                                 select item2.Mark).Sum()
                        };
            System.Console.WriteLine(data1.Any(n => n.V > 40));
        }
        public static void MoreThan20()
        {
            var data1 = from item1 in details
                        select new
                        {
                            item1,
                            V = (from item2 in item1.ScoreDetails
                                 select item2.Mark).Sum()
                        }; ;
            System.Console.WriteLine(data1.All(n => n.V > 20));
        }
        public static void ShowDetails()
        {
            var item = from data in details
                       from data1 in data.ScoreDetails
                       orderby data.TraineeName descending, data1.Mark descending
                       select (data.TraineeId, data.TraineeName, data1.TopicName, data1.ExerciseName, data1.Mark);
            foreach (var item1 in item)
            {
                Console.WriteLine(item1);
            }
        }
    }
}

// Press 1 to Show the list of Trainee Id

// Press 2 to Show the first 3 Trainee Id using Take

// Press 3 to show the last 2 Trainee Id using Skip

// Press 4 to show the count of Trainee

// Press 5 to show the Trainee Name who are all passed out 2019 or later

// Press 6 to show the Trainee Id and Trainee Name by alphabetic order of the trainee name.

// Press 7 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark

// Press 8 to show the unique passed out year using distinct

// Press 9 to show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message

// Press 10 to show the first Trainee Id and Trainee Name

// Press 11 to show the last Trainee Id and Trainee Name

// Press 12 to print the total score of each trainee

// Press 13 to show the maximum total score

// Press 14 to show the minimum total score

// Press 15 to show the average of total score

// Press 16 to show true or false if any one has the more than 40 score using any()

// Press 17 to show true of false if all of them has the more than 20 using all()

// Press 18 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.