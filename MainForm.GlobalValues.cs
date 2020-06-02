using System;

namespace Pom_Pom
{

    public partial class MainForm
    {
        //wich timer shall be executing: reast, break or it's work time
        //values arranged as they should appear during timer work
        enum States
        {
            Work1,
            Break1,
            Work2,
            Break2,
            Work3,
            Break3,
            Work4,
            Rest
        }

        //values for working time, short break and long break
        //initialy loads from AppConfig file
        //by default values are 25, 5 and 20 minutes
        internal int workTime = 25;
        internal int shortBreak = 5;
        internal int rest = 20;

        //variable to contain time when timer starts,
        //to evaluate when it should stop
        private DateTime timeToStop = new DateTime();

        States state = States.Work1;

        //get quantity of States
        //becouse of some reasons in future in may change
        //and it will be wise to chect it at every load
        int statesLength = Enum.GetValues(typeof(States)).Length;
    }
}
