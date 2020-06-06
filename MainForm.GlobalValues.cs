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

        private int totalWorkPeriods = 0;
        private int stoppedWorkPeriods = 0;
        private int totalBreakPeriods = 0;
        private int totalRestPeriods = 0;


        //file for saving path to projects file
        //        internal string filePath;

        //variable to contain time when timer starts,
        //to evaluate when it should stop
        private DateTime timeToStop = new DateTime();

        States state = States.Work1;

        //get quantity of States
        //because of some reasons in future it may change
        //and it will be wise to check it at every load
        int statesLength = Enum.GetValues(typeof(States)).Length;
    }
}
