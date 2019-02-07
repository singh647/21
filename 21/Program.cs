using System;



namespace peter

{

    class Program

    {

        static void Main(string[] args)

        {

            var a = new TestQuestion2();

            a.PlayingWithForLoops();

        }

    }



    class TestQuestion2

    {

        public int myFavoriteVariable = 0;



        public void PlayingWithForLoops()

        {

            // write a For Loop to Add 10 Numbers

            for (; MyMethod();)

            {

                if (myFavoriteVariable > 10)

                {

                    Console.WriteLine("i am so out of here!");

                    break;

                }

                Console.WriteLine("oh no I have to go through this stupid loop again...");

            }

        }

        public bool MyMethod()

        {

            myFavoriteVariable++;

            return true;

        }

    }

}




Reply
Forward