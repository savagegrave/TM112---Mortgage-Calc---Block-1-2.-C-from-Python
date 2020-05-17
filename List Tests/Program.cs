//  Mortgage Program from Block 1 TM112.  I have converted it to C# to demonstrate how different C# is from python
//  Code by the Open University.  Coverted by Steven Houldey.
using System;
namespace List_Tests
{
    class Program
    {
        #region Variables
        //Declare Some Variables
        
        /*
         *  Use Double for variables as:
         *  INT is a Whole Number, I would have to declare and convert the float/double values to int 
         *  otherise the program will not compile.
         * 
         *  Using Double means it can handle the decimal values when doing the calculation in the loops.
         */

        static double mRate = 0.05;             // mRate = Interest Rate
        static double mMortgage = 1000;         // mMortgage = Mortgage Total
        static double mPayment = 200;           // mPayment = Monthly Payments
        static double mInterest;                // mInterest = Interest Payment as Calculated by the Program.
        #endregion
        
        /// <summary>
        /// Main Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Show the total mortgage
            Console.WriteLine("Outstanding Mortgage:" + mMortgage.ToString());
            Console.ReadLine();

            //While the value in mMortgage is NOT = to 0, OR is NOT below 0:
            while (!(mMortgage == 0.0d || mMortgage < 0.0d))
            {
                mInterest = mMortgage * mRate / 12;
                mMortgage = mMortgage + mInterest - mPayment;
                Console.WriteLine("Outstanding Mortgage:" + mMortgage.ToString());

            }

            // The conditions above returned true, so break out and print the results.
            Console.WriteLine("Your Final Payment was: " + mMortgage);
            Console.WriteLine("Your Final Payment was: " + mMortgage.ToString("#.##") + " Shown to 2dp");
            Console.ReadLine();

        }
    }
}
